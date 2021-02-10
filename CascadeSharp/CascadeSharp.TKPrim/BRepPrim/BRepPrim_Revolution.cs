//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKPrim.BRepPrim
{
	//---------------------------------------------------------------------
	//  Class  BRepPrim_Revolution
	//---------------------------------------------------------------------
	public  class BRepPrim_Revolution : BRepPrim_OneAxis
	{

		public BRepPrim_Revolution(gp_Ax2 A, double VMin, double VMax, Geom_Curve M, Geom2d_Curve PM)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepPrim_Revolution(gp_Ax2 A, double VMin, double VMax)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepPrim_Revolution(BRepPrim_Revolution parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepPrim_Revolution()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face MakeEmptyLateralFace()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge MakeEmptyMeridianEdge(double Ang)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d MeridianValue(double V)
		{
			throw new NotImplementedException();
		}

		public void SetMeridianPCurve(TopoDS_Edge E, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void Meridian(Geom_Curve M, Geom2d_Curve PM)
		{
			throw new NotImplementedException();
		}


	}; // class BRepPrim_Revolution

}
