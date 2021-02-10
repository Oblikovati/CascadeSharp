//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKernel.Message
{
    //---------------------------------------------------------------------
    //  Class  Message_Messenger
    //---------------------------------------------------------------------
    public sealed class Message_Messenger : Standard_Transient
    {
        public Message_Messenger()
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_Messenger(Message_Printer thePrinter)
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_Messenger(Message_Messenger parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public bool AddPrinter(Message_Printer thePrinter)
        {
            throw new NotImplementedException();
        }

        public bool RemovePrinter(Message_Printer thePrinter)
        {
            throw new NotImplementedException();
        }

        public Message_SequenceOfPrinters Printers()
        {
            throw new NotImplementedException();
        }

        public Message_SequenceOfPrinters ChangePrinters()
        {
            throw new NotImplementedException();
        }

        public void Send(string theString, Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }

        public void Send(string theString)
        {
            throw new NotImplementedException();
        }

        public void Send(TCollection_AsciiString theString, Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }

        public void Send(TCollection_AsciiString theString)
        {
            throw new NotImplementedException();
        }

        public void Send(TCollection_ExtendedString theString, Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }

        public void Send(TCollection_ExtendedString theString)
        {
            throw new NotImplementedException();
        }

        public void Send(Standard_Transient theObject, Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }

        public void Send(Standard_Transient theObject)
        {
            throw new NotImplementedException();
        }

        public void SendFail(TCollection_AsciiString theMessage)
        {
            throw new NotImplementedException();
        }

        public void SendAlarm(TCollection_AsciiString theMessage)
        {
            throw new NotImplementedException();
        }

        public void SendWarning(TCollection_AsciiString theMessage)
        {
            throw new NotImplementedException();
        }

        public void SendInfo(TCollection_AsciiString theMessage)
        {
            throw new NotImplementedException();
        }

        public void SendTrace(TCollection_AsciiString theMessage)
        {
            throw new NotImplementedException();
        }
    }; // class Message_Messenger
}