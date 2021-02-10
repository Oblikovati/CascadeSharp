//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomBase.FEmTool
{
    //---------------------------------------------------------------------
    //  Class  FEmTool_LinearTension
    //---------------------------------------------------------------------
    public sealed class FEmTool_LinearTension : FEmTool_ElementaryCriterion
    {
        public FEmTool_LinearTension(int WorkDegree, GeomAbs_Shape ConstraintOrder)
            : base()
        {
            throw new NotImplementedException();
        }

        public FEmTool_LinearTension(FEmTool_LinearTension parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public FEmTool_LinearTension()
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

        public void Hessian(int Dimension1, int Dimension2, math_Matrix H)
        {
            throw new NotImplementedException();
        }

        public void Gradient(int Dimension, Vector G)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class FEmTool_LinearTension
}