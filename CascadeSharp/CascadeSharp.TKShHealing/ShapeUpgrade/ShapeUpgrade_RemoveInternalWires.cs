//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeUpgrade
{
    //---------------------------------------------------------------------
    //  Class  ShapeUpgrade_RemoveInternalWires
    //---------------------------------------------------------------------
    public sealed class ShapeUpgrade_RemoveInternalWires : ShapeUpgrade_Tool
    {
        public ShapeUpgrade_RemoveInternalWires()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeUpgrade_RemoveInternalWires(TopoDS_Shape theShape)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeUpgrade_RemoveInternalWires(ShapeUpgrade_RemoveInternalWires parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Shape theShape)
        {
            throw new NotImplementedException();
        }

        public bool Perform()
        {
            throw new NotImplementedException();
        }

        public bool Perform(TopTools_SequenceOfShape theSeqShapes)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape GetResult()
        {
            throw new NotImplementedException();
        }

        public double MinArea()
        {
            throw new NotImplementedException();
        }

        public bool RemoveFaceMode()
        {
            throw new NotImplementedException();
        }

        public TopTools_SequenceOfShape RemovedFaces()
        {
            throw new NotImplementedException();
        }

        public TopTools_SequenceOfShape RemovedWires()
        {
            throw new NotImplementedException();
        }

        public bool Status(ShapeExtend_Status theStatus)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void removeSmallWire(TopoDS_Shape theFace, TopoDS_Shape theWire)
        {
            throw new NotImplementedException();
        }

        public void removeSmallFaces()
        {
            throw new NotImplementedException();
        }
    }; // class ShapeUpgrade_RemoveInternalWires
}