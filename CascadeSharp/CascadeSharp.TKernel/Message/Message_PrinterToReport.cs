//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKernel.Message
{
    //---------------------------------------------------------------------
    //  Class  Message_PrinterToReport
    //---------------------------------------------------------------------
    public sealed class Message_PrinterToReport : Message_Printer
    {
        public Message_PrinterToReport()
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_PrinterToReport(Message_PrinterToReport parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public Message_Report Report()
        {
            throw new NotImplementedException();
        }

        public void SetReport(Message_Report theReport)
        {
            throw new NotImplementedException();
        }

        public void SendObject(Standard_Transient theObject, Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }

        public void send(TCollection_AsciiString theString, Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }

        public void sendMetricAlert(TCollection_AsciiString theValue, Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }
    }; // class Message_PrinterToReport
}