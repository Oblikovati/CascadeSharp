//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKShHealing.ShapeAnalysis
{
    //---------------------------------------------------------------------
    //  Class  ShapeAnalysis_FreeBounds
    //---------------------------------------------------------------------
    public sealed class ShapeAnalysis_FreeBounds
    {
        public ShapeAnalysis_FreeBounds()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_FreeBounds(TopoDS_Shape shape, double toler, bool splitclosed, bool splitopen)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_FreeBounds(TopoDS_Shape shape, double toler, bool splitclosed)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_FreeBounds(TopoDS_Shape shape, double toler)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_FreeBounds(TopoDS_Shape shape, bool splitclosed, bool splitopen, bool checkinternaledges)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_FreeBounds(TopoDS_Shape shape, bool splitclosed, bool splitopen)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_FreeBounds(TopoDS_Shape shape, bool splitclosed)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_FreeBounds(TopoDS_Shape shape)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_FreeBounds(ShapeAnalysis_FreeBounds parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Compound GetClosedWires()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Compound GetOpenWires()
        {
            throw new NotImplementedException();
        }

        public void ConnectEdgesToWires(TopTools_HSequenceOfShape edges, double toler, bool shared,
            TopTools_HSequenceOfShape wires)
        {
            throw new NotImplementedException();
        }

        public void ConnectWiresToWires(TopTools_HSequenceOfShape iwires, double toler, bool shared,
            TopTools_HSequenceOfShape owires)
        {
            throw new NotImplementedException();
        }

        public void ConnectWiresToWires(TopTools_HSequenceOfShape iwires, double toler, bool shared,
            TopTools_HSequenceOfShape owires, TopTools_DataMapOfShapeShape vertices)
        {
            throw new NotImplementedException();
        }

        public void SplitWires(TopTools_HSequenceOfShape wires, double toler, bool shared,
            TopTools_HSequenceOfShape closed, TopTools_HSequenceOfShape open)
        {
            throw new NotImplementedException();
        }

        public void DispatchWires(TopTools_HSequenceOfShape wires, TopoDS_Compound closed, TopoDS_Compound open)
        {
            throw new NotImplementedException();
        }

        public void SplitWires()
        {
            throw new NotImplementedException();
        }
    }; // class ShapeAnalysis_FreeBounds
}