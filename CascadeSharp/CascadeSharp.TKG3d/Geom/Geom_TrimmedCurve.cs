//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Geom_TrimmedCurve
	//---------------------------------------------------------------------
	public  sealed class Geom_TrimmedCurve : CascadeSharp.Geom_BoundedCurve
	{

		public Geom_TrimmedCurve(Geom_Curve C, double U1, double U2, bool Sense, bool theAdjustPeriodic)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_TrimmedCurve(Geom_Curve C, double U1, double U2, bool Sense)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_TrimmedCurve(Geom_Curve C, double U1, double U2)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_TrimmedCurve(Geom_TrimmedCurve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_TrimmedCurve()
		{
			throw new NotImplementedException();
		}

		public void Reverse()
		{
			throw new NotImplementedException();
		}

		public double ReversedParameter(double U)
		{
			throw new NotImplementedException();
		}

		public void SetTrim(double U1, double U2, bool Sense, bool theAdjustPeriodic)
		{
			throw new NotImplementedException();
		}

		public void SetTrim(double U1, double U2, bool Sense)
		{
			throw new NotImplementedException();
		}

		public void SetTrim(double U1, double U2)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve BasisCurve()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public bool IsCN(int N)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt EndPoint()
		{
			throw new NotImplementedException();
		}

		public double FirstParameter()
		{
			throw new NotImplementedException();
		}

		public bool IsClosed()
		{
			throw new NotImplementedException();
		}

		public bool IsPeriodic()
		{
			throw new NotImplementedException();
		}

		public double Period()
		{
			throw new NotImplementedException();
		}

		public double LastParameter()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt StartPoint()
		{
			throw new NotImplementedException();
		}

		public void D0(double U, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, gp_Pnt P, gp_Vec V1)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2, gp_Vec V3)
		{
			throw new NotImplementedException();
		}

		public gp_Vec DN(double U, int N)
		{
			throw new NotImplementedException();
		}

		public void Transform(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public double TransformedParameter(double U, gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public double ParametricTransformation(gp_Trsf T)
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

				
	}; // class Geom_TrimmedCurve

}
