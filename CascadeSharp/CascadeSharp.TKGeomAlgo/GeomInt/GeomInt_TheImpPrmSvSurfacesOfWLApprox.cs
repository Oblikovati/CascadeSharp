//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomInt_TheImpPrmSvSurfacesOfWLApprox
	//---------------------------------------------------------------------
	public  sealed class GeomInt_TheImpPrmSvSurfacesOfWLApprox : CascadeSharp.ApproxInt_SvSurfaces
	{

		public GeomInt_TheImpPrmSvSurfacesOfWLApprox(Adaptor3d_HSurface Surf1, IntSurf_Quadric Surf2)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_TheImpPrmSvSurfacesOfWLApprox(IntSurf_Quadric Surf1, Adaptor3d_HSurface Surf2)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_TheImpPrmSvSurfacesOfWLApprox(GeomInt_TheImpPrmSvSurfacesOfWLApprox parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_TheImpPrmSvSurfacesOfWLApprox()
		{
			throw new NotImplementedException();
		}

		public bool Compute(ref double u1, ref double v1, ref double u2, ref double v2, gp_Pnt Pt, gp_Vec Tg, gp_Vec2d Tguv1, gp_Vec2d Tguv2)
		{
			throw new NotImplementedException();
		}

		public void Pnt(double u1, double v1, double u2, double v2, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public bool SeekPoint(double u1, double v1, double u2, double v2, IntSurf_PntOn2S Point)
		{
			throw new NotImplementedException();
		}

		public bool Tangency(double u1, double v1, double u2, double v2, gp_Vec Tg)
		{
			throw new NotImplementedException();
		}

		public bool TangencyOnSurf1(double u1, double v1, double u2, double v2, gp_Vec2d Tg)
		{
			throw new NotImplementedException();
		}

		public bool TangencyOnSurf2(double u1, double v1, double u2, double v2, gp_Vec2d Tg)
		{
			throw new NotImplementedException();
		}

		public bool FillInitialVectorOfSolution(double u1, double v1, double u2, double v2, double binfu, double bsupu, double binfv, double bsupv, math_Vector X, ref double TranslationU, ref double TranslationV)
		{
			throw new NotImplementedException();
		}


	}; // class GeomInt_TheImpPrmSvSurfacesOfWLApprox

}
