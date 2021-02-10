//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
	//---------------------------------------------------------------------
	//  Class  IntPatch_PolyArc
	//---------------------------------------------------------------------
	public  sealed class IntPatch_PolyArc : IntPatch_Polygo
	{

		public IntPatch_PolyArc(Adaptor2d_HCurve2d A, int NbSample, double Pfirst, double Plast, Bnd_Box2d BoxOtherPolygon)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_PolyArc(IntPatch_PolyArc parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_PolyArc()
		{
			throw new NotImplementedException();
		}

		public bool Closed()
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

		public double Parameter(int Index)
		{
			throw new NotImplementedException();
		}

		public void SetOffset(double OffsetX, double OffsetY)
		{
			throw new NotImplementedException();
		}


	}; // class IntPatch_PolyArc

}
