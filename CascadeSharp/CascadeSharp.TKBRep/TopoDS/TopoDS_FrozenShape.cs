//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using CascadeSharp.TKernel.Standard;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_FrozenShape
    //---------------------------------------------------------------------
    public sealed class TopoDS_FrozenShape : Standard_DomainError
    {
        public TopoDS_FrozenShape()
        {

        }

        public TopoDS_FrozenShape(string theMessage)
            : base(theMessage)
        {

        }

    }
}