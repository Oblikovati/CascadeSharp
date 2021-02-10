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
    //  Class  FairCurve_DistributionOfEnergy
    //---------------------------------------------------------------------
    public abstract class FairCurve_DistributionOfEnergy : math_FunctionSet
    {
        public FairCurve_DistributionOfEnergy(int BSplOrder, TColStd_HArray1OfReal FlatKnots,
            TColgp_HArray1OfPnt2d Poles, int DerivativeOrder, int NbValAux)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FairCurve_DistributionOfEnergy(int BSplOrder, TColStd_HArray1OfReal FlatKnots,
            TColgp_HArray1OfPnt2d Poles, int DerivativeOrder)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FairCurve_DistributionOfEnergy(FairCurve_DistributionOfEnergy parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FairCurve_DistributionOfEnergy()
        {
            throw new NotImplementedException();
        }

        public int NbVariables()
        {
            throw new NotImplementedException();
        }

        public int NbEquations()
        {
            throw new NotImplementedException();
        }

        public void SetDerivativeOrder(int DerivativeOrder)
        {
            throw new NotImplementedException();
        }
    }; // class FairCurve_DistributionOfEnergy
}