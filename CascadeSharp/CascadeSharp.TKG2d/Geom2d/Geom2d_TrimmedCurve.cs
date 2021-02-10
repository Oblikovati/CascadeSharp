//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG2d.Geom2d
{
	//---------------------------------------------------------------------
	//  Class  Geom2d_TrimmedCurve
	//---------------------------------------------------------------------
	public  sealed class Geom2d_TrimmedCurve : Geom2d_BoundedCurve
	{

		public Geom2d_TrimmedCurve(Geom2d_Curve C, double U1, double U2, bool Sense, bool theAdjustPeriodic)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2d_TrimmedCurve(Geom2d_Curve C, double U1, double U2, bool Sense)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2d_TrimmedCurve(Geom2d_Curve C, double U1, double U2)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2d_TrimmedCurve(Geom2d_TrimmedCurve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2d_TrimmedCurve()
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

		public Geom2d_Curve BasisCurve()
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public bool IsCN(int N)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d EndPoint()
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

		public gp_Pnt2d StartPoint()
		{
			throw new NotImplementedException();
		}

		public void D0(double U, gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, gp_Pnt2d P, gp_Vec2d V1)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, gp_Vec2d V3)
		{
			throw new NotImplementedException();
		}

		public gp_Vec2d DN(double U, int N)
		{
			throw new NotImplementedException();
		}

		public void Transform(gp_Trsf2d T)
		{
			throw new NotImplementedException();
		}

		public double TransformedParameter(double U, gp_Trsf2d T)
		{
			throw new NotImplementedException();
		}

		public double ParametricTransformation(gp_Trsf2d T)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Geometry Copy()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Geom2d_TrimmedCurve

}
