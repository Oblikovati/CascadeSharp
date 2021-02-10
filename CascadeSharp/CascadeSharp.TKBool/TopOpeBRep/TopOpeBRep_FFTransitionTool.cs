//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.TopOpeBRepDS;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBool.TopOpeBRep
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRep_FFTransitionTool
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRep_FFTransitionTool
	{

		public TopOpeBRep_FFTransitionTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_FFTransitionTool(TopOpeBRep_FFTransitionTool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Transition ProcessLineTransition(TopOpeBRep_VPointInter P, int Index, TopAbs_Orientation EdgeOrientation)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Transition ProcessLineTransition(TopOpeBRep_VPointInter P, TopOpeBRep_LineInter L)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Transition ProcessEdgeTransition(TopOpeBRep_VPointInter P, int Index, TopAbs_Orientation LineOrientation)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Transition ProcessFaceTransition(TopOpeBRep_LineInter L, int Index, TopAbs_Orientation FaceOrientation)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Transition ProcessEdgeONTransition(TopOpeBRep_VPointInter VP, int Index, TopoDS_Shape R, TopoDS_Shape E, TopoDS_Shape F)
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRep_FFTransitionTool

}
