//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  IntTools_BeanFaceIntersector
	//---------------------------------------------------------------------
	public  sealed class IntTools_BeanFaceIntersector
	{

		public IntTools_BeanFaceIntersector()
			: base()
		{
			throw new NotImplementedException();
		}

		public IntTools_BeanFaceIntersector(TopoDS_Edge theEdge, TopoDS_Face theFace)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntTools_BeanFaceIntersector(BRepAdaptor_Curve theCurve, BRepAdaptor_Surface theSurface, double theBeanTolerance, double theFaceTolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntTools_BeanFaceIntersector(BRepAdaptor_Curve theCurve, BRepAdaptor_Surface theSurface, double theFirstParOnCurve, double theLastParOnCurve, double theUMinParameter, double theUMaxParameter, double theVMinParameter, double theVMaxParameter, double theBeanTolerance, double theFaceTolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntTools_BeanFaceIntersector(IntTools_BeanFaceIntersector parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Edge theEdge, TopoDS_Face theFace)
		{
			throw new NotImplementedException();
		}

		public void Init(BRepAdaptor_Curve theCurve, BRepAdaptor_Surface theSurface, double theBeanTolerance, double theFaceTolerance)
		{
			throw new NotImplementedException();
		}

		public void Init(BRepAdaptor_Curve theCurve, BRepAdaptor_Surface theSurface, double theFirstParOnCurve, double theLastParOnCurve, double theUMinParameter, double theUMaxParameter, double theVMinParameter, double theVMaxParameter, double theBeanTolerance, double theFaceTolerance)
		{
			throw new NotImplementedException();
		}

		public void SetContext(IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public IntTools_Context Context()
		{
			throw new NotImplementedException();
		}

		public void SetBeanParameters(double theFirstParOnCurve, double theLastParOnCurve)
		{
			throw new NotImplementedException();
		}

		public void SetSurfaceParameters(double theUMinParameter, double theUMaxParameter, double theVMinParameter, double theVMaxParameter)
		{
			throw new NotImplementedException();
		}

		public void Perform()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public IntTools_SequenceOfRanges Result()
		{
			throw new NotImplementedException();
		}

		public void Result(IntTools_SequenceOfRanges theResults)
		{
			throw new NotImplementedException();
		}

		public double MinimalSquareDistance()
		{
			throw new NotImplementedException();
		}

		public void ComputeAroundExactIntersection()
		{
			throw new NotImplementedException();
		}

		public void ComputeLinePlane()
		{
			throw new NotImplementedException();
		}

		public bool FastComputeAnalytic()
		{
			throw new NotImplementedException();
		}

		public void ComputeUsingExtremum()
		{
			throw new NotImplementedException();
		}

		public void ComputeNearRangeBoundaries()
		{
			throw new NotImplementedException();
		}

		public bool ComputeLocalized()
		{
			throw new NotImplementedException();
		}

		public void ComputeRangeFromStartPoint(bool ToIncreaseParameter, double theParameter, double theUParameter, double theVParameter)
		{
			throw new NotImplementedException();
		}

		public void ComputeRangeFromStartPoint(bool ToIncreaseParameter, double theParameter, double theUParameter, double theVParameter, int theIndex)
		{
			throw new NotImplementedException();
		}

		public double Distance(double theArg, ref double theUParameter, ref double theVParameter)
		{
			throw new NotImplementedException();
		}

		public double Distance(double theArg)
		{
			throw new NotImplementedException();
		}

		public bool LocalizeSolutions(IntTools_CurveRangeSample theCurveRange, Bnd_Box theBoxCurve, IntTools_SurfaceRangeSample theSurfaceRange, Bnd_Box theBoxSurface, IntTools_CurveRangeLocalizeData theCurveData, IntTools_SurfaceRangeLocalizeData theSurfaceData, IntTools_ListOfCurveRangeSample theL_istCurveRange, IntTools_ListOfSurfaceRangeSample theL_istSurfaceRange)
		{
			throw new NotImplementedException();
		}

		public bool TestComputeCoinside()
		{
			throw new NotImplementedException();
		}


	}; // class IntTools_BeanFaceIntersector

}
