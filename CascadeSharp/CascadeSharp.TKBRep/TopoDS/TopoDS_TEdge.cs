//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_TEdge
    //---------------------------------------------------------------------
    /// <summary>
    /// A topological part of a curve in 2D or 3D, the boundary is a set of oriented Vertices.
    /// </summary>
    public abstract class TopoDS_TEdge : TopoDS_TShape
    {

        public override TopAbs_ShapeEnum ShapeType()
        {
            return TopAbs_ShapeEnum.TopAbs_EDGE;
        }
    }
}