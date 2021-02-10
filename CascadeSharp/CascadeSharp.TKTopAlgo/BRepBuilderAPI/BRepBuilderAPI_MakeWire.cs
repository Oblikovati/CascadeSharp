//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKTopAlgo.BRepBuilderAPI
{
    //---------------------------------------------------------------------
    //  Class  BRepBuilderAPI_MakeWire
    //---------------------------------------------------------------------
    public sealed class BRepBuilderAPI_MakeWire : BRepBuilderAPI_MakeShape
    {
        public BRepBuilderAPI_MakeWire()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepBuilderAPI_MakeWire(TopoDS_Edge E)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepBuilderAPI_MakeWire(TopoDS_Edge E1, TopoDS_Edge E2)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepBuilderAPI_MakeWire(TopoDS_Edge E1, TopoDS_Edge E2, TopoDS_Edge E3)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepBuilderAPI_MakeWire(TopoDS_Edge E1, TopoDS_Edge E2, TopoDS_Edge E3, TopoDS_Edge E4)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepBuilderAPI_MakeWire(TopoDS_Wire W)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepBuilderAPI_MakeWire(TopoDS_Wire W, TopoDS_Edge E)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepBuilderAPI_MakeWire(BRepBuilderAPI_MakeWire parameter1)
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

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public BRepBuilderAPI_WireError Error()
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
    }; // class BRepBuilderAPI_MakeWire
}