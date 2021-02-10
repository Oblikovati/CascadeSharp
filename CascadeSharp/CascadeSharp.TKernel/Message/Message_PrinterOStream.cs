//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKernel.Message
{
    //---------------------------------------------------------------------
    //  Class  Message_PrinterOStream
    //---------------------------------------------------------------------
    public sealed class Message_PrinterOStream : Message_Printer
    {
        public Message_PrinterOStream(Message_Gravity theTraceLevel)
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_PrinterOStream(string theFileName, bool theDoAppend, Message_Gravity theTraceLevel)
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_PrinterOStream(string theFileName, bool theDoAppend)
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_PrinterOStream(Message_PrinterOStream parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_PrinterOStream()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public bool ToColorize()
        {
            throw new NotImplementedException();
        }

        public void SetToColorize(bool theToColorize)
        {
            throw new NotImplementedException();
        }

        public void send(TCollection_AsciiString theString, Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }
    }; // class Message_PrinterOStream
}