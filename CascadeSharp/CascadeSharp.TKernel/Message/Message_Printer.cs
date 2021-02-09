//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Message_Printer
	//---------------------------------------------------------------------
	public  abstract class Message_Printer : Standard_Transient
	{

		public Message_Printer()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Message_Printer(Message_Printer parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public CascadeSharp.Message_Gravity GetTraceLevel()
		{
			throw new NotImplementedException();
		}

		public void SetTraceLevel(CascadeSharp.Message_Gravity theTraceLevel)
		{
			throw new NotImplementedException();
		}

		public void Send(TCollection_ExtendedString theString, CascadeSharp.Message_Gravity theGravity)
		{
			throw new NotImplementedException();
		}

		public void Send(string theString, CascadeSharp.Message_Gravity theGravity)
		{
			throw new NotImplementedException();
		}

		public void Send(TCollection_AsciiString theString, CascadeSharp.Message_Gravity theGravity)
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


	}; // class Message_Printer

}
