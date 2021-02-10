//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Geom
{
    //---------------------------------------------------------------------
    //  Class  Geom_AxisPlacement
    //---------------------------------------------------------------------
    public abstract class Geom_AxisPlacement : Geom_Geometry
    {
        public Geom_AxisPlacement()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Geom_AxisPlacement(Geom_AxisPlacement parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void SetAxis(gp_Ax1 A1)
        {
            throw new NotImplementedException();
        }

        public void SetDirection(gp_Dir V)
        {
            throw new NotImplementedException();
        }

        public void SetLocation(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public double Angle(Geom_AxisPlacement Other)
        {
            throw new NotImplementedException();
        }

        public gp_Ax1 Axis()
        {
            throw new NotImplementedException();
        }

        public gp_Dir Direction()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Location()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom_AxisPlacement
}