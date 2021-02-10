//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_Vector
    //---------------------------------------------------------------------
    public sealed class math_Vector
    {
        public math_Vector(int theLower, int theUpper)
        {
            myLocArray =  new List<double>(theUpper - theLower + 1);

        }

        public math_Vector(int theLower, int theUpper, double theInitialValue)
        {
            throw new NotImplementedException();
        }

        public math_Vector(double theTab, int theLower, int theUpper)
        {
            throw new NotImplementedException();
        }

        public math_Vector(gp_XY Other)
        {
            throw new NotImplementedException();
        }

        public math_Vector(gp_XYZ Other)
        {
            throw new NotImplementedException();
        }

        public math_Vector(math_Vector theOther)
        {
            throw new NotImplementedException();
        }

        public math_Vector()
        {
            myLocArray = new List<double>(512);
            Array = new List<double>();
        }

        #region Private Objects

        private List<double> myLocArray;
        private List<double> Array;

        #endregion

        public void Init(double theInitialValue)
        {
            throw new NotImplementedException();
        }

        public int Length()
        {
            throw new NotImplementedException();
        }

        public int Lower()
        {
            throw new NotImplementedException();
        }

        public int Upper()
        {
            throw new NotImplementedException();
        }

        public double Norm()
        {
            throw new NotImplementedException();
        }

        public double Norm2()
        {
            throw new NotImplementedException();
        }

        public int Max()
        {
            throw new NotImplementedException();
        }

        public int Min()
        {
            throw new NotImplementedException();
        }

        public void Normalize()
        {
            throw new NotImplementedException();
        }

        public math_Vector Normalized()
        {
            throw new NotImplementedException();
        }

        public void Invert()
        {
            throw new NotImplementedException();
        }

        public math_Vector Inverse()
        {
            throw new NotImplementedException();
        }

        public void Set(int theI1, int theI2, math_Vector theV)
        {
            throw new NotImplementedException();
        }

        public math_Vector Slice(int theI1, int theI2)
        {
            throw new NotImplementedException();
        }

        public void Multiply(double theRight)
        {
            throw new NotImplementedException();
        }

        public math_Vector Multiplied(double theRight)
        {
            throw new NotImplementedException();
        }

        public math_Vector TMultiplied(double theRight)
        {
            throw new NotImplementedException();
        }

        public void Divide(double theRight)
        {
            throw new NotImplementedException();
        }

        public math_Vector Divided(double theRight)
        {
            throw new NotImplementedException();
        }

        public void Add(math_Vector theRight)
        {
            throw new NotImplementedException();
        }

        public math_Vector Added(math_Vector theRight)
        {
            throw new NotImplementedException();
        }

        public void Multiply(math_Vector theLeft, math_Matrix theRight)
        {
            throw new NotImplementedException();
        }

        public void Multiply(math_Matrix theLeft, math_Vector theRight)
        {
            throw new NotImplementedException();
        }

        public void TMultiply(math_Matrix theTLeft, math_Vector theRight)
        {
            throw new NotImplementedException();
        }

        public void TMultiply(math_Vector theLeft, math_Matrix theTRight)
        {
            throw new NotImplementedException();
        }

        public void Add(math_Vector theLeft, math_Vector theRight)
        {
            throw new NotImplementedException();
        }

        public void Subtract(math_Vector theLeft, math_Vector theRight)
        {
            throw new NotImplementedException();
        }

        public void SetValue(int index, double value)
        {
            Array[index] = value;
        }
        public double GetValue(int index)
        {
            return Array[index];
        }


        public math_Vector Initialized(math_Vector theOther)
        {
            throw new NotImplementedException();
        }

        public double Multiplied(math_Vector theRight)
        {
            throw new NotImplementedException();
        }

        public math_Vector Multiplied(math_Matrix theRight)
        {
            throw new NotImplementedException();
        }

        public math_Vector Opposite()
        {
            throw new NotImplementedException();
        }

        public void Subtract(math_Vector theRight)
        {
            throw new NotImplementedException();
        }

        public math_Vector Subtracted(math_Vector theRight)
        {
            throw new NotImplementedException();
        }

        public void Multiply(double theLeft, math_Vector theRight)
        {
            throw new NotImplementedException();
        }

        public void SetLower(int theLower)
        {
            throw new NotImplementedException();
        }
    }; // class math_Vector
}