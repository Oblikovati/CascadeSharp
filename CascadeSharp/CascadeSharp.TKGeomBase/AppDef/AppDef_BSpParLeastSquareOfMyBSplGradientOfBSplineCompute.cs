//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  AppDef_BSpParLeastSquareOfMyBSplGradientOfBSplineCompute
	//---------------------------------------------------------------------
	public  sealed class AppDef_BSpParLeastSquareOfMyBSplGradientOfBSplineCompute
	{

		public AppDef_BSpParLeastSquareOfMyBSplGradientOfBSplineCompute(AppDef_MultiLine SSP, int FirstPoint, int LastPoint, CascadeSharp.AppParCurves_Constraint FirstCons, CascadeSharp.AppParCurves_Constraint LastCons, math_Vector Parameters, int NbPol)
			: base()
		{
			throw new NotImplementedException();
		}

		public AppDef_BSpParLeastSquareOfMyBSplGradientOfBSplineCompute(AppDef_MultiLine SSP, int FirstPoint, int LastPoint, CascadeSharp.AppParCurves_Constraint FirstCons, CascadeSharp.AppParCurves_Constraint LastCons, int NbPol)
			: base()
		{
			throw new NotImplementedException();
		}

		public AppDef_BSpParLeastSquareOfMyBSplGradientOfBSplineCompute(AppDef_MultiLine SSP, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, int FirstPoint, int LastPoint, CascadeSharp.AppParCurves_Constraint FirstCons, CascadeSharp.AppParCurves_Constraint LastCons, math_Vector Parameters, int NbPol)
			: base()
		{
			throw new NotImplementedException();
		}

		public AppDef_BSpParLeastSquareOfMyBSplGradientOfBSplineCompute(AppDef_MultiLine SSP, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, int FirstPoint, int LastPoint, CascadeSharp.AppParCurves_Constraint FirstCons, CascadeSharp.AppParCurves_Constraint LastCons, int NbPol)
			: base()
		{
			throw new NotImplementedException();
		}

		public AppDef_BSpParLeastSquareOfMyBSplGradientOfBSplineCompute(AppDef_BSpParLeastSquareOfMyBSplGradientOfBSplineCompute parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AppDef_BSpParLeastSquareOfMyBSplGradientOfBSplineCompute()
		{
			throw new NotImplementedException();
		}

		public void Perform(math_Vector Parameters)
		{
			throw new NotImplementedException();
		}

		public void Perform(math_Vector Parameters, double l1, double l2)
		{
			throw new NotImplementedException();
		}

		public void Perform(math_Vector Parameters, math_Vector V1t, math_Vector V2t, double l1, double l2)
		{
			throw new NotImplementedException();
		}

		public void Perform(math_Vector Parameters, math_Vector V1t, math_Vector V2t, math_Vector V1c, math_Vector V2c, double l1, double l2)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public AppParCurves_MultiCurve BezierValue()
		{
			throw new NotImplementedException();
		}

		public AppParCurves_MultiBSpCurve BSplineValue()
		{
			throw new NotImplementedException();
		}

		public math_Matrix FunctionMatrix()
		{
			throw new NotImplementedException();
		}

		public math_Matrix DerivativeFunctionMatrix()
		{
			throw new NotImplementedException();
		}

		public void ErrorGradient(math_Vector Grad, ref double F, ref double MaxE3d, ref double MaxE2d)
		{
			throw new NotImplementedException();
		}

		public math_Matrix Distance()
		{
			throw new NotImplementedException();
		}

		public void Error(ref double F, ref double MaxE3d, ref double MaxE2d)
		{
			throw new NotImplementedException();
		}

		public double FirstLambda()
		{
			throw new NotImplementedException();
		}

		public double LastLambda()
		{
			throw new NotImplementedException();
		}

		public math_Matrix Points()
		{
			throw new NotImplementedException();
		}

		public math_Matrix Poles()
		{
			throw new NotImplementedException();
		}

		public math_IntegerVector KIndex()
		{
			throw new NotImplementedException();
		}

		public void Init(AppDef_MultiLine SSP, int FirstPoint, int LastPoint)
		{
			throw new NotImplementedException();
		}

		public int NbBColumns(AppDef_MultiLine SSP)
		{
			throw new NotImplementedException();
		}

		public int TheFirstPoint(CascadeSharp.AppParCurves_Constraint FirstCons, int FirstPoint)
		{
			throw new NotImplementedException();
		}

		public int TheLastPoint(CascadeSharp.AppParCurves_Constraint LastCons, int LastPoint)
		{
			throw new NotImplementedException();
		}

		public void Affect(AppDef_MultiLine SSP, int Index,  ref CascadeSharp.AppParCurves_Constraint Cons, math_Vector Vt, math_Vector Vc)
		{
			throw new NotImplementedException();
		}

		public void ComputeFunction(math_Vector Parameters)
		{
			throw new NotImplementedException();
		}

		public void SearchIndex(math_IntegerVector Index)
		{
			throw new NotImplementedException();
		}

		public void MakeTAA(math_Vector TheA, math_Vector TheB)
		{
			throw new NotImplementedException();
		}

		public void MakeTAA(math_Vector TheA)
		{
			throw new NotImplementedException();
		}

		public void MakeTAA(math_Vector TheA, math_Matrix TheB)
		{
			throw new NotImplementedException();
		}


	}; // class AppDef_BSpParLeastSquareOfMyBSplGradientOfBSplineCompute

}
