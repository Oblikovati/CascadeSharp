//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomBase.ProjLib
{
	//---------------------------------------------------------------------
	//  Class  ProjLib_CompProjectedCurve
	//---------------------------------------------------------------------
	public  sealed class ProjLib_CompProjectedCurve : Adaptor2d_Curve2d
	{

		public ProjLib_CompProjectedCurve()
			: base()
		{
			throw new NotImplementedException();
		}

		public ProjLib_CompProjectedCurve(Adaptor3d_HSurface S, Adaptor3d_HCurve C, double TolU, double TolV)
			: base()
		{
			throw new NotImplementedException();
		}

		public ProjLib_CompProjectedCurve(Adaptor3d_HSurface S, Adaptor3d_HCurve C, double TolU, double TolV, double MaxD_ist)
			: base()
		{
			throw new NotImplementedException();
		}

		public ProjLib_CompProjectedCurve(ProjLib_CompProjectedCurve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init()
		{
			throw new NotImplementedException();
		}

		public void Load(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public void Load(Adaptor3d_HCurve C)
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurface GetSurface()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HCurve GetCurve()
		{
			throw new NotImplementedException();
		}

		public void GetTolerance(ref double TolU, ref double TolV)
		{
			throw new NotImplementedException();
		}

		public int NbCurves()
		{
			throw new NotImplementedException();
		}

		public void Bounds(int Index, ref double Udeb, ref double Ufin)
		{
			throw new NotImplementedException();
		}

		public bool IsSinglePnt(int Index, gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}

		public bool IsUIso(int Index, ref double U)
		{
			throw new NotImplementedException();
		}

		public bool IsVIso(int Index, ref double V)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d Value(double U)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, gp_Pnt2d P, gp_Vec2d V)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2)
		{
			throw new NotImplementedException();
		}

		public gp_Vec2d DN(double U, int N)
		{
			throw new NotImplementedException();
		}

		public double FirstParameter()
		{
			throw new NotImplementedException();
		}

		public double LastParameter()
		{
			throw new NotImplementedException();
		}

		public int NbIntervals(GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public Adaptor2d_HCurve2d Trim(double FirstParam, double LastParam, double Tol)
		{
			throw new NotImplementedException();
		}

		public void Intervals(TColStd_Array1OfReal T, GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public double MaxDistance(int Index)
		{
			throw new NotImplementedException();
		}

		public ProjLib_HSequenceOfHSequenceOfPnt GetSequence()
		{
			throw new NotImplementedException();
		}

		public GeomAbs_CurveType GetGeomType()
		{
			throw new NotImplementedException();
		}

		public void UpdateTripleByTrapCriteria(gp_Pnt thePoint)
		{
			throw new NotImplementedException();
		}

		public void BuildIntervals(GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}


	}; // class ProjLib_CompProjectedCurve

}
