//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.Message;

namespace CascadeSharp.TKShHealing.ShapeExtend
{
    //---------------------------------------------------------------------
    //  Class  ShapeExtend_BasicMsgRegistrator
    //---------------------------------------------------------------------
    public class ShapeExtend_BasicMsgRegistrator : Standard_Transient
    {
        public ShapeExtend_BasicMsgRegistrator()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeExtend_BasicMsgRegistrator(ShapeExtend_BasicMsgRegistrator parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Send(Standard_Transient obj, Message_Msg message, Message_Gravity gravity)
        {
            throw new NotImplementedException();
        }

        public void Send(TopoDS_Shape shape, Message_Msg message, Message_Gravity gravity)
        {
            throw new NotImplementedException();
        }

        public void Send(Message_Msg message, Message_Gravity gravity)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class ShapeExtend_BasicMsgRegistrator
}