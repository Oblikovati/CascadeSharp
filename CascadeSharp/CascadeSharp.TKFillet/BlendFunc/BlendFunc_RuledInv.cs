//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BlendFunc_RuledInv
	//---------------------------------------------------------------------
	public  sealed class BlendFunc_RuledInv : CascadeSharp.Blend_FuncInv
	{

		public BlendFunc_RuledInv(Adaptor3d_HSurface S1, Adaptor3d_HSurface S2, Adaptor3d_HCurve C)
			: base()
		{
			throw new NotImplementedException();
		}

		public BlendFunc_RuledInv(BlendFunc_RuledInv parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BlendFunc_RuledInv()
		{
			throw new NotImplementedException();
		}

		public void Set(bool OnFirst, Adaptor2d_HCurve2d COnSurf)
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


	}; // class BlendFunc_RuledInv

}
