//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKShHealing.ShapeBuild;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeFix
{
    //---------------------------------------------------------------------
    //  Class  ShapeFix_IntersectionTool
    //---------------------------------------------------------------------
    public sealed class ShapeFix_IntersectionTool
    {
        public ShapeFix_IntersectionTool(ShapeBuild_ReShape context, double preci, double maxtol)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_IntersectionTool(ShapeBuild_ReShape context, double preci)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_IntersectionTool(ShapeFix_IntersectionTool parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_IntersectionTool()
        {
            throw new NotImplementedException();
        }

        public ShapeBuild_ReShape Context()
        {
            throw new NotImplementedException();
        }

        public bool SplitEdge(TopoDS_Edge edge, double param, TopoDS_Vertex vert, TopoDS_Face face, TopoDS_Edge newE1,
            TopoDS_Edge newE2, double preci)
        {
            throw new NotImplementedException();
        }

        public bool CutEdge(TopoDS_Edge edge, double pend, double cut, TopoDS_Face face, ref bool _iscutline)
        {
            throw new NotImplementedException();
        }

        public bool FixSelfIntersectWire(ShapeExtend_WireData sewd, TopoDS_Face face, ref int NbSplit, ref int NbCut,
            ref int NbRemoved)
        {
            throw new NotImplementedException();
        }

        public bool FixIntersectingWires(TopoDS_Face face)
        {
            throw new NotImplementedException();
        }

        public bool SplitEdge1(ShapeExtend_WireData sewd, TopoDS_Face face, int num, double param, TopoDS_Vertex vert,
            double preci, ShapeFix_DataMapOfShapeBox2d boxes)
        {
            throw new NotImplementedException();
        }

        public bool SplitEdge2(ShapeExtend_WireData sewd, TopoDS_Face face, int num, double param1, double param2,
            TopoDS_Vertex vert, double preci, ShapeFix_DataMapOfShapeBox2d boxes)
        {
            throw new NotImplementedException();
        }

        public bool UnionVertexes(ShapeExtend_WireData sewd, TopoDS_Edge edge1, TopoDS_Edge edge2, int num2,
            ShapeFix_DataMapOfShapeBox2d boxes, Bnd_Box2d B2)
        {
            throw new NotImplementedException();
        }

        public bool FindVertAndSplitEdge(double param1, TopoDS_Edge edge1, TopoDS_Edge edge2, Geom2d_Curve Crv1,
            ref double MaxTolVert, ref int num1, ShapeExtend_WireData sewd, TopoDS_Face face,
            ShapeFix_DataMapOfShapeBox2d boxes, bool aTmpKey)
        {
            throw new NotImplementedException();
        }
    }; // class ShapeFix_IntersectionTool
}