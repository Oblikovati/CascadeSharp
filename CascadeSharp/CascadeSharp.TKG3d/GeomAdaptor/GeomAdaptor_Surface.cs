//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.GeomAdaptor
{
	//---------------------------------------------------------------------
	//  Class  GeomAdaptor_Surface
	//---------------------------------------------------------------------
	public  class GeomAdaptor_Surface : Adaptor3d_Surface
	{

		public GeomAdaptor_Surface()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAdaptor_Surface(Geom_Surface S)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAdaptor_Surface(Geom_Surface S, double UFirst, double ULast, double VFirst, double VLast, double TolU, double TolV)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAdaptor_Surface(Geom_Surface S, double UFirst, double ULast, double VFirst, double VLast, double TolU)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAdaptor_Surface(Geom_Surface S, double UFirst, double ULast, double VFirst, double VLast)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAdaptor_Surface(GeomAdaptor_Surface parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Load(Geom_Surface S)
		{
			throw new NotImplementedException();
		}

		public void Load(Geom_Surface S, double UFirst, double ULast, double VFirst, double VLast, double TolU, double TolV)
		{
			throw new NotImplementedException();
		}

		public void Load(Geom_Surface S, double UFirst, double ULast, double VFirst, double VLast, double TolU)
		{
			throw new NotImplementedException();
		}

		public void Load(Geom_Surface S, double UFirst, double ULast, double VFirst, double VLast)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Surface()
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

		public GeomAbs_Shape UContinuity()
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape VContinuity()
		{
			throw new NotImplementedException();
		}

		public int NbUIntervals(GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public int NbVIntervals(GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void UIntervals(TColStd_Array1OfReal T, GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void VIntervals(TColStd_Array1OfReal T, GeomAbs_Shape S)
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

		public gp_Pnt Value(double U, double V)
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

		public double UResolution(double R3d)
		{
			throw new NotImplementedException();
		}

		public double VResolution(double R3d)
		{
			throw new NotImplementedException();
		}

		public GeomAbs_SurfaceType GetGeomType()
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

		public int UDegree()
		{
			throw new NotImplementedException();
		}

		public int NbUPoles()
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

		public int NbUKnots()
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

		public gp_Ax1 AxeOfRevolution()
		{
			throw new NotImplementedException();
		}

		public gp_Dir Direction()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HCurve BasisCurve()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurface BasisSurface()
		{
			throw new NotImplementedException();
		}

		public double OffsetValue()
		{
			throw new NotImplementedException();
		}

		public void Span(int Side, int Ideb, int Ifin, ref int OutIdeb, ref int OutIfin, int FKIndx, int LKIndx)
		{
			throw new NotImplementedException();
		}

		public bool IfUVBound(double U, double V, ref int Ideb, ref int Ifin, ref int IVdeb, ref int IVfin, int USide, int VSide)
		{
			throw new NotImplementedException();
		}

		public void load(Geom_Surface S, double UFirst, double ULast, double VFirst, double VLast, double TolU, double TolV)
		{
			throw new NotImplementedException();
		}

		public void load(Geom_Surface S, double UFirst, double ULast, double VFirst, double VLast, double TolU)
		{
			throw new NotImplementedException();
		}

		public void load(Geom_Surface S, double UFirst, double ULast, double VFirst, double VLast)
		{
			throw new NotImplementedException();
		}

		public void RebuildCache(double theU, double theV)
		{
			throw new NotImplementedException();
		}


	}; // class GeomAdaptor_Surface

}
