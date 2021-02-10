//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKernel.Message
{
    //---------------------------------------------------------------------
    //  Class  Message_PrinterSystemLog
    //---------------------------------------------------------------------
    public sealed class Message_PrinterSystemLog : Message_Printer
    {
        public Message_PrinterSystemLog(TCollection_AsciiString theEventSourceName, Message_Gravity theTraceLevel)
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_PrinterSystemLog(TCollection_AsciiString theEventSourceName)
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_PrinterSystemLog(Message_PrinterSystemLog parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_PrinterSystemLog()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void send(TCollection_AsciiString theString, Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }
    }; // class Message_PrinterSystemLog
}