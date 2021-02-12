//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System.IO;
using System.Text.Json;
using CascadeSharp.TKernel.Standard;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_TShape
    //---------------------------------------------------------------------
    /// <summary>
    ///A TShape  is a topological  structure describing a set of points in a 2D or 3D space.
    /// A topological shape is a structure made from other shapes.
    /// This is a deferred class  used to support topological objects.
    /// TShapes are   defined   by  their  optional domain (geometry)  and  their  components  (other TShapes
    /// with  Locations and Orientations).  The components are stored in a List of Shapes.
    /// A   TShape contains  the   following boolean flags :
    /// - Free       : Free or Frozen.
    /// - Modified   : Has been modified.
    /// - Checked    : Has been checked.
    /// - Orientable : Can be oriented.
    /// - Closed     : Is closed (note that only Wires and Shells may be closed).
    /// - Infinite   : Is infinite.
    /// - Convex     : Is convex.
    /// Users have no direct access to the classes derived from TShape.  They  handle them with  the classes
    /// derived from Shape.
    /// </summary>
    public abstract class TopoDS_TShape
    {
        protected TopoDS_TShape()
        {
            myShapes = new TopoDS_ListOfShape();
        }

        protected TopoDS_TShape(TopoDS_TShape tShape)
        {
            Free = tShape.Free;
            Locked = tShape.Locked;
            Modified = tShape.Modified;
            Checked = tShape.Checked;
            Orientable = tShape.Orientable;
            Closed = tShape.Closed;
            Infinite = tShape.Infinite;
            Convex = tShape.Convex;
            myShapes = new TopoDS_ListOfShape();
            foreach (var shape in tShape.myShapes)
            {
                myShapes.Append(shape);
            }
        }


        public TopoDS_ListOfShape myShapes { get; protected set;  }

        public bool Free { get; protected set; }
        /// <summary>
        /// This is a hack to solve for now the no friends in c# problem.
        /// DO NOT use it outside Builder and Iterator!
        /// </summary>
        /// <param name="value"></param>
        public void OnlyFriendsFree(bool value) => Free = value;

        public bool Locked { get; protected set; }

        public bool Modified { get; protected set; }
        /// <summary>
        /// This is a hack to solve for now the no friends in c# problem.
        /// DO NOT use it outside Builder and Iterator!
        /// </summary>
        /// <param name="value"></param>
        public void OnlyFriendsModified(bool value) => Modified = value;

        public bool Checked { get; protected set; }

        public bool Orientable { get; protected set; }

        public bool Closed { get; protected set; }

        public bool Infinite { get; protected set; }

        public bool Convex { get; protected set; }

        public TopAbs_ShapeEnum ShapeType()
        {
            return TopAbs_ShapeEnum.TopAbs_COMPOUND;
        }

        public T EmptyCopy<T>() where T : TopoDS_TShape, new()
        {
            return new T
            {
                Free = Free,
                Locked = Locked,
                Checked = Checked,
                Closed = Closed,
                Convex = Convex,
                Infinite = Infinite,
                Modified = Modified,
                Orientable = Orientable
            };
        }

        public int NbChildren()
        {
            return myShapes.Size();
        }

        public virtual void DumpJson(Standard_OStream theOStream, int theDepth = -1)
        {
            using (theOStream)
            {
                using var writer = new StreamWriter(theOStream);
                writer.Write(JsonSerializer.Serialize(this));
            }
        }
    }
}