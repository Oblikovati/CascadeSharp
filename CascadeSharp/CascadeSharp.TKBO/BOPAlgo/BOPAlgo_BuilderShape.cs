//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepTools;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKernel.NCollection;

namespace CascadeSharp.TKBO.BOPAlgo
{
	//---------------------------------------------------------------------
	//  Class  BOPAlgo_BuilderShape
	//---------------------------------------------------------------------
	public  abstract class BOPAlgo_BuilderShape : BOPAlgo_Algo
	{

		public BOPAlgo_BuilderShape()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BOPAlgo_BuilderShape(NCollection_BaseAllocator theAllocator)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BOPAlgo_BuilderShape(BOPAlgo_BuilderShape parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Modified(TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Generated(TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}

		public bool IsDeleted(TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}

		public bool HasModified()
		{
			throw new NotImplementedException();
		}

		public bool HasGenerated()
		{
			throw new NotImplementedException();
		}

		public bool HasDeleted()
		{
			throw new NotImplementedException();
		}

		public BRepTools_History History()
		{
			throw new NotImplementedException();
		}

		public void SetToFillHistory(bool theH_istFlag)
		{
			throw new NotImplementedException();
		}

		public bool HasHistory()
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}


	}; // class BOPAlgo_BuilderShape

}
