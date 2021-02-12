//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.Standard
{
    //---------------------------------------------------------------------
    //  Class  Standard_DomainError
    //---------------------------------------------------------------------
    public class Standard_DomainError : Standard_Failure
    {
        public Standard_DomainError()
            : base()
        {

        }

        public Standard_DomainError(string theMessage)
            : base(theMessage)
        {
            throw new NotImplementedException();
        }
    }
}