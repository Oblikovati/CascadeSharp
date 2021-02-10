//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKPrim.BRepPrim
{
	//---------------------------------------------------------------------
	//  Class  BRepPrim_Torus
	//---------------------------------------------------------------------
	public  sealed class BRepPrim_Torus : BRepPrim_Revolution
	{

		public BRepPrim_Torus(gp_Ax2 Position, double Major, double Minor)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepPrim_Torus(double Major, double Minor)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepPrim_Torus(gp_Pnt Center, double Major, double Minor)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepPrim_Torus(BRepPrim_Torus parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepPrim_Torus()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face MakeEmptyLateralFace()
		{
			throw new NotImplementedException();
		}

		public void SetMeridian()
		{
			throw new NotImplementedException();
		}


	}; // class BRepPrim_Torus

}
