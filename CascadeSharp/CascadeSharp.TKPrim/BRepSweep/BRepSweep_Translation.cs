//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;
using CascadeSharp.TKPrim.Sweep;

namespace CascadeSharp.TKPrim.BRepSweep
{
    //---------------------------------------------------------------------
    //  Class  BRepSweep_Translation
    //---------------------------------------------------------------------
    public sealed class BRepSweep_Translation : BRepSweep_Trsf
    {
        public BRepSweep_Translation(TopoDS_Shape S, Sweep_NumShape N, TopLoc_Location L, gp_Vec V, bool C,
            bool Canonize)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepSweep_Translation(TopoDS_Shape S, Sweep_NumShape N, TopLoc_Location L, gp_Vec V, bool C)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepSweep_Translation(BRepSweep_Translation parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepSweep_Translation()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape MakeEmptyVertex(TopoDS_Shape aGenV, Sweep_NumShape aDirV)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape MakeEmptyDirectingEdge(TopoDS_Shape aGenV, Sweep_NumShape aDirE)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape MakeEmptyGeneratingEdge(TopoDS_Shape aGenE, Sweep_NumShape aDirV)
        {
            throw new NotImplementedException();
        }

        public void SetParameters(TopoDS_Shape aNewFace, TopoDS_Shape aNewVertex, TopoDS_Shape aGenF,
            TopoDS_Shape aGenV, Sweep_NumShape aDirV)
        {
            throw new NotImplementedException();
        }

        public void SetDirectingParameter(TopoDS_Shape aNewEdge, TopoDS_Shape aNewVertex, TopoDS_Shape aGenV,
            Sweep_NumShape aDirE, Sweep_NumShape aDirV)
        {
            throw new NotImplementedException();
        }

        public void SetGeneratingParameter(TopoDS_Shape aNewEdge, TopoDS_Shape aNewVertex, TopoDS_Shape aGenE,
            TopoDS_Shape aGenV, Sweep_NumShape aDirV)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape MakeEmptyFace(TopoDS_Shape aGenS, Sweep_NumShape aDirS)
        {
            throw new NotImplementedException();
        }

        public void SetPCurve(TopoDS_Shape aNewFace, TopoDS_Shape aNewEdge, TopoDS_Shape aGenF, TopoDS_Shape aGenE,
            Sweep_NumShape aDirV, TopAbs_Orientation orien)
        {
            throw new NotImplementedException();
        }

        public void SetGeneratingPCurve(TopoDS_Shape aNewFace, TopoDS_Shape aNewEdge, TopoDS_Shape aGenE,
            Sweep_NumShape aDirE, Sweep_NumShape aDirV, TopAbs_Orientation orien)
        {
            throw new NotImplementedException();
        }

        public void SetDirectingPCurve(TopoDS_Shape aNewFace, TopoDS_Shape aNewEdge, TopoDS_Shape aGenE,
            TopoDS_Shape aGenV, Sweep_NumShape aDirE, TopAbs_Orientation orien)
        {
            throw new NotImplementedException();
        }

        public TopAbs_Orientation DirectSolid(TopoDS_Shape aGenS, Sweep_NumShape aDirS)
        {
            throw new NotImplementedException();
        }

        public bool GGDShapeIsToAdd(TopoDS_Shape aNewShape, TopoDS_Shape aNewSubShape, TopoDS_Shape aGenS,
            TopoDS_Shape aSubGenS, Sweep_NumShape aDirS)
        {
            throw new NotImplementedException();
        }

        public bool GDDShapeIsToAdd(TopoDS_Shape aNewShape, TopoDS_Shape aNewSubShape, TopoDS_Shape aGenS,
            Sweep_NumShape aDirS, Sweep_NumShape aSubDirS)
        {
            throw new NotImplementedException();
        }

        public bool SeparatedWires(TopoDS_Shape aNewShape, TopoDS_Shape aNewSubShape, TopoDS_Shape aGenS,
            TopoDS_Shape aSubGenS, Sweep_NumShape aDirS)
        {
            throw new NotImplementedException();
        }

        public bool HasShape(TopoDS_Shape aGenS, Sweep_NumShape aDirS)
        {
            throw new NotImplementedException();
        }

        public bool IsInvariant(TopoDS_Shape aGenS)
        {
            throw new NotImplementedException();
        }

        public gp_Vec Vec()
        {
            throw new NotImplementedException();
        }
    }; // class BRepSweep_Translation
}