//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.Bisector
{
    //---------------------------------------------------------------------
    //  Class  Bisector_Curve
    //---------------------------------------------------------------------
    public abstract class Bisector_Curve : Geom2d_Curve
    {
        public Bisector_Curve(Bisector_Curve parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Bisector_Curve()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public double Parameter(gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public bool IsExtendAtStart()
        {
            throw new NotImplementedException();
        }

        public bool IsExtendAtEnd()
        {
            throw new NotImplementedException();
        }

        public int NbIntervals()
        {
            throw new NotImplementedException();
        }

        public double IntervalFirst(int Index)
        {
            throw new NotImplementedException();
        }

        public double IntervalLast(int Index)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Bisector_Curve
}