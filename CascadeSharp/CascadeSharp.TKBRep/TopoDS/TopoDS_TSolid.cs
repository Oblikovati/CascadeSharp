//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_TSolid
    //---------------------------------------------------------------------
    /// <summary>
    /// A Topological part of 3D space, bounded by shells, edges and vertices.
    /// </summary>
    public class TopoDS_TSolid : TopoDS_TShape
    {

        public override TopAbs_ShapeEnum ShapeType()
        {
            return TopAbs_ShapeEnum.TopAbs_SOLID;
        }

        public override TopoDS_TShape EmptyCopy()
        {
            return new TopoDS_TSolid();
        }

    }
}