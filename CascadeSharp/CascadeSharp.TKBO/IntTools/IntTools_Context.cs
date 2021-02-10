//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepAdaptor;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.NCollection;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKGeomAlgo.Geom2dHatch;
using CascadeSharp.TKGeomAlgo.GeomAPI;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKTopAlgo.BRepClass3d;

namespace CascadeSharp.TKBO.IntTools
{
    //---------------------------------------------------------------------
    //  Class  IntTools_Context
    //---------------------------------------------------------------------
    public sealed class IntTools_Context : Standard_Transient
    {
        public IntTools_Context()
            : base()
        {
            throw new NotImplementedException();
        }

        public IntTools_Context(NCollection_BaseAllocator theAllocator)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntTools_Context(IntTools_Context parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntTools_FClass2d FClass2d(TopoDS_Face aF)
        {
            throw new NotImplementedException();
        }

        public GeomAPI_ProjectPointOnSurf ProjPS(TopoDS_Face aF)
        {
            throw new NotImplementedException();
        }

        public GeomAPI_ProjectPointOnCurve ProjPC(TopoDS_Edge aE)
        {
            throw new NotImplementedException();
        }

        public GeomAPI_ProjectPointOnCurve ProjPT(Geom_Curve aC)
        {
            throw new NotImplementedException();
        }

        public IntTools_SurfaceRangeLocalizeData SurfaceData(TopoDS_Face aF)
        {
            throw new NotImplementedException();
        }

        public BRepClass3d_SolidClassifier SolidClassifier(TopoDS_Solid aSolid)
        {
            throw new NotImplementedException();
        }

        public Geom2dHatch_Hatcher Hatcher(TopoDS_Face aF)
        {
            throw new NotImplementedException();
        }

        public BRepAdaptor_Surface SurfaceAdaptor(TopoDS_Face theFace)
        {
            throw new NotImplementedException();
        }

        public Bnd_OBB OBB(TopoDS_Shape theShape, double theFuzzyValue)
        {
            throw new NotImplementedException();
        }

        public Bnd_OBB OBB(TopoDS_Shape theShape)
        {
            throw new NotImplementedException();
        }

        public void UVBounds(TopoDS_Face theFace, ref double UMin, ref double UMax, ref double VMin, ref double VMax)
        {
            throw new NotImplementedException();
        }

        public int ComputePE(gp_Pnt theP, double theTolP, TopoDS_Edge theE, ref double theT, ref double theD_ist)
        {
            throw new NotImplementedException();
        }

        public int ComputeVE(TopoDS_Vertex theV, TopoDS_Edge theE, ref double theT, ref double theTol, double theFuzz)
        {
            throw new NotImplementedException();
        }

        public int ComputeVE(TopoDS_Vertex theV, TopoDS_Edge theE, ref double theT, ref double theTol)
        {
            throw new NotImplementedException();
        }

        public int ComputeVF(TopoDS_Vertex theVertex, TopoDS_Face theFace, ref double theU, ref double theV,
            ref double theTol, double theFuzz)
        {
            throw new NotImplementedException();
        }

        public int ComputeVF(TopoDS_Vertex theVertex, TopoDS_Face theFace, ref double theU, ref double theV,
            ref double theTol)
        {
            throw new NotImplementedException();
        }

        public TopAbs_State StatePointFace(TopoDS_Face aF, gp_Pnt2d aP2D)
        {
            throw new NotImplementedException();
        }

        public bool IsPointInFace(TopoDS_Face aF, gp_Pnt2d aP2D)
        {
            throw new NotImplementedException();
        }

        public bool IsPointInFace(gp_Pnt aP3D, TopoDS_Face aF, double aTol)
        {
            throw new NotImplementedException();
        }

        public bool IsPointInOnFace(TopoDS_Face aF, gp_Pnt2d aP2D)
        {
            throw new NotImplementedException();
        }

        public bool IsValidPointForFace(gp_Pnt aP3D, TopoDS_Face aF, double aTol)
        {
            throw new NotImplementedException();
        }

        public bool IsValidPointForFaces(gp_Pnt aP3D, TopoDS_Face aF1, TopoDS_Face aF2, double aTol)
        {
            throw new NotImplementedException();
        }

        public bool IsValidBlockForFace(double aT1, double aT2, IntTools_Curve aIC, TopoDS_Face aF, double aTol)
        {
            throw new NotImplementedException();
        }

        public bool IsValidBlockForFaces(double aT1, double aT2, IntTools_Curve aIC, TopoDS_Face aF1, TopoDS_Face aF2,
            double aTol)
        {
            throw new NotImplementedException();
        }

        public bool IsVertexOnLine(TopoDS_Vertex aV, IntTools_Curve aIC, double aTolC, ref double aT)
        {
            throw new NotImplementedException();
        }

        public bool IsVertexOnLine(TopoDS_Vertex aV, double aTolV, IntTools_Curve aIC, double aTolC, ref double aT)
        {
            throw new NotImplementedException();
        }

        public bool ProjectPointOnEdge(gp_Pnt aP, TopoDS_Edge aE, ref double aT)
        {
            throw new NotImplementedException();
        }

        public Bnd_Box BndBox(TopoDS_Shape theS)
        {
            throw new NotImplementedException();
        }

        public bool IsInfiniteFace(TopoDS_Face theFace)
        {
            throw new NotImplementedException();
        }

        public void SetPOnSProjectionTolerance(double theValue)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void clearCachedPOnSProjectors()
        {
            throw new NotImplementedException();
        }
    }; // class IntTools_Context
}