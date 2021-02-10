//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKernel.Message
{
    //---------------------------------------------------------------------
    //  Class  Message_Attribute
    //---------------------------------------------------------------------
    public class Message_Attribute : Standard_Transient
    {
        public Message_Attribute(TCollection_AsciiString theName)
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_Attribute(Message_Attribute parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_Attribute()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public string GetMessageKey()
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString GetName()
        {
            throw new NotImplementedException();
        }

        public void SetName(TCollection_AsciiString theName)
        {
            throw new NotImplementedException();
        }
    }; // class Message_Attribute
}