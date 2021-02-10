//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;

namespace CascadeSharp.TKGeomAlgo.Law
{
	//---------------------------------------------------------------------
	//  Class  Law_Interpolate
	//---------------------------------------------------------------------
	public  sealed class Law_Interpolate
	{

		public Law_Interpolate(TColStd_HArray1OfReal Points, bool PeriodicFlag, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public Law_Interpolate(TColStd_HArray1OfReal Points, TColStd_HArray1OfReal Parameters, bool PeriodicFlag, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public Law_Interpolate(Law_Interpolate parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Law_Interpolate()
		{
			throw new NotImplementedException();
		}

		public void Load(double InitialTangent, double FinalTangent)
		{
			throw new NotImplementedException();
		}

		public void Load(TColStd_Array1OfReal Tangents, TColStd_HArray1OfBoolean TangentFlags)
		{
			throw new NotImplementedException();
		}

		public void ClearTangents()
		{
			throw new NotImplementedException();
		}

		public void Perform()
		{
			throw new NotImplementedException();
		}

		public Law_BSpline Curve()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public void PerformNonPeriodic()
		{
			throw new NotImplementedException();
		}

		public void PerformPeriodic()
		{
			throw new NotImplementedException();
		}


	}; // class Law_Interpolate

}
