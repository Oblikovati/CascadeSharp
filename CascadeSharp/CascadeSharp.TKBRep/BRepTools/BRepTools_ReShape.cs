//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepTools_ReShape
	//---------------------------------------------------------------------
	public  class BRepTools_ReShape : Standard_Transient
	{

		public BRepTools_ReShape()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepTools_ReShape(BRepTools_ReShape parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void Remove(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public void Replace(TopoDS_Shape shape, TopoDS_Shape newshape)
		{
			throw new NotImplementedException();
		}

		public bool IsRecorded(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Value(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public int Status(TopoDS_Shape shape, TopoDS_Shape newsh, bool last)
		{
			throw new NotImplementedException();
		}

		public int Status(TopoDS_Shape shape, TopoDS_Shape newsh)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Apply(TopoDS_Shape shape, CascadeSharp.TopAbs_ShapeEnum until)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Apply(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public bool ModeConsiderLocation()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex CopyVertex(TopoDS_Vertex theV, double theTol)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex CopyVertex(TopoDS_Vertex theV)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex CopyVertex(TopoDS_Vertex theV, gp_Pnt theNewPos, double aTol)
		{
			throw new NotImplementedException();
		}

		public bool IsNewShape(TopoDS_Shape theShape)
		{
			throw new NotImplementedException();
		}

		public BRepTools_History History()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void replace(TopoDS_Shape shape, TopoDS_Shape newshape, CascadeSharp.BRepTools_ReShape.TReplacementKind theKind)
		{
			throw new NotImplementedException();
		}

		public bool isOrdinaryMerged(CascadeSharp.BRepTools_ReShape.TReplacementKind theKind)
		{
			throw new NotImplementedException();
		}


		//---------------------------------------------------------------------
		//  Enum  TReplacementKind
		//---------------------------------------------------------------------
		public		enum TReplacementKind
		{
			TReplacementKind_Remove = 1,
			TReplacementKind_Modify = 2,
			TReplacementKind_Merge_Main = 4,
			TReplacementKind_Merge_Ordinary = 8
		} // enum  class TReplacementKind

	}; // class BRepTools_ReShape

}
