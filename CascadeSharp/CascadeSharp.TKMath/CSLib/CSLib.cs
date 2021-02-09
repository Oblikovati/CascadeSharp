//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  CSLib
	//---------------------------------------------------------------------
	public  sealed class CSLib
	{

		public CSLib()
			: base()
		{
			throw new NotImplementedException();
		}

		public CSLib(CSLib parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Normal(gp_Vec D1U, gp_Vec D1V, double SinTol,  ref CascadeSharp.CSLib_DerivativeStatus theStatus, gp_Dir Normal)
		{
			throw new NotImplementedException();
		}

		public void Normal(gp_Vec D1U, gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec D2UV, double SinTol, ref bool Done,  ref CascadeSharp.CSLib_NormalStatus theStatus, gp_Dir Normal)
		{
			throw new NotImplementedException();
		}

		public void Normal(gp_Vec D1U, gp_Vec D1V, double MagTol,  ref CascadeSharp.CSLib_NormalStatus theStatus, gp_Dir Normal)
		{
			throw new NotImplementedException();
		}

		public void Normal(int MaxOrder, TColgp_Array2OfVec DerNUV, double MagTol, double U, double V, double Umin, double Umax, double Vmin, double Vmax,  ref CascadeSharp.CSLib_NormalStatus theStatus, gp_Dir Normal, ref int OrderU, ref int OrderV)
		{
			throw new NotImplementedException();
		}

		public gp_Vec DNNUV(int Nu, int Nv, TColgp_Array2OfVec DerSurf)
		{
			throw new NotImplementedException();
		}

		public gp_Vec DNNUV(int Nu, int Nv, TColgp_Array2OfVec DerSurf1, TColgp_Array2OfVec DerSurf2)
		{
			throw new NotImplementedException();
		}

		public gp_Vec DNNormal(int Nu, int Nv, TColgp_Array2OfVec DerNUV, int Idu_ref, int Idv_ref)
		{
			throw new NotImplementedException();
		}

		public gp_Vec DNNormal(int Nu, int Nv, TColgp_Array2OfVec DerNUV, int Idu_ref)
		{
			throw new NotImplementedException();
		}

		public gp_Vec DNNormal(int Nu, int Nv, TColgp_Array2OfVec DerNUV)
		{
			throw new NotImplementedException();
		}


	}; // class CSLib

}
