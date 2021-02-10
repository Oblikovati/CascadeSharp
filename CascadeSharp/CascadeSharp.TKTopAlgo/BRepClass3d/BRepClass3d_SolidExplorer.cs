//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepAdaptor;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKTopAlgo.IntCurvesFace;

namespace CascadeSharp.TKTopAlgo.BRepClass3d
{
	//---------------------------------------------------------------------
	//  Class  BRepClass3d_SolidExplorer
	//---------------------------------------------------------------------
	public  sealed class BRepClass3d_SolidExplorer
	{

		public BRepClass3d_SolidExplorer()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepClass3d_SolidExplorer(TopoDS_Shape S)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepClass3d_SolidExplorer(BRepClass3d_SolidExplorer Oth)
			: base()
		{
			throw new NotImplementedException();
		}

		public void InitShape(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public bool Reject(gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public bool FindAPointInTheFace(TopoDS_Face F, gp_Pnt P, ref double Param)
		{
			throw new NotImplementedException();
		}

		public bool FindAPointInTheFace(TopoDS_Face F, gp_Pnt P, ref double u, ref double v, ref double Param)
		{
			throw new NotImplementedException();
		}

		public bool FindAPointInTheFace(TopoDS_Face F, gp_Pnt P, ref double u, ref double v, ref double Param, gp_Vec theVecD1U, gp_Vec theVecD1V)
		{
			throw new NotImplementedException();
		}

		public bool FindAPointInTheFace(TopoDS_Face F, gp_Pnt P, ref double u, ref double v)
		{
			throw new NotImplementedException();
		}

		public bool FindAPointInTheFace(TopoDS_Face F, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public bool FindAPointInTheFace(TopoDS_Face F, ref double u, ref double v)
		{
			throw new NotImplementedException();
		}

		public bool PointInTheFace(TopoDS_Face F, gp_Pnt P, ref double u, ref double v, ref double Param, ref int Index)
		{
			throw new NotImplementedException();
		}

		public bool PointInTheFace(TopoDS_Face F, gp_Pnt P, ref double u, ref double v, ref double Param, ref int Index, BRepAdaptor_HSurface surf, double u1, double v1, double u2, double v2)
		{
			throw new NotImplementedException();
		}

		public bool PointInTheFace(TopoDS_Face F, gp_Pnt P, ref double u, ref double v, ref double Param, ref int Index, BRepAdaptor_HSurface surf, double u1, double v1, double u2, double v2, gp_Vec theVecD1U, gp_Vec theVecD1V)
		{
			throw new NotImplementedException();
		}

		public void InitShell()
		{
			throw new NotImplementedException();
		}

		public bool MoreShell()
		{
			throw new NotImplementedException();
		}

		public void NextShell()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shell CurrentShell()
		{
			throw new NotImplementedException();
		}

		public bool RejectShell(gp_Lin L)
		{
			throw new NotImplementedException();
		}

		public void InitFace()
		{
			throw new NotImplementedException();
		}

		public bool MoreFace()
		{
			throw new NotImplementedException();
		}

		public void NextFace()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face CurrentFace()
		{
			throw new NotImplementedException();
		}

		public bool RejectFace(gp_Lin L)
		{
			throw new NotImplementedException();
		}

		public int Segment(gp_Pnt P, gp_Lin L, ref double Par)
		{
			throw new NotImplementedException();
		}

		public int OtherSegment(gp_Pnt P, gp_Lin L, ref double Par)
		{
			throw new NotImplementedException();
		}

		public int GetFaceSegmentIndex()
		{
			throw new NotImplementedException();
		}

		public void DumpSegment(gp_Pnt P, gp_Lin L, double Par, TopAbs_State S)
		{
			throw new NotImplementedException();
		}

		public Bnd_Box Box()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape GetShape()
		{
			throw new NotImplementedException();
		}

		public IntCurvesFace_Intersector Intersector(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

				public TopTools_IndexedMapOfShape GetMapEV()
		{
			throw new NotImplementedException();
		}

		public void Destroy()
		{
			throw new NotImplementedException();
		}

		public TopAbs_State ClassifyUVPoint(IntCurvesFace_Intersector theIntersector, BRepAdaptor_HSurface theSurf, gp_Pnt2d theP2d)
		{
			throw new NotImplementedException();
		}


	}; // class BRepClass3d_SolidExplorer

}
