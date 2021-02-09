//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Message_PrinterToReport
	//---------------------------------------------------------------------
	public  sealed class Message_PrinterToReport : CascadeSharp.Message_Printer
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

				public void SendObject(Standard_Transient theObject, CascadeSharp.Message_Gravity theGravity)
		{
			throw new NotImplementedException();
		}

		public void send(TCollection_AsciiString theString, CascadeSharp.Message_Gravity theGravity)
		{
			throw new NotImplementedException();
		}

		public void sendMetricAlert(TCollection_AsciiString theValue, CascadeSharp.Message_Gravity theGravity)
		{
			throw new NotImplementedException();
		}


	}; // class Message_PrinterToReport

}
