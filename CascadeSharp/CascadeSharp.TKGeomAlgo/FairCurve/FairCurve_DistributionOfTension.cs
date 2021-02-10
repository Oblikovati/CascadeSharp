//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.math;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomAlgo.FairCurve
{
    //---------------------------------------------------------------------
    //  Class  FairCurve_DistributionOfTension
    //---------------------------------------------------------------------
    public sealed class FairCurve_DistributionOfTension : FairCurve_DistributionOfEnergy
    {
        public FairCurve_DistributionOfTension(int BSplOrder, TColStd_HArray1OfReal FlatKnots,
            TColgp_HArray1OfPnt2d Poles, int DerivativeOrder, double LengthSliding, FairCurve_BattenLaw Law,
            int NbValAux, bool Uniform)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_DistributionOfTension(int BSplOrder, TColStd_HArray1OfReal FlatKnots,
            TColgp_HArray1OfPnt2d Poles, int DerivativeOrder, double LengthSliding, FairCurve_BattenLaw Law,
            int NbValAux)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_DistributionOfTension(int BSplOrder, TColStd_HArray1OfReal FlatKnots,
            TColgp_HArray1OfPnt2d Poles, int DerivativeOrder, double LengthSliding, FairCurve_BattenLaw Law)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_DistributionOfTension(FairCurve_DistributionOfTension parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_DistributionOfTension()
        {
            throw new NotImplementedException();
        }

        public void SetLengthSliding(double LengthSliding)
        {
            throw new NotImplementedException();
        }

        public bool Value(math_Vector X, math_Vector F)
        {
            throw new NotImplementedException();
        }
    }; // class FairCurve_DistributionOfTension
}