//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_TWire
    //---------------------------------------------------------------------
    /// <summary>
    /// A set of edges connected by their vertices.
    /// </summary>
    public class TopoDS_TWire : TopoDS_TShape
    {

        public override TopAbs_ShapeEnum ShapeType()
        {
            return TopAbs_ShapeEnum.TopAbs_WIRE;
        }

        public override TopoDS_TShape EmptyCopy()
        {
            return new TopoDS_TWire();
        }

    }
}