//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Geom
{
    //---------------------------------------------------------------------
    //  Class  Geom_Circle
    //---------------------------------------------------------------------
    public sealed class Geom_Circle : Geom_Conic
    {
        public Geom_Circle(gp_Circ C)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Circle(gp_Ax2 A2, double Radius)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Circle(Geom_Circle parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Circle()
        {
            throw new NotImplementedException();
        }

        public void SetCirc(gp_Circ C)
        {
            throw new NotImplementedException();
        }

        public void SetRadius(double R)
        {
            throw new NotImplementedException();
        }

        public gp_Circ Circ()
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

        public Geom_Geometry Copy()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom_Circle
}