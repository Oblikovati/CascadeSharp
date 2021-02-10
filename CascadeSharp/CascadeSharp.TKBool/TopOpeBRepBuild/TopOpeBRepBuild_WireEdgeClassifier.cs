//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBool.TopOpeBRepBuild
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepBuild_WireEdgeClassifier
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepBuild_WireEdgeClassifier : TopOpeBRepBuild_CompositeClassifier
	{

		public TopOpeBRepBuild_WireEdgeClassifier(TopoDS_Shape F, TopOpeBRepBuild_BlockBuilder BB)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_WireEdgeClassifier(TopOpeBRepBuild_WireEdgeClassifier parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_WireEdgeClassifier()
		{
			throw new NotImplementedException();
		}

		public TopAbs_State Compare(TopOpeBRepBuild_Loop L1, TopOpeBRepBuild_Loop L2)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape LoopToShape(TopOpeBRepBuild_Loop L)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State CompareShapes(TopoDS_Shape B1, TopoDS_Shape B2)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State CompareElementToShape(TopoDS_Shape E, TopoDS_Shape B)
		{
			throw new NotImplementedException();
		}

		public void ResetShape(TopoDS_Shape B)
		{
			throw new NotImplementedException();
		}

		public void ResetElement(TopoDS_Shape E)
		{
			throw new NotImplementedException();
		}

		public bool CompareElement(TopoDS_Shape E)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State State()
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRepBuild_WireEdgeClassifier

}
