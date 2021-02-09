//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomAdaptor_SurfaceOfRevolution
	//---------------------------------------------------------------------
	public  sealed class GeomAdaptor_SurfaceOfRevolution : CascadeSharp.GeomAdaptor_Surface
	{

		public GeomAdaptor_SurfaceOfRevolution()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAdaptor_SurfaceOfRevolution(Adaptor3d_HCurve C)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAdaptor_SurfaceOfRevolution(Adaptor3d_HCurve C, gp_Ax1 V)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAdaptor_SurfaceOfRevolution(GeomAdaptor_SurfaceOfRevolution parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Load(Adaptor3d_HCurve C)
		{
			throw new NotImplementedException();
		}

		public void Load(gp_Ax1 V)
		{
			throw new NotImplementedException();
		}

		public gp_Ax1 AxeOfRevolution()
		{
			throw new NotImplementedException();
		}

		public double FirstUParameter()
		{
			throw new NotImplementedException();
		}

		public double LastUParameter()
		{
			throw new NotImplementedException();
		}

		public double FirstVParameter()
		{
			throw new NotImplementedException();
		}

		public double LastVParameter()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_Shape UContinuity()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_Shape VContinuity()
		{
			throw new NotImplementedException();
		}

		public int NbUIntervals(CascadeSharp.GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public int NbVIntervals(CascadeSharp.GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void UIntervals(TColStd_Array1OfReal T, CascadeSharp.GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void VIntervals(TColStd_Array1OfReal T, CascadeSharp.GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurface UTrim(double First, double Last, double Tol)
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurface VTrim(double First, double Last, double Tol)
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

		public double UPeriod()
		{
			throw new NotImplementedException();
		}

		public bool IsVPeriodic()
		{
			throw new NotImplementedException();
		}

		public double VPeriod()
		{
			throw new NotImplementedException();
		}

		public double UResolution(double R3d)
		{
			throw new NotImplementedException();
		}

		public double VResolution(double R3d)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_SurfaceType GetGeomType()
		{
			throw new NotImplementedException();
		}

		public gp_Pln Plane()
		{
			throw new NotImplementedException();
		}

		public gp_Cylinder Cylinder()
		{
			throw new NotImplementedException();
		}

		public gp_Cone Cone()
		{
			throw new NotImplementedException();
		}

		public gp_Sphere Sphere()
		{
			throw new NotImplementedException();
		}

		public gp_Torus Torus()
		{
			throw new NotImplementedException();
		}

		public int VDegree()
		{
			throw new NotImplementedException();
		}

		public int NbVPoles()
		{
			throw new NotImplementedException();
		}

		public int NbVKnots()
		{
			throw new NotImplementedException();
		}

		public bool IsURational()
		{
			throw new NotImplementedException();
		}

		public bool IsVRational()
		{
			throw new NotImplementedException();
		}

		public Geom_BezierSurface Bezier()
		{
			throw new NotImplementedException();
		}

		public Geom_BSplineSurface BSpline()
		{
			throw new NotImplementedException();
		}

		public gp_Ax3 Axis()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HCurve BasisCurve()
		{
			throw new NotImplementedException();
		}


	}; // class GeomAdaptor_SurfaceOfRevolution

}
