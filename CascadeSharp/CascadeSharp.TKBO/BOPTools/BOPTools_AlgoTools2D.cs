//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBO.IntTools;
using CascadeSharp.TKBRep.BRepAdaptor;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBO.BOPTools
{
    //---------------------------------------------------------------------
    //  Class  BOPTools_AlgoTools2D
    //---------------------------------------------------------------------
    public sealed class BOPTools_AlgoTools2D
    {
        public BOPTools_AlgoTools2D()
            : base()
        {
            throw new NotImplementedException();
        }

        public BOPTools_AlgoTools2D(BOPTools_AlgoTools2D parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void BuildPCurveForEdgeOnFace(TopoDS_Edge aE, TopoDS_Face aF, IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public void BuildPCurveForEdgeOnFace(TopoDS_Edge aE, TopoDS_Face aF)
        {
            throw new NotImplementedException();
        }

        public bool EdgeTangent(TopoDS_Edge anE, double aT, gp_Vec Tau)
        {
            throw new NotImplementedException();
        }

        public void PointOnSurface(TopoDS_Edge aE, TopoDS_Face aF, double aT, ref double U, ref double V,
            IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public void PointOnSurface(TopoDS_Edge aE, TopoDS_Face aF, double aT, ref double U, ref double V)
        {
            throw new NotImplementedException();
        }

        public void CurveOnSurface(TopoDS_Edge aE, TopoDS_Face aF, Geom2d_Curve aC, ref double aToler,
            IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public void CurveOnSurface(TopoDS_Edge aE, TopoDS_Face aF, Geom2d_Curve aC, ref double aToler)
        {
            throw new NotImplementedException();
        }

        public void CurveOnSurface(TopoDS_Edge aE, TopoDS_Face aF, Geom2d_Curve aC, ref double aFirst, ref double aLast,
            ref double aToler, IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public void CurveOnSurface(TopoDS_Edge aE, TopoDS_Face aF, Geom2d_Curve aC, ref double aFirst, ref double aLast,
            ref double aToler)
        {
            throw new NotImplementedException();
        }

        public bool HasCurveOnSurface(TopoDS_Edge aE, TopoDS_Face aF, Geom2d_Curve aC, ref double aFirst,
            ref double aLast, ref double aToler)
        {
            throw new NotImplementedException();
        }

        public bool HasCurveOnSurface(TopoDS_Edge aE, TopoDS_Face aF)
        {
            throw new NotImplementedException();
        }

        public void AdjustPCurveOnFace(TopoDS_Face theF, Geom_Curve theC3D, Geom2d_Curve theC2D, Geom2d_Curve theC2DA,
            IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public void AdjustPCurveOnFace(TopoDS_Face theF, Geom_Curve theC3D, Geom2d_Curve theC2D, Geom2d_Curve theC2DA)
        {
            throw new NotImplementedException();
        }

        public void AdjustPCurveOnFace(TopoDS_Face theF, double theFirst, double theLast, Geom2d_Curve theC2D,
            Geom2d_Curve theC2DA, IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public void AdjustPCurveOnFace(TopoDS_Face theF, double theFirst, double theLast, Geom2d_Curve theC2D,
            Geom2d_Curve theC2DA)
        {
            throw new NotImplementedException();
        }

        public void AdjustPCurveOnSurf(BRepAdaptor_Surface aF, double aT1, double aT2, Geom2d_Curve aC2D,
            Geom2d_Curve aC2DA)
        {
            throw new NotImplementedException();
        }

        public double IntermediatePoint(double aFirst, double aLast)
        {
            throw new NotImplementedException();
        }

        public double IntermediatePoint(TopoDS_Edge anE)
        {
            throw new NotImplementedException();
        }

        public void Make2D(TopoDS_Edge aE, TopoDS_Face aF, Geom2d_Curve aC, ref double aFirst, ref double aLast,
            ref double aToler, IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public void Make2D(TopoDS_Edge aE, TopoDS_Face aF, Geom2d_Curve aC, ref double aFirst, ref double aLast,
            ref double aToler)
        {
            throw new NotImplementedException();
        }

        public void MakePCurveOnFace(TopoDS_Face aF, Geom_Curve C3D, Geom2d_Curve aC, ref double aToler,
            IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public void MakePCurveOnFace(TopoDS_Face aF, Geom_Curve C3D, Geom2d_Curve aC, ref double aToler)
        {
            throw new NotImplementedException();
        }

        public void MakePCurveOnFace(TopoDS_Face aF, Geom_Curve C3D, double aT1, double aT2, Geom2d_Curve aC,
            ref double aToler, IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public void MakePCurveOnFace(TopoDS_Face aF, Geom_Curve C3D, double aT1, double aT2, Geom2d_Curve aC,
            ref double aToler)
        {
            throw new NotImplementedException();
        }

        public int AttachExistingPCurve(TopoDS_Edge aEold, TopoDS_Edge aEnew, TopoDS_Face aF, IntTools_Context aCtx)
        {
            throw new NotImplementedException();
        }

        public void IsEdgeIsoline(TopoDS_Edge theE, TopoDS_Face theF, ref bool _isTheUIso, ref bool _isTheVIso)
        {
            throw new NotImplementedException();
        }
    }; // class BOPTools_AlgoTools2D
}