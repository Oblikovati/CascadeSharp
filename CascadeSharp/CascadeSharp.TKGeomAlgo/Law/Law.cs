//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Adaptor3d;

namespace CascadeSharp.TKGeomAlgo.Law
{
    //---------------------------------------------------------------------
    //  Class  Law
    //---------------------------------------------------------------------
    public sealed class Law
    {
        public Law()
            : base()
        {
            throw new NotImplementedException();
        }

        public Law(Law parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Law_BSpFunc MixBnd(Law_Linear Lin)
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray1OfReal MixBnd(int Degree, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults,
            Law_Linear Lin)
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray1OfReal MixTgt(int Degree, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults,
            bool NulOnTheRight, int Index)
        {
            throw new NotImplementedException();
        }

        public Law_BSpline Reparametrize(Adaptor3d_Curve Curve, double First, double Last, bool HasDF, bool HasDL,
            double DFirst, double DLast, bool Rev, int NbPoints)
        {
            throw new NotImplementedException();
        }

        public Law_BSpline Scale(double First, double Last, bool HasF, bool HasL, double VFirst, double VLast)
        {
            throw new NotImplementedException();
        }

        public Law_BSpline ScaleCub(double First, double Last, bool HasF, bool HasL, double VFirst, double VLast)
        {
            throw new NotImplementedException();
        }
    }; // class Law
}