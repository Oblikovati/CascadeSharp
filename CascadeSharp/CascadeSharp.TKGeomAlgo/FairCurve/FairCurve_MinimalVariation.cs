//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.FairCurve
{
	//---------------------------------------------------------------------
	//  Class  FairCurve_MinimalVariation
	//---------------------------------------------------------------------
	public  sealed class FairCurve_MinimalVariation : FairCurve_Batten
	{

		public FairCurve_MinimalVariation(gp_Pnt2d P1, gp_Pnt2d P2, double Heigth, double Slope, double PhysicalRatio)
			: base()
		{
			throw new NotImplementedException();
		}

		public FairCurve_MinimalVariation(gp_Pnt2d P1, gp_Pnt2d P2, double Heigth, double Slope)
			: base()
		{
			throw new NotImplementedException();
		}

		public FairCurve_MinimalVariation(gp_Pnt2d P1, gp_Pnt2d P2, double Heigth)
			: base()
		{
			throw new NotImplementedException();
		}

		public FairCurve_MinimalVariation(FairCurve_MinimalVariation parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public FairCurve_MinimalVariation()
		{
			throw new NotImplementedException();
		}

		public void SetCurvature1(double Curvature)
		{
			throw new NotImplementedException();
		}

		public void SetCurvature2(double Curvature)
		{
			throw new NotImplementedException();
		}

		public void SetPhysicalRatio(double Ratio)
		{
			throw new NotImplementedException();
		}

		public bool Compute( ref FairCurve_AnalysisCode ACode, int NbIterations, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public bool Compute( ref FairCurve_AnalysisCode ACode, int NbIterations)
		{
			throw new NotImplementedException();
		}

		public bool Compute( ref FairCurve_AnalysisCode ACode)
		{
			throw new NotImplementedException();
		}

		public double GetCurvature1()
		{
			throw new NotImplementedException();
		}

		public double GetCurvature2()
		{
			throw new NotImplementedException();
		}

		public double GetPhysicalRatio()
		{
			throw new NotImplementedException();
		}

				public bool Compute(gp_Vec2d DeltaP1, gp_Vec2d DeltaP2, double DeltaAngle1, double DeltaAngle2, double DeltaCurvature1, double DeltaCurvature2,  ref FairCurve_AnalysisCode ACode, int NbIterations, double Tolerance)
		{
			throw new NotImplementedException();
		}


	}; // class FairCurve_MinimalVariation

}
