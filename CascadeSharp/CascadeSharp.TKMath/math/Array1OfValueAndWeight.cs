//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.NCollection;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  Array1OfValueAndWeight
    //---------------------------------------------------------------------
    public sealed class Array1OfValueAndWeight : Array1<ValueAndWeight>
    {
        public Array1OfValueAndWeight()
            : base(0,1)
        {

        }

        public Array1OfValueAndWeight(int theLower, int theUpper)
            : base(theLower, theUpper)
        {

        }

        public Array1OfValueAndWeight(Array1OfValueAndWeight theOther)
            : base(theOther)
        {

        }

        public Array1OfValueAndWeight(ValueAndWeight theBegin, int theLower, int theUpper)
            : base(theLower,theUpper)
        {
            Init(theBegin);
        }

        public Array1OfValueAndWeight Assign(Array1OfValueAndWeight theOther)
        {
            return (Array1OfValueAndWeight) base.Assign(theOther);
        }

        public Array1OfValueAndWeight Move(Array1OfValueAndWeight theOther)
        {
            return (Array1OfValueAndWeight) base.Move(theOther);
        }

    }; // class Array1OfValueAndWeight
}