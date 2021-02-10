//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKFillet.Blend;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKFillet.BlendFunc
{
    //---------------------------------------------------------------------
    //  Class  BlendFunc_ConstRad
    //---------------------------------------------------------------------
    public sealed class BlendFunc_ConstRad : Blend_Function
    {
        public BlendFunc_ConstRad(Adaptor3d_HSurface S1, Adaptor3d_HSurface S2, Adaptor3d_HCurve C)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_ConstRad(BlendFunc_ConstRad parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_ConstRad()
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

        public gp_Pnt PointOnS1()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt PointOnS2()
        {
            throw new NotImplementedException();
        }

        public bool IsTangencyPoint()
        {
            throw new NotImplementedException();
        }

        public gp_Vec TangentOnS1()
        {
            throw new NotImplementedException();
        }

        public gp_Vec2d Tangent2dOnS1()
        {
            throw new NotImplementedException();
        }

        public gp_Vec TangentOnS2()
        {
            throw new NotImplementedException();
        }

        public gp_Vec2d Tangent2dOnS2()
        {
            throw new NotImplementedException();
        }

        public void Tangent(double U1, double V1, double U2, double V2, gp_Vec TgFirst, gp_Vec TgLast, gp_Vec NormFirst,
            gp_Vec NormLast)
        {
            throw new NotImplementedException();
        }

        public bool TwistOnS1()
        {
            throw new NotImplementedException();
        }

        public bool TwistOnS2()
        {
            throw new NotImplementedException();
        }

        public void Set(double Radius, int Choix)
        {
            throw new NotImplementedException();
        }

        public void Set(BlendFunc_SectionShape TypeSection)
        {
            throw new NotImplementedException();
        }

        public void Section(double Param, double U1, double V1, double U2, double V2, ref double Pdeb, ref double Pfin,
            gp_Circ C)
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
            TColgp_Array1OfVec D2Poles, TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d,
            TColgp_Array1OfVec2d D2Poles2d, TColStd_Array1OfReal Weigths, TColStd_Array1OfReal DWeigths,
            TColStd_Array1OfReal D2Weigths)
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

        public gp_Ax1 AxeRot(double Prm)
        {
            throw new NotImplementedException();
        }

        public void Resolution(int IC2d, double Tol, ref double TolU, ref double TolV)
        {
            throw new NotImplementedException();
        }

        public bool ComputeValues(Vector X, int Order, bool ByParam, double Param)
        {
            throw new NotImplementedException();
        }

        public bool ComputeValues(Vector X, int Order, bool ByParam)
        {
            throw new NotImplementedException();
        }

        public bool ComputeValues(Vector X, int Order)
        {
            throw new NotImplementedException();
        }
    }; // class BlendFunc_ConstRad
}