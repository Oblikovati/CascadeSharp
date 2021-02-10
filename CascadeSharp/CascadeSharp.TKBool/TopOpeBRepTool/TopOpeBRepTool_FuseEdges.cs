//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKBool.TopOpeBRepTool
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRepTool_FuseEdges
    //---------------------------------------------------------------------
    public sealed class TopOpeBRepTool_FuseEdges
    {
        public TopOpeBRepTool_FuseEdges(TopoDS_Shape theShape, bool PerformNow)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_FuseEdges(TopoDS_Shape theShape)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_FuseEdges(TopOpeBRepTool_FuseEdges parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_FuseEdges()
        {
            throw new NotImplementedException();
        }

        public void AvoidEdges(TopTools_IndexedMapOfShape theMapEdg)
        {
            throw new NotImplementedException();
        }

        public void Edges(TopTools_DataMapOfIntegerListOfShape theMapLstEdg)
        {
            throw new NotImplementedException();
        }

        public void ResultEdges(TopTools_DataMapOfIntegerShape theMapEdg)
        {
            throw new NotImplementedException();
        }

        public void Faces(TopTools_DataMapOfShapeShape theMapFac)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape()
        {
            throw new NotImplementedException();
        }

        public int NbVertices()
        {
            throw new NotImplementedException();
        }

        public void Perform()
        {
            throw new NotImplementedException();
        }

        public void BuildListEdges()
        {
            throw new NotImplementedException();
        }

        public void BuildListResultEdges()
        {
            throw new NotImplementedException();
        }

        public void BuildListConnexEdge(TopoDS_Shape theEdge, TopTools_MapOfShape theMapUniq,
            TopTools_ListOfShape theLstEdg)
        {
            throw new NotImplementedException();
        }

        public bool NextConnexEdge(TopoDS_Vertex theVertex, TopoDS_Shape theEdge, TopoDS_Shape theEdgeConnex)
        {
            throw new NotImplementedException();
        }

        public bool SameSupport(TopoDS_Edge E1, TopoDS_Edge E2)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePCurve(TopoDS_Edge theOldEdge, TopoDS_Edge theNewEdge, TopTools_ListOfShape theLstEdg)
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRepTool_FuseEdges
}