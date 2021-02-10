//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKGeomBase.IntAna;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomAlgo.IntCurveSurface
{
	//---------------------------------------------------------------------
	//  Class  IntCurveSurface_HInter
	//---------------------------------------------------------------------
	public  sealed class IntCurveSurface_HInter : IntCurveSurface_Intersection
	{

		public IntCurveSurface_HInter()
			: base()
		{
			throw new NotImplementedException();
		}

		public IntCurveSurface_HInter(IntCurveSurface_HInter parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HCurve Curve, Adaptor3d_HSurface Surface)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HCurve Curve, IntCurveSurface_ThePolygonOfHInter Polygon, Adaptor3d_HSurface Surface)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HCurve Curve, IntCurveSurface_ThePolygonOfHInter ThePolygon, Adaptor3d_HSurface Surface, IntCurveSurface_ThePolyhedronOfHInter Polyhedron)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HCurve Curve, IntCurveSurface_ThePolygonOfHInter ThePolygon, Adaptor3d_HSurface Surface, IntCurveSurface_ThePolyhedronOfHInter Polyhedron, Bnd_BoundSortBox BndBSB)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HCurve Curve, Adaptor3d_HSurface Surface, IntCurveSurface_ThePolyhedronOfHInter Polyhedron)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HCurve Curve, Adaptor3d_HSurface Surface, double U0, double V0, double U1, double V1)
		{
			throw new NotImplementedException();
		}

		public void InternalPerformCurveQuadric(Adaptor3d_HCurve Curve, Adaptor3d_HSurface Surface)
		{
			throw new NotImplementedException();
		}

		public void InternalPerform(Adaptor3d_HCurve Curve, IntCurveSurface_ThePolygonOfHInter Polygon, Adaptor3d_HSurface Surface, IntCurveSurface_ThePolyhedronOfHInter Polyhedron, double U1, double V1, double U2, double V2)
		{
			throw new NotImplementedException();
		}

		public void InternalPerform(Adaptor3d_HCurve Curve, IntCurveSurface_ThePolygonOfHInter Polygon, Adaptor3d_HSurface Surface, IntCurveSurface_ThePolyhedronOfHInter Polyhedron, double U1, double V1, double U2, double V2, Bnd_BoundSortBox BSB)
		{
			throw new NotImplementedException();
		}

		public void InternalPerform(Adaptor3d_HCurve Curve, IntCurveSurface_ThePolygonOfHInter Polygon, Adaptor3d_HSurface Surface, double U1, double V1, double U2, double V2)
		{
			throw new NotImplementedException();
		}

		public void PerformConicSurf(gp_Lin Line, Adaptor3d_HCurve Curve, Adaptor3d_HSurface Surface, double U1, double V1, double U2, double V2)
		{
			throw new NotImplementedException();
		}

		public void PerformConicSurf(gp_Circ Circle, Adaptor3d_HCurve Curve, Adaptor3d_HSurface Surface, double U1, double V1, double U2, double V2)
		{
			throw new NotImplementedException();
		}

		public void PerformConicSurf(gp_Elips Ellipse, Adaptor3d_HCurve Curve, Adaptor3d_HSurface Surface, double U1, double V1, double U2, double V2)
		{
			throw new NotImplementedException();
		}

		public void PerformConicSurf(gp_Parab Parab, Adaptor3d_HCurve Curve, Adaptor3d_HSurface Surface, double U1, double V1, double U2, double V2)
		{
			throw new NotImplementedException();
		}

		public void PerformConicSurf(gp_Hypr Hyper, Adaptor3d_HCurve Curve, Adaptor3d_HSurface Surface, double U1, double V1, double U2, double V2)
		{
			throw new NotImplementedException();
		}

		public void AppendIntAna(Adaptor3d_HCurve Curve, Adaptor3d_HSurface Surface, IntAna_IntConicQuad InterAna)
		{
			throw new NotImplementedException();
		}

		public void AppendPoint(Adaptor3d_HCurve Curve, double w, Adaptor3d_HSurface Surface, double u, double v)
		{
			throw new NotImplementedException();
		}

		public void AppendSegment(Adaptor3d_HCurve Curve, double u0, double u1, Adaptor3d_HSurface Surface)
		{
			throw new NotImplementedException();
		}

		public void DoSurface(Adaptor3d_HSurface surface, double u0, double u1, double v0, double v1, TColgp_Array2OfPnt pntsOnSurface, Bnd_Box boxSurface, ref double gap)
		{
			throw new NotImplementedException();
		}

		public void DoNewBounds(Adaptor3d_HSurface surface, double u0, double u1, double v0, double v1, TColgp_Array2OfPnt pntsOnSurface, TColStd_Array1OfReal X, TColStd_Array1OfReal Y, TColStd_Array1OfReal Z, TColStd_Array1OfReal Bounds)
		{
			throw new NotImplementedException();
		}


	}; // class IntCurveSurface_HInter

}
