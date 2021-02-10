//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG2d.Geom2d
{
    //---------------------------------------------------------------------
    //  Class  Geom2d_OffsetCurve
    //---------------------------------------------------------------------
    public sealed class Geom2d_OffsetCurve : Geom2d_Curve
    {
        public Geom2d_OffsetCurve(Geom2d_Curve C, double Offset, bool _isNotCheckC0)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_OffsetCurve(Geom2d_Curve C, double Offset)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_OffsetCurve(Geom2d_OffsetCurve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_OffsetCurve()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public double ReversedParameter(double U)
        {
            throw new NotImplementedException();
        }

        public void SetBasisCurve(Geom2d_Curve C, bool _isNotCheckC0)
        {
            throw new NotImplementedException();
        }

        public void SetBasisCurve(Geom2d_Curve C)
        {
            throw new NotImplementedException();
        }

        public void SetOffsetValue(double D)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve BasisCurve()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity()
        {
            throw new NotImplementedException();
        }

        public void D0(double U, gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, gp_Pnt2d P, gp_Vec2d V1)
        {
            throw new NotImplementedException();
        }

        public void D2(double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2)
        {
            throw new NotImplementedException();
        }

        public void D3(double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, gp_Vec2d V3)
        {
            throw new NotImplementedException();
        }

        public gp_Vec2d DN(double U, int N)
        {
            throw new NotImplementedException();
        }

        public double FirstParameter()
        {
            throw new NotImplementedException();
        }

        public double LastParameter()
        {
            throw new NotImplementedException();
        }

        public double Offset()
        {
            throw new NotImplementedException();
        }

        public bool IsClosed()
        {
            throw new NotImplementedException();
        }

        public bool IsCN(int N)
        {
            throw new NotImplementedException();
        }

        public bool IsPeriodic()
        {
            throw new NotImplementedException();
        }

        public double Period()
        {
            throw new NotImplementedException();
        }

        public void Transform(gp_Trsf2d T)
        {
            throw new NotImplementedException();
        }

        public double TransformedParameter(double U, gp_Trsf2d T)
        {
            throw new NotImplementedException();
        }

        public double ParametricTransformation(gp_Trsf2d T)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Geometry Copy()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape GetBasisCurveContinuity()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom2d_OffsetCurve
}