//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKFillet.Blend;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKFillet.BlendFunc
{
	//---------------------------------------------------------------------
	//  Class  BlendFunc_CSConstRad
	//---------------------------------------------------------------------
	public  sealed class BlendFunc_CSConstRad : Blend_CSFunction
	{

		public BlendFunc_CSConstRad(Adaptor3d_HSurface S, Adaptor3d_HCurve C, Adaptor3d_HCurve CGuide)
			: base()
		{
			throw new NotImplementedException();
		}

		public BlendFunc_CSConstRad(BlendFunc_CSConstRad parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BlendFunc_CSConstRad()
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

		public void Set(double Radius, int Choix)
		{
			throw new NotImplementedException();
		}

		public void Set(BlendFunc_SectionShape TypeSection)
		{
			throw new NotImplementedException();
		}

		public void Section(double Param, double U, double V, double W, ref double Pdeb, ref double Pfin, gp_Circ C)
		{
			throw new NotImplementedException();
		}

		public bool Section(Blend_Point P, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColgp_Array1OfVec D2Poles, TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d, TColgp_Array1OfVec2d D2Poles2d, TColStd_Array1OfReal Weigths, TColStd_Array1OfReal DWeigths, TColStd_Array1OfReal D2Weigths)
		{
			throw new NotImplementedException();
		}

		public bool GetSection(double Param, double U, double V, double W, TColgp_Array1OfPnt tabP, TColgp_Array1OfVec tabV)
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

		public int NbIntervals(GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Intervals(TColStd_Array1OfReal T, GeomAbs_Shape S)
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

		public void Resolution(int IC2d, double Tol, ref double TolU, ref double TolV)
		{
			throw new NotImplementedException();
		}


	}; // class BlendFunc_CSConstRad

}
