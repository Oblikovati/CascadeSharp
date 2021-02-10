//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepFeat_MakeRevolutionForm
	//---------------------------------------------------------------------
	public  sealed class BRepFeat_MakeRevolutionForm : CascadeSharp.BRepFeat_RibSlot
	{

		public BRepFeat_MakeRevolutionForm()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFeat_MakeRevolutionForm(TopoDS_Shape Sbase, TopoDS_Wire W, Geom_Plane Plane, gp_Ax1 Ax_is, double Height1, double Height2, int Fuse, ref bool Sliding)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFeat_MakeRevolutionForm(BRepFeat_MakeRevolutionForm parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape Sbase, TopoDS_Wire W, Geom_Plane Plane, gp_Ax1 Ax_is, double Height1, double Height2, int Fuse, ref bool Sliding)
		{
			throw new NotImplementedException();
		}

		public void Add(TopoDS_Edge E, TopoDS_Face OnFace)
		{
			throw new NotImplementedException();
		}

		public void Perform()
		{
			throw new NotImplementedException();
		}

		public bool Propagate(TopTools_ListOfShape L, TopoDS_Face F, gp_Pnt FPoint, gp_Pnt LPoint, ref bool falseside)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFeat_MakeRevolutionForm

}
