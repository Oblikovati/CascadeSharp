//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  IntCurvesFace_Intersector
	//---------------------------------------------------------------------
	public  sealed class IntCurvesFace_Intersector
	{

		public IntCurvesFace_Intersector(TopoDS_Face F, double aTol, bool aRestr, bool UseBToler)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntCurvesFace_Intersector(TopoDS_Face F, double aTol, bool aRestr)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntCurvesFace_Intersector(TopoDS_Face F, double aTol)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntCurvesFace_Intersector(IntCurvesFace_Intersector parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntCurvesFace_Intersector()
		{
			throw new NotImplementedException();
		}

		public void Perform(gp_Lin L, double PInf, double PSup)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HCurve HCu, double PInf, double PSup)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_SurfaceType SurfaceType()
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

		public CascadeSharp.IntCurveSurface_TransitionOnCurve Transition(int I)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_State State(int I)
		{
			throw new NotImplementedException();
		}

		public bool IsParallel()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Face()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_State ClassifyUVPoint(gp_Pnt2d Puv)
		{
			throw new NotImplementedException();
		}

		public Bnd_Box Bounding()
		{
			throw new NotImplementedException();
		}

		public void SetUseBoundToler(bool UseBToler)
		{
			throw new NotImplementedException();
		}

		public bool GetUseBoundToler()
		{
			throw new NotImplementedException();
		}

		public void Destroy()
		{
			throw new NotImplementedException();
		}

		public void InternalCall(IntCurveSurface_HInter HICS, double pinf, double psup)
		{
			throw new NotImplementedException();
		}


	}; // class IntCurvesFace_Intersector

}
