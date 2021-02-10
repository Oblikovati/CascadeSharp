//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.IntCurveSurface
{
    //---------------------------------------------------------------------
    //  Class  IntCurveSurface_ThePolygonOfHInter
    //---------------------------------------------------------------------
    public sealed class IntCurveSurface_ThePolygonOfHInter
    {
        public IntCurveSurface_ThePolygonOfHInter(Adaptor3d_HCurve Curve, int NbPnt)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntCurveSurface_ThePolygonOfHInter(Adaptor3d_HCurve Curve, double U1, double U2, int NbPnt)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntCurveSurface_ThePolygonOfHInter(Adaptor3d_HCurve Curve, TColStd_Array1OfReal Upars)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntCurveSurface_ThePolygonOfHInter(IntCurveSurface_ThePolygonOfHInter parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntCurveSurface_ThePolygonOfHInter()
        {
            throw new NotImplementedException();
        }

        public Bnd_Box Bounding()
        {
            throw new NotImplementedException();
        }

        public double DeflectionOverEstimation()
        {
            throw new NotImplementedException();
        }

        public void SetDeflectionOverEstimation(double x)
        {
            throw new NotImplementedException();
        }

        public void Closed(bool clos)
        {
            throw new NotImplementedException();
        }

        public bool Closed()
        {
            throw new NotImplementedException();
        }

        public int NbSegments()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt BeginOfSeg(int Index)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt EndOfSeg(int Index)
        {
            throw new NotImplementedException();
        }

        public double InfParameter()
        {
            throw new NotImplementedException();
        }

        public double SupParameter()
        {
            throw new NotImplementedException();
        }

        public double ApproxParamOnCurve(int Index, double ParamOnLine)
        {
            throw new NotImplementedException();
        }

        public void Dump()
        {
            throw new NotImplementedException();
        }

        public void Init(Adaptor3d_HCurve Curve)
        {
            throw new NotImplementedException();
        }

        public void Init(Adaptor3d_HCurve Curve, TColStd_Array1OfReal Upars)
        {
            throw new NotImplementedException();
        }
    }; // class IntCurveSurface_ThePolygonOfHInter
}