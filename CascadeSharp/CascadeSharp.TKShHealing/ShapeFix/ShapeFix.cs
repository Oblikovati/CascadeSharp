//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.Message;
using CascadeSharp.TKShHealing.ShapeBuild;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeFix
{
	//---------------------------------------------------------------------
	//  Class  ShapeFix
	//---------------------------------------------------------------------
	public  sealed class ShapeFix
	{

		public ShapeFix()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeFix(ShapeFix parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public bool SameParameter(TopoDS_Shape shape, bool enforce, double preci, Message_ProgressRange theProgress, ShapeExtend_BasicMsgRegistrator theMsgReg)
		{
			throw new NotImplementedException();
		}

		public bool SameParameter(TopoDS_Shape shape, bool enforce, double preci, Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public bool SameParameter(TopoDS_Shape shape, bool enforce, double preci)
		{
			throw new NotImplementedException();
		}

		public bool SameParameter(TopoDS_Shape shape, bool enforce)
		{
			throw new NotImplementedException();
		}

		public void EncodeRegularity(TopoDS_Shape shape, double tolang)
		{
			throw new NotImplementedException();
		}

		public void EncodeRegularity(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape RemoveSmallEdges(TopoDS_Shape shape, double Tolerance, ShapeBuild_ReShape context)
		{
			throw new NotImplementedException();
		}

		public bool FixVertexPosition(TopoDS_Shape theshape, double theTolerance, ShapeBuild_ReShape thecontext)
		{
			throw new NotImplementedException();
		}

		public double LeastEdgeSize(TopoDS_Shape theshape)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeFix

}
