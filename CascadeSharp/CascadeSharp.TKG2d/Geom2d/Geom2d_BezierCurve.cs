//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKG2d.Geom2d
{
	//---------------------------------------------------------------------
	//  Class  Geom2d_BezierCurve
	//---------------------------------------------------------------------
	public  sealed class Geom2d_BezierCurve : Geom2d_BoundedCurve
	{

		public Geom2d_BezierCurve(TColgp_Array1OfPnt2d CurvePoles)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2d_BezierCurve(TColgp_Array1OfPnt2d CurvePoles, TColStd_Array1OfReal PoleWeights)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2d_BezierCurve(Geom2d_BezierCurve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2d_BezierCurve()
		{
			throw new NotImplementedException();
		}

		public void Increase(int Degree)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleAfter(int Index, gp_Pnt2d P, double Weight)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleAfter(int Index, gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleBefore(int Index, gp_Pnt2d P, double Weight)
		{
			throw new NotImplementedException();
		}

		public void InsertPoleBefore(int Index, gp_Pnt2d P)
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

		public void SetPole(int Index, gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}

		public void SetPole(int Index, gp_Pnt2d P, double Weight)
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

		public GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public int Degree()
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

		public gp_Pnt2d EndPoint()
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

		public gp_Pnt2d Pole(int Index)
		{
			throw new NotImplementedException();
		}

		public void Poles(TColgp_Array1OfPnt2d P)
		{
			throw new NotImplementedException();
		}

		public TColgp_Array1OfPnt2d Poles()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d StartPoint()
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

		public void Transform(gp_Trsf2d T)
		{
			throw new NotImplementedException();
		}

		public int MaxDegree()
		{
			throw new NotImplementedException();
		}

		public void Resolution(double ToleranceUV, ref double UTolerance)
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

						public void Init(TColgp_HArray1OfPnt2d Poles, TColStd_HArray1OfReal Weights)
		{
			throw new NotImplementedException();
		}


	}; // class Geom2d_BezierCurve

}
