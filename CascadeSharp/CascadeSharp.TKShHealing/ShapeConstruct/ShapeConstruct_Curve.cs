//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKShHealing.ShapeConstruct
{
    //---------------------------------------------------------------------
    //  Class  ShapeConstruct_Curve
    //---------------------------------------------------------------------
    public sealed class ShapeConstruct_Curve
    {
        public ShapeConstruct_Curve()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeConstruct_Curve(ShapeConstruct_Curve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool AdjustCurve(Geom_Curve C3D, gp_Pnt P1, gp_Pnt P2, bool take1, bool take2)
        {
            throw new NotImplementedException();
        }

        public bool AdjustCurve(Geom_Curve C3D, gp_Pnt P1, gp_Pnt P2, bool take1)
        {
            throw new NotImplementedException();
        }

        public bool AdjustCurve(Geom_Curve C3D, gp_Pnt P1, gp_Pnt P2)
        {
            throw new NotImplementedException();
        }

        public bool AdjustCurveSegment(Geom_Curve C3D, gp_Pnt P1, gp_Pnt P2, double U1, double U2)
        {
            throw new NotImplementedException();
        }

        public bool AdjustCurve2d(Geom2d_Curve C2D, gp_Pnt2d P1, gp_Pnt2d P2, bool take1, bool take2)
        {
            throw new NotImplementedException();
        }

        public bool AdjustCurve2d(Geom2d_Curve C2D, gp_Pnt2d P1, gp_Pnt2d P2, bool take1)
        {
            throw new NotImplementedException();
        }

        public bool AdjustCurve2d(Geom2d_Curve C2D, gp_Pnt2d P1, gp_Pnt2d P2)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve ConvertToBSpline(Geom_Curve C, double first, double last, double prec)
        {
            throw new NotImplementedException();
        }

        public Geom2d_BSplineCurve ConvertToBSpline(Geom2d_Curve C, double first, double last, double prec)
        {
            throw new NotImplementedException();
        }

        public bool FixKnots(TColStd_HArray1OfReal knots)
        {
            throw new NotImplementedException();
        }

        public bool FixKnots(TColStd_Array1OfReal knots)
        {
            throw new NotImplementedException();
        }
    }; // class ShapeConstruct_Curve
}