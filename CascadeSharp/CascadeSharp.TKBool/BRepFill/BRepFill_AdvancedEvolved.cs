//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKBool.BRepFill
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_AdvancedEvolved
	//---------------------------------------------------------------------
	public  sealed class BRepFill_AdvancedEvolved
	{

		public BRepFill_AdvancedEvolved()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_AdvancedEvolved(BRepFill_AdvancedEvolved parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Wire theSpine, TopoDS_Wire theProfile, double theTolerance, bool theSolidReq)
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Wire theSpine, TopoDS_Wire theProfile, double theTolerance)
		{
			throw new NotImplementedException();
		}

		public bool IsDone(ref uint theErrorCode)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public void SetTemporaryDirectory(string thePath)
		{
			throw new NotImplementedException();
		}

		public void SetParallelMode(bool theVal)
		{
			throw new NotImplementedException();
		}

		public void PerformSweep()
		{
			throw new NotImplementedException();
		}

		public void GetLids()
		{
			throw new NotImplementedException();
		}

		public void BuildSolid()
		{
			throw new NotImplementedException();
		}

				public void ExtractOuterSolid(TopoDS_Shape theShape, TopTools_ListOfShape theArgsL_ist)
		{
			throw new NotImplementedException();
		}

		public void GetSpineAndProfile(TopoDS_Wire theSpine, TopoDS_Wire theProfile)
		{
			throw new NotImplementedException();
		}

		public void UnifyShape()
		{
			throw new NotImplementedException();
		}

		public bool PerformBoolean(TopTools_ListOfShape theArgsL_ist, TopoDS_Shape theResult)
		{
			throw new NotImplementedException();
		}

		public bool CheckSingularityAndAdd(TopoDS_Face theF, double theFuzzyToler, TopTools_ListOfShape theL_istOfFaces, TopTools_ListOfShape theL_istOfSplits)
		{
			throw new NotImplementedException();
		}

		public bool IsLid(TopoDS_Face theF, TopTools_IndexedMapOfShape theMapOfLids)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFill_AdvancedEvolved

}
