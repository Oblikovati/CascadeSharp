//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BlendFunc_EvolRad
	//---------------------------------------------------------------------
	public  sealed class BlendFunc_EvolRad : CascadeSharp.Blend_Function
	{

		public BlendFunc_EvolRad(Adaptor3d_HSurface S1, Adaptor3d_HSurface S2, Adaptor3d_HCurve C, Law_Function Law)
			: base()
		{
			throw new NotImplementedException();
		}

		public BlendFunc_EvolRad(BlendFunc_EvolRad parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BlendFunc_EvolRad()
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

		public gp_Pnt PointOnS1()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt PointOnS2()
		{
			throw new NotImplementedException();
		}

		public bool IsTangencyPoint()
		{
			throw new NotImplementedException();
		}

		public gp_Vec TangentOnS1()
		{
			throw new NotImplementedException();
		}

		public gp_Vec2d Tangent2dOnS1()
		{
			throw new NotImplementedException();
		}

		public gp_Vec TangentOnS2()
		{
			throw new NotImplementedException();
		}

		public gp_Vec2d Tangent2dOnS2()
		{
			throw new NotImplementedException();
		}

		public void Tangent(double U1, double V1, double U2, double V2, gp_Vec TgFirst, gp_Vec TgLast, gp_Vec NormFirst, gp_Vec NormLast)
		{
			throw new NotImplementedException();
		}

		public bool TwistOnS1()
		{
			throw new NotImplementedException();
		}

		public bool TwistOnS2()
		{
			throw new NotImplementedException();
		}

		public void Set(int Choix)
		{
			throw new NotImplementedException();
		}

		public void Set(CascadeSharp.BlendFunc_SectionShape TypeSection)
		{
			throw new NotImplementedException();
		}

		public void Section(double Param, double U1, double V1, double U2, double V2, ref double Pdeb, ref double Pfin, gp_Circ C)
		{
			throw new NotImplementedException();
		}

		public bool IsRational()
		{
			throw new NotImplementedException();
		}

		public double GetSectionSize()
		{
			throw new NotImplementedException();
		}

		public void GetMinimalWeight(TColStd_Array1OfReal Weigths)
		{
			throw new NotImplementedException();
		}

		public int NbIntervals(CascadeSharp.GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Intervals(TColStd_Array1OfReal T, CascadeSharp.GeomAbs_Shape S)
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

		public bool Section(Blend_Point P, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColgp_Array1OfVec D2Poles, TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d, TColgp_Array1OfVec2d D2Poles2d, TColStd_Array1OfReal Weigths, TColStd_Array1OfReal DWeigths, TColStd_Array1OfReal D2Weigths)
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

		public void Resolution(int IC2d, double Tol, ref double TolU, ref double TolV)
		{
			throw new NotImplementedException();
		}

		public bool ComputeValues(math_Vector X, int Order, bool ByParam, double Param)
		{
			throw new NotImplementedException();
		}

		public bool ComputeValues(math_Vector X, int Order, bool ByParam)
		{
			throw new NotImplementedException();
		}

		public bool ComputeValues(math_Vector X, int Order)
		{
			throw new NotImplementedException();
		}


	}; // class BlendFunc_EvolRad

}
