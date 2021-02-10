//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomBase.FEmTool
{
    //---------------------------------------------------------------------
    //  Class  FEmTool_ElementaryCriterion
    //---------------------------------------------------------------------
    public abstract class FEmTool_ElementaryCriterion : Standard_Transient
    {
        public FEmTool_ElementaryCriterion()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FEmTool_ElementaryCriterion(FEmTool_ElementaryCriterion parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void Set(TColStd_HArray2OfReal Coeff)
        {
            throw new NotImplementedException();
        }

        public void Set(double FirstKnot, double LastKnot)
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray2OfInteger DependenceTable()
        {
            throw new NotImplementedException();
        }

        public double Value()
        {
            throw new NotImplementedException();
        }

        public void Hessian(int Dim1, int Dim2, math_Matrix H)
        {
            throw new NotImplementedException();
        }

        public void Gradient(int Dim, math_Vector G)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class FEmTool_ElementaryCriterion
}