//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  IntPatch_ImpImpIntersection
	//---------------------------------------------------------------------
	public  sealed class IntPatch_ImpImpIntersection
	{

		public IntPatch_ImpImpIntersection()
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_ImpImpIntersection(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang, bool theIsReqToKeepRLine)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_ImpImpIntersection(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_ImpImpIntersection(IntPatch_ImpImpIntersection parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang, bool theIsReqToKeepRLine)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HSurface S1, Adaptor3d_TopolTool D1, Adaptor3d_HSurface S2, Adaptor3d_TopolTool D2, double TolArc, double TolTang)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.IntPatch_ImpImpIntersection.IntStatus GetStatus()
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


		//---------------------------------------------------------------------
		//  Enum  IntStatus
		//---------------------------------------------------------------------
		public		enum IntStatus
		{
			IntStatus_OK = 0,
			IntStatus_InfiniteSectionCurve = 1,
			IntStatus_Fail = 2
		} // enum  class IntStatus

	}; // class IntPatch_ImpImpIntersection

}
