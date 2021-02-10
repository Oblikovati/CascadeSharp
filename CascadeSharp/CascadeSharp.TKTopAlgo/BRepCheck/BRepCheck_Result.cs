//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepCheck_Result
	//---------------------------------------------------------------------
	public  abstract class BRepCheck_Result : Standard_Transient
	{

		public BRepCheck_Result()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BRepCheck_Result(BRepCheck_Result parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void Init(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void InContext(TopoDS_Shape ContextShape)
		{
			throw new NotImplementedException();
		}

		public void Minimum()
		{
			throw new NotImplementedException();
		}

		public void Blind()
		{
			throw new NotImplementedException();
		}

		public void SetFailStatus(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public BRepCheck_ListOfStatus Status()
		{
			throw new NotImplementedException();
		}

		public bool IsMinimum()
		{
			throw new NotImplementedException();
		}

		public bool IsBlind()
		{
			throw new NotImplementedException();
		}

		public BRepCheck_ListOfStatus StatusOnShape(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void InitContextIterator()
		{
			throw new NotImplementedException();
		}

		public bool MoreShapeInContext()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ContextualShape()
		{
			throw new NotImplementedException();
		}

		public BRepCheck_ListOfStatus StatusOnShape()
		{
			throw new NotImplementedException();
		}

		public void NextShapeInContext()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRepCheck_Result

}
