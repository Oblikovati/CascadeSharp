//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepOffsetAPI_DraftAngle
	//---------------------------------------------------------------------
	public  sealed class BRepOffsetAPI_DraftAngle : CascadeSharp.BRepBuilderAPI_ModifyShape
	{

		public BRepOffsetAPI_DraftAngle()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_DraftAngle(TopoDS_Shape S)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_DraftAngle(BRepOffsetAPI_DraftAngle parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Add(TopoDS_Face F, gp_Dir Direction, double Angle, gp_Pln NeutralPlane, bool Flag)
		{
			throw new NotImplementedException();
		}

		public void Add(TopoDS_Face F, gp_Dir Direction, double Angle, gp_Pln NeutralPlane)
		{
			throw new NotImplementedException();
		}

		public bool AddDone()
		{
			throw new NotImplementedException();
		}

		public void Remove(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ProblematicShape()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Draft_ErrorStatus Status()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape ConnectedFaces(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape ModifiedFaces()
		{
			throw new NotImplementedException();
		}

		public void Build()
		{
			throw new NotImplementedException();
		}

		public void CorrectWires()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Generated(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Modified(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ModifiedShape(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void CorrectVertexTol()
		{
			throw new NotImplementedException();
		}


	}; // class BRepOffsetAPI_DraftAngle

}
