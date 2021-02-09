//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GProp_PrincipalProps
	//---------------------------------------------------------------------
	public  sealed class GProp_PrincipalProps
	{

		public GProp_PrincipalProps()
			: base()
		{
			throw new NotImplementedException();
		}

		public GProp_PrincipalProps(double Ixx, double Iyy, double Izz, double Rxx, double Ryy, double Rzz, gp_Vec Vxx, gp_Vec Vyy, gp_Vec Vzz, gp_Pnt G)
			: base()
		{
			throw new NotImplementedException();
		}

		public GProp_PrincipalProps(GProp_PrincipalProps parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public bool HasSymmetryAxis()
		{
			throw new NotImplementedException();
		}

		public bool HasSymmetryAxis(double aTol)
		{
			throw new NotImplementedException();
		}

		public bool HasSymmetryPoint()
		{
			throw new NotImplementedException();
		}

		public bool HasSymmetryPoint(double aTol)
		{
			throw new NotImplementedException();
		}

		public void Moments(ref double Ixx, ref double Iyy, ref double Izz)
		{
			throw new NotImplementedException();
		}

		public gp_Vec FirstAxisOfInertia()
		{
			throw new NotImplementedException();
		}

		public gp_Vec SecondAxisOfInertia()
		{
			throw new NotImplementedException();
		}

		public gp_Vec ThirdAxisOfInertia()
		{
			throw new NotImplementedException();
		}

		public void RadiusOfGyration(ref double Rxx, ref double Ryy, ref double Rzz)
		{
			throw new NotImplementedException();
		}


	}; // class GProp_PrincipalProps

}
