//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TColGeom;
using CascadeSharp.TKMath.Convert;

namespace CascadeSharp.TKGeomBase.GeomConvert
{
    //---------------------------------------------------------------------
    //  Class  GeomConvert
    //---------------------------------------------------------------------
    public sealed class GeomConvert
    {
        public GeomConvert()
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomConvert(GeomConvert parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve SplitBSplineCurve(Geom_BSplineCurve C, int FromK1, int ToK2, bool SameOrientation)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve SplitBSplineCurve(Geom_BSplineCurve C, int FromK1, int ToK2)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve SplitBSplineCurve(Geom_BSplineCurve C, double FromU1, double ToU2,
            double ParametricTolerance, bool SameOrientation)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve SplitBSplineCurve(Geom_BSplineCurve C, double FromU1, double ToU2,
            double ParametricTolerance)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface SplitBSplineSurface(Geom_BSplineSurface S, int FromUK1, int ToUK2, int FromVK1,
            int ToVK2, bool SameUOrientation, bool SameVOrientation)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface SplitBSplineSurface(Geom_BSplineSurface S, int FromUK1, int ToUK2, int FromVK1,
            int ToVK2, bool SameUOrientation)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface SplitBSplineSurface(Geom_BSplineSurface S, int FromUK1, int ToUK2, int FromVK1,
            int ToVK2)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface SplitBSplineSurface(Geom_BSplineSurface S, int FromK1, int ToK2, bool USplit,
            bool SameOrientation)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface SplitBSplineSurface(Geom_BSplineSurface S, int FromK1, int ToK2, bool USplit)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface SplitBSplineSurface(Geom_BSplineSurface S, double FromU1, double ToU2, double FromV1,
            double ToV2, double ParametricTolerance, bool SameUOrientation, bool SameVOrientation)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface SplitBSplineSurface(Geom_BSplineSurface S, double FromU1, double ToU2, double FromV1,
            double ToV2, double ParametricTolerance, bool SameUOrientation)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface SplitBSplineSurface(Geom_BSplineSurface S, double FromU1, double ToU2, double FromV1,
            double ToV2, double ParametricTolerance)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface SplitBSplineSurface(Geom_BSplineSurface S, double FromParam1, double ToParam2,
            bool USplit, double ParametricTolerance, bool SameOrientation)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface SplitBSplineSurface(Geom_BSplineSurface S, double FromParam1, double ToParam2,
            bool USplit, double ParametricTolerance)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve CurveToBSplineCurve(Geom_Curve C, Convert_ParameterisationType Parameter_isation)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve CurveToBSplineCurve(Geom_Curve C)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface SurfaceToBSplineSurface(Geom_Surface S)
        {
            throw new NotImplementedException();
        }

        public void ConcatG1(TColGeom_Array1OfBSplineCurve ArrayOfCurves, TColStd_Array1OfReal ArrayOfToler,
            TColGeom_HArray1OfBSplineCurve ArrayOfConcatenated, ref bool ClosedFlag, double ClosedTolerance)
        {
            throw new NotImplementedException();
        }

        public void ConcatC1(TColGeom_Array1OfBSplineCurve ArrayOfCurves, TColStd_Array1OfReal ArrayOfToler,
            TColStd_HArray1OfInteger ArrayOfIndices, TColGeom_HArray1OfBSplineCurve ArrayOfConcatenated,
            ref bool ClosedFlag, double ClosedTolerance)
        {
            throw new NotImplementedException();
        }

        public void ConcatC1(TColGeom_Array1OfBSplineCurve ArrayOfCurves, TColStd_Array1OfReal ArrayOfToler,
            TColStd_HArray1OfInteger ArrayOfIndices, TColGeom_HArray1OfBSplineCurve ArrayOfConcatenated,
            ref bool ClosedFlag, double ClosedTolerance, double AngularTolerance)
        {
            throw new NotImplementedException();
        }

        public void C0BSplineToC1BSplineCurve(Geom_BSplineCurve BS, double tolerance, double AngularTolerance)
        {
            throw new NotImplementedException();
        }

        public void C0BSplineToC1BSplineCurve(Geom_BSplineCurve BS, double tolerance)
        {
            throw new NotImplementedException();
        }

        public void C0BSplineToArrayOfC1BSplineCurve(Geom_BSplineCurve BS, TColGeom_HArray1OfBSplineCurve tabBS,
            double tolerance)
        {
            throw new NotImplementedException();
        }

        public void C0BSplineToArrayOfC1BSplineCurve(Geom_BSplineCurve BS, TColGeom_HArray1OfBSplineCurve tabBS,
            double AngularTolerance, double tolerance)
        {
            throw new NotImplementedException();
        }
    }; // class GeomConvert
}