//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomAPI_Interpolate
	//---------------------------------------------------------------------
	public  sealed class GeomAPI_Interpolate
	{

		public GeomAPI_Interpolate(TColgp_HArray1OfPnt Points, bool PeriodicFlag, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAPI_Interpolate(TColgp_HArray1OfPnt Points, TColStd_HArray1OfReal Parameters, bool PeriodicFlag, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAPI_Interpolate(GeomAPI_Interpolate parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAPI_Interpolate()
		{
			throw new NotImplementedException();
		}

		public void Load(gp_Vec InitialTangent, gp_Vec FinalTangent, bool Scale)
		{
			throw new NotImplementedException();
		}

		public void Load(gp_Vec InitialTangent, gp_Vec FinalTangent)
		{
			throw new NotImplementedException();
		}

		public void Load(TColgp_Array1OfVec Tangents, TColStd_HArray1OfBoolean TangentFlags, bool Scale)
		{
			throw new NotImplementedException();
		}

		public void Load(TColgp_Array1OfVec Tangents, TColStd_HArray1OfBoolean TangentFlags)
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

		public Geom_BSplineCurve Curve()
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


	}; // class GeomAPI_Interpolate

}
