//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;

namespace CascadeSharp.TKTopAlgo.BRepExtrema
{
    //---------------------------------------------------------------------
    //  Class  BRepExtrema_ShapeProximity
    //---------------------------------------------------------------------
    public sealed class BRepExtrema_ShapeProximity
    {
        public BRepExtrema_ShapeProximity(double theTolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_ShapeProximity(TopoDS_Shape theShape1, TopoDS_Shape theShape2, double theTolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_ShapeProximity(TopoDS_Shape theShape1, TopoDS_Shape theShape2)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_ShapeProximity(BRepExtrema_ShapeProximity parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_ShapeProximity()
        {
            throw new NotImplementedException();
        }

        public double Tolerance()
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(double theTolerance)
        {
            throw new NotImplementedException();
        }

        public bool LoadShape1(TopoDS_Shape theShape1)
        {
            throw new NotImplementedException();
        }

        public bool LoadShape2(TopoDS_Shape theShape2)
        {
            throw new NotImplementedException();
        }

        public void Perform()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_MapOfIntegerPackedMapOfInteger OverlapSubShapes1()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_MapOfIntegerPackedMapOfInteger OverlapSubShapes2()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face GetSubShape1(int theID)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face GetSubShape2(int theID)
        {
            throw new NotImplementedException();
        }
    }; // class BRepExtrema_ShapeProximity
}