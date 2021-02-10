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
    //  Class  Law_Linear
    //---------------------------------------------------------------------
    public sealed class Law_Linear : Law_Function
    {
        public Law_Linear()
            : base()
        {
            throw new NotImplementedException();
        }

        public Law_Linear(Law_Linear parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Set(double Pdeb, double Valdeb, double Pfin, double Valfin)
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

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Law_Linear
}