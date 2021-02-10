//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Bisector_BisecPC
	//---------------------------------------------------------------------
	public  sealed class Bisector_BisecPC : CascadeSharp.Bisector_Curve
	{

		public Bisector_BisecPC()
			: base()
		{
			throw new NotImplementedException();
		}

		public Bisector_BisecPC(Geom2d_Curve Cu, gp_Pnt2d P, double Side, double D_istMax)
			: base()
		{
			throw new NotImplementedException();
		}

		public Bisector_BisecPC(Geom2d_Curve Cu, gp_Pnt2d P, double Side)
			: base()
		{
			throw new NotImplementedException();
		}

		public Bisector_BisecPC(Geom2d_Curve Cu, gp_Pnt2d P, double Side, double UMin, double UMax)
			: base()
		{
			throw new NotImplementedException();
		}

		public Bisector_BisecPC(Bisector_BisecPC parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom2d_Curve Cu, gp_Pnt2d P, double Side, double D_istMax)
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom2d_Curve Cu, gp_Pnt2d P, double Side)
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

		public Geom2d_Geometry Copy()
		{
			throw new NotImplementedException();
		}

		public void Transform(gp_Trsf2d T)
		{
			throw new NotImplementedException();
		}

		public bool IsCN(int N)
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

		public CascadeSharp.GeomAbs_Shape Continuity()
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

		public CascadeSharp.GeomAbs_Shape IntervalContinuity()
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

		public double Distance(double U)
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

		public bool IsEmpty()
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

		public void Extension(double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, gp_Vec2d V3)
		{
			throw new NotImplementedException();
		}

		public void ComputeIntervals()
		{
			throw new NotImplementedException();
		}

		public void CuspFilter()
		{
			throw new NotImplementedException();
		}

		public double SearchBound(double U1, double U2)
		{
			throw new NotImplementedException();
		}

		public void Init(Geom2d_Curve Curve, gp_Pnt2d Point, double Sign, TColStd_SequenceOfReal StartIntervals, TColStd_SequenceOfReal EndIntervals, int B_isInterval, int CurrentInterval, double ShiftParameter, double D_istMax, bool IsEmpty, bool IsConvex, bool ExtensionStart, bool ExtensionEnd, gp_Pnt2d PointStartB_is, gp_Pnt2d PointEndB_is)
		{
			throw new NotImplementedException();
		}


	}; // class Bisector_BisecPC

}
