//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopoDS
{
	//---------------------------------------------------------------------
	//  Class  TopoDS_TShape
	//---------------------------------------------------------------------
	public  abstract class TopoDS_TShape : Standard_Transient
	{

		public TopoDS_TShape()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public TopoDS_TShape(TopoDS_TShape parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public bool Free()
		{
			throw new NotImplementedException();
		}

		public void Free(bool theIsFree)
		{
			throw new NotImplementedException();
		}

		public bool Locked()
		{
			throw new NotImplementedException();
		}

		public void Locked(bool theIsLocked)
		{
			throw new NotImplementedException();
		}

		public bool Modified()
		{
			throw new NotImplementedException();
		}

		public void Modified(bool theIsModified)
		{
			throw new NotImplementedException();
		}

		public bool Checked()
		{
			throw new NotImplementedException();
		}

		public void Checked(bool theIsChecked)
		{
			throw new NotImplementedException();
		}

		public bool Orientable()
		{
			throw new NotImplementedException();
		}

		public void Orientable(bool theIsOrientable)
		{
			throw new NotImplementedException();
		}

		public bool Closed()
		{
			throw new NotImplementedException();
		}

		public void Closed(bool theIsClosed)
		{
			throw new NotImplementedException();
		}

		public bool Infinite()
		{
			throw new NotImplementedException();
		}

		public void Infinite(bool theIsInfinite)
		{
			throw new NotImplementedException();
		}

		public bool Convex()
		{
			throw new NotImplementedException();
		}

		public void Convex(bool theIsConvex)
		{
			throw new NotImplementedException();
		}

		public TopAbs_ShapeEnum ShapeType()
		{
			throw new NotImplementedException();
		}

		public TopoDS_TShape EmptyCopy()
		{
			throw new NotImplementedException();
		}

		public int NbChildren()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void setFlag(TopoDS_TShape_Flags theFlag, bool theIsOn)
		{
			throw new NotImplementedException();
		}


		//---------------------------------------------------------------------
		//  Enum  TopoDS_TShape_Flags
		//---------------------------------------------------------------------
		public		enum TopoDS_TShape_Flags
		{
			TopoDS_TShape_Flags_Free = 1,
			TopoDS_TShape_Flags_Modified = 2,
			TopoDS_TShape_Flags_Checked = 4,
			TopoDS_TShape_Flags_Orientable = 8,
			TopoDS_TShape_Flags_Closed = 16,
			TopoDS_TShape_Flags_Infinite = 32,
			TopoDS_TShape_Flags_Convex = 64,
			TopoDS_TShape_Flags_Locked = 128
		} // enum  class TopoDS_TShape_Flags

	}; // class TopoDS_TShape

}
