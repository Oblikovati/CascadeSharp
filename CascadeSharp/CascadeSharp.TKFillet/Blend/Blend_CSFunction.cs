//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Blend_CSFunction
	//---------------------------------------------------------------------
	public  abstract class Blend_CSFunction : CascadeSharp.Blend_AppFunction
	{

		public Blend_CSFunction()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Blend_CSFunction(Blend_CSFunction parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public int NbVariables()
		{
			throw new NotImplementedException();
		}

		public int NbEquations()
		{
			throw new NotImplementedException();
		}

		public bool Value(math_Vector X, math_Vector F)
		{
			throw new NotImplementedException();
		}

		public bool Derivatives(math_Vector X, math_Matrix D)
		{
			throw new NotImplementedException();
		}

		public bool Values(math_Vector X, math_Vector F, math_Matrix D)
		{
			throw new NotImplementedException();
		}

		public void Set(double Param)
		{
			throw new NotImplementedException();
		}

		public void Set(double First, double Last)
		{
			throw new NotImplementedException();
		}

		public void GetTolerance(math_Vector Tolerance, double Tol)
		{
			throw new NotImplementedException();
		}

		public void GetBounds(math_Vector InfBound, math_Vector SupBound)
		{
			throw new NotImplementedException();
		}

		public bool IsSolution(math_Vector Sol, double Tol)
		{
			throw new NotImplementedException();
		}

		public double GetMinimalDistance()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Pnt1()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Pnt2()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt PointOnS()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt PointOnC()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d Pnt2d()
		{
			throw new NotImplementedException();
		}

		public double ParameterOnC()
		{
			throw new NotImplementedException();
		}

		public bool IsTangencyPoint()
		{
			throw new NotImplementedException();
		}

		public gp_Vec TangentOnS()
		{
			throw new NotImplementedException();
		}

		public gp_Vec2d Tangent2d()
		{
			throw new NotImplementedException();
		}

		public gp_Vec TangentOnC()
		{
			throw new NotImplementedException();
		}

		public void Tangent(double U, double V, gp_Vec TgS, gp_Vec NormS)
		{
			throw new NotImplementedException();
		}

		public void GetShape(ref int NbPoles, ref int NbKnots, ref int Degree, ref int NbPoles2d)
		{
			throw new NotImplementedException();
		}

		public void GetTolerance(double BoundTol, double SurfTol, double AngleTol, math_Vector Tol3d, math_Vector Tol1D)
		{
			throw new NotImplementedException();
		}

		public void Knots(TColStd_Array1OfReal TKnots)
		{
			throw new NotImplementedException();
		}

		public void Mults(TColStd_Array1OfInteger TMults)
		{
			throw new NotImplementedException();
		}

		public bool Section(Blend_Point P, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d, TColStd_Array1OfReal Weigths, TColStd_Array1OfReal DWeigths)
		{
			throw new NotImplementedException();
		}

		public void Section(Blend_Point P, TColgp_Array1OfPnt Poles, TColgp_Array1OfPnt2d Poles2d, TColStd_Array1OfReal Weigths)
		{
			throw new NotImplementedException();
		}

		public bool Section(Blend_Point P, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColgp_Array1OfVec D2Poles, TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d, TColgp_Array1OfVec2d D2Poles2d, TColStd_Array1OfReal Weigths, TColStd_Array1OfReal DWeigths, TColStd_Array1OfReal D2Weigths)
		{
			throw new NotImplementedException();
		}


	}; // class Blend_CSFunction

}
