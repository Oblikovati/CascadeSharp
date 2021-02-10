//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKGeomAlgo.IntSurf;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
    //---------------------------------------------------------------------
    //  Class  IntPatch_TheSurfFunction
    //---------------------------------------------------------------------
    public sealed class IntPatch_TheSurfFunction : math_FunctionSetWithDerivatives
    {
        public IntPatch_TheSurfFunction()
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_TheSurfFunction(Adaptor3d_HSurface PS, IntSurf_Quadric IS)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_TheSurfFunction(IntSurf_Quadric IS)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_TheSurfFunction(IntPatch_TheSurfFunction parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Set(Adaptor3d_HSurface PS)
        {
            throw new NotImplementedException();
        }

        public void SetImplicitSurface(IntSurf_Quadric IS)
        {
            throw new NotImplementedException();
        }

        public void Set(double Tolerance)
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

        public double Root()
        {
            throw new NotImplementedException();
        }

        public double Tolerance()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Point()
        {
            throw new NotImplementedException();
        }

        public bool IsTangent()
        {
            throw new NotImplementedException();
        }

        public gp_Vec Direction3d()
        {
            throw new NotImplementedException();
        }

        public gp_Dir2d Direction2d()
        {
            throw new NotImplementedException();
        }

        public Adaptor3d_HSurface PSurface()
        {
            throw new NotImplementedException();
        }

        public IntSurf_Quadric ISurface()
        {
            throw new NotImplementedException();
        }
    }; // class IntPatch_TheSurfFunction
}