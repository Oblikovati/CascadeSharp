//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.TopOpeBRepTool;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBool.TopOpeBRepDS
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRepDS_BuildTool
    //---------------------------------------------------------------------
    public sealed class TopOpeBRepDS_BuildTool
    {
        public TopOpeBRepDS_BuildTool()
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_BuildTool(TopOpeBRepTool_OutCurveType OutCurveType)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_BuildTool(TopOpeBRepTool_GeomTool GT)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_BuildTool(TopOpeBRepDS_BuildTool parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_GeomTool GetGeomTool()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_GeomTool ChangeGeomTool()
        {
            throw new NotImplementedException();
        }

        public void MakeVertex(TopoDS_Shape V, TopOpeBRepDS_Point P)
        {
            throw new NotImplementedException();
        }

        public void MakeEdge(TopoDS_Shape E, TopOpeBRepDS_Curve C)
        {
            throw new NotImplementedException();
        }

        public void MakeEdge(TopoDS_Shape E, TopOpeBRepDS_Curve C, TopOpeBRepDS_DataStructure DS)
        {
            throw new NotImplementedException();
        }

        public void MakeEdge(TopoDS_Shape E, Geom_Curve C, double Tol)
        {
            throw new NotImplementedException();
        }

        public void MakeEdge(TopoDS_Shape E)
        {
            throw new NotImplementedException();
        }

        public void MakeWire(TopoDS_Shape W)
        {
            throw new NotImplementedException();
        }

        public void MakeFace(TopoDS_Shape F, TopOpeBRepDS_Surface S)
        {
            throw new NotImplementedException();
        }

        public void MakeShell(TopoDS_Shape Sh)
        {
            throw new NotImplementedException();
        }

        public void MakeSolid(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void CopyEdge(TopoDS_Shape Ein, TopoDS_Shape Eou)
        {
            throw new NotImplementedException();
        }

        public void GetOrientedEdgeVertices(TopoDS_Edge E, TopoDS_Vertex Vmin, TopoDS_Vertex Vmax, ref double Parmin,
            ref double Parmax)
        {
            throw new NotImplementedException();
        }

        public void UpdateEdgeCurveTol(TopoDS_Face F1, TopoDS_Face F2, TopoDS_Edge E, Geom_Curve C3Dnew, double tol3d,
            double tol2d1, double tol2d2, ref double newtol, ref double newparmin, ref double newparmax)
        {
            throw new NotImplementedException();
        }

        public void ApproxCurves(TopOpeBRepDS_Curve C, TopoDS_Edge E, ref int inewC, TopOpeBRepDS_HDataStructure HDS)
        {
            throw new NotImplementedException();
        }

        public void ComputePCurves(TopOpeBRepDS_Curve C, TopoDS_Edge E, TopOpeBRepDS_Curve newC, bool CompPC1,
            bool CompPC2, bool CompC3D)
        {
            throw new NotImplementedException();
        }

        public void PutPCurves(TopOpeBRepDS_Curve newC, TopoDS_Edge E, bool CompPC1, bool CompPC2)
        {
            throw new NotImplementedException();
        }

        public void RecomputeCurves(TopOpeBRepDS_Curve C, TopoDS_Edge oldE, TopoDS_Edge E, ref int inewC,
            TopOpeBRepDS_HDataStructure HDS)
        {
            throw new NotImplementedException();
        }

        public void CopyFace(TopoDS_Shape Fin, TopoDS_Shape Fou)
        {
            throw new NotImplementedException();
        }

        public void AddEdgeVertex(TopoDS_Shape Ein, TopoDS_Shape Eou, TopoDS_Shape V)
        {
            throw new NotImplementedException();
        }

        public void AddEdgeVertex(TopoDS_Shape E, TopoDS_Shape V)
        {
            throw new NotImplementedException();
        }

        public void AddWireEdge(TopoDS_Shape W, TopoDS_Shape E)
        {
            throw new NotImplementedException();
        }

        public void AddFaceWire(TopoDS_Shape F, TopoDS_Shape W)
        {
            throw new NotImplementedException();
        }

        public void AddShellFace(TopoDS_Shape Sh, TopoDS_Shape F)
        {
            throw new NotImplementedException();
        }

        public void AddSolidShell(TopoDS_Shape S, TopoDS_Shape Sh)
        {
            throw new NotImplementedException();
        }

        public void Parameter(TopoDS_Shape E, TopoDS_Shape V, double P)
        {
            throw new NotImplementedException();
        }

        public void Range(TopoDS_Shape E, double first, double last)
        {
            throw new NotImplementedException();
        }

        public void UpdateEdge(TopoDS_Shape Ein, TopoDS_Shape Eou)
        {
            throw new NotImplementedException();
        }

        public void Parameter(TopOpeBRepDS_Curve C, TopoDS_Shape E, TopoDS_Shape V)
        {
            throw new NotImplementedException();
        }

        public void Curve3D(TopoDS_Shape E, Geom_Curve C, double Tol)
        {
            throw new NotImplementedException();
        }

        public void PCurve(TopoDS_Shape F, TopoDS_Shape E, Geom2d_Curve C)
        {
            throw new NotImplementedException();
        }

        public void PCurve(TopoDS_Shape F, TopoDS_Shape E, TopOpeBRepDS_Curve CDS, Geom2d_Curve C)
        {
            throw new NotImplementedException();
        }

        public void Orientation(TopoDS_Shape S, TopAbs_Orientation O)
        {
            throw new NotImplementedException();
        }

        public TopAbs_Orientation Orientation(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void Closed(TopoDS_Shape S, bool B)
        {
            throw new NotImplementedException();
        }

        public bool Approximation()
        {
            throw new NotImplementedException();
        }

        public void UpdateSurface(TopoDS_Shape F, Geom_Surface SU)
        {
            throw new NotImplementedException();
        }

        public void UpdateSurface(TopoDS_Shape E, TopoDS_Shape oldF, TopoDS_Shape newF)
        {
            throw new NotImplementedException();
        }

        public bool OverWrite()
        {
            throw new NotImplementedException();
        }

        public void OverWrite(bool O)
        {
            throw new NotImplementedException();
        }

        public bool Translate()
        {
            throw new NotImplementedException();
        }

        public void Translate(bool T)
        {
            throw new NotImplementedException();
        }

        public void TranslateOnPeriodic(TopoDS_Shape F, TopoDS_Shape E, Geom2d_Curve C)
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRepDS_BuildTool
}