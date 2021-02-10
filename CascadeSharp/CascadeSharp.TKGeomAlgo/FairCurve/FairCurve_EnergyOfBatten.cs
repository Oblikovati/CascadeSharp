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
    //  Class  FairCurve_EnergyOfBatten
    //---------------------------------------------------------------------
    public sealed class FairCurve_EnergyOfBatten : FairCurve_Energy
    {
        public FairCurve_EnergyOfBatten(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles,
            int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double LengthSliding, bool FreeSliding,
            double Angle1, double Angle2)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_EnergyOfBatten(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles,
            int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double LengthSliding, bool FreeSliding,
            double Angle1)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_EnergyOfBatten(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles,
            int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double LengthSliding, bool FreeSliding)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_EnergyOfBatten(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles,
            int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double LengthSliding)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_EnergyOfBatten(FairCurve_EnergyOfBatten parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_EnergyOfBatten()
        {
            throw new NotImplementedException();
        }

        public double LengthSliding()
        {
            throw new NotImplementedException();
        }

        public FairCurve_AnalysisCode Status()
        {
            throw new NotImplementedException();
        }

        public bool Variable(Vector X)
        {
            throw new NotImplementedException();
        }

        public void ComputePoles(Vector X)
        {
            throw new NotImplementedException();
        }

        public bool Compute(int DerivativeOrder, Vector Result)
        {
            throw new NotImplementedException();
        }
    }; // class FairCurve_EnergyOfBatten
}