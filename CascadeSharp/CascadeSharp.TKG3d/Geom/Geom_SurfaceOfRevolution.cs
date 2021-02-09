//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Geom_SurfaceOfRevolution
	//---------------------------------------------------------------------
	public  sealed class Geom_SurfaceOfRevolution : CascadeSharp.Geom_SweptSurface
	{

		public Geom_SurfaceOfRevolution(Geom_Curve C, gp_Ax1 A1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_SurfaceOfRevolution(Geom_SurfaceOfRevolution parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_SurfaceOfRevolution()
		{
			throw new NotImplementedException();
		}

		public void SetAxis(gp_Ax1 A1)
		{
			throw new NotImplementedException();
		}

		public void SetDirection(gp_Dir V)
		{
			throw new NotImplementedException();
		}

		public void SetBasisCurve(Geom_Curve C)
		{
			throw new NotImplementedException();
		}

		public void SetLocation(gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public gp_Ax1 Axis()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Location()
		{
			throw new NotImplementedException();
		}

		public gp_Ax2 ReferencePlane()
		{
			throw new NotImplementedException();
		}

		public void UReverse()
		{
			throw new NotImplementedException();
		}

		public double UReversedParameter(double U)
		{
			throw new NotImplementedException();
		}

		public void VReverse()
		{
			throw new NotImplementedException();
		}

		public double VReversedParameter(double V)
		{
			throw new NotImplementedException();
		}

		public void TransformParameters(ref double U, ref double V, gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public gp_GTrsf2d ParametricTransformation(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public void Bounds(ref double U1, ref double U2, ref double V1, ref double V2)
		{
			throw new NotImplementedException();
		}

		public bool IsUClosed()
		{
			throw new NotImplementedException();
		}

		public bool IsVClosed()
		{
			throw new NotImplementedException();
		}

		public bool IsCNu(int N)
		{
			throw new NotImplementedException();
		}

		public bool IsCNv(int N)
		{
			throw new NotImplementedException();
		}

		public bool IsUPeriodic()
		{
			throw new NotImplementedException();
		}

		public bool IsVPeriodic()
		{
			throw new NotImplementedException();
		}

		public Geom_Curve UIso(double U)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve VIso(double V)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, double V, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec D2UV)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec D2UV, gp_Vec D3U, gp_Vec D3V, gp_Vec D3UUV, gp_Vec D3UVV)
		{
			throw new NotImplementedException();
		}

		public gp_Vec DN(double U, double V, int Nu, int Nv)
		{
			throw new NotImplementedException();
		}

		public void Transform(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public Geom_Geometry Copy()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Geom_SurfaceOfRevolution

}
