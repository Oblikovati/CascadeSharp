//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.TopTrans
{
    //---------------------------------------------------------------------
    //  Class  TopTrans_SurfaceTransition
    //---------------------------------------------------------------------
    public sealed class TopTrans_SurfaceTransition
    {
        public TopTrans_SurfaceTransition()
            : base()
        {
            throw new NotImplementedException();
        }

        public TopTrans_SurfaceTransition(TopTrans_SurfaceTransition parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Reset(gp_Dir Tgt, gp_Dir Norm, gp_Dir MaxD, gp_Dir MinD, double MaxCurv, double MinCurv)
        {
            throw new NotImplementedException();
        }

        public void Reset(gp_Dir Tgt, gp_Dir Norm)
        {
            throw new NotImplementedException();
        }

        public void Compare(double Tole, gp_Dir Norm, gp_Dir MaxD, gp_Dir MinD, double MaxCurv, double MinCurv,
            TopAbs_Orientation S, TopAbs_Orientation O)
        {
            throw new NotImplementedException();
        }

        public void Compare(double Tole, gp_Dir Norm, TopAbs_Orientation S, TopAbs_Orientation O)
        {
            throw new NotImplementedException();
        }

        public TopAbs_State StateBefore()
        {
            throw new NotImplementedException();
        }

        public TopAbs_State StateAfter()
        {
            throw new NotImplementedException();
        }

        public TopAbs_State GetBefore(TopAbs_Orientation Tran)
        {
            throw new NotImplementedException();
        }

        public TopAbs_State GetAfter(TopAbs_Orientation Tran)
        {
            throw new NotImplementedException();
        }

        public void UpdateReference(double Tole, bool _isInfRef, ref double CosInf, ref double CosSup,
            TopAbs_Orientation Tran, ref TopAbs_Orientation TranRef)
        {
            throw new NotImplementedException();
        }

        public double ComputeCos(double Tole, gp_Dir Norm, TopAbs_Orientation O, ref bool _isleft)
        {
            throw new NotImplementedException();
        }
    }; // class TopTrans_SurfaceTransition
}