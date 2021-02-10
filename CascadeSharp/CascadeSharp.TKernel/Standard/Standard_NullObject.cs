//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.Standard
{
    //---------------------------------------------------------------------
    //  Class  Standard_NullObject
    //---------------------------------------------------------------------
    public sealed class Standard_NullObject : Standard_DomainError
    {
        public Standard_NullObject()
            : base()
        {
            throw new NotImplementedException();
        }

        public Standard_NullObject(string theMessage)
            : base()
        {
            throw new NotImplementedException();
        }

        public Standard_NullObject(Standard_NullObject parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Throw()
        {
            throw new NotImplementedException();
        }

        public void Raise(string theMessage)
        {
            throw new NotImplementedException();
        }

        public void Raise()
        {
            throw new NotImplementedException();
        }

        public Standard_NullObject NewInstance(string theMessage)
        {
            throw new NotImplementedException();
        }

        public Standard_NullObject NewInstance()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Standard_NullObject
}