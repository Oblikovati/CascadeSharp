//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_PlanFunc
	//---------------------------------------------------------------------
	public  sealed class GeomFill_PlanFunc : math_FunctionWithDerivative
	{

		public GeomFill_PlanFunc(gp_Pnt P, gp_Vec V, Adaptor3d_HCurve C)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_PlanFunc(GeomFill_PlanFunc parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_PlanFunc()
		{
			throw new NotImplementedException();
		}

		public bool Value(double X, ref double F)
		{
			throw new NotImplementedException();
		}

		public bool Derivative(double X, ref double D)
		{
			throw new NotImplementedException();
		}

		public bool Values(double X, ref double F, ref double D)
		{
			throw new NotImplementedException();
		}

		public void D2(double X, ref double F, ref double D1, ref double D2)
		{
			throw new NotImplementedException();
		}

		public void DEDT(double X, gp_Vec DP, gp_Vec DV, ref double DF)
		{
			throw new NotImplementedException();
		}

		public void D2E(double X, gp_Vec DP, gp_Vec D2P, gp_Vec DV, gp_Vec D2V, ref double DFDT, ref double D2FDT2, ref double D2FDTDX)
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill_PlanFunc

}
