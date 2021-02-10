//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.FairCurve
{
	//---------------------------------------------------------------------
	//  Class  FairCurve_Batten
	//---------------------------------------------------------------------
	public  class FairCurve_Batten
	{

		public FairCurve_Batten(gp_Pnt2d P1, gp_Pnt2d P2, double Height, double Slope)
			: base()
		{
			throw new NotImplementedException();
		}

		public FairCurve_Batten(gp_Pnt2d P1, gp_Pnt2d P2, double Height)
			: base()
		{
			throw new NotImplementedException();
		}

		public FairCurve_Batten(FairCurve_Batten parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public FairCurve_Batten()
		{
			throw new NotImplementedException();
		}

		public void SetFreeSliding(bool FreeSliding)
		{
			throw new NotImplementedException();
		}

		public void SetConstraintOrder1(int ConstraintOrder)
		{
			throw new NotImplementedException();
		}

		public void SetConstraintOrder2(int ConstraintOrder)
		{
			throw new NotImplementedException();
		}

		public void SetP1(gp_Pnt2d P1)
		{
			throw new NotImplementedException();
		}

		public void SetP2(gp_Pnt2d P2)
		{
			throw new NotImplementedException();
		}

		public void SetAngle1(double Angle1)
		{
			throw new NotImplementedException();
		}

		public void SetAngle2(double Angle2)
		{
			throw new NotImplementedException();
		}

		public void SetHeight(double Height)
		{
			throw new NotImplementedException();
		}

		public void SetSlope(double Slope)
		{
			throw new NotImplementedException();
		}

		public void SetSlidingFactor(double SlidingFactor)
		{
			throw new NotImplementedException();
		}

		public bool Compute( ref FairCurve_AnalysisCode Code, int NbIterations, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public bool Compute( ref FairCurve_AnalysisCode Code, int NbIterations)
		{
			throw new NotImplementedException();
		}

		public bool Compute( ref FairCurve_AnalysisCode Code)
		{
			throw new NotImplementedException();
		}

		public double SlidingOfReference()
		{
			throw new NotImplementedException();
		}

		public bool GetFreeSliding()
		{
			throw new NotImplementedException();
		}

		public int GetConstraintOrder1()
		{
			throw new NotImplementedException();
		}

		public int GetConstraintOrder2()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d GetP1()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d GetP2()
		{
			throw new NotImplementedException();
		}

		public double GetAngle1()
		{
			throw new NotImplementedException();
		}

		public double GetAngle2()
		{
			throw new NotImplementedException();
		}

		public double GetHeight()
		{
			throw new NotImplementedException();
		}

		public double GetSlope()
		{
			throw new NotImplementedException();
		}

		public double GetSlidingFactor()
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve Curve()
		{
			throw new NotImplementedException();
		}

				public double SlidingOfReference(double D, double A1, double A2)
		{
			throw new NotImplementedException();
		}

		public double Compute(double D, double A1, double A2)
		{
			throw new NotImplementedException();
		}

		public double Compute(double D, double A)
		{
			throw new NotImplementedException();
		}

		public bool Compute(gp_Vec2d DeltaP1, gp_Vec2d DeltaP2, double DeltaAngle1, double DeltaAngle2,  ref FairCurve_AnalysisCode ACode, int NbIterations, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void Angles(gp_Pnt2d P1, gp_Pnt2d P2)
		{
			throw new NotImplementedException();
		}


	}; // class FairCurve_Batten

}
