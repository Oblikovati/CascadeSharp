//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomBase.FEmTool
{
    //---------------------------------------------------------------------
    //  Class  FEmTool_SparseMatrix
    //---------------------------------------------------------------------
    public abstract class FEmTool_SparseMatrix : Standard_Transient
    {
        public FEmTool_SparseMatrix(FEmTool_SparseMatrix parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FEmTool_SparseMatrix()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
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

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class FEmTool_SparseMatrix
}