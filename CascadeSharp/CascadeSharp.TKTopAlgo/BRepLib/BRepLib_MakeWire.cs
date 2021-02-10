//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKTopAlgo.BRepLib
{
    //---------------------------------------------------------------------
    //  Class  BRepLib_MakeWire
    //---------------------------------------------------------------------
    public sealed class BRepLib_MakeWire : BRepLib_MakeShape
    {
        public BRepLib_MakeWire()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeWire(TopoDS_Edge E)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeWire(TopoDS_Edge E1, TopoDS_Edge E2)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeWire(TopoDS_Edge E1, TopoDS_Edge E2, TopoDS_Edge E3)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeWire(TopoDS_Edge E1, TopoDS_Edge E2, TopoDS_Edge E3, TopoDS_Edge E4)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeWire(TopoDS_Wire W)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeWire(TopoDS_Wire W, TopoDS_Edge E)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeWire(BRepLib_MakeWire parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Wire W)
        {
            throw new NotImplementedException();
        }

        public void Add(TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public BRepLib_WireError Error()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Wire Wire()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge Edge()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex Vertex()
        {
            throw new NotImplementedException();
        }

        public void CreateNewListOfEdges(TopTools_ListOfShape theL, TopTools_DataMapOfShapeShape theO2NV,
            TopTools_ListOfShape theNewEL_ist)
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Edge E, bool IsCheckGeometryProximity)
        {
            throw new NotImplementedException();
        }
    }; // class BRepLib_MakeWire
}