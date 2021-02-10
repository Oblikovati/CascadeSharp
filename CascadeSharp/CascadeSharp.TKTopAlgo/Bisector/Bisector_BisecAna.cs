//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKGeomAlgo.GccInt;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.Bisector
{
    //---------------------------------------------------------------------
    //  Class  Bisector_BisecAna
    //---------------------------------------------------------------------
    public sealed class Bisector_BisecAna : Bisector_Curve
    {
        public Bisector_BisecAna()
            : base()
        {
            throw new NotImplementedException();
        }

        public Bisector_BisecAna(Bisector_BisecAna parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Perform(Geom2d_Curve Cu1, Geom2d_Curve Cu2, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, double Sense,
            GeomAbs_JoinType jointype, double Tolerance, bool oncurve)
        {
            throw new NotImplementedException();
        }

        public void Perform(Geom2d_Curve Cu1, Geom2d_Curve Cu2, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, double Sense,
            GeomAbs_JoinType jointype, double Tolerance)
        {
            throw new NotImplementedException();
        }

        public void Perform(Geom2d_Curve Cu, Geom2d_Point Pnt, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, double Sense,
            double Tolerance, bool oncurve)
        {
            throw new NotImplementedException();
        }

        public void Perform(Geom2d_Curve Cu, Geom2d_Point Pnt, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, double Sense,
            double Tolerance)
        {
            throw new NotImplementedException();
        }

        public void Perform(Geom2d_Point Pnt, Geom2d_Curve Cu, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, double Sense,
            double Tolerance, bool oncurve)
        {
            throw new NotImplementedException();
        }

        public void Perform(Geom2d_Point Pnt, Geom2d_Curve Cu, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, double Sense,
            double Tolerance)
        {
            throw new NotImplementedException();
        }

        public void Perform(Geom2d_Point Pnt1, Geom2d_Point Pnt2, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, double Sense,
            double Tolerance, bool oncurve)
        {
            throw new NotImplementedException();
        }

        public void Perform(Geom2d_Point Pnt1, Geom2d_Point Pnt2, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, double Sense,
            double Tolerance)
        {
            throw new NotImplementedException();
        }

        public void Perform(Geom2d_Point Pnt1, Geom2d_Point Pnt2, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, double Sense)
        {
            throw new NotImplementedException();
        }

        public void Init(Geom2d_TrimmedCurve b_isector)
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

        public void SetTrim(Geom2d_Curve Cu)
        {
            throw new NotImplementedException();
        }

        public void SetTrim(double uf, double ul)
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

        public bool IsClosed()
        {
            throw new NotImplementedException();
        }

        public bool IsPeriodic()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity()
        {
            throw new NotImplementedException();
        }

        public void D0(double U, gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, gp_Pnt2d P, gp_Vec2d V1)
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

        public Geom2d_Curve Geom2dCurve()
        {
            throw new NotImplementedException();
        }

        public double Parameter(gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public double ParameterOfStartPoint()
        {
            throw new NotImplementedException();
        }

        public double ParameterOfEndPoint()
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

        public double Distance(gp_Pnt2d P, GccInt_Bisec B_is, gp_Vec2d V1, gp_Vec2d V2, gp_Vec2d VecRef, double Sense,
            ref double U, ref bool sense, ref bool ok, bool IsB_isecOfTwoLines)
        {
            throw new NotImplementedException();
        }

        public double Distance(gp_Pnt2d P, GccInt_Bisec B_is, gp_Vec2d V1, gp_Vec2d V2, gp_Vec2d VecRef, double Sense,
            ref double U, ref bool sense, ref bool ok)
        {
            throw new NotImplementedException();
        }
    }; // class Bisector_BisecAna
}