//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBool.TopOpeBRepBuild
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepBuild_LoopClassifier
	//---------------------------------------------------------------------
	public  abstract class TopOpeBRepBuild_LoopClassifier
	{

		public TopOpeBRepBuild_LoopClassifier(TopOpeBRepBuild_LoopClassifier parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public TopOpeBRepBuild_LoopClassifier()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public TopAbs_State Compare(TopOpeBRepBuild_Loop L1, TopOpeBRepBuild_Loop L2)
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRepBuild_LoopClassifier

}
