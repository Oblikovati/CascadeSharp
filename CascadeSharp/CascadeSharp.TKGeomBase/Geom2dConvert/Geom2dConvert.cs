//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG2d.TColGeom2d;
using CascadeSharp.TKMath.Convert;

namespace CascadeSharp.TKGeomBase.Geom2dConvert
{
	//---------------------------------------------------------------------
	//  Class  Geom2dConvert
	//---------------------------------------------------------------------
	public  sealed class Geom2dConvert
	{

		public Geom2dConvert()
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dConvert(Geom2dConvert parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve SplitBSplineCurve(Geom2d_BSplineCurve C, int FromK1, int ToK2, bool SameOrientation)
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve SplitBSplineCurve(Geom2d_BSplineCurve C, int FromK1, int ToK2)
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve SplitBSplineCurve(Geom2d_BSplineCurve C, double FromU1, double ToU2, double ParametricTolerance, bool SameOrientation)
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve SplitBSplineCurve(Geom2d_BSplineCurve C, double FromU1, double ToU2, double ParametricTolerance)
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve CurveToBSplineCurve(Geom2d_Curve C, Convert_ParameterisationType Parameter_isation)
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve CurveToBSplineCurve(Geom2d_Curve C)
		{
			throw new NotImplementedException();
		}

		public void ConcatG1(TColGeom2d_Array1OfBSplineCurve ArrayOfCurves, TColStd_Array1OfReal ArrayOfToler, TColGeom2d_HArray1OfBSplineCurve ArrayOfConcatenated, ref bool ClosedFlag, double ClosedTolerance)
		{
			throw new NotImplementedException();
		}

		public void ConcatC1(TColGeom2d_Array1OfBSplineCurve ArrayOfCurves, TColStd_Array1OfReal ArrayOfToler, TColStd_HArray1OfInteger ArrayOfIndices, TColGeom2d_HArray1OfBSplineCurve ArrayOfConcatenated, ref bool ClosedFlag, double ClosedTolerance)
		{
			throw new NotImplementedException();
		}

		public void ConcatC1(TColGeom2d_Array1OfBSplineCurve ArrayOfCurves, TColStd_Array1OfReal ArrayOfToler, TColStd_HArray1OfInteger ArrayOfIndices, TColGeom2d_HArray1OfBSplineCurve ArrayOfConcatenated, ref bool ClosedFlag, double ClosedTolerance, double AngularTolerance)
		{
			throw new NotImplementedException();
		}

		public void C0BSplineToC1BSplineCurve(Geom2d_BSplineCurve BS, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void C0BSplineToArrayOfC1BSplineCurve(Geom2d_BSplineCurve BS, TColGeom2d_HArray1OfBSplineCurve tabBS, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void C0BSplineToArrayOfC1BSplineCurve(Geom2d_BSplineCurve BS, TColGeom2d_HArray1OfBSplineCurve tabBS, double AngularTolerance, double Tolerance)
		{
			throw new NotImplementedException();
		}


	}; // class Geom2dConvert

}
