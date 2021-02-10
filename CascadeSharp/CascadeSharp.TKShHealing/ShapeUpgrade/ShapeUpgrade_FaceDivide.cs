//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeUpgrade
{
    //---------------------------------------------------------------------
    //  Class  ShapeUpgrade_FaceDivide
    //---------------------------------------------------------------------
    public class ShapeUpgrade_FaceDivide : ShapeUpgrade_Tool
    {
        public ShapeUpgrade_FaceDivide()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeUpgrade_FaceDivide(TopoDS_Face F)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeUpgrade_FaceDivide(ShapeUpgrade_FaceDivide parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public void SetSurfaceSegmentMode(bool Segment)
        {
            throw new NotImplementedException();
        }

        public bool Perform()
        {
            throw new NotImplementedException();
        }

        public bool SplitSurface()
        {
            throw new NotImplementedException();
        }

        public bool SplitCurves()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Result()
        {
            throw new NotImplementedException();
        }

        public bool Status(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public void SetSplitSurfaceTool(ShapeUpgrade_SplitSurface splitSurfaceTool)
        {
            throw new NotImplementedException();
        }

        public void SetWireDivideTool(ShapeUpgrade_WireDivide wireDivideTool)
        {
            throw new NotImplementedException();
        }

        public ShapeUpgrade_SplitSurface GetSplitSurfaceTool()
        {
            throw new NotImplementedException();
        }

        public ShapeUpgrade_WireDivide GetWireDivideTool()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class ShapeUpgrade_FaceDivide
}