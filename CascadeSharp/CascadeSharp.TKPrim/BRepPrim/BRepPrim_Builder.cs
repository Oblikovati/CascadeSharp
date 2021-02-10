//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRep;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKPrim.BRepPrim
{
    //---------------------------------------------------------------------
    //  Class  BRepPrim_Builder
    //---------------------------------------------------------------------
    public sealed class BRepPrim_Builder
    {
        public BRepPrim_Builder()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Builder(BRep_Builder B)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Builder(BRepPrim_Builder parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRep_Builder Builder()
        {
            throw new NotImplementedException();
        }

        public void MakeShell(TopoDS_Shell S)
        {
            throw new NotImplementedException();
        }

        public void MakeFace(TopoDS_Face F, gp_Pln P)
        {
            throw new NotImplementedException();
        }

        public void MakeWire(TopoDS_Wire W)
        {
            throw new NotImplementedException();
        }

        public void MakeDegeneratedEdge(TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public void MakeEdge(TopoDS_Edge E, gp_Lin L)
        {
            throw new NotImplementedException();
        }

        public void MakeEdge(TopoDS_Edge E, gp_Circ C)
        {
            throw new NotImplementedException();
        }

        public void SetPCurve(TopoDS_Edge E, TopoDS_Face F, gp_Lin2d L)
        {
            throw new NotImplementedException();
        }

        public void SetPCurve(TopoDS_Edge E, TopoDS_Face F, gp_Lin2d L1, gp_Lin2d L2)
        {
            throw new NotImplementedException();
        }

        public void SetPCurve(TopoDS_Edge E, TopoDS_Face F, gp_Circ2d C)
        {
            throw new NotImplementedException();
        }

        public void MakeVertex(TopoDS_Vertex V, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void ReverseFace(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public void AddEdgeVertex(TopoDS_Edge E, TopoDS_Vertex V, double P, bool direct)
        {
            throw new NotImplementedException();
        }

        public void AddEdgeVertex(TopoDS_Edge E, TopoDS_Vertex V, double P1, double P2)
        {
            throw new NotImplementedException();
        }

        public void SetParameters(TopoDS_Edge E, TopoDS_Vertex V, double P1, double P2)
        {
            throw new NotImplementedException();
        }

        public void AddWireEdge(TopoDS_Wire W, TopoDS_Edge E, bool direct)
        {
            throw new NotImplementedException();
        }

        public void AddFaceWire(TopoDS_Face F, TopoDS_Wire W)
        {
            throw new NotImplementedException();
        }

        public void AddShellFace(TopoDS_Shell Sh, TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public void CompleteEdge(TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public void CompleteWire(TopoDS_Wire W)
        {
            throw new NotImplementedException();
        }

        public void CompleteFace(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public void CompleteShell(TopoDS_Shell S)
        {
            throw new NotImplementedException();
        }
    }; // class BRepPrim_Builder
}