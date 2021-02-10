//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKGeomAlgo.IntSurf;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
	//---------------------------------------------------------------------
	//  Class  IntPatch_RLine
	//---------------------------------------------------------------------
	public  sealed class IntPatch_RLine : IntPatch_PointLine
	{

		public IntPatch_RLine(bool Tang, IntSurf_TypeTrans Trans1, IntSurf_TypeTrans Trans2)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_RLine(bool Tang, IntSurf_Situation Situ1, IntSurf_Situation Situ2)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_RLine(bool Tang)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_RLine(IntPatch_RLine parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_RLine()
		{
			throw new NotImplementedException();
		}

		public void AddVertex(IntPatch_Point Pnt, bool theIsPrepend)
		{
			throw new NotImplementedException();
		}

		public void AddVertex(IntPatch_Point Pnt)
		{
			throw new NotImplementedException();
		}

		public void Replace(int Index, IntPatch_Point Pnt)
		{
			throw new NotImplementedException();
		}

		public void SetFirstPoint(int IndFirst)
		{
			throw new NotImplementedException();
		}

		public void SetLastPoint(int IndLast)
		{
			throw new NotImplementedException();
		}

		public void Add(IntSurf_LineOn2S L)
		{
			throw new NotImplementedException();
		}

		public bool IsArcOnS1()
		{
			throw new NotImplementedException();
		}

		public bool IsArcOnS2()
		{
			throw new NotImplementedException();
		}

		public void SetArcOnS1(Adaptor2d_HCurve2d A)
		{
			throw new NotImplementedException();
		}

		public void SetArcOnS2(Adaptor2d_HCurve2d A)
		{
			throw new NotImplementedException();
		}

		public void SetParamOnS1(double p1, double p2)
		{
			throw new NotImplementedException();
		}

		public void SetParamOnS2(ref double p1, ref double p2)
		{
			throw new NotImplementedException();
		}

		public Adaptor2d_HCurve2d ArcOnS1()
		{
			throw new NotImplementedException();
		}

		public Adaptor2d_HCurve2d ArcOnS2()
		{
			throw new NotImplementedException();
		}

		public void ParamOnS1(ref double p1, ref double p2)
		{
			throw new NotImplementedException();
		}

		public void ParamOnS2(ref double p1, ref double p2)
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

		public IntPatch_Point FirstPoint()
		{
			throw new NotImplementedException();
		}

		public IntPatch_Point LastPoint()
		{
			throw new NotImplementedException();
		}

		public int NbVertex()
		{
			throw new NotImplementedException();
		}

		public IntPatch_Point Vertex(int Index)
		{
			throw new NotImplementedException();
		}

		public IntPatch_Point ChangeVertex(int Index)
		{
			throw new NotImplementedException();
		}

		public void RemoveVertex(int theIndex)
		{
			throw new NotImplementedException();
		}

		public bool HasPolygon()
		{
			throw new NotImplementedException();
		}

		public int NbPnts()
		{
			throw new NotImplementedException();
		}

		public IntSurf_PntOn2S Point(int Index)
		{
			throw new NotImplementedException();
		}

		public void SetPoint(int Index, IntPatch_Point Pnt)
		{
			throw new NotImplementedException();
		}

		public void ComputeVertexParameters(double Tol)
		{
			throw new NotImplementedException();
		}

		public IntSurf_LineOn2S Curve()
		{
			throw new NotImplementedException();
		}

		public bool IsOutSurf1Box(gp_Pnt2d theP)
		{
			throw new NotImplementedException();
		}

		public bool IsOutSurf2Box(gp_Pnt2d theP)
		{
			throw new NotImplementedException();
		}

		public bool IsOutBox(gp_Pnt theP)
		{
			throw new NotImplementedException();
		}

		public void ClearVertexes()
		{
			throw new NotImplementedException();
		}

		public void SetCurve(IntSurf_LineOn2S theNewCurve)
		{
			throw new NotImplementedException();
		}

		public void Dump(int theMode)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class IntPatch_RLine

}
