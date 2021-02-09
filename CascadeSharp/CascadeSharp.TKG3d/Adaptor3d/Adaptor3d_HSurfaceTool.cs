//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Adaptor3d_HSurfaceTool
	//---------------------------------------------------------------------
	public  sealed class Adaptor3d_HSurfaceTool
	{

		public Adaptor3d_HSurfaceTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurfaceTool(Adaptor3d_HSurfaceTool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public double FirstUParameter(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public double FirstVParameter(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public double LastUParameter(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public double LastVParameter(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public int NbUIntervals(Adaptor3d_HSurface S, CascadeSharp.GeomAbs_Shape Sh)
		{
			throw new NotImplementedException();
		}

		public int NbVIntervals(Adaptor3d_HSurface S, CascadeSharp.GeomAbs_Shape Sh)
		{
			throw new NotImplementedException();
		}

		public void UIntervals(Adaptor3d_HSurface S, TColStd_Array1OfReal T, CascadeSharp.GeomAbs_Shape Sh)
		{
			throw new NotImplementedException();
		}

		public void VIntervals(Adaptor3d_HSurface S, TColStd_Array1OfReal T, CascadeSharp.GeomAbs_Shape Sh)
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurface UTrim(Adaptor3d_HSurface S, double First, double Last, double Tol)
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurface VTrim(Adaptor3d_HSurface S, double First, double Last, double Tol)
		{
			throw new NotImplementedException();
		}

		public bool IsUClosed(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public bool IsVClosed(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public bool IsUPeriodic(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public double UPeriod(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public bool IsVPeriodic(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public double VPeriod(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Value(Adaptor3d_HSurface S, double u, double v)
		{
			throw new NotImplementedException();
		}

		public void D0(Adaptor3d_HSurface S, double u, double v, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void D1(Adaptor3d_HSurface S, double u, double v, gp_Pnt P, gp_Vec D1u, gp_Vec D1v)
		{
			throw new NotImplementedException();
		}

		public void D2(Adaptor3d_HSurface S, double u, double v, gp_Pnt P, gp_Vec D1U, gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec D2UV)
		{
			throw new NotImplementedException();
		}

		public void D3(Adaptor3d_HSurface S, double u, double v, gp_Pnt P, gp_Vec D1U, gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec D2UV, gp_Vec D3U, gp_Vec D3V, gp_Vec D3UUV, gp_Vec D3UVV)
		{
			throw new NotImplementedException();
		}

		public gp_Vec DN(Adaptor3d_HSurface S, double u, double v, int Nu, int Nv)
		{
			throw new NotImplementedException();
		}

		public double UResolution(Adaptor3d_HSurface S, double R3d)
		{
			throw new NotImplementedException();
		}

		public double VResolution(Adaptor3d_HSurface S, double R3d)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_SurfaceType GetGeomType(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public gp_Pln Plane(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public gp_Cylinder Cylinder(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public gp_Cone Cone(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public gp_Torus Torus(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public gp_Sphere Sphere(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public Geom_BezierSurface Bezier(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public Geom_BSplineSurface BSpline(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public gp_Ax1 AxeOfRevolution(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public gp_Dir Direction(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HCurve BasisCurve(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurface BasisSurface(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public double OffsetValue(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public int NbSamplesU(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public int NbSamplesV(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public int NbSamplesU(Adaptor3d_HSurface S, double u1, double u2)
		{
			throw new NotImplementedException();
		}

		public int NbSamplesV(Adaptor3d_HSurface S, double v1, double v2)
		{
			throw new NotImplementedException();
		}


	}; // class Adaptor3d_HSurfaceTool

}
