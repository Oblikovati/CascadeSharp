//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ShapeCustom
	//---------------------------------------------------------------------
	public  sealed class ShapeCustom
	{

		public ShapeCustom()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeCustom(ShapeCustom parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ApplyModifier(TopoDS_Shape S, BRepTools_Modification M, TopTools_DataMapOfShapeShape context, BRepTools_Modifier MD, Message_ProgressRange theProgress, ShapeBuild_ReShape aReShape)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ApplyModifier(TopoDS_Shape S, BRepTools_Modification M, TopTools_DataMapOfShapeShape context, BRepTools_Modifier MD, Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ApplyModifier(TopoDS_Shape S, BRepTools_Modification M, TopTools_DataMapOfShapeShape context, BRepTools_Modifier MD)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape DirectFaces(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ScaleShape(TopoDS_Shape S, double scale)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape BSplineRestriction(TopoDS_Shape S, double Tol3d, double Tol2d, int MaxDegree, int MaxNbSegment, CascadeSharp.GeomAbs_Shape Continuity3d, CascadeSharp.GeomAbs_Shape Continuity2d, bool Degree, bool Rational, ShapeCustom_RestrictionParameters aParameters)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ConvertToRevolution(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape SweptToElementary(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ConvertToBSpline(TopoDS_Shape S, bool extrMode, bool revolMode, bool offsetMode, bool planeMode)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ConvertToBSpline(TopoDS_Shape S, bool extrMode, bool revolMode, bool offsetMode)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeCustom

}
