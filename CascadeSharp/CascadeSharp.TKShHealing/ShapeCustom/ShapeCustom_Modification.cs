//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ShapeCustom_Modification
	//---------------------------------------------------------------------
	public  abstract class ShapeCustom_Modification : CascadeSharp.BRepTools_Modification
	{

		public ShapeCustom_Modification(ShapeCustom_Modification parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public ShapeCustom_Modification()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void SetMsgRegistrator(ShapeExtend_BasicMsgRegistrator msgreg)
		{
			throw new NotImplementedException();
		}

		public ShapeExtend_BasicMsgRegistrator MsgRegistrator()
		{
			throw new NotImplementedException();
		}

		public void SendMsg(TopoDS_Shape shape, Message_Msg message, CascadeSharp.Message_Gravity gravity)
		{
			throw new NotImplementedException();
		}

		public void SendMsg(TopoDS_Shape shape, Message_Msg message)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class ShapeCustom_Modification

}
