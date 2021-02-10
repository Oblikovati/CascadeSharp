//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKFillet.Blend
{
	//---------------------------------------------------------------------
	//  Class  Blend_CurvPointFuncInv
	//---------------------------------------------------------------------
	public  abstract class Blend_CurvPointFuncInv : math_FunctionSetWithDerivatives
	{

		public Blend_CurvPointFuncInv()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Blend_CurvPointFuncInv(Blend_CurvPointFuncInv parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public int NbVariables()
		{
			throw new NotImplementedException();
		}

		public int NbEquations()
		{
			throw new NotImplementedException();
		}

		public bool Value(math_Vector X, math_Vector F)
		{
			throw new NotImplementedException();
		}

		public bool Derivatives(math_Vector X, math_Matrix D)
		{
			throw new NotImplementedException();
		}

		public bool Values(math_Vector X, math_Vector F, math_Matrix D)
		{
			throw new NotImplementedException();
		}

		public void Set(gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void GetTolerance(math_Vector Tolerance, double Tol)
		{
			throw new NotImplementedException();
		}

		public void GetBounds(math_Vector InfBound, math_Vector SupBound)
		{
			throw new NotImplementedException();
		}

		public bool IsSolution(math_Vector Sol, double Tol)
		{
			throw new NotImplementedException();
		}


	}; // class Blend_CurvPointFuncInv

}
