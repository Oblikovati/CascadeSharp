//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.Message
{
    //---------------------------------------------------------------------
    //  Class  Message_Alert
    //---------------------------------------------------------------------
    public class Message_Alert : Standard_Transient
    {
        public Message_Alert(Message_Alert parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_Alert()
            : base()
        {
            throw new NotImplementedException();
        }

        public string GetMessageKey()
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
    }; // class Message_Alert
}