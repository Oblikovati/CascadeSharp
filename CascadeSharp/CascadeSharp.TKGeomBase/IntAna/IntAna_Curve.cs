//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  IntAna_Curve
	//---------------------------------------------------------------------
	public  sealed class IntAna_Curve
	{

		public IntAna_Curve()
			: base()
		{
			throw new NotImplementedException();
		}

		public IntAna_Curve(IntAna_Curve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetCylinderQuadValues(gp_Cylinder Cylinder, double Qxx, double Qyy, double Qzz, double Qxy, double Qxz, double Qyz, double Qx, double Qy, double Qz, double Q1, double Tol, double DomInf, double DomSup, bool TwoZForATheta, bool ZIsPositive)
		{
			throw new NotImplementedException();
		}

		public void SetConeQuadValues(gp_Cone Cone, double Qxx, double Qyy, double Qzz, double Qxy, double Qxz, double Qyz, double Qx, double Qy, double Qz, double Q1, double Tol, double DomInf, double DomSup, bool TwoZForATheta, bool ZIsPositive)
		{
			throw new NotImplementedException();
		}

		public bool IsOpen()
		{
			throw new NotImplementedException();
		}

		public void Domain(ref double theFirst, ref double theLast)
		{
			throw new NotImplementedException();
		}

		public bool IsConstant()
		{
			throw new NotImplementedException();
		}

		public bool IsFirstOpen()
		{
			throw new NotImplementedException();
		}

		public bool IsLastOpen()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Value(double Theta)
		{
			throw new NotImplementedException();
		}

		public bool D1u(double Theta, gp_Pnt P, gp_Vec V)
		{
			throw new NotImplementedException();
		}

		public void FindParameter(gp_Pnt P, TColStd_ListOfReal theParams)
		{
			throw new NotImplementedException();
		}

		public void SetIsFirstOpen(bool Flag)
		{
			throw new NotImplementedException();
		}

		public void SetIsLastOpen(bool Flag)
		{
			throw new NotImplementedException();
		}

		public void SetDomain(double theFirst, double theLast)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt InternalValue(double Theta1, double Theta2)
		{
			throw new NotImplementedException();
		}

		public void InternalUVValue(double Param, ref double U, ref double V, ref double A, ref double B, ref double C, ref double Co, ref double Si, ref double Di)
		{
			throw new NotImplementedException();
		}


	}; // class IntAna_Curve

}
