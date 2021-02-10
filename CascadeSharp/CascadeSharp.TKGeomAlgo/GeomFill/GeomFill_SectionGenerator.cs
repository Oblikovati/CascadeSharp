//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_SectionGenerator
	//---------------------------------------------------------------------
	public  sealed class GeomFill_SectionGenerator : CascadeSharp.GeomFill_Profiler
	{

		public GeomFill_SectionGenerator()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SectionGenerator(GeomFill_SectionGenerator parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetParam(TColStd_HArray1OfReal Params)
		{
			throw new NotImplementedException();
		}

		public void GetShape(ref int NbPoles, ref int NbKnots, ref int Degree, ref int NbPoles2d)
		{
			throw new NotImplementedException();
		}

		public void Knots(TColStd_Array1OfReal TKnots)
		{
			throw new NotImplementedException();
		}

		public void Mults(TColStd_Array1OfInteger TMults)
		{
			throw new NotImplementedException();
		}

		public bool Section(int P, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d, TColStd_Array1OfReal Weigths, TColStd_Array1OfReal DWeigths)
		{
			throw new NotImplementedException();
		}

		public void Section(int P, TColgp_Array1OfPnt Poles, TColgp_Array1OfPnt2d Poles2d, TColStd_Array1OfReal Weigths)
		{
			throw new NotImplementedException();
		}

		public double Parameter(int P)
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill_SectionGenerator

}
