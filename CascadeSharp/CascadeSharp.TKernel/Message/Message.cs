//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Message
	//---------------------------------------------------------------------
	public  sealed class Message
	{

		public Message()
			: base()
		{
			throw new NotImplementedException();
		}

		public Message(Message parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Message_Messenger DefaultMessenger()
		{
			throw new NotImplementedException();
		}

				public void Send(TCollection_AsciiString theMessage, CascadeSharp.Message_Gravity theGravity)
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

		public TCollection_AsciiString FillTime(int Hour, int Minute, double Second)
		{
			throw new NotImplementedException();
		}

		public Message_Report DefaultReport(bool theToCreate)
		{
			throw new NotImplementedException();
		}

		public Message_Report DefaultReport()
		{
			throw new NotImplementedException();
		}

		public bool MetricFromString(string theString,  ref CascadeSharp.Message_MetricType theType)
		{
			throw new NotImplementedException();
		}

		public string MetricToString(CascadeSharp.Message_MetricType theType)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Message_MetricType MetricFromString(string theString)
		{
			throw new NotImplementedException();
		}

				
	}; // class Message

}
