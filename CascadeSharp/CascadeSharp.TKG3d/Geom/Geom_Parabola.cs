//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Geom
{
    //---------------------------------------------------------------------
    //  Class  Geom_Parabola
    //---------------------------------------------------------------------
    public sealed class Geom_Parabola : Geom_Conic
    {
        public Geom_Parabola(gp_Parab Prb)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Parabola(gp_Ax2 A2, double Focal)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Parabola(gp_Ax1 D, gp_Pnt F)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Parabola(Geom_Parabola parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Parabola()
        {
            throw new NotImplementedException();
        }

        public void SetFocal(double Focal)
        {
            throw new NotImplementedException();
        }

        public void SetParab(gp_Parab Prb)
        {
            throw new NotImplementedException();
        }

        public gp_Parab Parab()
        {
            throw new NotImplementedException();
        }

        public double ReversedParameter(double U)
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

        public bool IsClosed()
        {
            throw new NotImplementedException();
        }

        public bool IsPeriodic()
        {
            throw new NotImplementedException();
        }

        public gp_Ax1 Directrix()
        {
            throw new NotImplementedException();
        }

        public double Eccentricity()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Focus()
        {
            throw new NotImplementedException();
        }

        public double Focal()
        {
            throw new NotImplementedException();
        }

        public double Parameter()
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

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom_Parabola
}