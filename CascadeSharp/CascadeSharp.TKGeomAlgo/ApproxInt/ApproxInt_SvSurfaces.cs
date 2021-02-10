//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKGeomAlgo.IntSurf;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.ApproxInt
{
    //---------------------------------------------------------------------
    //  Class  ApproxInt_SvSurfaces
    //---------------------------------------------------------------------
    public abstract class ApproxInt_SvSurfaces
    {
        public ApproxInt_SvSurfaces()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public ApproxInt_SvSurfaces(ApproxInt_SvSurfaces parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public bool Compute(ref double u1, ref double v1, ref double u2, ref double v2, gp_Pnt Pt, gp_Vec Tg,
            gp_Vec2d Tguv1, gp_Vec2d Tguv2)
        {
            throw new NotImplementedException();
        }

        public void Pnt(double u1, double v1, double u2, double v2, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public bool SeekPoint(double u1, double v1, double u2, double v2, IntSurf_PntOn2S Point)
        {
            throw new NotImplementedException();
        }

        public bool Tangency(double u1, double v1, double u2, double v2, gp_Vec Tg)
        {
            throw new NotImplementedException();
        }

        public bool TangencyOnSurf1(double u1, double v1, double u2, double v2, gp_Vec2d Tg)
        {
            throw new NotImplementedException();
        }

        public bool TangencyOnSurf2(double u1, double v1, double u2, double v2, gp_Vec2d Tg)
        {
            throw new NotImplementedException();
        }
    }; // class ApproxInt_SvSurfaces
}