//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  AdvApp2Var_Iso
	//---------------------------------------------------------------------
	public  sealed class AdvApp2Var_Iso : Standard_Transient
	{

		public AdvApp2Var_Iso()
			: base()
		{
			throw new NotImplementedException();
		}

		public AdvApp2Var_Iso(CascadeSharp.GeomAbs_IsoType type, int iu, int iv)
			: base()
		{
			throw new NotImplementedException();
		}

		public AdvApp2Var_Iso(CascadeSharp.GeomAbs_IsoType type, double cte, double Ufirst, double Ulast, double Vfirst, double Vlast, int pos, int iu, int iv)
			: base()
		{
			throw new NotImplementedException();
		}

		public AdvApp2Var_Iso(AdvApp2Var_Iso Other)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IsApproximated()
		{
			throw new NotImplementedException();
		}

		public bool HasResult()
		{
			throw new NotImplementedException();
		}

		public void MakeApprox(AdvApp2Var_Context Conditions, double a, double b, double c, double d, AdvApp2Var_EvaluatorFunc2Var func, AdvApp2Var_Node NodeBegin, AdvApp2Var_Node NodeEnd)
		{
			throw new NotImplementedException();
		}

		public void ChangeDomain(double a, double b)
		{
			throw new NotImplementedException();
		}

		public void ChangeDomain(double a, double b, double c, double d)
		{
			throw new NotImplementedException();
		}

		public void SetConstante(double newcte)
		{
			throw new NotImplementedException();
		}

		public void SetPosition(int newpos)
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

		public CascadeSharp.GeomAbs_IsoType Type()
		{
			throw new NotImplementedException();
		}

		public double Constante()
		{
			throw new NotImplementedException();
		}

		public double T0()
		{
			throw new NotImplementedException();
		}

		public double T1()
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

		public int Position()
		{
			throw new NotImplementedException();
		}

		public int NbCoeff()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal Polynom()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal SomTab()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal DifTab()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray2OfReal MaxErrors()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray2OfReal MoyErrors()
		{
			throw new NotImplementedException();
		}


	}; // class AdvApp2Var_Iso

}
