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
    //  Class  BlendFunc_Corde
    //---------------------------------------------------------------------
    public sealed class BlendFunc_Corde
    {
        public BlendFunc_Corde(Adaptor3d_HSurface S, Adaptor3d_HCurve CGuide)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_Corde(BlendFunc_Corde parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_Corde()
        {
            throw new NotImplementedException();
        }

        public void SetParam(double Param)
        {
            throw new NotImplementedException();
        }

        public void SetDist(double D_ist)
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

        public gp_Pnt PointOnS()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt PointOnGuide()
        {
            throw new NotImplementedException();
        }

        public gp_Vec NPlan()
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

        public gp_Vec2d Tangent2dOnS()
        {
            throw new NotImplementedException();
        }

        public void DerFguide(Vector Sol, gp_Vec2d DerF)
        {
            throw new NotImplementedException();
        }

        public bool IsSolution(Vector Sol, double Tol)
        {
            throw new NotImplementedException();
        }
    }; // class BlendFunc_Corde
}