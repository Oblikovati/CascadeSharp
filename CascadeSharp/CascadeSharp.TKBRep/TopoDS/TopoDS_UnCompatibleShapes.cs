//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Standard;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_UnCompatibleShapes
    //---------------------------------------------------------------------
    public sealed class TopoDS_UnCompatibleShapes : Standard_DomainError
    {
        public TopoDS_UnCompatibleShapes()
            : base()
        {

        }

        public TopoDS_UnCompatibleShapes(string theMessage)
            : base(theMessage)
        {

        }

    }
}