//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKShHealing.ShapeBuild
{
    //---------------------------------------------------------------------
    //  Class  ShapeBuild_Edge
    //---------------------------------------------------------------------
    public sealed class ShapeBuild_Edge
    {
        public ShapeBuild_Edge()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeBuild_Edge(ShapeBuild_Edge parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge CopyReplaceVertices(TopoDS_Edge edge, TopoDS_Vertex V1, TopoDS_Vertex V2)
        {
            throw new NotImplementedException();
        }

        public void CopyRanges(TopoDS_Edge toedge, TopoDS_Edge fromedge, double alpha, double beta)
        {
            throw new NotImplementedException();
        }

        public void CopyRanges(TopoDS_Edge toedge, TopoDS_Edge fromedge, double alpha)
        {
            throw new NotImplementedException();
        }

        public void CopyRanges(TopoDS_Edge toedge, TopoDS_Edge fromedge)
        {
            throw new NotImplementedException();
        }

        public void SetRange3d(TopoDS_Edge edge, double first, double last)
        {
            throw new NotImplementedException();
        }

        public void CopyPCurves(TopoDS_Edge toedge, TopoDS_Edge fromedge)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge Copy(TopoDS_Edge edge, bool sharepcurves)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge Copy(TopoDS_Edge edge)
        {
            throw new NotImplementedException();
        }

        public void RemovePCurve(TopoDS_Edge edge, TopoDS_Face face)
        {
            throw new NotImplementedException();
        }

        public void RemovePCurve(TopoDS_Edge edge, Geom_Surface surf)
        {
            throw new NotImplementedException();
        }

        public void RemovePCurve(TopoDS_Edge edge, Geom_Surface surf, TopLoc_Location loc)
        {
            throw new NotImplementedException();
        }

        public void ReplacePCurve(TopoDS_Edge edge, Geom2d_Curve pcurve, TopoDS_Face face)
        {
            throw new NotImplementedException();
        }

        public bool ReassignPCurve(TopoDS_Edge edge, TopoDS_Face old, TopoDS_Face sub)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve TransformPCurve(Geom2d_Curve pcurve, gp_Trsf2d trans, double uFact, ref double aFirst,
            ref double aLast)
        {
            throw new NotImplementedException();
        }

        public void RemoveCurve3d(TopoDS_Edge edge)
        {
            throw new NotImplementedException();
        }

        public bool BuildCurve3d(TopoDS_Edge edge)
        {
            throw new NotImplementedException();
        }

        public void MakeEdge(TopoDS_Edge edge, Geom_Curve curve, TopLoc_Location L)
        {
            throw new NotImplementedException();
        }

        public void MakeEdge(TopoDS_Edge edge, Geom_Curve curve, TopLoc_Location L, double p1, double p2)
        {
            throw new NotImplementedException();
        }

        public void MakeEdge(TopoDS_Edge edge, Geom2d_Curve pcurve, TopoDS_Face face)
        {
            throw new NotImplementedException();
        }

        public void MakeEdge(TopoDS_Edge edge, Geom2d_Curve pcurve, TopoDS_Face face, double p1, double p2)
        {
            throw new NotImplementedException();
        }

        public void MakeEdge(TopoDS_Edge edge, Geom2d_Curve pcurve, Geom_Surface S, TopLoc_Location L)
        {
            throw new NotImplementedException();
        }

        public void MakeEdge(TopoDS_Edge edge, Geom2d_Curve pcurve, Geom_Surface S, TopLoc_Location L, double p1,
            double p2)
        {
            throw new NotImplementedException();
        }
    }; // class ShapeBuild_Edge
}