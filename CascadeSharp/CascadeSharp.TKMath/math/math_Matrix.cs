//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_Matrix
    //---------------------------------------------------------------------
    public sealed class math_Matrix
    {
        public math_Matrix(int LowerRow, int UpperRow, int LowerCol, int UpperCol)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_Matrix(int LowerRow, int UpperRow, int LowerCol, int UpperCol, double InitialValue)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_Matrix(IntPtr Tab, int LowerRow, int UpperRow, int LowerCol, int UpperCol)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_Matrix(math_Matrix Other)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_Matrix()
        {
            throw new NotImplementedException();
        }

        //TODO: those fields are private on c++?!?
        public int LowerRowIndex;
        public int UpperRowIndex;
        public int LowerColIndex;
        public int UpperColIndex;
        public math_DoubleTab Array;

        public void Init(double InitialValue)
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

        public int LowerRow()
        {
            throw new NotImplementedException();
        }

        public int UpperRow()
        {
            throw new NotImplementedException();
        }

        public int LowerCol()
        {
            throw new NotImplementedException();
        }

        public int UpperCol()
        {
            throw new NotImplementedException();
        }

        public double Determinant()
        {
            throw new NotImplementedException();
        }

        public void Transpose()
        {
            throw new NotImplementedException();
        }

        public void Invert()
        {
            throw new NotImplementedException();
        }

        public void Multiply(double Right)
        {
            throw new NotImplementedException();
        }

        public math_Matrix Multiplied(double Right)
        {
            throw new NotImplementedException();
        }

        public math_Matrix TMultiplied(double Right)
        {
            throw new NotImplementedException();
        }

        public void Divide(double Right)
        {
            throw new NotImplementedException();
        }

        public math_Matrix Divided(double Right)
        {
            throw new NotImplementedException();
        }

        public void Add(math_Matrix Right)
        {
            throw new NotImplementedException();
        }

        public math_Matrix Added(math_Matrix Right)
        {
            throw new NotImplementedException();
        }

        public void Add(math_Matrix Left, math_Matrix Right)
        {
            throw new NotImplementedException();
        }

        public void Subtract(math_Matrix Right)
        {
            throw new NotImplementedException();
        }

        public math_Matrix Subtracted(math_Matrix Right)
        {
            throw new NotImplementedException();
        }

        public void Set(int I1, int I2, int J1, int J2, math_Matrix M)
        {
            throw new NotImplementedException();
        }

        public void SetRow(int Row, Vector V)
        {
            throw new NotImplementedException();
        }

        public void SetCol(int Col, Vector V)
        {
            throw new NotImplementedException();
        }

        public void SetDiag(double Value)
        {
            throw new NotImplementedException();
        }

        public Vector Row(int Row)
        {
            throw new NotImplementedException();
        }

        public Vector Col(int Col)
        {
            throw new NotImplementedException();
        }

        public void SwapRow(int Row1, int Row2)
        {
            throw new NotImplementedException();
        }

        public void SwapCol(int Col1, int Col2)
        {
            throw new NotImplementedException();
        }

        public math_Matrix Transposed()
        {
            throw new NotImplementedException();
        }

        public math_Matrix Inverse()
        {
            throw new NotImplementedException();
        }

        public math_Matrix TMultiply(math_Matrix Right)
        {
            throw new NotImplementedException();
        }

        public void Multiply(Vector Left, Vector Right)
        {
            throw new NotImplementedException();
        }

        public void Multiply(math_Matrix Left, math_Matrix Right)
        {
            throw new NotImplementedException();
        }

        public void TMultiply(math_Matrix TLeft, math_Matrix Right)
        {
            throw new NotImplementedException();
        }

        public void Subtract(math_Matrix Left, math_Matrix Right)
        {
            throw new NotImplementedException();
        }

        public double Value(int Row, int Col)
        {
            throw new NotImplementedException();
        }

        public math_Matrix Initialized(math_Matrix Other)
        {
            throw new NotImplementedException();
        }

        public void Multiply(math_Matrix Right)
        {
            throw new NotImplementedException();
        }

        public math_Matrix Multiplied(math_Matrix Right)
        {
            throw new NotImplementedException();
        }

        public Vector Multiplied(Vector Right)
        {
            throw new NotImplementedException();
        }

        public math_Matrix Opposite()
        {
            throw new NotImplementedException();
        }

        public void SetLowerRow(int LowerRow)
        {
            throw new NotImplementedException();
        }

        public void SetLowerCol(int LowerCol)
        {
            throw new NotImplementedException();
        }

        public void SetLower(int LowerRow, int LowerCol)
        {
            throw new NotImplementedException();
        }
    }; // class math_Matrix
}