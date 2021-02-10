//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_LocationGuide
	//---------------------------------------------------------------------
	public  sealed class GeomFill_LocationGuide : CascadeSharp.GeomFill_LocationLaw
	{

		public GeomFill_LocationGuide(GeomFill_TrihedronWithGuide Triedre)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_LocationGuide(GeomFill_LocationGuide parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_LocationGuide()
		{
			throw new NotImplementedException();
		}

		public void Set(GeomFill_SectionLaw Section, bool rotat, double SFirst, double SLast, double PrecAngle, ref double LastAngle)
		{
			throw new NotImplementedException();
		}

		public void EraseRotation()
		{
			throw new NotImplementedException();
		}

		public void SetCurve(Adaptor3d_HCurve C)
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HCurve GetCurve()
		{
			throw new NotImplementedException();
		}

		public void SetTrsf(gp_Mat Transfo)
		{
			throw new NotImplementedException();
		}

		public GeomFill_LocationLaw Copy()
		{
			throw new NotImplementedException();
		}

		public bool D0(double Param, gp_Mat M, gp_Vec V)
		{
			throw new NotImplementedException();
		}

		public bool D0(double Param, gp_Mat M, gp_Vec V, TColgp_Array1OfPnt2d Poles2d)
		{
			throw new NotImplementedException();
		}

		public bool D1(double Param, gp_Mat M, gp_Vec V, gp_Mat DM, gp_Vec DV, TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d)
		{
			throw new NotImplementedException();
		}

		public bool D2(double Param, gp_Mat M, gp_Vec V, gp_Mat DM, gp_Vec DV, gp_Mat D2M, gp_Vec D2V, TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d, TColgp_Array1OfVec2d D2Poles2d)
		{
			throw new NotImplementedException();
		}

		public bool HasFirstRestriction()
		{
			throw new NotImplementedException();
		}

		public bool HasLastRestriction()
		{
			throw new NotImplementedException();
		}

		public int TraceNumber()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomFill_PipeError ErrorStatus()
		{
			throw new NotImplementedException();
		}

		public int NbIntervals(CascadeSharp.GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Intervals(TColStd_Array1OfReal T, CascadeSharp.GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void SetInterval(double First, double Last)
		{
			throw new NotImplementedException();
		}

		public void GetInterval(ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public void GetDomain(ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(double Tol3d, double Tol2d)
		{
			throw new NotImplementedException();
		}

		public void Resolution(int Index, double Tol, ref double TolU, ref double TolV)
		{
			throw new NotImplementedException();
		}

		public double GetMaximalNorm()
		{
			throw new NotImplementedException();
		}

		public void GetAverageLaw(gp_Mat AM, gp_Vec AV)
		{
			throw new NotImplementedException();
		}

		public bool IsTranslation(ref double Error)
		{
			throw new NotImplementedException();
		}

		public bool IsRotation(ref double Error)
		{
			throw new NotImplementedException();
		}

		public void Rotation(gp_Pnt Center)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve Section()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HCurve Guide()
		{
			throw new NotImplementedException();
		}

		public void SetOrigine(double Param1, double Param2)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomFill_PipeError ComputeAutomaticLaw(TColgp_HArray1OfPnt2d ParAndRad)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void SetRotation(double PrecAngle, ref double LastAngle)
		{
			throw new NotImplementedException();
		}

		public void InitX(double Param)
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill_LocationGuide

}
