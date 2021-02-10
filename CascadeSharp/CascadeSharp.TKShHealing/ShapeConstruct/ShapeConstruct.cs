//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ShapeConstruct
	//---------------------------------------------------------------------
	public  sealed class ShapeConstruct
	{

		public ShapeConstruct()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeConstruct(ShapeConstruct parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_BSplineCurve ConvertCurveToBSpline(Geom_Curve C3D, double First, double Last, double Tol3d, CascadeSharp.GeomAbs_Shape Continuity, int MaxSegments, int MaxDegree)
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve ConvertCurveToBSpline(Geom2d_Curve C2D, double First, double Last, double Tol2d, CascadeSharp.GeomAbs_Shape Continuity, int MaxSegments, int MaxDegree)
		{
			throw new NotImplementedException();
		}

		public Geom_BSplineSurface ConvertSurfaceToBSpline(Geom_Surface surf, double UF, double UL, double VF, double VL, double Tol3d, CascadeSharp.GeomAbs_Shape Continuity, int MaxSegments, int MaxDegree)
		{
			throw new NotImplementedException();
		}

		public bool JoinPCurves(TopTools_HSequenceOfShape theEdges, TopoDS_Face theFace, TopoDS_Edge theEdge)
		{
			throw new NotImplementedException();
		}

		public bool JoinCurves(Geom_Curve c3d1, Geom_Curve ac3d2, CascadeSharp.TopAbs_Orientation Orient1, CascadeSharp.TopAbs_Orientation Orient2, ref double first1, ref double last1, ref double first2, ref double last2, Geom_Curve c3dOut, ref bool _isRev1, ref bool _isRev2)
		{
			throw new NotImplementedException();
		}

		public bool JoinCurves(Geom2d_Curve c2d1, Geom2d_Curve ac2d2, CascadeSharp.TopAbs_Orientation Orient1, CascadeSharp.TopAbs_Orientation Orient2, ref double first1, ref double last1, ref double first2, ref double last2, Geom2d_Curve c2dOut, ref bool _isRev1, ref bool _isRev2, bool _isError)
		{
			throw new NotImplementedException();
		}

		public bool JoinCurves(Geom2d_Curve c2d1, Geom2d_Curve ac2d2, CascadeSharp.TopAbs_Orientation Orient1, CascadeSharp.TopAbs_Orientation Orient2, ref double first1, ref double last1, ref double first2, ref double last2, Geom2d_Curve c2dOut, ref bool _isRev1, ref bool _isRev2)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeConstruct

}
