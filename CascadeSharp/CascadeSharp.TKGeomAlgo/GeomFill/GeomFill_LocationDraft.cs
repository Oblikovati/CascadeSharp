//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_LocationDraft
	//---------------------------------------------------------------------
	public  sealed class GeomFill_LocationDraft : GeomFill_LocationLaw
	{

		public GeomFill_LocationDraft(gp_Dir Direction, double Angle)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_LocationDraft(GeomFill_LocationDraft parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_LocationDraft()
		{
			throw new NotImplementedException();
		}

		public void SetStopSurf(Adaptor3d_HSurface Surf)
		{
			throw new NotImplementedException();
		}

		public void SetAngle(double Angle)
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

		public int NbIntervals(GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Intervals(TColStd_Array1OfReal T, GeomAbs_Shape S)
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

		public bool IsIntersec()
		{
			throw new NotImplementedException();
		}

		public gp_Dir Direction()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Prepare()
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill_LocationDraft

}
