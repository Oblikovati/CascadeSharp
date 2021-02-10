//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKFeat.LocOpe
{
	//---------------------------------------------------------------------
	//  Class  LocOpe_SplitShape
	//---------------------------------------------------------------------
	public  sealed class LocOpe_SplitShape
	{

		public LocOpe_SplitShape()
			: base()
		{
			throw new NotImplementedException();
		}

		public LocOpe_SplitShape(TopoDS_Shape S)
			: base()
		{
			throw new NotImplementedException();
		}

		public LocOpe_SplitShape(LocOpe_SplitShape parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public bool CanSplit(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void Add(TopoDS_Vertex V, double P, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public bool Add(TopoDS_Wire W, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool Add(TopTools_ListOfShape Lwires, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape DescendantShapes(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape LeftOf(TopoDS_Wire W, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool AddOpenWire(TopoDS_Wire W, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool AddClosedWire(TopoDS_Wire W, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void Put(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public bool Rebuild(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}


	}; // class LocOpe_SplitShape

}
