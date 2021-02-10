//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.Units
{
    //---------------------------------------------------------------------
    //  Class  Units_ShiftedUnit
    //---------------------------------------------------------------------
    public sealed class Units_ShiftedUnit : Units_Unit
    {
        public Units_ShiftedUnit(string aname, string asymbol, double avalue, double amove, Units_Quantity aquantity)
            : base()
        {
            throw new NotImplementedException();
        }

        public Units_ShiftedUnit(string aname, string asymbol)
            : base()
        {
            throw new NotImplementedException();
        }

        public Units_ShiftedUnit(string aname)
            : base()
        {
            throw new NotImplementedException();
        }

        public Units_ShiftedUnit(Units_ShiftedUnit parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Units_ShiftedUnit()
        {
            throw new NotImplementedException();
        }

        public void Move(double amove)
        {
            throw new NotImplementedException();
        }

        public double Move()
        {
            throw new NotImplementedException();
        }

        public Units_Token Token()
        {
            throw new NotImplementedException();
        }

        public void Dump(int ashift, int alevel)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Units_ShiftedUnit
}