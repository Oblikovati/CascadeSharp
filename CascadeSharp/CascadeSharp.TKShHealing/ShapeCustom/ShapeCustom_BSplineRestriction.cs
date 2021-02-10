//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKShHealing.ShapeCustom
{
    //---------------------------------------------------------------------
    //  Class  ShapeCustom_BSplineRestriction
    //---------------------------------------------------------------------
    public sealed class ShapeCustom_BSplineRestriction : ShapeCustom_Modification
    {
        public ShapeCustom_BSplineRestriction()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeCustom_BSplineRestriction(bool anApproxSurfaceFlag, bool anApproxCurve3dFlag,
            bool anApproxCurve2dFlag, double aTol3d, double aTol2d, GeomAbs_Shape aContinuity3d,
            GeomAbs_Shape aContinuity2d, int aMaxDegree, int aNbMaxSeg, bool Degree, bool Rational)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeCustom_BSplineRestriction(bool anApproxSurfaceFlag, bool anApproxCurve3dFlag,
            bool anApproxCurve2dFlag, double aTol3d, double aTol2d, GeomAbs_Shape aContinuity3d,
            GeomAbs_Shape aContinuity2d, int aMaxDegree, int aNbMaxSeg, bool Degree, bool Rational,
            ShapeCustom_RestrictionParameters aModes)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeCustom_BSplineRestriction(ShapeCustom_BSplineRestriction parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool NewSurface(TopoDS_Face F, Geom_Surface S, TopLoc_Location L, ref double Tol, ref bool RevWires,
            ref bool RevFace)
        {
            throw new NotImplementedException();
        }

        public bool NewCurve(TopoDS_Edge E, Geom_Curve C, TopLoc_Location L, ref double Tol)
        {
            throw new NotImplementedException();
        }

        public bool NewCurve2d(TopoDS_Edge E, TopoDS_Face F, TopoDS_Edge NewE, TopoDS_Face NewF, Geom2d_Curve C,
            ref double Tol)
        {
            throw new NotImplementedException();
        }

        public bool ConvertSurface(Geom_Surface aSurface, Geom_Surface S, double UF, double UL, double VF, double VL,
            bool IsOf)
        {
            throw new NotImplementedException();
        }

        public bool ConvertSurface(Geom_Surface aSurface, Geom_Surface S, double UF, double UL, double VF, double VL)
        {
            throw new NotImplementedException();
        }

        public bool ConvertCurve(Geom_Curve aCurve, Geom_Curve C, bool IsConvert, double First, double Last,
            ref double TolCur, bool IsOf)
        {
            throw new NotImplementedException();
        }

        public bool ConvertCurve(Geom_Curve aCurve, Geom_Curve C, bool IsConvert, double First, double Last,
            ref double TolCur)
        {
            throw new NotImplementedException();
        }

        public bool ConvertCurve2d(Geom2d_Curve aCurve, Geom2d_Curve C, bool IsConvert, double First, double Last,
            ref double TolCur, bool IsOf)
        {
            throw new NotImplementedException();
        }

        public bool ConvertCurve2d(Geom2d_Curve aCurve, Geom2d_Curve C, bool IsConvert, double First, double Last,
            ref double TolCur)
        {
            throw new NotImplementedException();
        }

        public void SetTol3d(double Tol3d)
        {
            throw new NotImplementedException();
        }

        public void SetTol2d(double Tol2d)
        {
            throw new NotImplementedException();
        }

        public bool ModifyApproxSurfaceFlag()
        {
            throw new NotImplementedException();
        }

        public bool ModifyApproxCurve3dFlag()
        {
            throw new NotImplementedException();
        }

        public bool ModifyApproxCurve2dFlag()
        {
            throw new NotImplementedException();
        }

        public void SetContinuity3d(GeomAbs_Shape Continuity3d)
        {
            throw new NotImplementedException();
        }

        public void SetContinuity2d(GeomAbs_Shape Continuity2d)
        {
            throw new NotImplementedException();
        }

        public void SetMaxDegree(int MaxDegree)
        {
            throw new NotImplementedException();
        }

        public void SetMaxNbSegments(int MaxNbSegments)
        {
            throw new NotImplementedException();
        }

        public void SetPriority(bool Degree)
        {
            throw new NotImplementedException();
        }

        public void SetConvRational(bool Rational)
        {
            throw new NotImplementedException();
        }

        public ShapeCustom_RestrictionParameters GetRestrictionParameters()
        {
            throw new NotImplementedException();
        }

        public void SetRestrictionParameters(ShapeCustom_RestrictionParameters aModes)
        {
            throw new NotImplementedException();
        }

        public double Curve3dError()
        {
            throw new NotImplementedException();
        }

        public double Curve2dError()
        {
            throw new NotImplementedException();
        }

        public double SurfaceError()
        {
            throw new NotImplementedException();
        }

        public bool NewPoint(TopoDS_Vertex V, gp_Pnt P, ref double Tol)
        {
            throw new NotImplementedException();
        }

        public bool NewParameter(TopoDS_Vertex V, TopoDS_Edge E, ref double P, ref double Tol)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity(TopoDS_Edge E, TopoDS_Face F1, TopoDS_Face F2, TopoDS_Edge NewE,
            TopoDS_Face NewF1, TopoDS_Face NewF2)
        {
            throw new NotImplementedException();
        }

        public double MaxErrors(ref double aCurve3dErr, ref double aCurve2dErr)
        {
            throw new NotImplementedException();
        }

        public int NbOfSpan()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class ShapeCustom_BSplineRestriction
}