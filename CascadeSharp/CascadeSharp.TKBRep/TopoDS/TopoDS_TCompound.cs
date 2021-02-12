//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_TCompound
    //---------------------------------------------------------------------
    /// <summary>
    /// A TCompound is an all-purpose set of Shapes.
    /// </summary>
    public class TopoDS_TCompound : TopoDS_TShape
    {
        public override TopAbs_ShapeEnum ShapeType()
        {
            return TopAbs_ShapeEnum.TopAbs_COMPOUND;
        }

        public override TopoDS_TShape EmptyCopy()
        {
            return new TopoDS_TCompound();
        }

    }
}