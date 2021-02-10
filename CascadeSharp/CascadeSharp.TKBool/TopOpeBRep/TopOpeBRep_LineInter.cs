//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.TopOpeBRepDS;
using CascadeSharp.TKBRep.BRepAdaptor;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKGeomAlgo.IntPatch;
using CascadeSharp.TKGeomAlgo.IntSurf;

namespace CascadeSharp.TKBool.TopOpeBRep
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRep_LineInter
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRep_LineInter
	{

		public TopOpeBRep_LineInter()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_LineInter(TopOpeBRep_LineInter parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetLine(IntPatch_Line L, BRepAdaptor_Surface S1, BRepAdaptor_Surface S2)
		{
			throw new NotImplementedException();
		}

		public void SetFaces(TopoDS_Face F1, TopoDS_Face F2)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_TypeLineCurve TypeLineCurve()
		{
			throw new NotImplementedException();
		}

		public int NbVPoint()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_VPointInter VPoint(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_VPointInter ChangeVPoint(int I)
		{
			throw new NotImplementedException();
		}

		public void SetINL()
		{
			throw new NotImplementedException();
		}

		public bool INL()
		{
			throw new NotImplementedException();
		}

		public void SetIsVClosed()
		{
			throw new NotImplementedException();
		}

		public bool IsVClosed()
		{
			throw new NotImplementedException();
		}

		public void SetOK(bool B)
		{
			throw new NotImplementedException();
		}

		public bool OK()
		{
			throw new NotImplementedException();
		}

		public void SetHasVPonR()
		{
			throw new NotImplementedException();
		}

		public bool HasVPonR()
		{
			throw new NotImplementedException();
		}

		public void SetVPBounds()
		{
			throw new NotImplementedException();
		}

		public void VPBounds(ref int f, ref int l, ref int n)
		{
			throw new NotImplementedException();
		}

		public bool IsPeriodic()
		{
			throw new NotImplementedException();
		}

		public double Period()
		{
			throw new NotImplementedException();
		}

		public void Bounds(ref double f, ref double l)
		{
			throw new NotImplementedException();
		}

		public bool HasVInternal()
		{
			throw new NotImplementedException();
		}

		public int NbWPoint()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_WPointInter WPoint(int I)
		{
			throw new NotImplementedException();
		}

		public IntSurf_TypeTrans TransitionOnS1()
		{
			throw new NotImplementedException();
		}

		public IntSurf_TypeTrans TransitionOnS2()
		{
			throw new NotImplementedException();
		}

		public IntSurf_Situation SituationS1()
		{
			throw new NotImplementedException();
		}

		public IntSurf_Situation SituationS2()
		{
			throw new NotImplementedException();
		}

		public Geom_Curve Curve()
		{
			throw new NotImplementedException();
		}

		public Geom_Curve Curve(double parmin, double parmax)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Arc()
		{
			throw new NotImplementedException();
		}

		public bool ArcIsEdge(int I)
		{
			throw new NotImplementedException();
		}

		public IntPatch_WLine LineW()
		{
			throw new NotImplementedException();
		}

		public IntPatch_GLine LineG()
		{
			throw new NotImplementedException();
		}

		public IntPatch_RLine LineR()
		{
			throw new NotImplementedException();
		}

		public bool HasFirstPoint()
		{
			throw new NotImplementedException();
		}

		public bool HasLastPoint()
		{
			throw new NotImplementedException();
		}

		public void ComputeFaceFaceTransition()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Transition FaceFaceTransition(int I)
		{
			throw new NotImplementedException();
		}

		public void Index(int I)
		{
			throw new NotImplementedException();
		}

		public int Index()
		{
			throw new NotImplementedException();
		}

		public void DumpType()
		{
			throw new NotImplementedException();
		}

		public void DumpVPoint(int I, TCollection_AsciiString s1, TCollection_AsciiString s2)
		{
			throw new NotImplementedException();
		}

		public void DumpBipoint(TopOpeBRep_Bipoint B, TCollection_AsciiString s1, TCollection_AsciiString s2)
		{
			throw new NotImplementedException();
		}

		public void SetTraceIndex(int exF1, int exF2)
		{
			throw new NotImplementedException();
		}

		public void GetTraceIndex(ref int exF1, ref int exF2)
		{
			throw new NotImplementedException();
		}

		
	}; // class TopOpeBRep_LineInter

}
