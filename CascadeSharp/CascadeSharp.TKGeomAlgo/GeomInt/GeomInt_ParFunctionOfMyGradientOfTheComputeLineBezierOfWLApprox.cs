//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomInt_ParFunctionOfMyGradientOfTheComputeLineBezierOfWLApprox
	//---------------------------------------------------------------------
	public  sealed class GeomInt_ParFunctionOfMyGradientOfTheComputeLineBezierOfWLApprox : CascadeSharp.math_MultipleVarFunctionWithGradient
	{

		public GeomInt_ParFunctionOfMyGradientOfTheComputeLineBezierOfWLApprox(GeomInt_TheMultiLineOfWLApprox SSP, int FirstPoint, int LastPoint, AppParCurves_HArray1OfConstraintCouple TheConstraints, math_Vector Parameters, int Deg)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_ParFunctionOfMyGradientOfTheComputeLineBezierOfWLApprox(GeomInt_ParFunctionOfMyGradientOfTheComputeLineBezierOfWLApprox parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_ParFunctionOfMyGradientOfTheComputeLineBezierOfWLApprox()
		{
			throw new NotImplementedException();
		}

		public int NbVariables()
		{
			throw new NotImplementedException();
		}

		public bool Value(math_Vector X, ref double F)
		{
			throw new NotImplementedException();
		}

		public bool Gradient(math_Vector X, math_Vector G)
		{
			throw new NotImplementedException();
		}

		public bool Values(math_Vector X, ref double F, math_Vector G)
		{
			throw new NotImplementedException();
		}

		public math_Vector NewParameters()
		{
			throw new NotImplementedException();
		}

		public AppParCurves_MultiCurve CurveValue()
		{
			throw new NotImplementedException();
		}

		public double Error(int IPoint, int CurveIndex)
		{
			throw new NotImplementedException();
		}

		public double MaxError3d()
		{
			throw new NotImplementedException();
		}

		public double MaxError2d()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.AppParCurves_Constraint FirstConstraint(AppParCurves_HArray1OfConstraintCouple TheConstraints, int FirstPoint)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.AppParCurves_Constraint LastConstraint(AppParCurves_HArray1OfConstraintCouple TheConstraints, int LastPoint)
		{
			throw new NotImplementedException();
		}

		public void Perform(math_Vector X)
		{
			throw new NotImplementedException();
		}


	}; // class GeomInt_ParFunctionOfMyGradientOfTheComputeLineBezierOfWLApprox

}
