//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKGeomAlgo.IntCurveSurface;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.IntCurvesFace
{
	//---------------------------------------------------------------------
	//  Class  IntCurvesFace_ShapeIntersector
	//---------------------------------------------------------------------
	public  sealed class IntCurvesFace_ShapeIntersector
	{

		public IntCurvesFace_ShapeIntersector()
			: base()
		{
			throw new NotImplementedException();
		}

		public IntCurvesFace_ShapeIntersector(IntCurvesFace_ShapeIntersector parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Load(TopoDS_Shape Sh, double Tol)
		{
			throw new NotImplementedException();
		}

		public void Perform(gp_Lin L, double PInf, double PSup)
		{
			throw new NotImplementedException();
		}

		public void PerformNearest(gp_Lin L, double PInf, double PSup)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HCurve HCu, double PInf, double PSup)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public int NbPnt()
		{
			throw new NotImplementedException();
		}

		public double UParameter(int I)
		{
			throw new NotImplementedException();
		}

		public double VParameter(int I)
		{
			throw new NotImplementedException();
		}

		public double WParameter(int I)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Pnt(int I)
		{
			throw new NotImplementedException();
		}

		public IntCurveSurface_TransitionOnCurve Transition(int I)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State State(int I)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Face(int I)
		{
			throw new NotImplementedException();
		}

		public void SortResult()
		{
			throw new NotImplementedException();
		}

		public void Destroy()
		{
			throw new NotImplementedException();
		}


	}; // class IntCurvesFace_ShapeIntersector

}
