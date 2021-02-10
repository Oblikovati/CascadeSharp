//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKGeomAlgo.Law
{
    //---------------------------------------------------------------------
    //  Class  Law_Composite
    //---------------------------------------------------------------------
    public sealed class Law_Composite : Law_Function
    {
        public Law_Composite()
            : base()
        {
            throw new NotImplementedException();
        }

        public Law_Composite(double First, double Last, double Tol)
            : base()
        {
            throw new NotImplementedException();
        }

        public Law_Composite(Law_Composite parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity()
        {
            throw new NotImplementedException();
        }

        public int NbIntervals(GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public void Intervals(TColStd_Array1OfReal T, GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public double Value(double X)
        {
            throw new NotImplementedException();
        }

        public void D1(double X, ref double F, ref double D)
        {
            throw new NotImplementedException();
        }

        public void D2(double X, ref double F, ref double D, ref double D2)
        {
            throw new NotImplementedException();
        }

        public Law_Function Trim(double PFirst, double PLast, double Tol)
        {
            throw new NotImplementedException();
        }

        public void Bounds(ref double PFirst, ref double PLast)
        {
            throw new NotImplementedException();
        }

        public Law_Function ChangeElementaryLaw(double W)
        {
            throw new NotImplementedException();
        }

        public Law_Laws ChangeLaws()
        {
            throw new NotImplementedException();
        }

        public bool IsPeriodic()
        {
            throw new NotImplementedException();
        }

        public void SetPeriodic()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void Prepare(ref double W)
        {
            throw new NotImplementedException();
        }
    }; // class Law_Composite
}