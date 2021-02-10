//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKGeomBase.AppParCurves;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomBase.AppDef
{
	//---------------------------------------------------------------------
	//  Class  AppDef_ResConstraintOfTheGradient
	//---------------------------------------------------------------------
	public  sealed class AppDef_ResConstraintOfTheGradient
	{

		public AppDef_ResConstraintOfTheGradient(AppDef_MultiLine SSP, AppParCurves_MultiCurve SCurv, int FirstPoint, int LastPoint, AppParCurves_HArray1OfConstraintCouple Constraints, math_Matrix Bern, math_Matrix DerivativeBern, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public AppDef_ResConstraintOfTheGradient(AppDef_MultiLine SSP, AppParCurves_MultiCurve SCurv, int FirstPoint, int LastPoint, AppParCurves_HArray1OfConstraintCouple Constraints, math_Matrix Bern, math_Matrix DerivativeBern)
			: base()
		{
			throw new NotImplementedException();
		}

		public AppDef_ResConstraintOfTheGradient(AppDef_ResConstraintOfTheGradient parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AppDef_ResConstraintOfTheGradient()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public double Error()
		{
			throw new NotImplementedException();
		}

		public math_Matrix ConstraintMatrix()
		{
			throw new NotImplementedException();
		}

		public math_Vector Duale()
		{
			throw new NotImplementedException();
		}

		public math_Matrix ConstraintDerivative(AppDef_MultiLine SSP, math_Vector Parameters, int Deg, math_Matrix DA)
		{
			throw new NotImplementedException();
		}

		public math_Matrix InverseMatrix()
		{
			throw new NotImplementedException();
		}

		public int NbConstraints(AppDef_MultiLine SSP, int FirstPoint, int LastPoint, AppParCurves_HArray1OfConstraintCouple TheConstraints)
		{
			throw new NotImplementedException();
		}

		public int NbColumns(AppDef_MultiLine SSP, int Deg)
		{
			throw new NotImplementedException();
		}


	}; // class AppDef_ResConstraintOfTheGradient

}
