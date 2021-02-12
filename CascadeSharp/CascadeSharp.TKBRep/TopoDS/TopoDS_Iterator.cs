//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using CascadeSharp.TKernel.Standard;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_Iterator
    //---------------------------------------------------------------------
    /// <summary>
    /// Iterates on the underlying shape underlying a given TopoDS_Shape object, providing access to its
    /// component sub-shapes. Each component shape is  returned as a TopoDS_Shape with an orientation,
    /// and a compound of the original values and the relative values.
    /// </summary>
    public sealed class TopoDS_Iterator
    {
        public TopoDS_Iterator() { }
        /// <summary>
        /// Creates an Iterator on <S> sub-shapes.
        /// Note:
        /// - If cumOri is true, the function composes all  sub-shapes with the orientation of S.
        /// - If cumLoc is true, the function multiplies all  sub-shapes by the location of S, i.e. it applies to
        /// each sub-shape the transformation that is associated with S.
        /// </summary>
        /// <param name="S"></param>
        /// <param name="cumOri"></param>
        /// <param name="cumLoc"></param>
        public TopoDS_Iterator(TopoDS_Shape S, bool cumOri = true, bool cumLoc = true)
        {
            Initialize(S, cumOri, cumLoc);
        }

        #region Private Objects

        TopoDS_Shape myShape;
        TopoDS_ListIteratorOfListOfShape myShapes;
        TopAbs_Orientation myOrientation;
        TopLoc_Location myLocation;

        #endregion
        /// <summary>
        /// Initializes this iterator with shape S.
        /// Note:
        /// - If cumOri is true, the function composes all sub-shapes with the orientation of S.
        /// - If cumLoc is true, the function multiplies all sub-shapes by the location of S, i.e. it applies to
        /// each sub-shape the transformation that is associated with S.
        /// </summary>
        /// <param name="S"></param>
        /// <param name="cumOri"></param>
        /// <param name="cumLoc"></param>
        public void Initialize(TopoDS_Shape S, bool cumOri, bool cumLoc)
        {
            if (cumLoc)
                myLocation = S.Location();
            else
                myLocation.Identity();
            if (cumOri)
                myOrientation = S.Orientation();
            else
                myOrientation = TopAbs_Orientation.TopAbs_FORWARD;

            if (S.IsNull())
                myShapes = new TopoDS_ListIteratorOfListOfShape();
            else
                myShapes.Initialize(S.TShape().myShapes);

            if (More())
            {
                myShape = myShapes.Value();
                myShape.Orientation(TopAbs.Compose(myOrientation, myShape.Orientation()));
                if (!myLocation.IsIdentity())
                    myShape.Move(myLocation);
            }
        }

        public void Next()
        {
            myShapes.Next();
            if (More())
            {
                myShape = myShapes.Value();
                myShape.Orientation(TopAbs.Compose(myOrientation, myShape.Orientation()));
                if (!myLocation.IsIdentity())
                    myShape.Move(myLocation);
            }
        }

        public bool More()
        {
            return myShapes.More();
        }

        public TopoDS_Shape Value()
        {
            if (!More())
                throw new Standard_NoSuchObject("TopoDS_Iterator.Value");
            return myShape;
        }
    }
}