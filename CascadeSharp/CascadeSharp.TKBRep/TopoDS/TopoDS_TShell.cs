//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_TShell
    //---------------------------------------------------------------------
    /// <summary>
    /// A set of faces connected by their edges.
    /// </summary>
    public class TopoDS_TShell : TopoDS_TShape
    {
        public override TopAbs_ShapeEnum ShapeType()
        {
            return TopAbs_ShapeEnum.TopAbs_SHELL;
        }

        public override TopoDS_TShape EmptyCopy()
        {
            return new TopoDS_TShell();
        }

    }
}