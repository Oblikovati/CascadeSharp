//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.Convert;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKFillet.BlendFunc
{
    //---------------------------------------------------------------------
    //  Class  BlendFunc
    //---------------------------------------------------------------------
    public sealed class BlendFunc
    {
        public BlendFunc()
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc(BlendFunc parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void GetShape(BlendFunc_SectionShape SectShape, double MaxAng, ref int NbPoles, ref int NbKnots,
            ref int Degree, ref Convert_ParameterisationType TypeConv)
        {
            throw new NotImplementedException();
        }

        public void Knots(BlendFunc_SectionShape SectShape, TColStd_Array1OfReal TKnots)
        {
            throw new NotImplementedException();
        }

        public void Mults(BlendFunc_SectionShape SectShape, TColStd_Array1OfInteger TMults)
        {
            throw new NotImplementedException();
        }

        public void GetMinimalWeights(BlendFunc_SectionShape SectShape, Convert_ParameterisationType TConv,
            double AngleMin, double AngleMax, TColStd_Array1OfReal Weigths)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape NextShape(GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool ComputeNormal(Adaptor3d_HSurface Surf, gp_Pnt2d p2d, gp_Vec Normal)
        {
            throw new NotImplementedException();
        }

        public bool ComputeDNormal(Adaptor3d_HSurface Surf, gp_Pnt2d p2d, gp_Vec Normal, gp_Vec DNu, gp_Vec DNv)
        {
            throw new NotImplementedException();
        }
    }; // class BlendFunc
}