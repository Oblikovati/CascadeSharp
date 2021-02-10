//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG2d.Geom2d
{
    //---------------------------------------------------------------------
    //  Class  Geom2d_Parabola
    //---------------------------------------------------------------------
    public sealed class Geom2d_Parabola : Geom2d_Conic
    {
        public Geom2d_Parabola(gp_Parab2d Prb)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Parabola(gp_Ax2d MirrorAx_is, double Focal, bool Sense)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Parabola(gp_Ax2d MirrorAx_is, double Focal)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Parabola(gp_Ax22d Ax_is, double Focal)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Parabola(gp_Ax2d D, gp_Pnt2d F)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Parabola(Geom2d_Parabola parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Parabola()
        {
            throw new NotImplementedException();
        }

        public void SetFocal(double Focal)
        {
            throw new NotImplementedException();
        }

        public void SetParab2d(gp_Parab2d Prb)
        {
            throw new NotImplementedException();
        }

        public gp_Parab2d Parab2d()
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

        public gp_Ax2d Directrix()
        {
            throw new NotImplementedException();
        }

        public double Eccentricity()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d Focus()
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

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom2d_Parabola
}