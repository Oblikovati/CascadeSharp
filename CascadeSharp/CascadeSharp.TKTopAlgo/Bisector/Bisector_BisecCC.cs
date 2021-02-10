//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.Bisector
{
	//---------------------------------------------------------------------
	//  Class  Bisector_BisecCC
	//---------------------------------------------------------------------
	public  sealed class Bisector_BisecCC : Bisector_Curve
	{

		public Bisector_BisecCC()
			: base()
		{
			throw new NotImplementedException();
		}

		public Bisector_BisecCC(Geom2d_Curve Cu1, Geom2d_Curve Cu2, double Side1, double Side2, gp_Pnt2d Origin, double D_istMax)
			: base()
		{
			throw new NotImplementedException();
		}

		public Bisector_BisecCC(Geom2d_Curve Cu1, Geom2d_Curve Cu2, double Side1, double Side2, gp_Pnt2d Origin)
			: base()
		{
			throw new NotImplementedException();
		}

		public Bisector_BisecCC(Bisector_BisecCC parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom2d_Curve Cu1, Geom2d_Curve Cu2, double Side1, double Side2, gp_Pnt2d Origin, double D_istMax)
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom2d_Curve Cu1, Geom2d_Curve Cu2, double Side1, double Side2, gp_Pnt2d Origin)
		{
			throw new NotImplementedException();
		}

		public bool IsExtendAtStart()
		{
			throw new NotImplementedException();
		}

		public bool IsExtendAtEnd()
		{
			throw new NotImplementedException();
		}

		public void Reverse()
		{
			throw new NotImplementedException();
		}

		public double ReversedParameter(double U)
		{
			throw new NotImplementedException();
		}

		public bool IsCN(int N)
		{
			throw new NotImplementedException();
		}

		public Bisector_BisecCC ChangeGuide()
		{
			throw new NotImplementedException();
		}

		public Geom2d_Geometry Copy()
		{
			throw new NotImplementedException();
		}

		public void Transform(gp_Trsf2d T)
		{
			throw new NotImplementedException();
		}

		public double FirstParameter()
		{
			throw new NotImplementedException();
		}

		public double LastParameter()
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public int NbIntervals()
		{
			throw new NotImplementedException();
		}

		public double IntervalFirst(int Index)
		{
			throw new NotImplementedException();
		}

		public double IntervalLast(int Index)
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape IntervalContinuity()
		{
			throw new NotImplementedException();
		}

		public bool IsClosed()
		{
			throw new NotImplementedException();
		}

		public bool IsPeriodic()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d ValueAndDist(double U, ref double U1, ref double U2, ref double D_istance)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d ValueByInt(double U, ref double U1, ref double U2, ref double D_istance)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, gp_Pnt2d P, gp_Vec2d V)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, gp_Vec2d V3)
		{
			throw new NotImplementedException();
		}

		public gp_Vec2d DN(double U, int N)
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			throw new NotImplementedException();
		}

		public double LinkBisCurve(double U)
		{
			throw new NotImplementedException();
		}

		public double LinkCurveBis(double U)
		{
			throw new NotImplementedException();
		}

		public double Parameter(gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve Curve(int IndCurve)
		{
			throw new NotImplementedException();
		}

		public Bisector_PolyBis Polygon()
		{
			throw new NotImplementedException();
		}

		public void Dump(int Deep, int Offset)
		{
			throw new NotImplementedException();
		}

		public void Dump(int Deep)
		{
			throw new NotImplementedException();
		}

		public void Dump()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Values(double U, int N, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, gp_Vec2d V3)
		{
			throw new NotImplementedException();
		}

		public void SupLastParameter()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d Extension(double U, ref double U1, ref double U2, ref double D_ist, gp_Vec2d T1)
		{
			throw new NotImplementedException();
		}

		public double SearchBound(double U1, double U2)
		{
			throw new NotImplementedException();
		}

		public void ComputePointEnd()
		{
			throw new NotImplementedException();
		}

		public void Curve(int Index, Geom2d_Curve C)
		{
			throw new NotImplementedException();
		}

		public void Sign(int Index, double Sign)
		{
			throw new NotImplementedException();
		}

		public void Polygon(Bisector_PolyBis Poly)
		{
			throw new NotImplementedException();
		}

		public void DistMax(double D_istMax)
		{
			throw new NotImplementedException();
		}

		public void IsConvex(int Index, bool IsConvex)
		{
			throw new NotImplementedException();
		}

		public void IsEmpty(bool IsEmpty)
		{
			throw new NotImplementedException();
		}

		public void ExtensionStart(bool ExtensionStart)
		{
			throw new NotImplementedException();
		}

		public void ExtensionEnd(bool ExtensionEnd)
		{
			throw new NotImplementedException();
		}

		public void PointStart(gp_Pnt2d Point)
		{
			throw new NotImplementedException();
		}

		public void PointEnd(gp_Pnt2d Point)
		{
			throw new NotImplementedException();
		}

		public void StartIntervals(TColStd_SequenceOfReal StartIntervals)
		{
			throw new NotImplementedException();
		}

		public void EndIntervals(TColStd_SequenceOfReal EndIntervals)
		{
			throw new NotImplementedException();
		}

		public void FirstParameter(double U1)
		{
			throw new NotImplementedException();
		}

		public void LastParameter(double U1)
		{
			throw new NotImplementedException();
		}


	}; // class Bisector_BisecCC

}
