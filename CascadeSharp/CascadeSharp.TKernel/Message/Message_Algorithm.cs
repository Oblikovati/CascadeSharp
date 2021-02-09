//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Message_Algorithm
	//---------------------------------------------------------------------
	public  sealed class Message_Algorithm : Standard_Transient
	{

		public Message_Algorithm()
			: base()
		{
			throw new NotImplementedException();
		}

		public Message_Algorithm(Message_Algorithm parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat)
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat, int theInt)
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat, string theStr, bool noRepetitions)
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat, string theStr)
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat, TCollection_AsciiString theStr, bool noRepetitions)
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat, TCollection_AsciiString theStr)
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat, TCollection_HAsciiString theStr, bool noRepetitions)
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat, TCollection_HAsciiString theStr)
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat, TCollection_ExtendedString theStr, bool noRepetitions)
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat, TCollection_ExtendedString theStr)
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat, TCollection_HExtendedString theStr, bool noRepetitions)
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat, TCollection_HExtendedString theStr)
		{
			throw new NotImplementedException();
		}

		public void SetStatus( ref CascadeSharp.Message_Status theStat, Message_Msg theMsg)
		{
			throw new NotImplementedException();
		}

		public Message_ExecStatus GetStatus()
		{
			throw new NotImplementedException();
		}

		public Message_ExecStatus ChangeStatus()
		{
			throw new NotImplementedException();
		}

		public void ClearStatus()
		{
			throw new NotImplementedException();
		}

		public void SetMessenger(Message_Messenger theMsgr)
		{
			throw new NotImplementedException();
		}

		public Message_Messenger GetMessenger()
		{
			throw new NotImplementedException();
		}

		public void SendStatusMessages(Message_ExecStatus theFilter, CascadeSharp.Message_Gravity theTraceLevel, int theMaxCount)
		{
			throw new NotImplementedException();
		}

		public void SendStatusMessages(Message_ExecStatus theFilter, CascadeSharp.Message_Gravity theTraceLevel)
		{
			throw new NotImplementedException();
		}

		public void SendStatusMessages(Message_ExecStatus theFilter)
		{
			throw new NotImplementedException();
		}

		public void SendMessages(CascadeSharp.Message_Gravity theTraceLevel, int theMaxCount)
		{
			throw new NotImplementedException();
		}

		public void SendMessages(CascadeSharp.Message_Gravity theTraceLevel)
		{
			throw new NotImplementedException();
		}

		public void SendMessages()
		{
			throw new NotImplementedException();
		}

		public void AddStatus(Message_Algorithm theOther)
		{
			throw new NotImplementedException();
		}

		public void AddStatus(Message_ExecStatus theStatus, Message_Algorithm theOther)
		{
			throw new NotImplementedException();
		}

		public TColStd_HPackedMapOfInteger GetMessageNumbers( ref CascadeSharp.Message_Status theStatus)
		{
			throw new NotImplementedException();
		}

		public TColStd_HSequenceOfHExtendedString GetMessageStrings( ref CascadeSharp.Message_Status theStatus)
		{
			throw new NotImplementedException();
		}

		public TCollection_ExtendedString PrepareReport(TColStd_HPackedMapOfInteger theError, int theMaxCount)
		{
			throw new NotImplementedException();
		}

		public TCollection_ExtendedString PrepareReport(TColStd_SequenceOfHExtendedString theReportSeq, int theMaxCount)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Message_Algorithm

}
