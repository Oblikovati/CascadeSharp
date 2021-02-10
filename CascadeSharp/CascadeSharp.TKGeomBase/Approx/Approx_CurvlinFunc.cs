//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKGeomBase.Approx
{
	//---------------------------------------------------------------------
	//  Class  Approx_CurvlinFunc
	//---------------------------------------------------------------------
	public  sealed class Approx_CurvlinFunc : Standard_Transient
	{

		public Approx_CurvlinFunc(Adaptor3d_HCurve C, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurvlinFunc(Adaptor2d_HCurve2d C2D, Adaptor3d_HSurface S, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurvlinFunc(Adaptor2d_HCurve2d C2D1, Adaptor2d_HCurve2d C2D2, Adaptor3d_HSurface S1, Adaptor3d_HSurface S2, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurvlinFunc(Approx_CurvlinFunc parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurvlinFunc()
		{
			throw new NotImplementedException();
		}

		public void SetTol(double Tol)
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

		public int NbIntervals(GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Intervals(TColStd_Array1OfReal T, GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Trim(double First, double Last, double Tol)
		{
			throw new NotImplementedException();
		}

		public void Length()
		{
			throw new NotImplementedException();
		}

		public double Length(Adaptor3d_Curve C, double FirstU, double LasrU)
		{
			throw new NotImplementedException();
		}

		public double GetLength()
		{
			throw new NotImplementedException();
		}

		public double GetUParameter(Adaptor3d_Curve C, double S, int NumberOfCurve)
		{
			throw new NotImplementedException();
		}

		public double GetSParameter(double U)
		{
			throw new NotImplementedException();
		}

		public bool EvalCase1(double S, int Order, TColStd_Array1OfReal Result)
		{
			throw new NotImplementedException();
		}

		public bool EvalCase2(double S, int Order, TColStd_Array1OfReal Result)
		{
			throw new NotImplementedException();
		}

		public bool EvalCase3(double S, int Order, TColStd_Array1OfReal Result)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Init()
		{
			throw new NotImplementedException();
		}

		public void Init(Adaptor3d_Curve C, TColStd_HArray1OfReal Si, TColStd_HArray1OfReal Ui)
		{
			throw new NotImplementedException();
		}

		public double GetSParameter(Adaptor3d_Curve C, double U, double Length)
		{
			throw new NotImplementedException();
		}

		public bool EvalCurOnSur(double S, int Order, TColStd_Array1OfReal Result, int NumberOfCurve)
		{
			throw new NotImplementedException();
		}


	}; // class Approx_CurvlinFunc

}
