//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.BRep
{
    //---------------------------------------------------------------------
    //  Class  BRep_PointOnCurve
    //---------------------------------------------------------------------
    public sealed class BRep_PointOnCurve : BRep_PointRepresentation
    {
        public BRep_PointOnCurve(double P, Geom_Curve C, TopLoc_Location L)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRep_PointOnCurve(BRep_PointOnCurve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRep_PointOnCurve()
        {
            throw new NotImplementedException();
        }

        public bool IsPointOnCurve()
        {
            throw new NotImplementedException();
        }

        public bool IsPointOnCurve(Geom_Curve C, TopLoc_Location L)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve Curve()
        {
            throw new NotImplementedException();
        }

        public void Curve(Geom_Curve C)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class BRep_PointOnCurve
}