//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKOffset.BRepOffsetAPI
{
    //---------------------------------------------------------------------
    //  Class  BRepOffsetAPI_FindContigousEdges
    //---------------------------------------------------------------------
    public sealed class BRepOffsetAPI_FindContigousEdges
    {
        public BRepOffsetAPI_FindContigousEdges(double tolerance, bool option)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_FindContigousEdges(double tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_FindContigousEdges(BRepOffsetAPI_FindContigousEdges parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_FindContigousEdges()
        {
            throw new NotImplementedException();
        }

        public void Init(double tolerance, bool option)
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Shape shape)
        {
            throw new NotImplementedException();
        }

        public void Perform()
        {
            throw new NotImplementedException();
        }

        public int NbEdges()
        {
            throw new NotImplementedException();
        }

        public int NbContigousEdges()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge ContigousEdge(int index)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape ContigousEdgeCouple(int index)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge SectionToBoundary(TopoDS_Edge section)
        {
            throw new NotImplementedException();
        }

        public int NbDegeneratedShapes()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape DegeneratedShape(int index)
        {
            throw new NotImplementedException();
        }

        public bool IsDegenerated(TopoDS_Shape shape)
        {
            throw new NotImplementedException();
        }

        public bool IsModified(TopoDS_Shape shape)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Modified(TopoDS_Shape shape)
        {
            throw new NotImplementedException();
        }

        public void Dump()
        {
            throw new NotImplementedException();
        }
    }; // class BRepOffsetAPI_FindContigousEdges
}