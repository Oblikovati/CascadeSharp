//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKGeomAlgo.IntRes2d;

namespace CascadeSharp.TKTopAlgo.Bisector
{
	//---------------------------------------------------------------------
	//  Class  Bisector_Inter
	//---------------------------------------------------------------------
	public  sealed class Bisector_Inter : IntRes2d_Intersection
	{

		public Bisector_Inter()
			: base()
		{
			throw new NotImplementedException();
		}

		public Bisector_Inter(Bisector_Bisec C1, IntRes2d_Domain D1, Bisector_Bisec C2, IntRes2d_Domain D2, double TolConf, double Tol, bool ComunElement)
			: base()
		{
			throw new NotImplementedException();
		}

		public Bisector_Inter(Bisector_Inter parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Perform(Bisector_Bisec C1, IntRes2d_Domain D1, Bisector_Bisec C2, IntRes2d_Domain D2, double TolConf, double Tol, bool ComunElement)
		{
			throw new NotImplementedException();
		}

		public void SinglePerform(Geom2d_Curve C1, IntRes2d_Domain D1, Geom2d_Curve C2, IntRes2d_Domain D2, double TolConf, double Tol, bool ComunElement)
		{
			throw new NotImplementedException();
		}

		public void NeighbourPerform(Bisector_BisecCC C1, IntRes2d_Domain D1, Bisector_BisecCC C2, IntRes2d_Domain D2, double Tol)
		{
			throw new NotImplementedException();
		}

		public void TestBound(Geom2d_Line C1, IntRes2d_Domain D1, Geom2d_Curve C2, IntRes2d_Domain D2, double Tol, bool Reverse)
		{
			throw new NotImplementedException();
		}


	}; // class Bisector_Inter

}
