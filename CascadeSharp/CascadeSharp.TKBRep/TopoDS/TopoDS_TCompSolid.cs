//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_TCompSolid
    //---------------------------------------------------------------------
    /// <summary>
    /// A set of solids connected by their faces.
    /// </summary>
    public class TopoDS_TCompSolid : TopoDS_TShape
    {
        public override TopAbs_ShapeEnum ShapeType()
        {
            return TopAbs_ShapeEnum.TopAbs_COMPSOLID;
        }

        public override TopoDS_TShape EmptyCopy()
        {
            return new TopoDS_TCompSolid();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }
}