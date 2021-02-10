//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG2d.Geom2d
{
    //---------------------------------------------------------------------
    //  Class  Geom2d_Circle
    //---------------------------------------------------------------------
    public sealed class Geom2d_Circle : Geom2d_Conic
    {
        public Geom2d_Circle(gp_Circ2d C)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Circle(gp_Ax2d A, double Radius, bool Sense)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Circle(gp_Ax2d A, double Radius)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Circle(gp_Ax22d A, double Radius)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Circle(Geom2d_Circle parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Circle()
        {
            throw new NotImplementedException();
        }

        public void SetCirc2d(gp_Circ2d C)
        {
            throw new NotImplementedException();
        }

        public void SetRadius(double R)
        {
            throw new NotImplementedException();
        }

        public gp_Circ2d Circ2d()
        {
            throw new NotImplementedException();
        }

        public double Radius()
        {
            throw new NotImplementedException();
        }

        public double ReversedParameter(double U)
        {
            throw new NotImplementedException();
        }

        public double Eccentricity()
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

        public Geom2d_Geometry Copy()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom2d_Circle
}