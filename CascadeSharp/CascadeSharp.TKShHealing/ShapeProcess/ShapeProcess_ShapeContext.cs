//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ShapeProcess_ShapeContext
	//---------------------------------------------------------------------
	public  sealed class ShapeProcess_ShapeContext : CascadeSharp.ShapeProcess_Context
	{

		public ShapeProcess_ShapeContext(string file, string seq)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeProcess_ShapeContext(string file)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeProcess_ShapeContext(TopoDS_Shape S, string file, string seq)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeProcess_ShapeContext(TopoDS_Shape S, string file)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeProcess_ShapeContext(ShapeProcess_ShapeContext parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeProcess_ShapeContext()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Result()
		{
			throw new NotImplementedException();
		}

		public TopTools_DataMapOfShapeShape Map()
		{
			throw new NotImplementedException();
		}

		public ShapeExtend_MsgRegistrator Messages()
		{
			throw new NotImplementedException();
		}

		public void SetDetalisation(CascadeSharp.TopAbs_ShapeEnum level)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_ShapeEnum GetDetalisation()
		{
			throw new NotImplementedException();
		}

		public void SetResult(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void RecordModification(TopTools_DataMapOfShapeShape repl, ShapeExtend_MsgRegistrator msg)
		{
			throw new NotImplementedException();
		}

		public void RecordModification(TopTools_DataMapOfShapeShape repl)
		{
			throw new NotImplementedException();
		}

		public void RecordModification(ShapeBuild_ReShape repl, ShapeExtend_MsgRegistrator msg)
		{
			throw new NotImplementedException();
		}

		public void RecordModification(ShapeBuild_ReShape repl)
		{
			throw new NotImplementedException();
		}

		public void RecordModification(TopoDS_Shape sh, BRepTools_Modifier repl, ShapeExtend_MsgRegistrator msg)
		{
			throw new NotImplementedException();
		}

		public void RecordModification(TopoDS_Shape sh, BRepTools_Modifier repl)
		{
			throw new NotImplementedException();
		}

		public void AddMessage(TopoDS_Shape S, Message_Msg msg, CascadeSharp.Message_Gravity gravity)
		{
			throw new NotImplementedException();
		}

		public void AddMessage(TopoDS_Shape S, Message_Msg msg)
		{
			throw new NotImplementedException();
		}

		public bool GetContinuity(string param,  ref CascadeSharp.GeomAbs_Shape val)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_Shape ContinuityVal(string param, CascadeSharp.GeomAbs_Shape def)
		{
			throw new NotImplementedException();
		}

		public void PrintStatistics()
		{
			throw new NotImplementedException();
		}

		public void SetNonManifold(bool theNonManifold)
		{
			throw new NotImplementedException();
		}

		public bool IsNonManifold()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class ShapeProcess_ShapeContext

}
