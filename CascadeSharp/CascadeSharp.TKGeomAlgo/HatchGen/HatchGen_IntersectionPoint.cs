//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKGeomAlgo.HatchGen
{
	//---------------------------------------------------------------------
	//  Class  HatchGen_IntersectionPoint
	//---------------------------------------------------------------------
	public  abstract class HatchGen_IntersectionPoint
	{

		public HatchGen_IntersectionPoint()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public HatchGen_IntersectionPoint(HatchGen_IntersectionPoint parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void SetIndex(int Index)
		{
			throw new NotImplementedException();
		}

		public int Index()
		{
			throw new NotImplementedException();
		}

		public void SetParameter(double Parameter)
		{
			throw new NotImplementedException();
		}

		public double Parameter()
		{
			throw new NotImplementedException();
		}

		public void SetPosition(TopAbs_Orientation Position)
		{
			throw new NotImplementedException();
		}

		public TopAbs_Orientation Position()
		{
			throw new NotImplementedException();
		}

		public void SetStateBefore(TopAbs_State State)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State StateBefore()
		{
			throw new NotImplementedException();
		}

		public void SetStateAfter(TopAbs_State State)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State StateAfter()
		{
			throw new NotImplementedException();
		}

		public void SetSegmentBeginning(bool State)
		{
			throw new NotImplementedException();
		}

		public void SetSegmentBeginning()
		{
			throw new NotImplementedException();
		}

		public bool SegmentBeginning()
		{
			throw new NotImplementedException();
		}

		public void SetSegmentEnd(bool State)
		{
			throw new NotImplementedException();
		}

		public void SetSegmentEnd()
		{
			throw new NotImplementedException();
		}

		public bool SegmentEnd()
		{
			throw new NotImplementedException();
		}

		public void Dump(int Index)
		{
			throw new NotImplementedException();
		}

		public void Dump()
		{
			throw new NotImplementedException();
		}


	}; // class HatchGen_IntersectionPoint

}
