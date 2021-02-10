//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomBase.AdvApp2Var
{
	//---------------------------------------------------------------------
	//  Class  AdvApp2Var_Patch
	//---------------------------------------------------------------------
	public  sealed class AdvApp2Var_Patch : Standard_Transient
	{

		public AdvApp2Var_Patch()
			: base()
		{
			throw new NotImplementedException();
		}

		public AdvApp2Var_Patch(double U0, double U1, double V0, double V1, int iu, int iv)
			: base()
		{
			throw new NotImplementedException();
		}

		public AdvApp2Var_Patch(AdvApp2Var_Patch P)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IsDiscretised()
		{
			throw new NotImplementedException();
		}

		public void Discretise(AdvApp2Var_Context Conditions, AdvApp2Var_Framework Constraints, AdvApp2Var_EvaluatorFunc2Var func)
		{
			throw new NotImplementedException();
		}

		public bool IsApproximated()
		{
			throw new NotImplementedException();
		}

		public bool HasResult()
		{
			throw new NotImplementedException();
		}

		public void MakeApprox(AdvApp2Var_Context Conditions, AdvApp2Var_Framework Constraints, int NumDec)
		{
			throw new NotImplementedException();
		}

		public void AddConstraints(AdvApp2Var_Context Conditions, AdvApp2Var_Framework Constraints)
		{
			throw new NotImplementedException();
		}

		public void AddErrors(AdvApp2Var_Framework Constraints)
		{
			throw new NotImplementedException();
		}

		public void ChangeDomain(double a, double b, double c, double d)
		{
			throw new NotImplementedException();
		}

		public void ResetApprox()
		{
			throw new NotImplementedException();
		}

		public void OverwriteApprox()
		{
			throw new NotImplementedException();
		}

		public double U0()
		{
			throw new NotImplementedException();
		}

		public double U1()
		{
			throw new NotImplementedException();
		}

		public double V0()
		{
			throw new NotImplementedException();
		}

		public double V1()
		{
			throw new NotImplementedException();
		}

		public int UOrder()
		{
			throw new NotImplementedException();
		}

		public int VOrder()
		{
			throw new NotImplementedException();
		}

		public int CutSense()
		{
			throw new NotImplementedException();
		}

		public int CutSense(AdvApp2Var_Criterion Crit, int NumDec)
		{
			throw new NotImplementedException();
		}

		public int NbCoeffInU()
		{
			throw new NotImplementedException();
		}

		public int NbCoeffInV()
		{
			throw new NotImplementedException();
		}

		public void ChangeNbCoeff(int NbCoeffU, int NbCoeffV)
		{
			throw new NotImplementedException();
		}

		public TColgp_HArray2OfPnt Poles(int SSPIndex, AdvApp2Var_Context Conditions)
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal Coefficients(int SSPIndex, AdvApp2Var_Context Conditions)
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal MaxErrors()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal AverageErrors()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray2OfReal IsoErrors()
		{
			throw new NotImplementedException();
		}

		public double CritValue()
		{
			throw new NotImplementedException();
		}

		public void SetCritValue(double d_ist)
		{
			throw new NotImplementedException();
		}


	}; // class AdvApp2Var_Patch

}
