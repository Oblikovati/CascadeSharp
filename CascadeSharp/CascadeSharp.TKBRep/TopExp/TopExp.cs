//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopExp
{
    //---------------------------------------------------------------------
    //  Class  TopExp
    //---------------------------------------------------------------------
    public sealed class TopExp
    {
        public TopExp()
            : base()
        {
            throw new NotImplementedException();
        }

        public TopExp(TopExp parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void MapShapes(TopoDS_Shape S, TopAbs_ShapeEnum T, TopTools_IndexedMapOfShape M)
        {
            throw new NotImplementedException();
        }

        public void MapShapes(TopoDS_Shape S, TopTools_IndexedMapOfShape M)
        {
            throw new NotImplementedException();
        }

        public void MapShapes(TopoDS_Shape S, TopTools_MapOfShape M)
        {
            throw new NotImplementedException();
        }

        public void MapShapesAndAncestors(TopoDS_Shape S, TopAbs_ShapeEnum TS, TopAbs_ShapeEnum TA,
            TopTools_IndexedDataMapOfShapeListOfShape M)
        {
            throw new NotImplementedException();
        }

        public void MapShapesAndUniqueAncestors(TopoDS_Shape S, TopAbs_ShapeEnum TS, TopAbs_ShapeEnum TA,
            TopTools_IndexedDataMapOfShapeListOfShape M, bool useOrientation)
        {
            throw new NotImplementedException();
        }

        public void MapShapesAndUniqueAncestors(TopoDS_Shape S, TopAbs_ShapeEnum TS, TopAbs_ShapeEnum TA,
            TopTools_IndexedDataMapOfShapeListOfShape M)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex FirstVertex(TopoDS_Edge E, bool CumOri)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex FirstVertex(TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex LastVertex(TopoDS_Edge E, bool CumOri)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex LastVertex(TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public void Vertices(TopoDS_Edge E, TopoDS_Vertex Vfirst, TopoDS_Vertex Vlast, bool CumOri)
        {
            throw new NotImplementedException();
        }

        public void Vertices(TopoDS_Edge E, TopoDS_Vertex Vfirst, TopoDS_Vertex Vlast)
        {
            throw new NotImplementedException();
        }

        public void Vertices(TopoDS_Wire W, TopoDS_Vertex Vfirst, TopoDS_Vertex Vlast)
        {
            throw new NotImplementedException();
        }

        public bool CommonVertex(TopoDS_Edge E1, TopoDS_Edge E2, TopoDS_Vertex V)
        {
            throw new NotImplementedException();
        }
    }; // class TopExp
}