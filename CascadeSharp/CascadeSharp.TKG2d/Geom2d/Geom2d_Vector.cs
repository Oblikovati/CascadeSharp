//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG2d.Geom2d
{
    //---------------------------------------------------------------------
    //  Class  Geom2d_Vector
    //---------------------------------------------------------------------
    public abstract class Geom2d_Vector : Geom2d_Geometry
    {
        public Geom2d_Vector()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Geom2d_Vector(Geom2d_Vector parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Vector Reversed()
        {
            throw new NotImplementedException();
        }

        public double Angle(Geom2d_Vector Other)
        {
            throw new NotImplementedException();
        }

        public void Coord(ref double X, ref double Y)
        {
            throw new NotImplementedException();
        }

        public double Magnitude()
        {
            throw new NotImplementedException();
        }

        public double SquareMagnitude()
        {
            throw new NotImplementedException();
        }

        public double X()
        {
            throw new NotImplementedException();
        }

        public double Y()
        {
            throw new NotImplementedException();
        }

        public double Crossed(Geom2d_Vector Other)
        {
            throw new NotImplementedException();
        }

        public double Dot(Geom2d_Vector Other)
        {
            throw new NotImplementedException();
        }

        public gp_Vec2d Vec2d()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom2d_Vector
}