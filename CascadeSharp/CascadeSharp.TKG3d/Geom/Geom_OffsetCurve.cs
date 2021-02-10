//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Geom
{
    //---------------------------------------------------------------------
    //  Class  Geom_OffsetCurve
    //---------------------------------------------------------------------
    public sealed class Geom_OffsetCurve : Geom_Curve
    {
        public Geom_OffsetCurve(Geom_Curve C, double Offset, gp_Dir V, bool _isNotCheckC0)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_OffsetCurve(Geom_Curve C, double Offset, gp_Dir V)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_OffsetCurve(Geom_OffsetCurve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_OffsetCurve()
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

        public void SetBasisCurve(Geom_Curve C, bool _isNotCheckC0)
        {
            throw new NotImplementedException();
        }

        public void SetBasisCurve(Geom_Curve C)
        {
            throw new NotImplementedException();
        }

        public void SetDirection(gp_Dir V)
        {
            throw new NotImplementedException();
        }

        public void SetOffsetValue(double D)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve BasisCurve()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity()
        {
            throw new NotImplementedException();
        }

        public gp_Dir Direction()
        {
            throw new NotImplementedException();
        }

        public void D0(double U, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, gp_Pnt P, gp_Vec V1)
        {
            throw new NotImplementedException();
        }

        public void D2(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2)
        {
            throw new NotImplementedException();
        }

        public void D3(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2, gp_Vec V3)
        {
            throw new NotImplementedException();
        }

        public gp_Vec DN(double U, int N)
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

        public void Transform(gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public double TransformedParameter(double U, gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public double ParametricTransformation(gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public Geom_Geometry Copy()
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
    }; // class Geom_OffsetCurve
}