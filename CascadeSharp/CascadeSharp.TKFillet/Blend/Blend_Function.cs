//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKFillet.Blend
{
    //---------------------------------------------------------------------
    //  Class  Blend_Function
    //---------------------------------------------------------------------
    public abstract class Blend_Function : Blend_AppFunction
    {
        public Blend_Function()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Blend_Function(Blend_Function parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public int NbVariables()
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
    }; // class Blend_Function
}