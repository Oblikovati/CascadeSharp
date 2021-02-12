//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.Standard
{
    //---------------------------------------------------------------------
    //  Class  Standard_Failure
    //---------------------------------------------------------------------
    public class Standard_Failure : Exception
    {
        public Standard_Failure()
            : base()
        {

        }

        public Standard_Failure(string aString)
            : base(aString)
        {

        }

    }
}