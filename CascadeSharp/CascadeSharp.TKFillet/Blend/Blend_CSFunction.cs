//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKFillet.Blend
{
    //---------------------------------------------------------------------
    //  Class  Blend_CSFunction
    //---------------------------------------------------------------------
    public abstract class Blend_CSFunction : Blend_AppFunction
    {
        public Blend_CSFunction()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Blend_CSFunction(Blend_CSFunction parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
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

        public void Set(double Param)
        {
            throw new NotImplementedException();
        }

        public void Set(double First, double Last)
        {
            throw new NotImplementedException();
        }

        public void GetTolerance(Vector Tolerance, double Tol)
        {
            throw new NotImplementedException();
        }

        public void GetBounds(Vector InfBound, Vector SupBound)
        {
            throw new NotImplementedException();
        }

        public bool IsSolution(Vector Sol, double Tol)
        {
            throw new NotImplementedException();
        }

        public double GetMinimalDistance()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Pnt1()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Pnt2()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt PointOnS()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt PointOnC()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d Pnt2d()
        {
            throw new NotImplementedException();
        }

        public double ParameterOnC()
        {
            throw new NotImplementedException();
        }

        public bool IsTangencyPoint()
        {
            throw new NotImplementedException();
        }

        public gp_Vec TangentOnS()
        {
            throw new NotImplementedException();
        }

        public gp_Vec2d Tangent2d()
        {
            throw new NotImplementedException();
        }

        public gp_Vec TangentOnC()
        {
            throw new NotImplementedException();
        }

        public void Tangent(double U, double V, gp_Vec TgS, gp_Vec NormS)
        {
            throw new NotImplementedException();
        }

        public void GetShape(ref int NbPoles, ref int NbKnots, ref int Degree, ref int NbPoles2d)
        {
            throw new NotImplementedException();
        }

        public void GetTolerance(double BoundTol, double SurfTol, double AngleTol, Vector Tol3d, Vector Tol1D)
        {
            throw new NotImplementedException();
        }

        public void Knots(TColStd_Array1OfReal TKnots)
        {
            throw new NotImplementedException();
        }

        public void Mults(TColStd_Array1OfInteger TMults)
        {
            throw new NotImplementedException();
        }

        public bool Section(Blend_Point P, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles,
            TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d, TColStd_Array1OfReal Weigths,
            TColStd_Array1OfReal DWeigths)
        {
            throw new NotImplementedException();
        }

        public void Section(Blend_Point P, TColgp_Array1OfPnt Poles, TColgp_Array1OfPnt2d Poles2d,
            TColStd_Array1OfReal Weigths)
        {
            throw new NotImplementedException();
        }

        public bool Section(Blend_Point P, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles,
            TColgp_Array1OfVec D2Poles, TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d,
            TColgp_Array1OfVec2d D2Poles2d, TColStd_Array1OfReal Weigths, TColStd_Array1OfReal DWeigths,
            TColStd_Array1OfReal D2Weigths)
        {
            throw new NotImplementedException();
        }
    }; // class Blend_CSFunction
}