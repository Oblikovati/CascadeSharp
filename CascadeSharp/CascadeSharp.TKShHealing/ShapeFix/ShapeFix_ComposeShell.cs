//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;
using CascadeSharp.TKShHealing.ShapeAnalysis;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeFix
{
    //---------------------------------------------------------------------
    //  Class  ShapeFix_ComposeShell
    //---------------------------------------------------------------------
    public sealed class ShapeFix_ComposeShell : ShapeFix_Root
    {
        public ShapeFix_ComposeShell()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_ComposeShell(ShapeFix_ComposeShell parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(ShapeExtend_CompositeSurface Grid, TopLoc_Location L, TopoDS_Face Face, double Prec)
        {
            throw new NotImplementedException();
        }

        public bool ClosedMode()
        {
            throw new NotImplementedException();
        }

        public bool Perform()
        {
            throw new NotImplementedException();
        }

        public void SplitEdges()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Result()
        {
            throw new NotImplementedException();
        }

        public bool Status(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public void DispatchWires(TopTools_SequenceOfShape faces, ShapeFix_SequenceOfWireSegment wires)
        {
            throw new NotImplementedException();
        }

        public void SetTransferParamTool(ShapeAnalysis_TransferParameters TransferParam)
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_TransferParameters GetTransferParamTool()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void LoadWires(ShapeFix_SequenceOfWireSegment seqw)
        {
            throw new NotImplementedException();
        }

        public int ComputeCode(ShapeExtend_WireData wire, gp_Lin2d line, int begInd, int endInd, double begPar,
            double endPar, bool IsInternal)
        {
            throw new NotImplementedException();
        }

        public int ComputeCode(ShapeExtend_WireData wire, gp_Lin2d line, int begInd, int endInd, double begPar,
            double endPar)
        {
            throw new NotImplementedException();
        }

        public ShapeFix_WireSegment SplitWire(ShapeFix_WireSegment wire, TColStd_SequenceOfInteger indexes,
            TColStd_SequenceOfReal values, TopTools_SequenceOfShape vertices, TColStd_SequenceOfInteger segcodes,
            bool cutbyu, int cutindex)
        {
            throw new NotImplementedException();
        }

        public bool SplitByLine(ShapeFix_WireSegment wire, gp_Lin2d line, bool cutbyu, int cutindex,
            TColStd_SequenceOfReal SplitLinePar, TColStd_SequenceOfInteger SplitLineCode,
            TopTools_SequenceOfShape SplitLineVertex)
        {
            throw new NotImplementedException();
        }

        public void SplitByLine(ShapeFix_SequenceOfWireSegment seqw, gp_Lin2d line, bool cutbyu, int cutindex)
        {
            throw new NotImplementedException();
        }

        public void SplitByGrid(ShapeFix_SequenceOfWireSegment seqw)
        {
            throw new NotImplementedException();
        }

        public void BreakWires(ShapeFix_SequenceOfWireSegment seqw)
        {
            throw new NotImplementedException();
        }

        public void CollectWires(ShapeFix_SequenceOfWireSegment wires, ShapeFix_SequenceOfWireSegment seqw)
        {
            throw new NotImplementedException();
        }

        public void MakeFacesOnPatch(TopTools_SequenceOfShape faces, Geom_Surface surf, TopTools_SequenceOfShape loops)
        {
            throw new NotImplementedException();
        }
    }; // class ShapeFix_ComposeShell
}