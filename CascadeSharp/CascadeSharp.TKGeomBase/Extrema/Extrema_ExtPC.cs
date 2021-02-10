//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomBase.Extrema
{
    //---------------------------------------------------------------------
    //  Class  Extrema_ExtPC
    //---------------------------------------------------------------------
    public sealed class Extrema_ExtPC
    {
        public Extrema_ExtPC()
            : base()
        {
            throw new NotImplementedException();
        }

        public Extrema_ExtPC(gp_Pnt P, Adaptor3d_Curve C, double Uinf, double Usup, double TolF)
            : base()
        {
            throw new NotImplementedException();
        }

        public Extrema_ExtPC(gp_Pnt P, Adaptor3d_Curve C, double Uinf, double Usup)
            : base()
        {
            throw new NotImplementedException();
        }

        public Extrema_ExtPC(gp_Pnt P, Adaptor3d_Curve C, double TolF)
            : base()
        {
            throw new NotImplementedException();
        }

        public Extrema_ExtPC(gp_Pnt P, Adaptor3d_Curve C)
            : base()
        {
            throw new NotImplementedException();
        }

        public Extrema_ExtPC(Extrema_ExtPC parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Initialize(Adaptor3d_Curve C, double Uinf, double Usup, double TolF)
        {
            throw new NotImplementedException();
        }

        public void Initialize(Adaptor3d_Curve C, double Uinf, double Usup)
        {
            throw new NotImplementedException();
        }

        public void Perform(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public double SquareDistance(int N)
        {
            throw new NotImplementedException();
        }

        public int NbExt()
        {
            throw new NotImplementedException();
        }

        public bool IsMin(int N)
        {
            throw new NotImplementedException();
        }

        public Extrema_POnCurv Point(int N)
        {
            throw new NotImplementedException();
        }

        public void TrimmedSquareDistances(ref double d_ist1, ref double d_ist2, gp_Pnt P1, gp_Pnt P2)
        {
            throw new NotImplementedException();
        }

        public void IntervalPerform(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void AddSol(double theU, gp_Pnt theP, double theSqD_ist, bool _isMin)
        {
            throw new NotImplementedException();
        }
    }; // class Extrema_ExtPC
}