//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Geom_BezierCurve
	//---------------------------------------------------------------------
	public  sealed class Geom_BezierCurve : CascadeSharp.Geom_BoundedCurve
	{

		public Geom_BezierCurve(TColgp_Array1OfPnt CurvePoles)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_BezierCurve(TColgp_Array1OfPnt CurvePoles, TColStd_Array1OfReal PoleWeights)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_BezierCurve(Geom_BezierCurve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_BezierCurve()
		{
			throw new NotImplementedException();
		}

		public void Increase(int Degree)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleAfter(int Index, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleAfter(int Index, gp_Pnt P, double Weight)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleBefore(int Index, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleBefore(int Index, gp_Pnt P, double Weight)
		{
			throw new NotImplementedException();
		}

		public void RemovePole(int Index)
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

		public void Segment(double U1, double U2)
		{
			throw new NotImplementedException();
		}

		public void SetPole(int Index, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void SetPole(int Index, gp_Pnt P, double Weight)
		{
			throw new NotImplementedException();
		}

		public void SetWeight(int Index, double Weight)
		{
			throw new NotImplementedException();
		}

		public bool IsClosed()
		{
			throw new NotImplementedException();
		}

		public bool IsCN(int N)
		{
			throw new NotImplementedException();
		}

		public bool IsPeriodic()
		{
			throw new NotImplementedException();
		}

		public bool IsRational()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public int Degree()
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

		public gp_Pnt StartPoint()
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

		public double LastParameter()
		{
			throw new NotImplementedException();
		}

		public int NbPoles()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Pole(int Index)
		{
			throw new NotImplementedException();
		}

		public void Poles(TColgp_Array1OfPnt P)
		{
			throw new NotImplementedException();
		}

		public TColgp_Array1OfPnt Poles()
		{
			throw new NotImplementedException();
		}

		public double Weight(int Index)
		{
			throw new NotImplementedException();
		}

		public void Weights(TColStd_Array1OfReal W)
		{
			throw new NotImplementedException();
		}

		public TColStd_Array1OfReal Weights()
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

		public void Resolution(double Tolerance3D, ref double UTolerance)
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

						public void Init(TColgp_HArray1OfPnt Poles, TColStd_HArray1OfReal Weights)
		{
			throw new NotImplementedException();
		}


	}; // class Geom_BezierCurve

}
