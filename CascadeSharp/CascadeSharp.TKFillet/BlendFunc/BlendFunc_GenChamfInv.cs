//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BlendFunc_GenChamfInv
	//---------------------------------------------------------------------
	public  abstract class BlendFunc_GenChamfInv : CascadeSharp.Blend_FuncInv
	{

		public BlendFunc_GenChamfInv(Adaptor3d_HSurface S1, Adaptor3d_HSurface S2, Adaptor3d_HCurve C)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BlendFunc_GenChamfInv(BlendFunc_GenChamfInv parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BlendFunc_GenChamfInv()
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

		public int NbEquations()
		{
			throw new NotImplementedException();
		}

		public bool Values(math_Vector X, math_Vector F, math_Matrix D)
		{
			throw new NotImplementedException();
		}

		public void Set(double D_ist1, double D_ist2, int Choix)
		{
			throw new NotImplementedException();
		}


	}; // class BlendFunc_GenChamfInv

}
