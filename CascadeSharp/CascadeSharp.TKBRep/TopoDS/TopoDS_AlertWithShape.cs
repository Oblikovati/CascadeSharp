//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Message;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_AlertWithShape
    //---------------------------------------------------------------------
    public sealed class TopoDS_AlertWithShape : Message_Alert
    {
        public TopoDS_AlertWithShape(TopoDS_Shape theShape)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopoDS_AlertWithShape(TopoDS_AlertWithShape parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopoDS_AlertWithShape()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape GetShape()
        {
            throw new NotImplementedException();
        }

        public void SetShape(TopoDS_Shape theShape)
        {
            throw new NotImplementedException();
        }

        public bool SupportsMerge()
        {
            throw new NotImplementedException();
        }

        public bool Merge(Message_Alert theTarget)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class TopoDS_AlertWithShape
}