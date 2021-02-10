//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKGeomBase.AppParCurves;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomAlgo.GeomInt
{
    //---------------------------------------------------------------------
    //  Class  GeomInt_ResConstraintOfMyGradientbisOfTheComputeLineOfWLApprox
    //---------------------------------------------------------------------
    public sealed class GeomInt_ResConstraintOfMyGradientbisOfTheComputeLineOfWLApprox
    {
        public GeomInt_ResConstraintOfMyGradientbisOfTheComputeLineOfWLApprox(GeomInt_TheMultiLineOfWLApprox SSP,
            AppParCurves_MultiCurve SCurv, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple Constraints, math_Matrix Bern, math_Matrix DerivativeBern,
            double Tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_ResConstraintOfMyGradientbisOfTheComputeLineOfWLApprox(GeomInt_TheMultiLineOfWLApprox SSP,
            AppParCurves_MultiCurve SCurv, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple Constraints, math_Matrix Bern, math_Matrix DerivativeBern)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_ResConstraintOfMyGradientbisOfTheComputeLineOfWLApprox(
            GeomInt_ResConstraintOfMyGradientbisOfTheComputeLineOfWLApprox parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_ResConstraintOfMyGradientbisOfTheComputeLineOfWLApprox()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public double Error()
        {
            throw new NotImplementedException();
        }

        public math_Matrix ConstraintMatrix()
        {
            throw new NotImplementedException();
        }

        public Vector Duale()
        {
            throw new NotImplementedException();
        }

        public math_Matrix ConstraintDerivative(GeomInt_TheMultiLineOfWLApprox SSP, Vector Parameters, int Deg,
            math_Matrix DA)
        {
            throw new NotImplementedException();
        }

        public math_Matrix InverseMatrix()
        {
            throw new NotImplementedException();
        }

        public int NbConstraints(GeomInt_TheMultiLineOfWLApprox SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints)
        {
            throw new NotImplementedException();
        }

        public int NbColumns(GeomInt_TheMultiLineOfWLApprox SSP, int Deg)
        {
            throw new NotImplementedException();
        }
    }; // class GeomInt_ResConstraintOfMyGradientbisOfTheComputeLineOfWLApprox
}