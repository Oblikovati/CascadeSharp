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
    //  Class  GeomInt_MyBSplGradientOfTheComputeLineOfWLApprox
    //---------------------------------------------------------------------
    public sealed class GeomInt_MyBSplGradientOfTheComputeLineOfWLApprox
    {
        public GeomInt_MyBSplGradientOfTheComputeLineOfWLApprox(GeomInt_TheMultiLineOfWLApprox SSP, int FirstPoint,
            int LastPoint, AppParCurves_HArray1OfConstraintCouple TheConstraints, Vector Parameters,
            TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, int Deg, double Tol3d, double Tol2d,
            int NbIterations)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_MyBSplGradientOfTheComputeLineOfWLApprox(GeomInt_TheMultiLineOfWLApprox SSP, int FirstPoint,
            int LastPoint, AppParCurves_HArray1OfConstraintCouple TheConstraints, Vector Parameters,
            TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, int Deg, double Tol3d, double Tol2d)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_MyBSplGradientOfTheComputeLineOfWLApprox(GeomInt_TheMultiLineOfWLApprox SSP, int FirstPoint,
            int LastPoint, AppParCurves_HArray1OfConstraintCouple TheConstraints, Vector Parameters,
            TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, int Deg, double Tol3d, double Tol2d,
            int NbIterations, double lambda1, double lambda2)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_MyBSplGradientOfTheComputeLineOfWLApprox(
            GeomInt_MyBSplGradientOfTheComputeLineOfWLApprox parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_MyBSplGradientOfTheComputeLineOfWLApprox()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_MultiBSpCurve Value()
        {
            throw new NotImplementedException();
        }

        public double Error(int Index)
        {
            throw new NotImplementedException();
        }

        public double MaxError3d()
        {
            throw new NotImplementedException();
        }

        public double MaxError2d()
        {
            throw new NotImplementedException();
        }

        public double AverageError()
        {
            throw new NotImplementedException();
        }

        public void Perform(GeomInt_TheMultiLineOfWLApprox SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints, Vector Parameters, TColStd_Array1OfReal Knots,
            TColStd_Array1OfInteger Mults, int Deg, double Tol3d, double Tol2d, int NbIterations)
        {
            throw new NotImplementedException();
        }

        public void Perform(GeomInt_TheMultiLineOfWLApprox SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints, Vector Parameters, TColStd_Array1OfReal Knots,
            TColStd_Array1OfInteger Mults, int Deg, double Tol3d, double Tol2d)
        {
            throw new NotImplementedException();
        }
    }; // class GeomInt_MyBSplGradientOfTheComputeLineOfWLApprox
}