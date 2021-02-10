//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG2d.Geom2d
{
    //---------------------------------------------------------------------
    //  Class  Geom2d_Point
    //---------------------------------------------------------------------
    public abstract class Geom2d_Point : Geom2d_Geometry
    {
        public Geom2d_Point()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Geom2d_Point(Geom2d_Point parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void Coord(ref double X, ref double Y)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d Pnt2d()
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

        public double Distance(Geom2d_Point Other)
        {
            throw new NotImplementedException();
        }

        public double SquareDistance(Geom2d_Point Other)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom2d_Point
}