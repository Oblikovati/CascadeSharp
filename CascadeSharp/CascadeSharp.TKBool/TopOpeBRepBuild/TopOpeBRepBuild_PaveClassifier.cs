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
	//  Class  TopOpeBRepBuild_PaveClassifier
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepBuild_PaveClassifier : TopOpeBRepBuild_LoopClassifier
	{

		public TopOpeBRepBuild_PaveClassifier(TopoDS_Shape E)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_PaveClassifier(TopOpeBRepBuild_PaveClassifier parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_PaveClassifier()
		{
			throw new NotImplementedException();
		}

		public TopAbs_State Compare(TopOpeBRepBuild_Loop L1, TopOpeBRepBuild_Loop L2)
		{
			throw new NotImplementedException();
		}

		public void SetFirstParameter(double P)
		{
			throw new NotImplementedException();
		}

		public void ClosedVertices(bool B)
		{
			throw new NotImplementedException();
		}

		public double AdjustCase(double p1, TopAbs_Orientation o, double first, double period, double tol, ref int cas)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State CompareOnNonPeriodic()
		{
			throw new NotImplementedException();
		}

		public TopAbs_State CompareOnPeriodic()
		{
			throw new NotImplementedException();
		}

		public void AdjustOnPeriodic()
		{
			throw new NotImplementedException();
		}

		public bool ToAdjustOnPeriodic()
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRepBuild_PaveClassifier

}
