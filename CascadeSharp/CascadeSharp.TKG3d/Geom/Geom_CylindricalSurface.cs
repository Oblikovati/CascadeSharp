//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Geom
{
    //---------------------------------------------------------------------
    //  Class  Geom_CylindricalSurface
    //---------------------------------------------------------------------
    public sealed class Geom_CylindricalSurface : Geom_ElementarySurface
    {
        public Geom_CylindricalSurface(gp_Ax3 A3, double Radius)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_CylindricalSurface(gp_Cylinder C)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_CylindricalSurface(Geom_CylindricalSurface parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_CylindricalSurface()
        {
            throw new NotImplementedException();
        }

        public void SetCylinder(gp_Cylinder C)
        {
            throw new NotImplementedException();
        }

        public void SetRadius(double R)
        {
            throw new NotImplementedException();
        }

        public gp_Cylinder Cylinder()
        {
            throw new NotImplementedException();
        }

        public double UReversedParameter(double U)
        {
            throw new NotImplementedException();
        }

        public double VReversedParameter(double V)
        {
            throw new NotImplementedException();
        }

        public void TransformParameters(ref double U, ref double V, gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public gp_GTrsf2d ParametricTransformation(gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public void Bounds(ref double U1, ref double U2, ref double V1, ref double V2)
        {
            throw new NotImplementedException();
        }

        public void Coefficients(ref double A1, ref double A2, ref double A3, ref double B1, ref double B2,
            ref double B3, ref double C1, ref double C2, ref double C3, ref double D)
        {
            throw new NotImplementedException();
        }

        public double Radius()
        {
            throw new NotImplementedException();
        }

        public bool IsUClosed()
        {
            throw new NotImplementedException();
        }

        public bool IsVClosed()
        {
            throw new NotImplementedException();
        }

        public bool IsUPeriodic()
        {
            throw new NotImplementedException();
        }

        public bool IsVPeriodic()
        {
            throw new NotImplementedException();
        }

        public Geom_Curve UIso(double U)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve VIso(double V)
        {
            throw new NotImplementedException();
        }

        public void D0(double U, double V, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V)
        {
            throw new NotImplementedException();
        }

        public void D2(double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec D2UV)
        {
            throw new NotImplementedException();
        }

        public void D3(double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec D2UV,
            gp_Vec D3U, gp_Vec D3V, gp_Vec D3UUV, gp_Vec D3UVV)
        {
            throw new NotImplementedException();
        }

        public gp_Vec DN(double U, double V, int Nu, int Nv)
        {
            throw new NotImplementedException();
        }

        public void Transform(gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public Geom_Geometry Copy()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom_CylindricalSurface
}