//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.PLib;

namespace CascadeSharp.TKGeomBase.FEmTool
{
    //---------------------------------------------------------------------
    //  Class  FEmTool_Curve
    //---------------------------------------------------------------------
    public sealed class FEmTool_Curve : Standard_Transient
    {
        public FEmTool_Curve(int Dimension, int NbElements, PLib_Base TheBase, double Tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public FEmTool_Curve(FEmTool_Curve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public FEmTool_Curve()
        {
            throw new NotImplementedException();
        }

        public TColStd_Array1OfReal Knots()
        {
            throw new NotImplementedException();
        }

        public void SetElement(int IndexOfElement, TColStd_Array2OfReal Coeffs)
        {
            throw new NotImplementedException();
        }

        public void D0(double U, TColStd_Array1OfReal Pnt)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, TColStd_Array1OfReal Vec)
        {
            throw new NotImplementedException();
        }

        public void D2(double U, TColStd_Array1OfReal Vec)
        {
            throw new NotImplementedException();
        }

        public void Length(double FirstU, double LastU, ref double Length)
        {
            throw new NotImplementedException();
        }

        public void GetElement(int IndexOfElement, TColStd_Array2OfReal Coeffs)
        {
            throw new NotImplementedException();
        }

        public void GetPolynom(TColStd_Array1OfReal Coeffs)
        {
            throw new NotImplementedException();
        }

        public int NbElements()
        {
            throw new NotImplementedException();
        }

        public int Dimension()
        {
            throw new NotImplementedException();
        }

        public PLib_Base Base()
        {
            throw new NotImplementedException();
        }

        public int Degree(int IndexOfElement)
        {
            throw new NotImplementedException();
        }

        public void SetDegree(int IndexOfElement, int Degree)
        {
            throw new NotImplementedException();
        }

        public void ReduceDegree(int IndexOfElement, double Tol, ref int NewDegree, ref double MaxError)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void Update(int Element, int Order)
        {
            throw new NotImplementedException();
        }
    }; // class FEmTool_Curve
}