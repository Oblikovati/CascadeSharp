//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKernel.TColStd;

namespace CascadeSharp.TKernel.Units
{
    //---------------------------------------------------------------------
    //  Class  Units_Unit
    //---------------------------------------------------------------------
    public class Units_Unit : Standard_Transient
    {
        public Units_Unit(string aname, string asymbol, double avalue, Units_Quantity aquantity)
            : base()
        {
            throw new NotImplementedException();
        }

        public Units_Unit(string aname, string asymbol)
            : base()
        {
            throw new NotImplementedException();
        }

        public Units_Unit(string aname)
            : base()
        {
            throw new NotImplementedException();
        }

        public Units_Unit(Units_Unit parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Units_Unit()
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString Name()
        {
            throw new NotImplementedException();
        }

        public void Symbol(string asymbol)
        {
            throw new NotImplementedException();
        }

        public double Value()
        {
            throw new NotImplementedException();
        }

        public Units_Quantity Quantity()
        {
            throw new NotImplementedException();
        }

        public TColStd_HSequenceOfHAsciiString SymbolsSequence()
        {
            throw new NotImplementedException();
        }

        public void Value(double avalue)
        {
            throw new NotImplementedException();
        }

        public void Quantity(Units_Quantity aquantity)
        {
            throw new NotImplementedException();
        }

        public Units_Token Token()
        {
            throw new NotImplementedException();
        }

        public bool IsEqual(string astring)
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
    }; // class Units_Unit
}