//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepAdaptor;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBRep.BRepLProp
{
	//---------------------------------------------------------------------
	//  Class  BRepLProp_SLProps
	//---------------------------------------------------------------------
	public  sealed class BRepLProp_SLProps
	{

		public BRepLProp_SLProps(BRepAdaptor_Surface S, double U, double V, int N, double Resolution)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepLProp_SLProps(BRepAdaptor_Surface S, int N, double Resolution)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepLProp_SLProps(int N, double Resolution)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepLProp_SLProps(BRepLProp_SLProps parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepLProp_SLProps()
		{
			throw new NotImplementedException();
		}

		public void SetSurface(BRepAdaptor_Surface S)
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


	}; // class BRepLProp_SLProps

}
