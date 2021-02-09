//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepTools_Modifier
	//---------------------------------------------------------------------
	public  sealed class BRepTools_Modifier
	{

		public BRepTools_Modifier(bool theMutableInput)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepTools_Modifier(TopoDS_Shape S)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepTools_Modifier(TopoDS_Shape S, BRepTools_Modification M)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepTools_Modifier(BRepTools_Modifier parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepTools_Modifier()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Perform(BRepTools_Modification M, Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public void Perform(BRepTools_Modification M)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public bool IsMutableInput()
		{
			throw new NotImplementedException();
		}

		public void SetMutableInput(bool theMutableInput)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ModifiedShape(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Put(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public bool Rebuild(TopoDS_Shape S, BRepTools_Modification M, ref bool theNewGeom, Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public bool Rebuild(TopoDS_Shape S, BRepTools_Modification M, ref bool theNewGeom)
		{
			throw new NotImplementedException();
		}

		public void CreateNewVertices(TopTools_IndexedDataMapOfShapeListOfShape theMVE, BRepTools_Modification M)
		{
			throw new NotImplementedException();
		}

		public void FillNewCurveInfo(TopTools_IndexedDataMapOfShapeListOfShape theMEF, BRepTools_Modification M)
		{
			throw new NotImplementedException();
		}

		public void FillNewSurfaceInfo(BRepTools_Modification M)
		{
			throw new NotImplementedException();
		}

		public void CreateOtherVertices(TopTools_IndexedDataMapOfShapeListOfShape theMVE, TopTools_IndexedDataMapOfShapeListOfShape theMEF, BRepTools_Modification M)
		{
			throw new NotImplementedException();
		}


	}; // class BRepTools_Modifier

}
