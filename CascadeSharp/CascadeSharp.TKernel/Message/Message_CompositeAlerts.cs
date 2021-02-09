//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Message_CompositeAlerts
	//---------------------------------------------------------------------
	public  sealed class Message_CompositeAlerts : Standard_Transient
	{

		public Message_CompositeAlerts()
			: base()
		{
			throw new NotImplementedException();
		}

		public Message_CompositeAlerts(Message_CompositeAlerts parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public Message_ListOfAlert Alerts(CascadeSharp.Message_Gravity theGravity)
		{
			throw new NotImplementedException();
		}

		public bool AddAlert(CascadeSharp.Message_Gravity theGravity, Message_Alert theAlert)
		{
			throw new NotImplementedException();
		}

		public bool RemoveAlert(CascadeSharp.Message_Gravity theGravity, Message_Alert theAlert)
		{
			throw new NotImplementedException();
		}

		public bool HasAlert(Message_Alert theAlert)
		{
			throw new NotImplementedException();
		}

				public void Clear()
		{
			throw new NotImplementedException();
		}

		public void Clear(CascadeSharp.Message_Gravity theGravity)
		{
			throw new NotImplementedException();
		}

						
	}; // class Message_CompositeAlerts

}
