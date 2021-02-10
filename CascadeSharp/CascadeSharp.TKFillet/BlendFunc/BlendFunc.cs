//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BlendFunc
	//---------------------------------------------------------------------
	public  sealed class BlendFunc
	{

		public BlendFunc()
			: base()
		{
			throw new NotImplementedException();
		}

		public BlendFunc(BlendFunc parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void GetShape(CascadeSharp.BlendFunc_SectionShape SectShape, double MaxAng, ref int NbPoles, ref int NbKnots, ref int Degree,  ref CascadeSharp.Convert_ParameterisationType TypeConv)
		{
			throw new NotImplementedException();
		}

		public void Knots(CascadeSharp.BlendFunc_SectionShape SectShape, TColStd_Array1OfReal TKnots)
		{
			throw new NotImplementedException();
		}

		public void Mults(CascadeSharp.BlendFunc_SectionShape SectShape, TColStd_Array1OfInteger TMults)
		{
			throw new NotImplementedException();
		}

		public void GetMinimalWeights(CascadeSharp.BlendFunc_SectionShape SectShape, CascadeSharp.Convert_ParameterisationType TConv, double AngleMin, double AngleMax, TColStd_Array1OfReal Weigths)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_Shape NextShape(CascadeSharp.GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public bool ComputeNormal(Adaptor3d_HSurface Surf, gp_Pnt2d p2d, gp_Vec Normal)
		{
			throw new NotImplementedException();
		}

		public bool ComputeDNormal(Adaptor3d_HSurface Surf, gp_Pnt2d p2d, gp_Vec Normal, gp_Vec DNu, gp_Vec DNv)
		{
			throw new NotImplementedException();
		}


	}; // class BlendFunc

}
