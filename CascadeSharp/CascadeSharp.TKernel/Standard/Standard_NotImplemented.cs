//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.Standard
{
    //---------------------------------------------------------------------
    //  Class  Standard_NotImplemented
    //---------------------------------------------------------------------
    public sealed class Standard_NotImplemented : Standard_ProgramError
    {
        public Standard_NotImplemented()
            : base()
        {
            throw new NotImplementedException();
        }

        public Standard_NotImplemented(string theMessage)
            : base()
        {
            throw new NotImplementedException();
        }

        public Standard_NotImplemented(Standard_NotImplemented parameter1)
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

        public Standard_NotImplemented NewInstance(string theMessage)
        {
            throw new NotImplementedException();
        }

        public Standard_NotImplemented NewInstance()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Standard_NotImplemented
}