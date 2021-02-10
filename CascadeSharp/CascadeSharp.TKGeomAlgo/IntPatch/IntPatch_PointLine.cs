//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  IntPatch_PointLine
	//---------------------------------------------------------------------
	public  abstract class IntPatch_PointLine : CascadeSharp.IntPatch_Line
	{

		public IntPatch_PointLine(bool Tang, CascadeSharp.IntSurf_TypeTrans Trans1, CascadeSharp.IntSurf_TypeTrans Trans2)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public IntPatch_PointLine(bool Tang, CascadeSharp.IntSurf_Situation Situ1, CascadeSharp.IntSurf_Situation Situ2)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public IntPatch_PointLine(bool Tang)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public IntPatch_PointLine(IntPatch_PointLine parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public IntPatch_PointLine()
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

		public int NbPnts()
		{
			throw new NotImplementedException();
		}

		public int NbVertex()
		{
			throw new NotImplementedException();
		}

		public IntSurf_PntOn2S Point(int Index)
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

		public void ClearVertexes()
		{
			throw new NotImplementedException();
		}

		public void RemoveVertex(int theIndex)
		{
			throw new NotImplementedException();
		}

		public IntSurf_LineOn2S Curve()
		{
			throw new NotImplementedException();
		}

		public bool IsOutSurf1Box(gp_Pnt2d P1)
		{
			throw new NotImplementedException();
		}

		public bool IsOutSurf2Box(gp_Pnt2d P2)
		{
			throw new NotImplementedException();
		}

		public bool IsOutBox(gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public double CurvatureRadiusOfIntersLine(Adaptor3d_HSurface theS1, Adaptor3d_HSurface theS2, IntSurf_PntOn2S theUVPoint)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class IntPatch_PointLine

}
