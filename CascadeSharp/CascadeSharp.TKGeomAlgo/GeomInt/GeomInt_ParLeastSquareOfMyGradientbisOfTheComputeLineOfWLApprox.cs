//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKGeomBase.AppParCurves;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomAlgo.GeomInt
{
    //---------------------------------------------------------------------
    //  Class  GeomInt_ParLeastSquareOfMyGradientbisOfTheComputeLineOfWLApprox
    //---------------------------------------------------------------------
    public sealed class GeomInt_ParLeastSquareOfMyGradientbisOfTheComputeLineOfWLApprox
    {
        public GeomInt_ParLeastSquareOfMyGradientbisOfTheComputeLineOfWLApprox(GeomInt_TheMultiLineOfWLApprox SSP,
            int FirstPoint, int LastPoint, AppParCurves_Constraint FirstCons, AppParCurves_Constraint LastCons,
            Vector Parameters, int NbPol)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_ParLeastSquareOfMyGradientbisOfTheComputeLineOfWLApprox(GeomInt_TheMultiLineOfWLApprox SSP,
            int FirstPoint, int LastPoint, AppParCurves_Constraint FirstCons, AppParCurves_Constraint LastCons,
            int NbPol)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_ParLeastSquareOfMyGradientbisOfTheComputeLineOfWLApprox(GeomInt_TheMultiLineOfWLApprox SSP,
            TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, int FirstPoint, int LastPoint,
            AppParCurves_Constraint FirstCons, AppParCurves_Constraint LastCons, Vector Parameters, int NbPol)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_ParLeastSquareOfMyGradientbisOfTheComputeLineOfWLApprox(GeomInt_TheMultiLineOfWLApprox SSP,
            TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, int FirstPoint, int LastPoint,
            AppParCurves_Constraint FirstCons, AppParCurves_Constraint LastCons, int NbPol)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_ParLeastSquareOfMyGradientbisOfTheComputeLineOfWLApprox(
            GeomInt_ParLeastSquareOfMyGradientbisOfTheComputeLineOfWLApprox parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_ParLeastSquareOfMyGradientbisOfTheComputeLineOfWLApprox()
        {
            throw new NotImplementedException();
        }

        public void Perform(Vector Parameters)
        {
            throw new NotImplementedException();
        }

        public void Perform(Vector Parameters, double l1, double l2)
        {
            throw new NotImplementedException();
        }

        public void Perform(Vector Parameters, Vector V1t, Vector V2t, double l1, double l2)
        {
            throw new NotImplementedException();
        }

        public void Perform(Vector Parameters, Vector V1t, Vector V2t, Vector V1c, Vector V2c,
            double l1, double l2)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_MultiCurve BezierValue()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_MultiBSpCurve BSplineValue()
        {
            throw new NotImplementedException();
        }

        public math_Matrix FunctionMatrix()
        {
            throw new NotImplementedException();
        }

        public math_Matrix DerivativeFunctionMatrix()
        {
            throw new NotImplementedException();
        }

        public void ErrorGradient(Vector Grad, ref double F, ref double MaxE3d, ref double MaxE2d)
        {
            throw new NotImplementedException();
        }

        public math_Matrix Distance()
        {
            throw new NotImplementedException();
        }

        public void Error(ref double F, ref double MaxE3d, ref double MaxE2d)
        {
            throw new NotImplementedException();
        }

        public double FirstLambda()
        {
            throw new NotImplementedException();
        }

        public double LastLambda()
        {
            throw new NotImplementedException();
        }

        public math_Matrix Points()
        {
            throw new NotImplementedException();
        }

        public math_Matrix Poles()
        {
            throw new NotImplementedException();
        }

        public math_IntegerVector KIndex()
        {
            throw new NotImplementedException();
        }

        public void Init(GeomInt_TheMultiLineOfWLApprox SSP, int FirstPoint, int LastPoint)
        {
            throw new NotImplementedException();
        }

        public int NbBColumns(GeomInt_TheMultiLineOfWLApprox SSP)
        {
            throw new NotImplementedException();
        }

        public int TheFirstPoint(AppParCurves_Constraint FirstCons, int FirstPoint)
        {
            throw new NotImplementedException();
        }

        public int TheLastPoint(AppParCurves_Constraint LastCons, int LastPoint)
        {
            throw new NotImplementedException();
        }

        public void Affect(GeomInt_TheMultiLineOfWLApprox SSP, int Index, ref AppParCurves_Constraint Cons,
            Vector Vt, Vector Vc)
        {
            throw new NotImplementedException();
        }

        public void ComputeFunction(Vector Parameters)
        {
            throw new NotImplementedException();
        }

        public void SearchIndex(math_IntegerVector Index)
        {
            throw new NotImplementedException();
        }

        public void MakeTAA(Vector TheA, Vector TheB)
        {
            throw new NotImplementedException();
        }

        public void MakeTAA(Vector TheA)
        {
            throw new NotImplementedException();
        }

        public void MakeTAA(Vector TheA, math_Matrix TheB)
        {
            throw new NotImplementedException();
        }
    }; // class GeomInt_ParLeastSquareOfMyGradientbisOfTheComputeLineOfWLApprox
}