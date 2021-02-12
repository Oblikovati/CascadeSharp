//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_TVertex
    //---------------------------------------------------------------------
    /// <summary>
    /// A Vertex is a topological point in two or three dimensions.
    /// </summary>
    public abstract class TopoDS_TVertex : TopoDS_TShape
    {
        protected TopoDS_TVertex() { }


        public override TopAbs_ShapeEnum ShapeType()
        {
            return TopAbs_ShapeEnum.TopAbs_VERTEX;
        }

    }
}