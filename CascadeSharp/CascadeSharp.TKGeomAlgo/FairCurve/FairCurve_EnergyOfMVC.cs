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
    //  Class  FairCurve_EnergyOfMVC
    //---------------------------------------------------------------------
    public sealed class FairCurve_EnergyOfMVC : FairCurve_Energy
    {
        public FairCurve_EnergyOfMVC(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles,
            int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double PhysicalRatio, double LengthSliding,
            bool FreeSliding, double Angle1, double Angle2, double Curvature1, double Curvature2)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_EnergyOfMVC(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles,
            int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double PhysicalRatio, double LengthSliding,
            bool FreeSliding, double Angle1, double Angle2, double Curvature1)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_EnergyOfMVC(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles,
            int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double PhysicalRatio, double LengthSliding,
            bool FreeSliding, double Angle1, double Angle2)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_EnergyOfMVC(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles,
            int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double PhysicalRatio, double LengthSliding,
            bool FreeSliding, double Angle1)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_EnergyOfMVC(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles,
            int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double PhysicalRatio, double LengthSliding,
            bool FreeSliding)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_EnergyOfMVC(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles,
            int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double PhysicalRatio, double LengthSliding)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_EnergyOfMVC(FairCurve_EnergyOfMVC parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public FairCurve_EnergyOfMVC()
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
    }; // class FairCurve_EnergyOfMVC
}