//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Geom_BezierSurface
	//---------------------------------------------------------------------
	public  sealed class Geom_BezierSurface : CascadeSharp.Geom_BoundedSurface
	{

		public Geom_BezierSurface(TColgp_Array2OfPnt SurfacePoles)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_BezierSurface(TColgp_Array2OfPnt SurfacePoles, TColStd_Array2OfReal PoleWeights)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_BezierSurface(TColgp_HArray2OfPnt SurfacePoles, TColStd_HArray2OfReal PoleWeights, bool IsURational, bool IsVRational)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_BezierSurface(Geom_BezierSurface parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_BezierSurface()
		{
			throw new NotImplementedException();
		}

		public void ExchangeUV()
		{
			throw new NotImplementedException();
		}

		public void Increase(int UDeg, int VDeg)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleColAfter(int VIndex, TColgp_Array1OfPnt CPoles)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleColAfter(int VIndex, TColgp_Array1OfPnt CPoles, TColStd_Array1OfReal CPoleWeights)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleColBefore(int VIndex, TColgp_Array1OfPnt CPoles)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleColBefore(int VIndex, TColgp_Array1OfPnt CPoles, TColStd_Array1OfReal CPoleWeights)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleRowAfter(int UIndex, TColgp_Array1OfPnt CPoles)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleRowAfter(int UIndex, TColgp_Array1OfPnt CPoles, TColStd_Array1OfReal CPoleWeights)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleRowBefore(int UIndex, TColgp_Array1OfPnt CPoles)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleRowBefore(int UIndex, TColgp_Array1OfPnt CPoles, TColStd_Array1OfReal CPoleWeights)
		{
			throw new NotImplementedException();
		}

		public void RemovePoleCol(int VIndex)
		{
			throw new NotImplementedException();
		}

		public void RemovePoleRow(int UIndex)
		{
			throw new NotImplementedException();
		}

		public void Segment(double U1, double U2, double V1, double V2)
		{
			throw new NotImplementedException();
		}

		public void SetPole(int UIndex, int VIndex, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void SetPole(int UIndex, int VIndex, gp_Pnt P, double Weight)
		{
			throw new NotImplementedException();
		}

		public void SetPoleCol(int VIndex, TColgp_Array1OfPnt CPoles)
		{
			throw new NotImplementedException();
		}

		public void SetPoleCol(int VIndex, TColgp_Array1OfPnt CPoles, TColStd_Array1OfReal CPoleWeights)
		{
			throw new NotImplementedException();
		}

		public void SetPoleRow(int UIndex, TColgp_Array1OfPnt CPoles)
		{
			throw new NotImplementedException();
		}

		public void SetPoleRow(int UIndex, TColgp_Array1OfPnt CPoles, TColStd_Array1OfReal CPoleWeights)
		{
			throw new NotImplementedException();
		}

		public void SetWeight(int UIndex, int VIndex, double Weight)
		{
			throw new NotImplementedException();
		}

		public void SetWeightCol(int VIndex, TColStd_Array1OfReal CPoleWeights)
		{
			throw new NotImplementedException();
		}

		public void SetWeightRow(int UIndex, TColStd_Array1OfReal CPoleWeights)
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

		public CascadeSharp.GeomAbs_Shape Continuity()
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

		public int NbUPoles()
		{
			throw new NotImplementedException();
		}

		public int NbVPoles()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Pole(int UIndex, int VIndex)
		{
			throw new NotImplementedException();
		}

		public void Poles(TColgp_Array2OfPnt P)
		{
			throw new NotImplementedException();
		}

		public TColgp_Array2OfPnt Poles()
		{
			throw new NotImplementedException();
		}

		public int UDegree()
		{
			throw new NotImplementedException();
		}

		public Geom_Curve UIso(double U)
		{
			throw new NotImplementedException();
		}

		public int VDegree()
		{
			throw new NotImplementedException();
		}

		public Geom_Curve VIso(double V)
		{
			throw new NotImplementedException();
		}

		public double Weight(int UIndex, int VIndex)
		{
			throw new NotImplementedException();
		}

		public void Weights(TColStd_Array2OfReal W)
		{
			throw new NotImplementedException();
		}

		public TColStd_Array2OfReal Weights()
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

		public bool IsCNu(int N)
		{
			throw new NotImplementedException();
		}

		public bool IsCNv(int N)
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

		public bool IsURational()
		{
			throw new NotImplementedException();
		}

		public bool IsVRational()
		{
			throw new NotImplementedException();
		}

		public void Transform(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public int MaxDegree()
		{
			throw new NotImplementedException();
		}

		public void Resolution(double Tolerance3D, ref double UTolerance, ref double VTolerance)
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

						public void Init(TColgp_HArray2OfPnt Poles, TColStd_HArray2OfReal Weights)
		{
			throw new NotImplementedException();
		}


	}; // class Geom_BezierSurface

}
