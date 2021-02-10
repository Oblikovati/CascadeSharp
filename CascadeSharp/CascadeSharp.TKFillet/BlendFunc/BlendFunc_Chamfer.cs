//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKFillet.BlendFunc
{
    //---------------------------------------------------------------------
    //  Class  BlendFunc_Chamfer
    //---------------------------------------------------------------------
    public sealed class BlendFunc_Chamfer : BlendFunc_GenChamfer
    {
        public BlendFunc_Chamfer(Adaptor3d_HSurface S1, Adaptor3d_HSurface S2, Adaptor3d_HCurve CG)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_Chamfer(BlendFunc_Chamfer parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_Chamfer()
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

        public void Set(double Param)
        {
            throw new NotImplementedException();
        }

        public bool IsSolution(math_Vector Sol, double Tol)
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

        public void Set(double D_ist1, double D_ist2, int Choix)
        {
            throw new NotImplementedException();
        }

        public double GetSectionSize()
        {
            throw new NotImplementedException();
        }
    }; // class BlendFunc_Chamfer
}