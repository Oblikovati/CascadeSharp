//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.TopLoc;
using CascadeSharp.TKShHealing.ShapeAnalysis;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeFix
{
    //---------------------------------------------------------------------
    //  Class  ShapeFix_Wire
    //---------------------------------------------------------------------
    public sealed class ShapeFix_Wire : ShapeFix_Root
    {
        public ShapeFix_Wire()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Wire(TopoDS_Wire wire, TopoDS_Face face, double prec)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Wire(ShapeFix_Wire parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void ClearModes()
        {
            throw new NotImplementedException();
        }

        public void ClearStatuses()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Wire wire, TopoDS_Face face, double prec)
        {
            throw new NotImplementedException();
        }

        public void Init(ShapeAnalysis_Wire saw)
        {
            throw new NotImplementedException();
        }

        public void Load(TopoDS_Wire wire)
        {
            throw new NotImplementedException();
        }

        public void Load(ShapeExtend_WireData sbwd)
        {
            throw new NotImplementedException();
        }

        public void SetFace(TopoDS_Face face)
        {
            throw new NotImplementedException();
        }

        public void SetSurface(Geom_Surface surf)
        {
            throw new NotImplementedException();
        }

        public void SetSurface(Geom_Surface surf, TopLoc_Location loc)
        {
            throw new NotImplementedException();
        }

        public void SetPrecision(double prec)
        {
            throw new NotImplementedException();
        }

        public void SetMaxTailAngle(double theMaxTailAngle)
        {
            throw new NotImplementedException();
        }

        public void SetMaxTailWidth(double theMaxTailWidth)
        {
            throw new NotImplementedException();
        }

        public bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public bool IsReady()
        {
            throw new NotImplementedException();
        }

        public int NbEdges()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Wire Wire()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Wire WireAPIMake()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_Wire Analyzer()
        {
            throw new NotImplementedException();
        }

        public ShapeExtend_WireData WireData()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face Face()
        {
            throw new NotImplementedException();
        }

        public bool ModifyTopologyMode()
        {
            throw new NotImplementedException();
        }

        public bool ModifyGeometryMode()
        {
            throw new NotImplementedException();
        }

        public int ModifyRemoveLoopMode()
        {
            throw new NotImplementedException();
        }

        public bool ClosedWireMode()
        {
            throw new NotImplementedException();
        }

        public bool PreferencePCurveMode()
        {
            throw new NotImplementedException();
        }

        public bool FixGapsByRangesMode()
        {
            throw new NotImplementedException();
        }

        public int FixReorderMode()
        {
            throw new NotImplementedException();
        }

        public int FixSmallMode()
        {
            throw new NotImplementedException();
        }

        public int FixConnectedMode()
        {
            throw new NotImplementedException();
        }

        public int FixEdgeCurvesMode()
        {
            throw new NotImplementedException();
        }

        public int FixDegeneratedMode()
        {
            throw new NotImplementedException();
        }

        public int FixSelfIntersectionMode()
        {
            throw new NotImplementedException();
        }

        public int FixLackingMode()
        {
            throw new NotImplementedException();
        }

        public int FixGaps3dMode()
        {
            throw new NotImplementedException();
        }

        public int FixGaps2dMode()
        {
            throw new NotImplementedException();
        }

        public int FixReversed2dMode()
        {
            throw new NotImplementedException();
        }

        public int FixRemovePCurveMode()
        {
            throw new NotImplementedException();
        }

        public int FixAddPCurveMode()
        {
            throw new NotImplementedException();
        }

        public int FixRemoveCurve3dMode()
        {
            throw new NotImplementedException();
        }

        public int FixAddCurve3dMode()
        {
            throw new NotImplementedException();
        }

        public int FixSeamMode()
        {
            throw new NotImplementedException();
        }

        public int FixShiftedMode()
        {
            throw new NotImplementedException();
        }

        public int FixSameParameterMode()
        {
            throw new NotImplementedException();
        }

        public int FixVertexToleranceMode()
        {
            throw new NotImplementedException();
        }

        public int FixNotchedEdgesMode()
        {
            throw new NotImplementedException();
        }

        public int FixSelfIntersectingEdgeMode()
        {
            throw new NotImplementedException();
        }

        public int FixIntersectingEdgesMode()
        {
            throw new NotImplementedException();
        }

        public int FixNonAdjacentIntersectingEdgesMode()
        {
            throw new NotImplementedException();
        }

        public int FixTailMode()
        {
            throw new NotImplementedException();
        }

        public bool Perform()
        {
            throw new NotImplementedException();
        }

        public bool FixReorder()
        {
            throw new NotImplementedException();
        }

        public int FixSmall(bool lockvtx, double precsmall)
        {
            throw new NotImplementedException();
        }

        public int FixSmall(bool lockvtx)
        {
            throw new NotImplementedException();
        }

        public bool FixConnected(double prec)
        {
            throw new NotImplementedException();
        }

        public bool FixConnected()
        {
            throw new NotImplementedException();
        }

        public bool FixEdgeCurves()
        {
            throw new NotImplementedException();
        }

        public bool FixDegenerated()
        {
            throw new NotImplementedException();
        }

        public bool FixSelfIntersection()
        {
            throw new NotImplementedException();
        }

        public bool FixLacking(bool force)
        {
            throw new NotImplementedException();
        }

        public bool FixLacking()
        {
            throw new NotImplementedException();
        }

        public bool FixClosed(double prec)
        {
            throw new NotImplementedException();
        }

        public bool FixClosed()
        {
            throw new NotImplementedException();
        }

        public bool FixGaps3d()
        {
            throw new NotImplementedException();
        }

        public bool FixGaps2d()
        {
            throw new NotImplementedException();
        }

        public bool FixReorder(ShapeAnalysis_WireOrder wi)
        {
            throw new NotImplementedException();
        }

        public bool FixSmall(int num, bool lockvtx, double precsmall)
        {
            throw new NotImplementedException();
        }

        public bool FixConnected(int num, double prec)
        {
            throw new NotImplementedException();
        }

        public bool FixSeam(int num)
        {
            throw new NotImplementedException();
        }

        public bool FixShifted()
        {
            throw new NotImplementedException();
        }

        public bool FixDegenerated(int num)
        {
            throw new NotImplementedException();
        }

        public bool FixLacking(int num, bool force)
        {
            throw new NotImplementedException();
        }

        public bool FixLacking(int num)
        {
            throw new NotImplementedException();
        }

        public bool FixNotchedEdges()
        {
            throw new NotImplementedException();
        }

        public bool FixGap3d(int num, bool convert)
        {
            throw new NotImplementedException();
        }

        public bool FixGap3d(int num)
        {
            throw new NotImplementedException();
        }

        public bool FixGap2d(int num, bool convert)
        {
            throw new NotImplementedException();
        }

        public bool FixGap2d(int num)
        {
            throw new NotImplementedException();
        }

        public bool FixTails()
        {
            throw new NotImplementedException();
        }

        public bool StatusReorder(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public bool StatusSmall(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public bool StatusConnected(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public bool StatusEdgeCurves(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public bool StatusDegenerated(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public bool StatusSelfIntersection(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public bool StatusLacking(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public bool StatusClosed(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public bool StatusGaps3d(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public bool StatusGaps2d(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public bool StatusNotches(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public bool StatusRemovedSegment()
        {
            throw new NotImplementedException();
        }

        public bool StatusFixTails(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public bool LastFixStatus(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Edge FixEdgeTool()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void UpdateWire()
        {
            throw new NotImplementedException();
        }

        public bool FixSelfIntersectingEdge(int num)
        {
            throw new NotImplementedException();
        }

        public bool FixIntersectingEdges(int num)
        {
            throw new NotImplementedException();
        }

        public bool FixIntersectingEdges(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public void FixDummySeam(int num)
        {
            throw new NotImplementedException();
        }
    }; // class ShapeFix_Wire
}