//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepTools_History
	//---------------------------------------------------------------------
	public  sealed class BRepTools_History : Standard_Transient
	{

		public BRepTools_History()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepTools_History(BRepTools_History parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public bool IsSupportedType(TopoDS_Shape theShape)
		{
			throw new NotImplementedException();
		}

		public void AddGenerated(TopoDS_Shape theInitial, TopoDS_Shape theGenerated)
		{
			throw new NotImplementedException();
		}

		public void AddModified(TopoDS_Shape theInitial, TopoDS_Shape theModified)
		{
			throw new NotImplementedException();
		}

		public void Remove(TopoDS_Shape theRemoved)
		{
			throw new NotImplementedException();
		}

		public void ReplaceGenerated(TopoDS_Shape theInitial, TopoDS_Shape theGenerated)
		{
			throw new NotImplementedException();
		}

		public void ReplaceModified(TopoDS_Shape theInitial, TopoDS_Shape theModified)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Generated(TopoDS_Shape theInitial)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Modified(TopoDS_Shape theInitial)
		{
			throw new NotImplementedException();
		}

		public bool IsRemoved(TopoDS_Shape theInitial)
		{
			throw new NotImplementedException();
		}

		public bool HasGenerated()
		{
			throw new NotImplementedException();
		}

		public bool HasModified()
		{
			throw new NotImplementedException();
		}

		public bool HasRemoved()
		{
			throw new NotImplementedException();
		}

		public void Merge(BRepTools_History theH_istory23)
		{
			throw new NotImplementedException();
		}

				public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool prepareGenerated(TopoDS_Shape theInitial, TopoDS_Shape theGenerated)
		{
			throw new NotImplementedException();
		}

		public bool prepareModified(TopoDS_Shape theInitial, TopoDS_Shape theModified)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape emptyList()
		{
			throw new NotImplementedException();
		}


		//---------------------------------------------------------------------
		//  Enum  TRelationType
		//---------------------------------------------------------------------
		public		enum TRelationType
		{
			TRelationType_Removed = 0,
			TRelationType_Generated = 1,
			TRelationType_Modified = 2
		} // enum  class TRelationType

	}; // class BRepTools_History

}
