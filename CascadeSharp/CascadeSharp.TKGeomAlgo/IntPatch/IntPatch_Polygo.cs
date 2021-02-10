//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKGeomAlgo.Intf;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
	//---------------------------------------------------------------------
	//  Class  IntPatch_Polygo
	//---------------------------------------------------------------------
	public  abstract class IntPatch_Polygo : Intf_Polygon2d
	{

		public IntPatch_Polygo(double theError)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public IntPatch_Polygo(IntPatch_Polygo parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public IntPatch_Polygo()
		{
			throw new NotImplementedException();
		}

		public double Error()
		{
			throw new NotImplementedException();
		}

		public int NbPoints()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d Point(int Index)
		{
			throw new NotImplementedException();
		}

		public double DeflectionOverEstimation()
		{
			throw new NotImplementedException();
		}

		public int NbSegments()
		{
			throw new NotImplementedException();
		}

		public void Segment(int theIndex, gp_Pnt2d theBegin, gp_Pnt2d theEnd)
		{
			throw new NotImplementedException();
		}

		public void Dump()
		{
			throw new NotImplementedException();
		}


	}; // class IntPatch_Polygo

}
