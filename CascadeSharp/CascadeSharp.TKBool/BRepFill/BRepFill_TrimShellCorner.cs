//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_TrimShellCorner
	//---------------------------------------------------------------------
	public  sealed class BRepFill_TrimShellCorner
	{

		public BRepFill_TrimShellCorner(TopTools_HArray2OfShape theFaces, CascadeSharp.BRepFill_TransitionStyle theTransition, gp_Ax2 theAxeOfB_isPlane)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_TrimShellCorner(BRepFill_TrimShellCorner parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_TrimShellCorner()
		{
			throw new NotImplementedException();
		}

		public void AddBounds(TopTools_HArray2OfShape Bounds)
		{
			throw new NotImplementedException();
		}

		public void AddUEdges(TopTools_HArray2OfShape theUEdges)
		{
			throw new NotImplementedException();
		}

		public void AddVEdges(TopTools_HArray2OfShape theVEdges, int theIndex)
		{
			throw new NotImplementedException();
		}

		public void Perform()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public bool HasSection()
		{
			throw new NotImplementedException();
		}

		public void Modified(TopoDS_Shape S, TopTools_ListOfShape theModified)
		{
			throw new NotImplementedException();
		}

		public bool MakeFacesSec(int theIndex, BOPDS_DS theDS, int theFaceIndex1, int theFaceIndex2, int theSSInterfIndex)
		{
			throw new NotImplementedException();
		}

		public bool MakeFacesNonSec(int theIndex, BOPDS_DS theDS, int theFaceIndex1, int theFaceIndex2)
		{
			throw new NotImplementedException();
		}

		public bool ChooseSection(TopoDS_Shape Comp, TopoDS_Vertex theFirstVertex, TopoDS_Vertex theLastVertex, TopoDS_Shape resWire, gp_Pln resPlane, ref bool IsSingular)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFill_TrimShellCorner

}
