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
	//  Class  BRepPrim_OneAxis
	//---------------------------------------------------------------------
	public  abstract class BRepPrim_OneAxis
	{

		public BRepPrim_OneAxis(BRepPrim_Builder B, gp_Ax2 A, double VMin, double VMax)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BRepPrim_OneAxis(BRepPrim_OneAxis parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BRepPrim_OneAxis()
		{
			throw new NotImplementedException();
		}

		public void SetMeridianOffset(double MeridianOffset)
		{
			throw new NotImplementedException();
		}

		public void SetMeridianOffset()
		{
			throw new NotImplementedException();
		}

		public gp_Ax2 Axes()
		{
			throw new NotImplementedException();
		}

		public void Axes(gp_Ax2 A)
		{
			throw new NotImplementedException();
		}

		public double Angle()
		{
			throw new NotImplementedException();
		}

		public void Angle(double A)
		{
			throw new NotImplementedException();
		}

		public double VMin()
		{
			throw new NotImplementedException();
		}

		public void VMin(double V)
		{
			throw new NotImplementedException();
		}

		public double VMax()
		{
			throw new NotImplementedException();
		}

		public void VMax(double V)
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

		public void SetMeridianPCurve(TopoDS_Edge E, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d MeridianValue(double V)
		{
			throw new NotImplementedException();
		}

		public bool MeridianOnAxis(double V)
		{
			throw new NotImplementedException();
		}

		public bool MeridianClosed()
		{
			throw new NotImplementedException();
		}

		public bool VMaxInfinite()
		{
			throw new NotImplementedException();
		}

		public bool VMinInfinite()
		{
			throw new NotImplementedException();
		}

		public bool HasTop()
		{
			throw new NotImplementedException();
		}

		public bool HasBottom()
		{
			throw new NotImplementedException();
		}

		public bool HasSides()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shell Shell()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face LateralFace()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face TopFace()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face BottomFace()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face StartFace()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face EndFace()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire LateralWire()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire LateralStartWire()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire LateralEndWire()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire TopWire()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire BottomWire()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire StartWire()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire AxisStartWire()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire EndWire()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire AxisEndWire()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge AxisEdge()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge StartEdge()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge EndEdge()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge StartTopEdge()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge StartBottomEdge()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge EndTopEdge()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge EndBottomEdge()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge TopEdge()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge BottomEdge()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex AxisTopVertex()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex AxisBottomVertex()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex TopStartVertex()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex TopEndVertex()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex BottomStartVertex()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex BottomEndVertex()
		{
			throw new NotImplementedException();
		}


	}; // class BRepPrim_OneAxis

}
