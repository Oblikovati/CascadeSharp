//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepFill
	//---------------------------------------------------------------------
	public  sealed class BRepFill
	{

		public BRepFill()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill(BRepFill parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Face(TopoDS_Edge Edge1, TopoDS_Edge Edge2)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shell Shell(TopoDS_Wire Wire1, TopoDS_Wire Wire2)
		{
			throw new NotImplementedException();
		}

		public void Axe(TopoDS_Shape Spine, TopoDS_Wire Profile, gp_Ax3 AxeProf, ref bool ProfOnSpine, double Tol)
		{
			throw new NotImplementedException();
		}

		public void ComputeACR(TopoDS_Wire wire, TColStd_Array1OfReal ACR)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire InsertACR(TopoDS_Wire wire, TColStd_Array1OfReal ACRcuts, double prec)
		{
			throw new NotImplementedException();
		}

		public void SearchOrigin(TopoDS_Wire W, gp_Pnt P, gp_Vec V, double Tol)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFill

}
