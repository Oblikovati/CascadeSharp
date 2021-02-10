//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.GeomAdaptor;
using CascadeSharp.TKGeomAlgo.IntPatch;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GeomInt
{
	//---------------------------------------------------------------------
	//  Class  GeomInt_IntSS
	//---------------------------------------------------------------------
	public  sealed class GeomInt_IntSS
	{

		public GeomInt_IntSS()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_IntSS(Geom_Surface S1, Geom_Surface S2, double Tol, bool Approx, bool ApproxS1, bool ApproxS2)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_IntSS(Geom_Surface S1, Geom_Surface S2, double Tol, bool Approx, bool ApproxS1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_IntSS(Geom_Surface S1, Geom_Surface S2, double Tol, bool Approx)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_IntSS(Geom_Surface S1, Geom_Surface S2, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_IntSS(GeomInt_IntSS parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom_Surface S1, Geom_Surface S2, double Tol, bool Approx, bool ApproxS1, bool ApproxS2)
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom_Surface S1, Geom_Surface S2, double Tol, bool Approx, bool ApproxS1)
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom_Surface S1, Geom_Surface S2, double Tol, bool Approx)
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom_Surface S1, Geom_Surface S2, double Tol)
		{
			throw new NotImplementedException();
		}

		public void Perform(GeomAdaptor_HSurface HS1, GeomAdaptor_HSurface HS2, double Tol, bool Approx, bool ApproxS1, bool ApproxS2)
		{
			throw new NotImplementedException();
		}

		public void Perform(GeomAdaptor_HSurface HS1, GeomAdaptor_HSurface HS2, double Tol, bool Approx, bool ApproxS1)
		{
			throw new NotImplementedException();
		}

		public void Perform(GeomAdaptor_HSurface HS1, GeomAdaptor_HSurface HS2, double Tol, bool Approx)
		{
			throw new NotImplementedException();
		}

		public void Perform(GeomAdaptor_HSurface HS1, GeomAdaptor_HSurface HS2, double Tol)
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom_Surface S1, Geom_Surface S2, double Tol, double U1, double V1, double U2, double V2, bool Approx, bool ApproxS1, bool ApproxS2)
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom_Surface S1, Geom_Surface S2, double Tol, double U1, double V1, double U2, double V2, bool Approx, bool ApproxS1)
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom_Surface S1, Geom_Surface S2, double Tol, double U1, double V1, double U2, double V2, bool Approx)
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom_Surface S1, Geom_Surface S2, double Tol, double U1, double V1, double U2, double V2)
		{
			throw new NotImplementedException();
		}

		public void Perform(GeomAdaptor_HSurface HS1, GeomAdaptor_HSurface HS2, double Tol, double U1, double V1, double U2, double V2, bool Approx, bool ApproxS1, bool ApproxS2)
		{
			throw new NotImplementedException();
		}

		public void Perform(GeomAdaptor_HSurface HS1, GeomAdaptor_HSurface HS2, double Tol, double U1, double V1, double U2, double V2, bool Approx, bool ApproxS1)
		{
			throw new NotImplementedException();
		}

		public void Perform(GeomAdaptor_HSurface HS1, GeomAdaptor_HSurface HS2, double Tol, double U1, double V1, double U2, double V2, bool Approx)
		{
			throw new NotImplementedException();
		}

		public void Perform(GeomAdaptor_HSurface HS1, GeomAdaptor_HSurface HS2, double Tol, double U1, double V1, double U2, double V2)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public double TolReached3d()
		{
			throw new NotImplementedException();
		}

		public double TolReached2d()
		{
			throw new NotImplementedException();
		}

		public int NbLines()
		{
			throw new NotImplementedException();
		}

		public Geom_Curve Line(int Index)
		{
			throw new NotImplementedException();
		}

		public bool HasLineOnS1(int Index)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve LineOnS1(int Index)
		{
			throw new NotImplementedException();
		}

		public bool HasLineOnS2(int Index)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve LineOnS2(int Index)
		{
			throw new NotImplementedException();
		}

		public int NbBoundaries()
		{
			throw new NotImplementedException();
		}

		public Geom_Curve Boundary(int Index)
		{
			throw new NotImplementedException();
		}

		public int NbPoints()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Point(int Index)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d Pnt2d(int Index, bool OnFirst)
		{
			throw new NotImplementedException();
		}

		public void SetTolFixTangents(double aTolCheck, double aTolAngCheck)
		{
			throw new NotImplementedException();
		}

		public void TolFixTangents(ref double aTolCheck, ref double aTolAngCheck)
		{
			throw new NotImplementedException();
		}

		public void TreatRLine(IntPatch_RLine theRL, GeomAdaptor_HSurface theHS1, GeomAdaptor_HSurface theHS2, Geom_Curve theC3d, Geom2d_Curve theC2d1, Geom2d_Curve theC2d2, ref double theTolReached)
		{
			throw new NotImplementedException();
		}

		public void BuildPCurves(double f, double l, ref double Tol, Geom_Surface S, Geom_Curve C, Geom2d_Curve C2d)
		{
			throw new NotImplementedException();
		}

				public Geom_Curve MakeBSpline(IntPatch_WLine WL, int ideb, int ifin)
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve MakeBSpline2d(IntPatch_WLine theWLine, int ideb, int ifin, bool onFirst)
		{
			throw new NotImplementedException();
		}

		public void InternalPerform(double Tol, bool Approx, bool ApproxS1, bool ApproxS2, bool useStart, double U1, double V1, double U2, double V2)
		{
			throw new NotImplementedException();
		}

		public void MakeCurve(int Ind, Adaptor3d_TopolTool D1, Adaptor3d_TopolTool D2, double Tol, bool Approx, bool Approx1, bool Approx2)
		{
			throw new NotImplementedException();
		}


	}; // class GeomInt_IntSS

}
