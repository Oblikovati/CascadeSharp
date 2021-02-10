//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_SweepSectionGenerator
	//---------------------------------------------------------------------
	public  sealed class GeomFill_SweepSectionGenerator
	{

		public GeomFill_SweepSectionGenerator()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SweepSectionGenerator(Geom_Curve Path, double Radius)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SweepSectionGenerator(Geom_Curve Path, Geom_Curve FirstSect)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SweepSectionGenerator(Geom_Curve Path, Geom_Curve FirstSect, Geom_Curve LastSect)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SweepSectionGenerator(Geom_Curve Path, Geom_Curve Curve1, Geom_Curve Curve2, double Radius)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SweepSectionGenerator(Adaptor3d_HCurve Path, Adaptor3d_HCurve Curve1, Adaptor3d_HCurve Curve2, double Radius)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SweepSectionGenerator(GeomFill_SweepSectionGenerator parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Curve Path, double Radius)
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Curve Path, Geom_Curve FirstSect)
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Curve Path, Geom_Curve FirstSect, Geom_Curve LastSect)
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Curve Path, Geom_Curve Curve1, Geom_Curve Curve2, double Radius)
		{
			throw new NotImplementedException();
		}

		public void Init(Adaptor3d_HCurve Path, Adaptor3d_HCurve Curve1, Adaptor3d_HCurve Curve2, double Radius)
		{
			throw new NotImplementedException();
		}

		public void Perform(bool Polynomial)
		{
			throw new NotImplementedException();
		}

		public void Perform()
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

		public int NbSections()
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

		public gp_Trsf Transformation(int Index)
		{
			throw new NotImplementedException();
		}

		public double Parameter(int P)
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill_SweepSectionGenerator

}
