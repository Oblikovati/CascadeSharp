//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TColGeom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKShHealing.ShapeExtend
{
	//---------------------------------------------------------------------
	//  Class  ShapeExtend_CompositeSurface
	//---------------------------------------------------------------------
	public  sealed class ShapeExtend_CompositeSurface : Geom_Surface
	{

		public ShapeExtend_CompositeSurface()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeExtend_CompositeSurface(TColGeom_HArray2OfSurface GridSurf, ShapeExtend_Parametrisation param)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeExtend_CompositeSurface(TColGeom_HArray2OfSurface GridSurf)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeExtend_CompositeSurface(TColGeom_HArray2OfSurface GridSurf, TColStd_Array1OfReal UJoints, TColStd_Array1OfReal VJoints)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeExtend_CompositeSurface(ShapeExtend_CompositeSurface parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public bool Init(TColGeom_HArray2OfSurface GridSurf, ShapeExtend_Parametrisation param)
		{
			throw new NotImplementedException();
		}

		public bool Init(TColGeom_HArray2OfSurface GridSurf)
		{
			throw new NotImplementedException();
		}

		public bool Init(TColGeom_HArray2OfSurface GridSurf, TColStd_Array1OfReal UJoints, TColStd_Array1OfReal VJoints)
		{
			throw new NotImplementedException();
		}

		public int NbUPatches()
		{
			throw new NotImplementedException();
		}

		public int NbVPatches()
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Patch(int i, int j)
		{
			throw new NotImplementedException();
		}

		public TColGeom_HArray2OfSurface Patches()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal UJointValues()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal VJointValues()
		{
			throw new NotImplementedException();
		}

		public double UJointValue(int i)
		{
			throw new NotImplementedException();
		}

		public double VJointValue(int j)
		{
			throw new NotImplementedException();
		}

		public bool SetUJointValues(TColStd_Array1OfReal UJoints)
		{
			throw new NotImplementedException();
		}

		public bool SetVJointValues(TColStd_Array1OfReal VJoints)
		{
			throw new NotImplementedException();
		}

		public void SetUFirstValue(double UFirst)
		{
			throw new NotImplementedException();
		}

		public void SetVFirstValue(double VFirst)
		{
			throw new NotImplementedException();
		}

		public int LocateUParameter(double U)
		{
			throw new NotImplementedException();
		}

		public int LocateVParameter(double V)
		{
			throw new NotImplementedException();
		}

		public void LocateUVPoint(gp_Pnt2d pnt, ref int i, ref int j)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Patch(double U, double V)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Patch(gp_Pnt2d pnt)
		{
			throw new NotImplementedException();
		}

		public double ULocalToGlobal(int i, int j, double u)
		{
			throw new NotImplementedException();
		}

		public double VLocalToGlobal(int i, int j, double v)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d LocalToGlobal(int i, int j, gp_Pnt2d uv)
		{
			throw new NotImplementedException();
		}

		public double UGlobalToLocal(int i, int j, double U)
		{
			throw new NotImplementedException();
		}

		public double VGlobalToLocal(int i, int j, double V)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d GlobalToLocal(int i, int j, gp_Pnt2d UV)
		{
			throw new NotImplementedException();
		}

		public bool GlobalToLocalTransformation(int i, int j, ref double uFact, gp_Trsf2d Trsf)
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

		public GeomAbs_Shape Continuity()
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

		public gp_Pnt Value(gp_Pnt2d pnt)
		{
			throw new NotImplementedException();
		}

		public void ComputeJointValues(ShapeExtend_Parametrisation param)
		{
			throw new NotImplementedException();
		}

		public void ComputeJointValues()
		{
			throw new NotImplementedException();
		}

		public bool CheckConnectivity(double prec)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class ShapeExtend_CompositeSurface

}
