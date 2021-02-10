//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepTools;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeBuild
{
    //---------------------------------------------------------------------
    //  Class  ShapeBuild_ReShape
    //---------------------------------------------------------------------
    public sealed class ShapeBuild_ReShape : BRepTools_ReShape
    {
        public ShapeBuild_ReShape()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeBuild_ReShape(ShapeBuild_ReShape parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Apply(TopoDS_Shape shape, TopAbs_ShapeEnum until, int buildmode)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Apply(TopoDS_Shape shape, TopAbs_ShapeEnum until)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Apply(TopoDS_Shape shape)
        {
            throw new NotImplementedException();
        }

        public int Status(TopoDS_Shape shape, TopoDS_Shape newsh, bool last)
        {
            throw new NotImplementedException();
        }

        public int Status(TopoDS_Shape shape, TopoDS_Shape newsh)
        {
            throw new NotImplementedException();
        }

        public bool Status(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class ShapeBuild_ReShape
}