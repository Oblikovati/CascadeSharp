//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.Message;
using CascadeSharp.TKShHealing.ShapeBuild;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeFix
{
	//---------------------------------------------------------------------
	//  Class  ShapeFix_Root
	//---------------------------------------------------------------------
	public  class ShapeFix_Root : Standard_Transient
	{

		public ShapeFix_Root()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeFix_Root(ShapeFix_Root parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Set(ShapeFix_Root Root)
		{
			throw new NotImplementedException();
		}

		public void SetContext(ShapeBuild_ReShape context)
		{
			throw new NotImplementedException();
		}

		public ShapeBuild_ReShape Context()
		{
			throw new NotImplementedException();
		}

		public void SetMsgRegistrator(ShapeExtend_BasicMsgRegistrator msgreg)
		{
			throw new NotImplementedException();
		}

		public ShapeExtend_BasicMsgRegistrator MsgRegistrator()
		{
			throw new NotImplementedException();
		}

		public void SetPrecision(double preci)
		{
			throw new NotImplementedException();
		}

		public double Precision()
		{
			throw new NotImplementedException();
		}

		public void SetMinTolerance(double mintol)
		{
			throw new NotImplementedException();
		}

		public double MinTolerance()
		{
			throw new NotImplementedException();
		}

		public void SetMaxTolerance(double maxtol)
		{
			throw new NotImplementedException();
		}

		public double MaxTolerance()
		{
			throw new NotImplementedException();
		}

		public double LimitTolerance(double toler)
		{
			throw new NotImplementedException();
		}

		public void SendMsg(TopoDS_Shape shape, Message_Msg message, Message_Gravity gravity)
		{
			throw new NotImplementedException();
		}

		public void SendMsg(TopoDS_Shape shape, Message_Msg message)
		{
			throw new NotImplementedException();
		}

		public void SendMsg(Message_Msg message, Message_Gravity gravity)
		{
			throw new NotImplementedException();
		}

		public void SendMsg(Message_Msg message)
		{
			throw new NotImplementedException();
		}

		public void SendWarning(TopoDS_Shape shape, Message_Msg message)
		{
			throw new NotImplementedException();
		}

		public void SendWarning(Message_Msg message)
		{
			throw new NotImplementedException();
		}

		public void SendFail(TopoDS_Shape shape, Message_Msg message)
		{
			throw new NotImplementedException();
		}

		public void SendFail(Message_Msg message)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool NeedFix(int flag, bool def)
		{
			throw new NotImplementedException();
		}

		public bool NeedFix(int flag)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeFix_Root

}
