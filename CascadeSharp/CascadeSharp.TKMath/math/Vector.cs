//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  Vector
    //---------------------------------------------------------------------
    public sealed class Vector : List<double>
    {
        public Vector(int theLower, int theUpper)
            : base(theUpper - theLower)
        {
            if (theLower > theUpper)
                throw new ArgumentOutOfRangeException(nameof(theLower));
        }
        
        public Vector(int theLower, int theUpper, double theInitialValue)
            : base(theUpper - theLower)
        {
            if (theLower > theUpper)
                throw new ArgumentOutOfRangeException(nameof(theLower));
        }

        public Vector(double theTab, int theLower, int theUpper)
            : base(theUpper - theLower)
        {
            if(theLower > theUpper)
                throw new ArgumentOutOfRangeException(nameof(theLower));
        }

        public Vector(gp_XY Other)
            :base(2)
        {
            Add(Other.X());
            Add(Other.Y());
        }

        public Vector(gp_XYZ Other)
            :base(3)
        {
            Add(Other.X());
            Add(Other.Y());
            Add(Other.Z());
        }

        public Vector(Vector theOther)
        {
            AddRange(theOther.ToArray());
        }

        public Vector()
            :base(1)
        {
            
        }

        public void Init(double theInitialValue)
        {
            while (Count < Capacity)
            {
                Add(theInitialValue);
            }

            for (var i = 0; i < Count; i++)
            {
                this[i] = theInitialValue;
            }
        }

        public int Length()
        {
            return Count;
        }

        public int Lower()
        {
            return 0;
        }

        public int Upper()
        {
            return Count;
        }

        public double Norm()
        {
            double result = 0;

            foreach (var d in this)
            {
                result += d * d;
            }

            return result.Sqrt();
        }

        public double Norm2()
        {
            return Norm();
        }

        public int Max()
        {
            int i = 0;
            double x = Double.MinValue;
            for (int idx =0; idx< Count;idx++)
            {
                if (this[idx] > x)
                {
                    x = this[idx];
                    i = idx;
                }
            }

            return i;
        }

        public int Min()
        {
            int i = 0;
            double x = Double.MaxValue;
            for (int idx = 0; idx < Count; idx++)
            {
                if (this[idx] < x)
                {
                    x = this[idx];
                    i = idx;
                }
            }

            return i;
        }

        public void Normalize()
        {
            var result = Norm();
            if(result <= double.Epsilon)
            {
                throw new ArithmeticException("Vector.Normalize() - vector has zero norm");
            }

            for (var idx = Lower(); idx <= Upper(); idx++)
            {
                this[idx] = this[idx] / result;
            }
        }

        public Vector Normalized()
        {
            var n = new Vector();
            n.AddRange(this.ToArray());
            n.Normalize();
            return n;
        }

        public void Invert()
        {
            for (var Index = Lower(); Index <= (Lower() + Length()) >> 1; Index++)
            {
                var J = Upper() + Lower() - Index;
                var aTemp = this[Index];
                this[Index] = this[J];
                this[J] = aTemp;
            }
        }

        public Vector Inverse()
        {
            var n = new Vector();
            n.AddRange(this.ToArray());
            n.Invert();
            return n;
        }

        public void Set(int theI1, int theI2, Vector theV)
        {
            if((theI1 < Lower()) || (theI2 > Upper())
                                 || (theI1 > theI2) 
                                 || (theI2 - theI1 + 1 != theV.Length()))
            {
                throw new ArgumentOutOfRangeException(nameof(theI1));
            }

            var l = theV.Lower();
            for (var i = theI1; i < theI2; i++)
            {
                this[i] = theV[l];
                l++;
            }
        }

        public Vector Slice(int theI1, int theI2)
        {
            if ((theI1 < Lower()) || (theI1 > Upper()) || (theI2 < Lower()) || (theI2 > Upper()))
            {
                throw new ArgumentOutOfRangeException(nameof(theI1));
            }
            if (theI2 >= theI1)
            {
                var Result = new Vector(theI1, theI2);
                for (int Index = theI1; Index <= theI2; Index++)
                {
                    Result.Add(this[Index]);
                }
                return Result;
            }
            else
            {
                var Result = new Vector(theI2, theI1);
                for (int Index = theI1; Index >= theI2; Index--)
                {
                    Result.Add(this[Index]);
                }
                return Result;
            }
        }

        public void Multiply(double theRight)
        {
            for (int Index = Lower(); Index <= Upper(); Index++)
            {
                this[Index] = this[Index] * theRight;
            }
        }

        public Vector Multiplied(double theRight)
        {
            var n = new Vector();
            n.AddRange(this.ToArray());
            n.Multiply(theRight);
            return n;
        }

        public Vector TMultiplied(double theRight)
        {
            return Multiplied(theRight);
        }

        public void Divide(double theRight)
        {
            if(theRight.Abs() <= double.Epsilon)
                throw new ArithmeticException("Divisor is zero");
            for (int Index = Lower(); Index <= Upper(); Index++)
            {
                this[Index] = this[Index] / theRight;
            }
        }

        public Vector Divided(double theRight)
        {
            var n = new Vector();
            n.AddRange(this.ToArray());
            n.Divide(theRight);
            return n;
        }

        public void Add(Vector theRight)
        {
            if(Length() != theRight.Length())
                throw new ArgumentOutOfRangeException(nameof(theRight),"Vector.Add() - input vector has wrong dimensions");

            var I = theRight.Lower();
            for (var Index = Lower(); Index <= Upper(); Index++)
            {
                this[Index] = this[Index] + theRight[I];
                I++;
            }
        }

        public Vector Added(Vector theRight)
        {
            var n = new Vector();
            n.AddRange(this.ToArray());
            n.Add(theRight);
            return n;
        }

        public void Multiply(Vector theLeft, math_Matrix theRight)
        {
            if((Length() != theRight.ColNumber()) || (theLeft.Length() != theRight.RowNumber()))
                throw new ArgumentOutOfRangeException(nameof(theLeft),
                "Vector.Multiply() - input matrix and/or vector have wrong dimensions");

            var Index = Lower();
            for (var J = theRight.LowerColIndex; J <= theRight.UpperColIndex; J++)
            {
                this[Index] = 0.0;
                var K = theLeft.Lower();
                for (var I = theRight.LowerRowIndex; I <= theRight.UpperRowIndex; I++)
                {
                    this[Index] = this[Index] + theLeft[K] * theRight.Array[I, J];
                    K++;
                }
                Index++;
            }
        }

        public void Multiply(math_Matrix theLeft, Vector theRight)
        {
            if ((Length() != theLeft.RowNumber()) || (theLeft.ColNumber() != theRight.Length()))
                throw new ArgumentOutOfRangeException(nameof(theLeft),
                    "Vector::Multiply() - input matrix and/or vector have wrong dimensions");

            var Index = Lower();
            for (var I = theLeft.LowerRowIndex; I <= theLeft.UpperRowIndex; I++)
            {
                this[Index] = 0.0;
                var K = theRight.Lower();
                for (var J = theLeft.LowerColIndex; J <= theLeft.UpperColIndex; J++)
                {
                    this[Index] = this[Index] + theLeft.Array[I, J] * theRight[K];
                    K++;
                }
                Index++;
            }
        }

        public void TMultiply(math_Matrix theTLeft, Vector theRight)
        {
            Multiply(theTLeft,theRight);
        }

        public void TMultiply(Vector theLeft, math_Matrix theTRight)
        {
            Multiply(theLeft,theTRight);
        }

        public void Add(Vector theLeft, Vector theRight)
        {
            if((Length() != theRight.Length()) || (theRight.Length() != theLeft.Length()))
                throw new ArgumentOutOfRangeException(nameof(theLeft),
                "Vector.Add() - input vectors have wrong dimensions");

            var I = theLeft.Lower();
            var J = theRight.Lower();
            for (var Index = Lower(); Index <= Upper(); Index++)
            {
                this[Index] = theLeft[I] + theRight[J];
                I++;
                J++;
            }
        }

        public void Subtract(Vector theLeft, Vector theRight)
        {
            if ((Length() != theRight.Length()) || (theRight.Length() != theLeft.Length()))
                throw new ArgumentOutOfRangeException(nameof(theLeft),
                    "Vector.Subtract() - input vectors have wrong dimensions");

            var I = theLeft.Lower();
            var J = theRight.Lower();
            for (var Index = Lower(); Index <= Upper(); Index++)
            {
                this[Index] = theLeft[I] - theRight[J];
                I++;
                J++;
            }
        }

        public void SetValue(int index, double value)
        {
            this[index] = value;
        }
        public double GetValue(int index)
        {
            return this[index];
        }


        public Vector Initialized(Vector theOther)
        {
            if (Length() != theOther.Length())
                throw new ArgumentOutOfRangeException(nameof(theOther),
            "Vector.Initialized() - input vector has wrong dimensions");
            this.Clear();
            foreach (var v in theOther)
            {
                Add(v);
            }

            return this;
        }

        public double Multiplied(Vector theRight)
        {
            double Result = 0;

            if(Length() != theRight.Length())
                throw new ArgumentOutOfRangeException(nameof(theRight),
                "Vector.Multiplied() - input vector has wrong dimensions");

            var I = theRight.Lower();
            for (var Index = Lower(); Index <= Upper(); Index++)
            {
                Result = Result + this[Index] * theRight[I];
                I++;
            }
            return Result;
        }

        public Vector Multiplied(math_Matrix theRight)
        {
            if(Length() != theRight.RowNumber())
                throw new ArgumentOutOfRangeException(nameof(theRight),
                "Vector.Multiplied() - input matrix has wrong dimensions");

            var Result = new Vector(theRight.LowerColIndex, theRight.UpperColIndex);

            for (var J2 = theRight.LowerColIndex; J2 <= theRight.UpperColIndex; J2++)
            {
                Result[J2] = 0.0;
                var theI2 = theRight.LowerRowIndex;
                for (var I = Lower(); I <= Upper(); I++)
                {
                    Result[J2] = Result[J2] + this[I] * theRight.Array[theI2, J2];
                    theI2++;
                }
            }
            return Result;
        }

        public Vector Opposite()
        {
            var v = new Vector();
            foreach (var ov in this)
            {
                v.Add(-ov);
            }
            return v;
        }

        public void Subtract(Vector theRight)
        {
            if (Length() != theRight.Length())
                throw new ArgumentOutOfRangeException(nameof(theRight),
            "Vector.Subtract() - input vector has wrong dimensions");

            var I = theRight.Lower();
            for (var Index = Lower(); Index <= Upper(); Index++)
            {
                this[Index] = this[Index] - theRight[I];
                I++;
            }
        }

        public Vector Subtracted(Vector theRight)
        {
            var v = new Vector(this);
            v.Subtract(theRight);
            return v;
        }

        public void Multiply(double theLeft, Vector theRight)
        {
            if ((Length() != theRight.Length()))
                throw new ArgumentOutOfRangeException(nameof(theRight),
            "Vector.Multiply() - input vector has wrong dimensions");
            for (var I = Lower(); I <= Upper(); I++)
            {
                this[I] = theLeft * theRight[I];
            }
        }
    }; // class Vector
}