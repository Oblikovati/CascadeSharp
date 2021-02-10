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
    //  Class  Geom_Conic
    //---------------------------------------------------------------------
    public abstract class Geom_Conic : Geom_Curve
    {
        public Geom_Conic()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Geom_Conic(Geom_Conic parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void SetAxis(gp_Ax1 theA1)
        {
            throw new NotImplementedException();
        }

        public void SetLocation(gp_Pnt theP)
        {
            throw new NotImplementedException();
        }

        public void SetPosition(gp_Ax2 theA2)
        {
            throw new NotImplementedException();
        }

        public gp_Ax1 Axis()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Location()
        {
            throw new NotImplementedException();
        }

        public gp_Ax2 Position()
        {
            throw new NotImplementedException();
        }

        public double Eccentricity()
        {
            throw new NotImplementedException();
        }

        public gp_Ax1 XAxis()
        {
            throw new NotImplementedException();
        }

        public gp_Ax1 YAxis()
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

        public GeomAbs_Shape Continuity()
        {
            throw new NotImplementedException();
        }

        public bool IsCN(int N)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom_Conic
}