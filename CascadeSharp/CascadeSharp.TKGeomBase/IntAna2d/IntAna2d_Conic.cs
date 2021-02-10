//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomBase.IntAna2d
{
    //---------------------------------------------------------------------
    //  Class  IntAna2d_Conic
    //---------------------------------------------------------------------
    public sealed class IntAna2d_Conic
    {
        public IntAna2d_Conic(gp_Circ2d C)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntAna2d_Conic(gp_Lin2d C)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntAna2d_Conic(gp_Parab2d C)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntAna2d_Conic(gp_Hypr2d C)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntAna2d_Conic(gp_Elips2d C)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntAna2d_Conic(IntAna2d_Conic parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntAna2d_Conic()
        {
            throw new NotImplementedException();
        }

        public double Value(double X, double Y)
        {
            throw new NotImplementedException();
        }

        public gp_XY Grad(double X, double Y)
        {
            throw new NotImplementedException();
        }

        public void ValAndGrad(double X, double Y, ref double Val, gp_XY Grd)
        {
            throw new NotImplementedException();
        }

        public void Coefficients(ref double A, ref double B, ref double C, ref double D, ref double E, ref double F)
        {
            throw new NotImplementedException();
        }

        public void NewCoefficients(ref double A, ref double B, ref double C, ref double D, ref double E, ref double F,
            gp_Ax2d Ax_is)
        {
            throw new NotImplementedException();
        }
    }; // class IntAna2d_Conic
}