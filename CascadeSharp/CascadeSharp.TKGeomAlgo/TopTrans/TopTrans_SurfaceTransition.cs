//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopTrans_SurfaceTransition
	//---------------------------------------------------------------------
	public  sealed class TopTrans_SurfaceTransition
	{

		public TopTrans_SurfaceTransition()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopTrans_SurfaceTransition(TopTrans_SurfaceTransition parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Reset(gp_Dir Tgt, gp_Dir Norm, gp_Dir MaxD, gp_Dir MinD, double MaxCurv, double MinCurv)
		{
			throw new NotImplementedException();
		}

		public void Reset(gp_Dir Tgt, gp_Dir Norm)
		{
			throw new NotImplementedException();
		}

		public void Compare(double Tole, gp_Dir Norm, gp_Dir MaxD, gp_Dir MinD, double MaxCurv, double MinCurv, CascadeSharp.TopAbs_Orientation S, CascadeSharp.TopAbs_Orientation O)
		{
			throw new NotImplementedException();
		}

		public void Compare(double Tole, gp_Dir Norm, CascadeSharp.TopAbs_Orientation S, CascadeSharp.TopAbs_Orientation O)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_State StateBefore()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_State StateAfter()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_State GetBefore(CascadeSharp.TopAbs_Orientation Tran)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_State GetAfter(CascadeSharp.TopAbs_Orientation Tran)
		{
			throw new NotImplementedException();
		}

		public void UpdateReference(double Tole, bool _isInfRef, ref double CosInf, ref double CosSup, CascadeSharp.TopAbs_Orientation Tran,  ref CascadeSharp.TopAbs_Orientation TranRef)
		{
			throw new NotImplementedException();
		}

		public double ComputeCos(double Tole, gp_Dir Norm, CascadeSharp.TopAbs_Orientation O, ref bool _isleft)
		{
			throw new NotImplementedException();
		}


	}; // class TopTrans_SurfaceTransition

}
