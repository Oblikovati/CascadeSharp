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
    //  Class  FEmTool_ProfileMatrix
    //---------------------------------------------------------------------
    public sealed class FEmTool_ProfileMatrix : FEmTool_SparseMatrix
    {
        public FEmTool_ProfileMatrix(TColStd_Array1OfInteger FirstIndexes)
            : base()
        {
            throw new NotImplementedException();
        }

        public FEmTool_ProfileMatrix(FEmTool_ProfileMatrix parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public FEmTool_ProfileMatrix()
        {
            throw new NotImplementedException();
        }

        public void Init(double Value)
        {
            throw new NotImplementedException();
        }

        public double ChangeValue(int I, int J)
        {
            throw new NotImplementedException();
        }

        public bool Decompose()
        {
            throw new NotImplementedException();
        }

        public void Solve(Vector B, Vector X)
        {
            throw new NotImplementedException();
        }

        public bool Prepare()
        {
            throw new NotImplementedException();
        }

        public void Solve(Vector B, Vector Init, Vector X, Vector Residual, double Tolerance,
            int NbIterations)
        {
            throw new NotImplementedException();
        }

        public void Solve(Vector B, Vector Init, Vector X, Vector Residual, double Tolerance)
        {
            throw new NotImplementedException();
        }

        public void Solve(Vector B, Vector Init, Vector X, Vector Residual)
        {
            throw new NotImplementedException();
        }

        public void Multiplied(Vector X, Vector MX)
        {
            throw new NotImplementedException();
        }

        public int RowNumber()
        {
            throw new NotImplementedException();
        }

        public int ColNumber()
        {
            throw new NotImplementedException();
        }

        public bool IsInProfile(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void OutM()
        {
            throw new NotImplementedException();
        }

        public void OutS()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class FEmTool_ProfileMatrix
}