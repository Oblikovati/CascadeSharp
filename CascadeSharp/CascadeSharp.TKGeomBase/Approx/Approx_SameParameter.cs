//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Approx_SameParameter
	//---------------------------------------------------------------------
	public  sealed class Approx_SameParameter
	{

		public Approx_SameParameter(Geom_Curve C3D, Geom2d_Curve C2D, Geom_Surface S, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_SameParameter(Adaptor3d_HCurve C3D, Geom2d_Curve C2D, Adaptor3d_HSurface S, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_SameParameter(Adaptor3d_HCurve C3D, Adaptor2d_HCurve2d C2D, Adaptor3d_HSurface S, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_SameParameter(Approx_SameParameter parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_SameParameter()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public double TolReached()
		{
			throw new NotImplementedException();
		}

		public bool IsSameParameter()
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve Curve2d()
		{
			throw new NotImplementedException();
		}

		public void Build(double Tol)
		{
			throw new NotImplementedException();
		}

						public bool ComputeTangents(Adaptor3d_CurveOnSurface theCOnS, ref double theFirstTangent, ref double theLastTangent)
		{
			throw new NotImplementedException();
		}

						
	}; // class Approx_SameParameter

}
