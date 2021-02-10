//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_SectionPlacement
	//---------------------------------------------------------------------
	public  sealed class GeomFill_SectionPlacement
	{

		public GeomFill_SectionPlacement(GeomFill_LocationLaw L, Geom_Geometry Section)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SectionPlacement(GeomFill_SectionPlacement parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SectionPlacement()
		{
			throw new NotImplementedException();
		}

		public void SetLocation(GeomFill_LocationLaw L)
		{
			throw new NotImplementedException();
		}

		public void Perform(double Tol)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HCurve Path, double Tol)
		{
			throw new NotImplementedException();
		}

		public void Perform(double ParamOnPath, double Tol)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public double ParameterOnPath()
		{
			throw new NotImplementedException();
		}

		public double ParameterOnSection()
		{
			throw new NotImplementedException();
		}

		public double Distance()
		{
			throw new NotImplementedException();
		}

		public double Angle()
		{
			throw new NotImplementedException();
		}

		public gp_Trsf Transformation(bool WithTranslation, bool WithCorrection)
		{
			throw new NotImplementedException();
		}

		public gp_Trsf Transformation(bool WithTranslation)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve Section(bool WithTranslation)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve ModifiedSection(bool WithTranslation)
		{
			throw new NotImplementedException();
		}

		public void SectionAxis(gp_Mat M, gp_Vec T, gp_Vec N, gp_Vec BN)
		{
			throw new NotImplementedException();
		}

		public bool Choix(double D_ist, double Angle)
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill_SectionPlacement

}
