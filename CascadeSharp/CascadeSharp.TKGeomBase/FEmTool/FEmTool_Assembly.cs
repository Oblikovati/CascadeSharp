//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomBase.FEmTool
{
    //---------------------------------------------------------------------
    //  Class  FEmTool_Assembly
    //---------------------------------------------------------------------
    public sealed class FEmTool_Assembly
    {
        public FEmTool_Assembly(TColStd_Array2OfInteger Dependence, FEmTool_HAssemblyTable Table)
            : base()
        {
            throw new NotImplementedException();
        }

        public FEmTool_Assembly(FEmTool_Assembly parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public FEmTool_Assembly()
        {
            throw new NotImplementedException();
        }

        public void NullifyMatrix()
        {
            throw new NotImplementedException();
        }

        public void AddMatrix(int Element, int Dimension1, int Dimension2, math_Matrix Mat)
        {
            throw new NotImplementedException();
        }

        public void NullifyVector()
        {
            throw new NotImplementedException();
        }

        public void AddVector(int Element, int Dimension, Vector Vec)
        {
            throw new NotImplementedException();
        }

        public void ResetConstraint()
        {
            throw new NotImplementedException();
        }

        public void NullifyConstraint()
        {
            throw new NotImplementedException();
        }

        public void AddConstraint(int IndexofConstraint, int Element, int Dimension, Vector LinearForm,
            double Value)
        {
            throw new NotImplementedException();
        }

        public bool Solve()
        {
            throw new NotImplementedException();
        }

        public void Solution(Vector Solution)
        {
            throw new NotImplementedException();
        }

        public int NbGlobVar()
        {
            throw new NotImplementedException();
        }

        public void GetAssemblyTable(FEmTool_HAssemblyTable AssTable)
        {
            throw new NotImplementedException();
        }
    }; // class FEmTool_Assembly
}