//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_CorrectedFrenet
	//---------------------------------------------------------------------
	public  sealed class GeomFill_CorrectedFrenet : CascadeSharp.GeomFill_TrihedronLaw
	{

		public GeomFill_CorrectedFrenet()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_CorrectedFrenet(bool ForEvaluation)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_CorrectedFrenet(GeomFill_CorrectedFrenet parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_TrihedronLaw Copy()
		{
			throw new NotImplementedException();
		}

		public void SetCurve(Adaptor3d_HCurve C)
		{
			throw new NotImplementedException();
		}

		public void SetInterval(double First, double Last)
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

		public CascadeSharp.GeomFill_Trihedron EvaluateBestMode()
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

						public void Init()
		{
			throw new NotImplementedException();
		}

		public bool InitInterval(double First, double Last, double Step, ref double startAng, gp_Vec prevTangent, gp_Vec prevNormal, gp_Vec aT, gp_Vec aN, Law_Function FuncInt, TColStd_SequenceOfReal SeqPoles, TColStd_SequenceOfReal SeqAngle, TColgp_SequenceOfVec SeqTangent, TColgp_SequenceOfVec SeqNormal)
		{
			throw new NotImplementedException();
		}

		public double CalcAngleAT(gp_Vec Tangent, gp_Vec Normal, gp_Vec prevTangent, gp_Vec prevNormal)
		{
			throw new NotImplementedException();
		}

		public double GetAngleAT(double P)
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill_CorrectedFrenet

}
