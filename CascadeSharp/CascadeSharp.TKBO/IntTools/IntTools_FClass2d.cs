//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBO.IntTools
{
    //---------------------------------------------------------------------
    //  Class  IntTools_FClass2d
    //---------------------------------------------------------------------
    public sealed class IntTools_FClass2d
    {
        public IntTools_FClass2d()
            : base()
        {
            throw new NotImplementedException();
        }

        public IntTools_FClass2d(TopoDS_Face F, double Tol)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Face F, double Tol)
        {
            throw new NotImplementedException();
        }

        public TopAbs_State PerformInfinitePoint()
        {
            throw new NotImplementedException();
        }

        public TopAbs_State Perform(gp_Pnt2d Puv, bool RecadreOnPeriodic)
        {
            throw new NotImplementedException();
        }

        public TopAbs_State Perform(gp_Pnt2d Puv)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public TopAbs_State TestOnRestriction(gp_Pnt2d Puv, double Tol, bool RecadreOnPeriodic)
        {
            throw new NotImplementedException();
        }

        public TopAbs_State TestOnRestriction(gp_Pnt2d Puv, double Tol)
        {
            throw new NotImplementedException();
        }

        public bool IsHole()
        {
            throw new NotImplementedException();
        }
    }; // class IntTools_FClass2d
}