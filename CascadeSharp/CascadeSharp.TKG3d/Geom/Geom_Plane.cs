//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Geom
{
	//---------------------------------------------------------------------
	//  Class  Geom_Plane
	//---------------------------------------------------------------------
	public  sealed class Geom_Plane : Geom_ElementarySurface
	{

		public Geom_Plane(gp_Ax3 A3)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Plane(gp_Pln Pl)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Plane(gp_Pnt P, gp_Dir V)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Plane(double A, double B, double C, double D)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Plane(Geom_Plane parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Plane()
		{
			throw new NotImplementedException();
		}

		public void SetPln(gp_Pln Pl)
		{
			throw new NotImplementedException();
		}

		public gp_Pln Pln()
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

		public void Coefficients(ref double A, ref double B, ref double C, ref double D)
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

				
	}; // class Geom_Plane

}
