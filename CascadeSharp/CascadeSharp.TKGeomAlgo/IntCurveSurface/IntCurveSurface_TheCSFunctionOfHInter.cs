//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomAlgo.IntCurveSurface
{
    //---------------------------------------------------------------------
    //  Class  IntCurveSurface_TheCSFunctionOfHInter
    //---------------------------------------------------------------------
    public sealed class IntCurveSurface_TheCSFunctionOfHInter : math_FunctionSetWithDerivatives
    {
        public IntCurveSurface_TheCSFunctionOfHInter(Adaptor3d_HSurface S, Adaptor3d_HCurve C)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntCurveSurface_TheCSFunctionOfHInter(IntCurveSurface_TheCSFunctionOfHInter parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntCurveSurface_TheCSFunctionOfHInter()
        {
            throw new NotImplementedException();
        }

        public int NbVariables()
        {
            throw new NotImplementedException();
        }

        public int NbEquations()
        {
            throw new NotImplementedException();
        }

        public bool Value(Vector X, Vector F)
        {
            throw new NotImplementedException();
        }

        public bool Derivatives(Vector X, math_Matrix D)
        {
            throw new NotImplementedException();
        }

        public bool Values(Vector X, Vector F, math_Matrix D)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Point()
        {
            throw new NotImplementedException();
        }

        public double Root()
        {
            throw new NotImplementedException();
        }

        public Adaptor3d_HSurface AuxillarSurface()
        {
            throw new NotImplementedException();
        }

        public Adaptor3d_HCurve AuxillarCurve()
        {
            throw new NotImplementedException();
        }
    }; // class IntCurveSurface_TheCSFunctionOfHInter
}