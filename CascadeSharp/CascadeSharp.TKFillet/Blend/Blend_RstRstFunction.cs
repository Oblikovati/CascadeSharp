//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKFillet.Blend
{
    //---------------------------------------------------------------------
    //  Class  Blend_RstRstFunction
    //---------------------------------------------------------------------
    public abstract class Blend_RstRstFunction : Blend_AppFunction
    {
        public Blend_RstRstFunction()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Blend_RstRstFunction(Blend_RstRstFunction parameter1)
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

        public bool Value(math_Vector X, math_Vector F)
        {
            throw new NotImplementedException();
        }

        public bool Derivatives(math_Vector X, math_Matrix D)
        {
            throw new NotImplementedException();
        }

        public bool Values(math_Vector X, math_Vector F, math_Matrix D)
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

        public void GetTolerance(math_Vector Tolerance, double Tol)
        {
            throw new NotImplementedException();
        }

        public void GetBounds(math_Vector InfBound, math_Vector SupBound)
        {
            throw new NotImplementedException();
        }

        public bool IsSolution(math_Vector Sol, double Tol)
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

        public gp_Pnt PointOnRst1()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt PointOnRst2()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d Pnt2dOnRst1()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d Pnt2dOnRst2()
        {
            throw new NotImplementedException();
        }

        public double ParameterOnRst1()
        {
            throw new NotImplementedException();
        }

        public double ParameterOnRst2()
        {
            throw new NotImplementedException();
        }

        public bool IsTangencyPoint()
        {
            throw new NotImplementedException();
        }

        public gp_Vec TangentOnRst1()
        {
            throw new NotImplementedException();
        }

        public gp_Vec2d Tangent2dOnRst1()
        {
            throw new NotImplementedException();
        }

        public gp_Vec TangentOnRst2()
        {
            throw new NotImplementedException();
        }

        public gp_Vec2d Tangent2dOnRst2()
        {
            throw new NotImplementedException();
        }

        public Blend_DecrochStatus Decroch(math_Vector Sol, gp_Vec NRst1, gp_Vec TgRst1, gp_Vec NRst2, gp_Vec TgRst2)
        {
            throw new NotImplementedException();
        }

        public bool IsRational()
        {
            throw new NotImplementedException();
        }

        public double GetSectionSize()
        {
            throw new NotImplementedException();
        }

        public void GetMinimalWeight(TColStd_Array1OfReal Weigths)
        {
            throw new NotImplementedException();
        }

        public int NbIntervals(GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public void Intervals(TColStd_Array1OfReal T, GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public void GetShape(ref int NbPoles, ref int NbKnots, ref int Degree, ref int NbPoles2d)
        {
            throw new NotImplementedException();
        }

        public void GetTolerance(double BoundTol, double SurfTol, double AngleTol, math_Vector Tol3d, math_Vector Tol1D)
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

        public void Section(Blend_Point P, TColgp_Array1OfPnt Poles, TColgp_Array1OfPnt2d Poles2d,
            TColStd_Array1OfReal Weigths)
        {
            throw new NotImplementedException();
        }

        public bool Section(Blend_Point P, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles,
            TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d, TColStd_Array1OfReal Weigths,
            TColStd_Array1OfReal DWeigths)
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
    }; // class Blend_RstRstFunction
}