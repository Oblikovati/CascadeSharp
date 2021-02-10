//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_Frenet
	//---------------------------------------------------------------------
	public  sealed class GeomFill_Frenet : CascadeSharp.GeomFill_TrihedronLaw
	{

		public GeomFill_Frenet()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_Frenet(GeomFill_Frenet parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_TrihedronLaw Copy()
		{
			throw new NotImplementedException();
		}

		public void Init()
		{
			throw new NotImplementedException();
		}

		public void SetCurve(Adaptor3d_HCurve C)
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

		public int NbIntervals(CascadeSharp.GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Intervals(TColStd_Array1OfReal T, CascadeSharp.GeomAbs_Shape S)
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

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IsSingular(double U, ref int Index)
		{
			throw new NotImplementedException();
		}

		public bool DoSingular(double U, int Index, gp_Vec Tangent, gp_Vec BiNormal, ref int n, ref int k, ref int TFlag, ref int BNFlag, ref double Delta)
		{
			throw new NotImplementedException();
		}

		public bool SingularD0(double Param, int Index, gp_Vec Tangent, gp_Vec Normal, gp_Vec BiNormal, ref double Delta)
		{
			throw new NotImplementedException();
		}

		public bool SingularD1(double Param, int Index, gp_Vec Tangent, gp_Vec DTangent, gp_Vec Normal, gp_Vec DNormal, gp_Vec BiNormal, gp_Vec DBiNormal, ref double Delta)
		{
			throw new NotImplementedException();
		}

		public bool SingularD2(double Param, int Index, gp_Vec Tangent, gp_Vec DTangent, gp_Vec D2Tangent, gp_Vec Normal, gp_Vec DNormal, gp_Vec D2Normal, gp_Vec BiNormal, gp_Vec DBiNormal, gp_Vec D2BiNormal, ref double Delta)
		{
			throw new NotImplementedException();
		}

		public bool RotateTrihedron(gp_Vec Tangent, gp_Vec Normal, gp_Vec BiNormal, gp_Vec NewTangent)
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill_Frenet

}
