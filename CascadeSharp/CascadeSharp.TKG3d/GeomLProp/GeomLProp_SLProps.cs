//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.GeomLProp
{
	//---------------------------------------------------------------------
	//  Class  GeomLProp_SLProps
	//---------------------------------------------------------------------
	public  sealed class GeomLProp_SLProps
	{

		public GeomLProp_SLProps(Geom_Surface S, double U, double V, int N, double Resolution)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomLProp_SLProps(Geom_Surface S, int N, double Resolution)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomLProp_SLProps(int N, double Resolution)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomLProp_SLProps(GeomLProp_SLProps parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomLProp_SLProps()
		{
			throw new NotImplementedException();
		}

		public void SetSurface(Geom_Surface S)
		{
			throw new NotImplementedException();
		}

		public void SetParameters(double U, double V)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Value()
		{
			throw new NotImplementedException();
		}

		public gp_Vec D1U()
		{
			throw new NotImplementedException();
		}

		public gp_Vec D1V()
		{
			throw new NotImplementedException();
		}

		public gp_Vec D2U()
		{
			throw new NotImplementedException();
		}

		public gp_Vec D2V()
		{
			throw new NotImplementedException();
		}

		public gp_Vec DUV()
		{
			throw new NotImplementedException();
		}

		public bool IsTangentUDefined()
		{
			throw new NotImplementedException();
		}

		public void TangentU(gp_Dir D)
		{
			throw new NotImplementedException();
		}

		public bool IsTangentVDefined()
		{
			throw new NotImplementedException();
		}

		public void TangentV(gp_Dir D)
		{
			throw new NotImplementedException();
		}

		public bool IsNormalDefined()
		{
			throw new NotImplementedException();
		}

		public gp_Dir Normal()
		{
			throw new NotImplementedException();
		}

		public bool IsCurvatureDefined()
		{
			throw new NotImplementedException();
		}

		public bool IsUmbilic()
		{
			throw new NotImplementedException();
		}

		public double MaxCurvature()
		{
			throw new NotImplementedException();
		}

		public double MinCurvature()
		{
			throw new NotImplementedException();
		}

		public void CurvatureDirections(gp_Dir MaxD, gp_Dir MinD)
		{
			throw new NotImplementedException();
		}

		public double MeanCurvature()
		{
			throw new NotImplementedException();
		}

		public double GaussianCurvature()
		{
			throw new NotImplementedException();
		}


	}; // class GeomLProp_SLProps

}
