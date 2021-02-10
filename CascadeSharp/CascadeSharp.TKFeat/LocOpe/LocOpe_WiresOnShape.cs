//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKFeat.LocOpe
{
    //---------------------------------------------------------------------
    //  Class  LocOpe_WiresOnShape
    //---------------------------------------------------------------------
    public sealed class LocOpe_WiresOnShape : Standard_Transient
    {
        public LocOpe_WiresOnShape(TopoDS_Shape S)
            : base()
        {
            throw new NotImplementedException();
        }

        public LocOpe_WiresOnShape(LocOpe_WiresOnShape parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public LocOpe_WiresOnShape()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool Add(TopTools_SequenceOfShape theEdges)
        {
            throw new NotImplementedException();
        }

        public void SetCheckInterior(bool ToCheckInterior)
        {
            throw new NotImplementedException();
        }

        public void Bind(TopoDS_Wire W, TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public void Bind(TopoDS_Compound Comp, TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public void Bind(TopoDS_Edge E, TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public void Bind(TopoDS_Edge EfromW, TopoDS_Edge EonFace)
        {
            throw new NotImplementedException();
        }

        public void BindAll()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public void InitEdgeIterator()
        {
            throw new NotImplementedException();
        }

        public bool MoreEdge()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge Edge()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face OnFace()
        {
            throw new NotImplementedException();
        }

        public bool OnEdge(TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public void NextEdge()
        {
            throw new NotImplementedException();
        }

        public bool OnVertex(TopoDS_Vertex Vwire, TopoDS_Vertex Vshape)
        {
            throw new NotImplementedException();
        }

        public bool OnEdge(TopoDS_Vertex V, TopoDS_Edge E, ref double P)
        {
            throw new NotImplementedException();
        }

        public bool OnEdge(TopoDS_Vertex V, TopoDS_Edge EdgeFrom, TopoDS_Edge E, ref double P)
        {
            throw new NotImplementedException();
        }

        public bool IsFaceWithSection(TopoDS_Shape aFace)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class LocOpe_WiresOnShape
}