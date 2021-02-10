//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG2d.Geom2d
{
    //---------------------------------------------------------------------
    //  Class  Geom2d_Geometry
    //---------------------------------------------------------------------
    public abstract class Geom2d_Geometry : Standard_Transient
    {
        public Geom2d_Geometry(Geom2d_Geometry parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Geom2d_Geometry()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void Mirror(gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public void Mirror(gp_Ax2d A)
        {
            throw new NotImplementedException();
        }

        public void Rotate(gp_Pnt2d P, double Ang)
        {
            throw new NotImplementedException();
        }

        public void Scale(gp_Pnt2d P, double S)
        {
            throw new NotImplementedException();
        }

        public void Translate(gp_Vec2d V)
        {
            throw new NotImplementedException();
        }

        public void Translate(gp_Pnt2d P1, gp_Pnt2d P2)
        {
            throw new NotImplementedException();
        }

        public void Transform(gp_Trsf2d T)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Geometry Mirrored(gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Geometry Mirrored(gp_Ax2d A)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Geometry Rotated(gp_Pnt2d P, double Ang)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Geometry Scaled(gp_Pnt2d P, double S)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Geometry Transformed(gp_Trsf2d T)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Geometry Translated(gp_Vec2d V)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Geometry Translated(gp_Pnt2d P1, gp_Pnt2d P2)
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
    }; // class Geom2d_Geometry
}