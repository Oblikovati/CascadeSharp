//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKGeomAlgo.IntSurf;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
	//---------------------------------------------------------------------
	//  Class  IntPatch_Intersection
	//---------------------------------------------------------------------
	public  sealed class IntPatch_Intersection
	{

		public IntPatch_Intersection()
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_Intersection(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_Intersection(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, double TolArc, double TolTang)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_Intersection(IntPatch_Intersection parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetTolerances(double TolArc, double TolTang, double UVMaxStep, double Fleche)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang, bool _isGeomInt, bool theIsReqToKeepRLine, bool theIsReqToPostWLProc)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang, bool _isGeomInt, bool theIsReqToKeepRLine)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang, bool _isGeomInt)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang, IntSurf_ListOfPntOn2S LOfPnts, bool _isGeomInt, bool theIsReqToKeepRLine, bool theIsReqToPostWLProc)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang, IntSurf_ListOfPntOn2S LOfPnts, bool _isGeomInt, bool theIsReqToKeepRLine)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang, IntSurf_ListOfPntOn2S LOfPnts, bool _isGeomInt)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang, IntSurf_ListOfPntOn2S LOfPnts)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double U1, double V1, double U2, double V2, double TolArc, double TolTang)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, double TolArc, double TolTang)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			throw new NotImplementedException();
		}

		public bool TangentFaces()
		{
			throw new NotImplementedException();
		}

		public bool OppositeFaces()
		{
			throw new NotImplementedException();
		}

		public int NbPnts()
		{
			throw new NotImplementedException();
		}

		public IntPatch_Point Point(int Index)
		{
			throw new NotImplementedException();
		}

		public int NbLines()
		{
			throw new NotImplementedException();
		}

		public IntPatch_Line Line(int Index)
		{
			throw new NotImplementedException();
		}

		public IntPatch_SequenceOfLine SequenceOfLine()
		{
			throw new NotImplementedException();
		}

		public void Dump(int Mode, Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2)
		{
			throw new NotImplementedException();
		}

		public void ParamParamPerfom(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang, IntSurf_ListOfPntOn2S LOfPnts, GeomAbs_SurfaceType typs1, GeomAbs_SurfaceType typs2)
		{
			throw new NotImplementedException();
		}

		public void GeomGeomPerfom(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang, IntSurf_ListOfPntOn2S LOfPnts, GeomAbs_SurfaceType typs1, GeomAbs_SurfaceType typs2, bool theIsReqToKeepRLine)
		{
			throw new NotImplementedException();
		}

		public void GeomParamPerfom(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, bool _isNotAnalitical, GeomAbs_SurfaceType typs1, GeomAbs_SurfaceType typs2)
		{
			throw new NotImplementedException();
		}


	}; // class IntPatch_Intersection

}
