//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ShapeUpgrade_FixSmallCurves
	//---------------------------------------------------------------------
	public  class ShapeUpgrade_FixSmallCurves : CascadeSharp.ShapeUpgrade_Tool
	{

		public ShapeUpgrade_FixSmallCurves()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeUpgrade_FixSmallCurves(ShapeUpgrade_FixSmallCurves parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Edge theEdge, TopoDS_Face theFace)
		{
			throw new NotImplementedException();
		}

		public bool Approx(Geom_Curve Curve3d, Geom2d_Curve Curve2d, Geom2d_Curve Curve2dR, ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public void SetSplitCurve3dTool(ShapeUpgrade_SplitCurve3d splitCurve3dTool)
		{
			throw new NotImplementedException();
		}

		public void SetSplitCurve2dTool(ShapeUpgrade_SplitCurve2d splitCurve2dTool)
		{
			throw new NotImplementedException();
		}

		public bool Status(CascadeSharp.ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public ShapeUpgrade_SplitCurve3d GetSplitCurve3dTool()
		{
			throw new NotImplementedException();
		}

		public ShapeUpgrade_SplitCurve2d GetSplitCurve2dTool()
		{
			throw new NotImplementedException();
		}


	}; // class ShapeUpgrade_FixSmallCurves

}
