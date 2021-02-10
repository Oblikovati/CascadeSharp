//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepTools;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKBO.BRepAlgoAPI
{
	//---------------------------------------------------------------------
	//  Class  BRepAlgoAPI_Defeaturing
	//---------------------------------------------------------------------
	public  sealed class BRepAlgoAPI_Defeaturing : BRepAlgoAPI_Algo
	{

		public BRepAlgoAPI_Defeaturing()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepAlgoAPI_Defeaturing(BRepAlgoAPI_Defeaturing parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetShape(TopoDS_Shape theShape)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape InputShape()
		{
			throw new NotImplementedException();
		}

		public void AddFaceToRemove(TopoDS_Shape theFace)
		{
			throw new NotImplementedException();
		}

		public void AddFacesToRemove(TopTools_ListOfShape theFaces)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape FacesToRemove()
		{
			throw new NotImplementedException();
		}

		public void Build()
		{
			throw new NotImplementedException();
		}

		public void SetToFillHistory(bool theFlag)
		{
			throw new NotImplementedException();
		}

		public bool HasHistory()
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

		public void Clear()
		{
			throw new NotImplementedException();
		}


	}; // class BRepAlgoAPI_Defeaturing

}
