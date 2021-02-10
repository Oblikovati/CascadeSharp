//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TColGeom;

namespace CascadeSharp.TKFeat.LocOpe
{
    //---------------------------------------------------------------------
    //  Class  LocOpe_DPrism
    //---------------------------------------------------------------------
    public sealed class LocOpe_DPrism
    {
        public LocOpe_DPrism(TopoDS_Face Spine, double Height1, double Height2, double Angle)
            : base()
        {
            throw new NotImplementedException();
        }

        public LocOpe_DPrism(TopoDS_Face Spine, double Height, double Angle)
            : base()
        {
            throw new NotImplementedException();
        }

        public LocOpe_DPrism(LocOpe_DPrism parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public LocOpe_DPrism()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Spine()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Profile()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape FirstShape()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape LastShape()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Shapes(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void Curves(TColGeom_SequenceOfCurve SCurves)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve BarycCurve()
        {
            throw new NotImplementedException();
        }

        public void IntPerf()
        {
            throw new NotImplementedException();
        }
    }; // class LocOpe_DPrism
}