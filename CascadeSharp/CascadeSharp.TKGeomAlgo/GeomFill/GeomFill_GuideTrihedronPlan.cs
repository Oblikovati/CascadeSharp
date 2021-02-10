//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_GuideTrihedronPlan
	//---------------------------------------------------------------------
	public  sealed class GeomFill_GuideTrihedronPlan : GeomFill_TrihedronWithGuide
	{

		public GeomFill_GuideTrihedronPlan(Adaptor3d_HCurve theGuide)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_GuideTrihedronPlan(GeomFill_GuideTrihedronPlan parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_GuideTrihedronPlan()
		{
			throw new NotImplementedException();
		}

		public void SetCurve(Adaptor3d_HCurve thePath)
		{
			throw new NotImplementedException();
		}

		public GeomFill_TrihedronLaw Copy()
		{
			throw new NotImplementedException();
		}

		public GeomFill_PipeError ErrorStatus()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HCurve Guide()
		{
			throw new NotImplementedException();
		}

		public bool D0(double Param, gp_Vec Tangent, gp_Vec Normal, gp_Vec BiNormal)
		{
			throw new NotImplementedException();
		}

		public bool D1(double Param, gp_Vec Tangent, gp_Vec DTangent, gp_Vec Normal, gp_Vec DNormal, gp_Vec BiNormal, gp_Vec DBiNormal)
		{
			throw new NotImplementedException();
		}

		public bool D2(double Param, gp_Vec Tangent, gp_Vec DTangent, gp_Vec D2Tangent, gp_Vec Normal, gp_Vec DNormal, gp_Vec D2Normal, gp_Vec BiNormal, gp_Vec DBiNormal, gp_Vec D2BiNormal)
		{
			throw new NotImplementedException();
		}

		public void SetInterval(double First, double Last)
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

		public void GetAverageLaw(gp_Vec ATangent, gp_Vec ANormal, gp_Vec ABiNormal)
		{
			throw new NotImplementedException();
		}

		public bool IsConstant()
		{
			throw new NotImplementedException();
		}

		public bool IsOnlyBy3dCurve()
		{
			throw new NotImplementedException();
		}

		public void Origine(double OrACR1, double OrACR2)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Init()
		{
			throw new NotImplementedException();
		}

		public void InitX(double Param)
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill_GuideTrihedronPlan

}
