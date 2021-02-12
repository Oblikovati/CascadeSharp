//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_Builder
    //---------------------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    public class TopoDS_Builder
    {
        /// <summary>
        /// Make an empty Wire.
        /// </summary>
        /// <param name="W"></param>
        public void MakeWire(TopoDS_Wire W)
        {
            var tw = new TopoDS_TWire();
            MakeShape(W,tw);
        }
        /// <summary>
        /// Make an empty Shell.
        /// </summary>
        /// <param name="S"></param>
        public void MakeShell(TopoDS_Shell S)
        {
            var ts = new TopoDS_TShell();
            MakeShape(S,ts);
        }
        /// <summary>
        /// Make a Solid covering the whole 3D space.
        /// </summary>
        /// <param name="S"></param>
        public void MakeSolid(TopoDS_Solid S)
        {
            var ts = new TopoDS_TSolid();
            MakeShape(S,ts);
        }
        /// <summary>
        /// Make an empty Composite Solid.
        /// </summary>
        /// <param name="C"></param>
        public void MakeCompSolid(TopoDS_CompSolid C)
        {
            var tc = new TopoDS_TCompSolid();
            MakeShape(C,tc);
        }
        /// <summary>
        /// Make an empty Compound.
        /// </summary>
        /// <param name="C"></param>
        public void MakeCompound(TopoDS_Compound C)
        {
            var tc = new TopoDS_TCompound();
            MakeShape(C,tc);
        }
        /// <summary>
        /// Add the Shape aComponent in the Shape aShape.
        /// Exceptions
        /// TopoDS_FrozenShape if S is not free and cannot be modified.
        /// TopoDS__UnCompatibleShapes if S and C are not compatible.
        /// </summary>
        /// <param name="aShape"></param>
        /// <param name="aComponent"></param>
        public void Add(TopoDS_Shape aShape, TopoDS_Shape aComponent)
        {
            // From now the Component cannot be edited
            aComponent.TShape().OnlyFriendsFree(false);

            // Note that freezing aComponent before testing if aShape is free
            // prevents from self-insertion
            // but aShape will be frozen when the Exception is raised
            if (aShape.Free)
            {
                int[] aTb =
                {
                    //COMPOUND to:
                    (1<<((int)TopAbs_ShapeEnum.TopAbs_COMPOUND)),
                    //COMPSOLID to:
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_COMPOUND)),
                    //SOLID to:
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_COMPOUND)) |
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_COMPSOLID)),
                    //SHELL to:
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_COMPOUND)) |
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_SOLID)),
                    //FACE to:
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_COMPOUND)) |
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_SHELL)),
                    //WIRE to:
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_COMPOUND)) |
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_FACE)),
                    //EDGE to:
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_COMPOUND)) |
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_SOLID)) |
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_WIRE)),
                    //VERTEX to:
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_COMPOUND)) |
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_SOLID)) |
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_FACE)) |
                    (1 << ((int)TopAbs_ShapeEnum.TopAbs_EDGE)),
                    //SHAPE to:
                    0
                };

                var iC = (int) aComponent.ShapeType();
                var iS = (int) aShape.ShapeType();

                if ((aTb[iC] & (1 << iS)) != 0)
                {
                    var L = aShape.TShape().myShapes;
                    L.Append(aComponent);
                    var S = L.Last;
                    //
                    // compute the relative Orientation
                    if (aShape.Orientation() == TopAbs_Orientation.TopAbs_REVERSED)
                        S.Reverse();
                    //
                    // and the Relative Location
                    var aLoc = aShape.Location();
                    if (!aLoc.IsIdentity())
                        S.Move(aLoc.Inverted());
                    //
                    // Set the TShape as modified.
                    aShape.TShape().OnlyFriendsModified(true);
                }
                else
                {
                    throw new TopoDS_UnCompatibleShapes("TopoDS_Builder.Add");
                }
            }
            else {
                throw new TopoDS_FrozenShape("TopoDS_Buider.Add");
            }
        }

        public void Remove(TopoDS_Shape aShape, TopoDS_Shape aComponent)
        {
            // check  if aShape  is  not Frozen
            if(!aShape.Free)
                throw new TopoDS_FrozenShape("TopoDS_Builder.Remove");

            // compute the relative Orientation and Location of aComponent
            var S = aComponent;
            if (aShape.Orientation() == TopAbs_Orientation.TopAbs_REVERSED)
                S.Reverse();
            S.Location(S.Location().Predivided(aShape.Location()));

            var L = aShape.TShape().myShapes;
            var It = new TopoDS_ListIteratorOfListOfShape(L);
            foreach (var i in It)
            {
                if (i != S) continue;

                L.Remove(It);
                aShape.TShape().OnlyFriendsModified(true);
                break;
            }
        }

        protected void MakeShape(TopoDS_Shape S, TopoDS_TShape T)
        {
            S.TShape(T);
            S.Location(new TopLoc_Location());
            S.Orientation(TopAbs_Orientation.TopAbs_FORWARD);
        }
    }
}