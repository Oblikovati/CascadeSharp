//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKTopAlgo.Bisector
{
	//---------------------------------------------------------------------
	//  Class  Bisector_FunctionH
	//---------------------------------------------------------------------
	public  sealed class Bisector_FunctionH : math_FunctionWithDerivative
	{

		public Bisector_FunctionH(Geom2d_Curve C2, gp_Pnt2d P1, gp_Vec2d T1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Bisector_FunctionH(Bisector_FunctionH parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Bisector_FunctionH()
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


	}; // class Bisector_FunctionH

}
