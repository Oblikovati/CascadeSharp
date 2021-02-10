//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBO.IntTools;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBO.BOPTools
{
    //---------------------------------------------------------------------
    //  Class  BOPTools_AlgoTools3D
    //---------------------------------------------------------------------
    public sealed class BOPTools_AlgoTools3D
    {
        public BOPTools_AlgoTools3D()
            : base()
        {
            throw new NotImplementedException();
        }

        public BOPTools_AlgoTools3D(BOPTools_AlgoTools3D parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool DoSplitSEAMOnFace(TopoDS_Edge theESplit, TopoDS_Face theFace)
        {
            throw new NotImplementedException();
        }

        public bool DoSplitSEAMOnFace(TopoDS_Edge theEOrigin, TopoDS_Edge theESplit, TopoDS_Face theFace)
        {
            throw new NotImplementedException();
        }

        public void GetNormalToFaceOnEdge(TopoDS_Edge aE, TopoDS_Face aF, double aT, gp_Dir aD,
            IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public void GetNormalToFaceOnEdge(TopoDS_Edge aE, TopoDS_Face aF, double aT, gp_Dir aD)
        {
            throw new NotImplementedException();
        }

        public void GetNormalToFaceOnEdge(TopoDS_Edge aE, TopoDS_Face aF, gp_Dir aD, IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public void GetNormalToFaceOnEdge(TopoDS_Edge aE, TopoDS_Face aF, gp_Dir aD)
        {
            throw new NotImplementedException();
        }

        public int SenseFlag(gp_Dir aNF1, gp_Dir aNF2)
        {
            throw new NotImplementedException();
        }

        public bool GetNormalToSurface(Geom_Surface aS, double U, double V, gp_Dir aD)
        {
            throw new NotImplementedException();
        }

        public bool GetApproxNormalToFaceOnEdge(TopoDS_Edge aE, TopoDS_Face aF, double aT, gp_Pnt aPx, gp_Dir aD,
            IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public bool GetApproxNormalToFaceOnEdge(TopoDS_Edge theE, TopoDS_Face theF, double aT, gp_Pnt aP, gp_Dir aDNF,
            double aDt2D)
        {
            throw new NotImplementedException();
        }

        public bool GetApproxNormalToFaceOnEdge(TopoDS_Edge theE, TopoDS_Face theF, double aT, double aDt2D, gp_Pnt aP,
            gp_Dir aDNF, IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public int PointNearEdge(TopoDS_Edge aE, TopoDS_Face aF, double aT, double aDt2D, gp_Pnt2d aP2D, gp_Pnt aPx,
            IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public int PointNearEdge(TopoDS_Edge aE, TopoDS_Face aF, double aT, double aDt2D, gp_Pnt2d aP2D, gp_Pnt aPx)
        {
            throw new NotImplementedException();
        }

        public int PointNearEdge(TopoDS_Edge aE, TopoDS_Face aF, double aT, gp_Pnt2d aP2D, gp_Pnt aPx,
            IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public int PointNearEdge(TopoDS_Edge aE, TopoDS_Face aF, gp_Pnt2d aP2D, gp_Pnt aPx, IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public double MinStepIn2d()
        {
            throw new NotImplementedException();
        }

        public bool IsEmptyShape(TopoDS_Shape aS)
        {
            throw new NotImplementedException();
        }

        public void OrientEdgeOnFace(TopoDS_Edge aE, TopoDS_Face aF, TopoDS_Edge aER)
        {
            throw new NotImplementedException();
        }

        public int PointInFace(TopoDS_Face theF, gp_Pnt theP, gp_Pnt2d theP2D, IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public int PointInFace(TopoDS_Face theF, TopoDS_Edge theE, double theT, double theDt2D, gp_Pnt theP,
            gp_Pnt2d theP2D, IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }

        public int PointInFace(TopoDS_Face theF, Geom2d_Curve theL, gp_Pnt theP, gp_Pnt2d theP2D,
            IntTools_Context theContext, double theDt2D)
        {
            throw new NotImplementedException();
        }

        public int PointInFace(TopoDS_Face theF, Geom2d_Curve theL, gp_Pnt theP, gp_Pnt2d theP2D,
            IntTools_Context theContext)
        {
            throw new NotImplementedException();
        }
    }; // class BOPTools_AlgoTools3D
}