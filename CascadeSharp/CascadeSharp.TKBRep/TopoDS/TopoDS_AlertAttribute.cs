//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopoDS_AlertAttribute
	//---------------------------------------------------------------------
	public  sealed class TopoDS_AlertAttribute : CascadeSharp.Message_AttributeStream
	{

		public TopoDS_AlertAttribute(TopoDS_Shape theShape, TCollection_AsciiString theName)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopoDS_AlertAttribute(TopoDS_Shape theShape)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopoDS_AlertAttribute()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public TopoDS_Shape GetShape()
		{
			throw new NotImplementedException();
		}

		public void Send(Message_Messenger theMessenger, TopoDS_Shape theShape)
		{
			throw new NotImplementedException();
		}

				
	}; // class TopoDS_AlertAttribute

}
