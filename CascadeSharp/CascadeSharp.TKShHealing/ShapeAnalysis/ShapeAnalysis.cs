//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ShapeAnalysis
	//---------------------------------------------------------------------
	public  sealed class ShapeAnalysis
	{

		public ShapeAnalysis()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis(ShapeAnalysis parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire OuterWire(TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public double TotCross2D(ShapeExtend_WireData sewd, TopoDS_Face aFace)
		{
			throw new NotImplementedException();
		}

		public double ContourArea(TopoDS_Wire theWire)
		{
			throw new NotImplementedException();
		}

		public bool IsOuterBound(TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public double AdjustByPeriod(double Val, double ToVal, double Period)
		{
			throw new NotImplementedException();
		}

		public double AdjustToPeriod(double Val, double ValMin, double ValMax)
		{
			throw new NotImplementedException();
		}

		public void FindBounds(TopoDS_Shape shape, TopoDS_Vertex V1, TopoDS_Vertex V2)
		{
			throw new NotImplementedException();
		}

		public void GetFaceUVBounds(TopoDS_Face F, ref double Umin, ref double Umax, ref double Vmin, ref double Vmax)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeAnalysis

}
