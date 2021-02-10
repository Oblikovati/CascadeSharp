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
    //  Class  FairCurve_DistributionOfJerk
    //---------------------------------------------------------------------
    public sealed class FairCurve_DistributionOfJerk : FairCurve_DistributionOfEnergy
    {
        public FairCurve_DistributionOfJerk(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles,
            int DerivativeOrder, FairCurve_BattenLaw Law, int NbValAux)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_DistributionOfJerk(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles,
            int DerivativeOrder, FairCurve_BattenLaw Law)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_DistributionOfJerk(FairCurve_DistributionOfJerk parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_DistributionOfJerk()
        {
            throw new NotImplementedException();
        }

        public bool Value(Vector X, Vector F)
        {
            throw new NotImplementedException();
        }
    }; // class FairCurve_DistributionOfJerk
}