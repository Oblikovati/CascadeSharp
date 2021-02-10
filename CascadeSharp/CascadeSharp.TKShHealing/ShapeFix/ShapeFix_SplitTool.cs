//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKShHealing.ShapeBuild;

namespace CascadeSharp.TKShHealing.ShapeFix
{
    //---------------------------------------------------------------------
    //  Class  ShapeFix_SplitTool
    //---------------------------------------------------------------------
    public sealed class ShapeFix_SplitTool
    {
        public ShapeFix_SplitTool()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_SplitTool(ShapeFix_SplitTool parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool SplitEdge(TopoDS_Edge edge, double param, TopoDS_Vertex vert, TopoDS_Face face, TopoDS_Edge newE1,
            TopoDS_Edge newE2, double tol3d, double tol2d)
        {
            throw new NotImplementedException();
        }

        public bool SplitEdge(TopoDS_Edge edge, double param1, double param2, TopoDS_Vertex vert, TopoDS_Face face,
            TopoDS_Edge newE1, TopoDS_Edge newE2, double tol3d, double tol2d)
        {
            throw new NotImplementedException();
        }

        public bool CutEdge(TopoDS_Edge edge, double pend, double cut, TopoDS_Face face, ref bool _iscutline)
        {
            throw new NotImplementedException();
        }

        public bool SplitEdge(TopoDS_Edge edge, double fp, TopoDS_Vertex V1, double lp, TopoDS_Vertex V2,
            TopoDS_Face face, TopTools_SequenceOfShape SeqE, ref int aNum, ShapeBuild_ReShape context, double tol3d,
            double tol2d)
        {
            throw new NotImplementedException();
        }
    }; // class ShapeFix_SplitTool
}