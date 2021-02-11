//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  ValueAndWeight
    //---------------------------------------------------------------------
    public sealed class ValueAndWeight
    {
        public ValueAndWeight()
            : base()
        {
            value = 0;
            weight = 0;
        }

        public ValueAndWeight(double theValue, double theWeight)
            : base()
        {
            value = theValue;
            weight = theWeight;
        }

        public ValueAndWeight(ValueAndWeight parameter1)
            : base()
        {
            value = parameter1.Value();
            weight = parameter1.Weight();
        }

        #region Private Objects

        private double value, weight;

        #endregion

        public double Value()
        {
            return value;
        }

        public double Weight()
        {
            return weight;
        }
    }; // class ValueAndWeight
}