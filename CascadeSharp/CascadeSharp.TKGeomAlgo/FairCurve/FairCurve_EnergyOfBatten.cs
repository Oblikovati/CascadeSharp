//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  FairCurve_EnergyOfBatten
	//---------------------------------------------------------------------
	public  sealed class FairCurve_EnergyOfBatten : CascadeSharp.FairCurve_Energy
	{

		public FairCurve_EnergyOfBatten(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles, int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double LengthSliding, bool FreeSliding, double Angle1, double Angle2)
			: base()
		{
			throw new NotImplementedException();
		}

		public FairCurve_EnergyOfBatten(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles, int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double LengthSliding, bool FreeSliding, double Angle1)
			: base()
		{
			throw new NotImplementedException();
		}

		public FairCurve_EnergyOfBatten(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles, int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double LengthSliding, bool FreeSliding)
			: base()
		{
			throw new NotImplementedException();
		}

		public FairCurve_EnergyOfBatten(int BSplOrder, TColStd_HArray1OfReal FlatKnots, TColgp_HArray1OfPnt2d Poles, int ContrOrder1, int ContrOrder2, FairCurve_BattenLaw Law, double LengthSliding)
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

		public CascadeSharp.FairCurve_AnalysisCode Status()
		{
			throw new NotImplementedException();
		}

		public bool Variable(math_Vector X)
		{
			throw new NotImplementedException();
		}

		public void ComputePoles(math_Vector X)
		{
			throw new NotImplementedException();
		}

		public bool Compute(int DerivativeOrder, math_Vector Result)
		{
			throw new NotImplementedException();
		}


	}; // class FairCurve_EnergyOfBatten

}
