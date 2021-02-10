//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKGeomAlgo.Law
{
    //---------------------------------------------------------------------
    //  Class  Law_Function
    //---------------------------------------------------------------------
    public abstract class Law_Function : Standard_Transient
    {
        public Law_Function(Law_Function parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Law_Function()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
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
    }; // class Law_Function
}