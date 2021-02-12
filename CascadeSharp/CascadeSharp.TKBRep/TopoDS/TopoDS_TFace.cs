//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_TFace
    //---------------------------------------------------------------------
    /// <summary>
    /// A topological part of a surface or of the 2D space.
    /// The  boundary is a set of wires and vertices.
    /// </summary>
    public class TopoDS_TFace : TopoDS_TShape
    {
        public override TopAbs_ShapeEnum ShapeType()
        {
            return TopAbs_ShapeEnum.TopAbs_FACE;
        }

        public override TopoDS_TShape EmptyCopy()
        {
            return new TopoDS_TFace();
        }

    }
}