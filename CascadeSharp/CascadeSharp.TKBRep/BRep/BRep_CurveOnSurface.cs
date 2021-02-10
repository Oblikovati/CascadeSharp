//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.BRep
{
    //---------------------------------------------------------------------
    //  Class  BRep_CurveOnSurface
    //---------------------------------------------------------------------
    public class BRep_CurveOnSurface : BRep_GCurve
    {
        public BRep_CurveOnSurface(Geom2d_Curve PC, Geom_Surface S, TopLoc_Location L)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRep_CurveOnSurface(BRep_CurveOnSurface parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRep_CurveOnSurface()
        {
            throw new NotImplementedException();
        }

        public void SetUVPoints(gp_Pnt2d P1, gp_Pnt2d P2)
        {
            throw new NotImplementedException();
        }

        public void UVPoints(gp_Pnt2d P1, gp_Pnt2d P2)
        {
            throw new NotImplementedException();
        }

        public void D0(double U, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public bool IsCurveOnSurface()
        {
            throw new NotImplementedException();
        }

        public bool IsCurveOnSurface(Geom_Surface S, TopLoc_Location L)
        {
            throw new NotImplementedException();
        }

        public Geom_Surface Surface()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve PCurve()
        {
            throw new NotImplementedException();
        }

        public void PCurve(Geom2d_Curve C)
        {
            throw new NotImplementedException();
        }

        public BRep_CurveRepresentation Copy()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class BRep_CurveOnSurface
}