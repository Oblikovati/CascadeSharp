//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBool.TopOpeBRepBuild
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRepBuild_WireEdgeSet
    //---------------------------------------------------------------------
    public sealed class TopOpeBRepBuild_WireEdgeSet : TopOpeBRepBuild_ShapeSet
    {
        public TopOpeBRepBuild_WireEdgeSet(TopoDS_Shape F, IntPtr Addr)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepBuild_WireEdgeSet(TopoDS_Shape F)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepBuild_WireEdgeSet(TopOpeBRepBuild_WireEdgeSet parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepBuild_WireEdgeSet()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face Face()
        {
            throw new NotImplementedException();
        }

        public void AddShape(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void AddStartElement(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void AddElement(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void InitNeighbours(TopoDS_Shape E)
        {
            throw new NotImplementedException();
        }

        public void FindNeighbours()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape MakeNeighboursList(TopoDS_Shape E, TopoDS_Shape V)
        {
            throw new NotImplementedException();
        }

        public void IsUVISO(TopoDS_Edge E, TopoDS_Face F, ref bool u_iso, ref bool v_iso)
        {
            throw new NotImplementedException();
        }

        public void DumpSS()
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SName(TopoDS_Shape S, TCollection_AsciiString sb, TCollection_AsciiString sa)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SName(TopoDS_Shape S, TCollection_AsciiString sb)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SName(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SName(TopTools_ListOfShape S, TCollection_AsciiString sb,
            TCollection_AsciiString sa)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SName(TopTools_ListOfShape S, TCollection_AsciiString sb)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SName(TopTools_ListOfShape S)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SNameori(TopoDS_Shape S, TCollection_AsciiString sb, TCollection_AsciiString sa)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SNameori(TopoDS_Shape S, TCollection_AsciiString sb)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SNameori(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SNameori(TopTools_ListOfShape S, TCollection_AsciiString sb,
            TCollection_AsciiString sa)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SNameori(TopTools_ListOfShape S, TCollection_AsciiString sb)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SNameori(TopTools_ListOfShape S)
        {
            throw new NotImplementedException();
        }

        public bool VertexConnectsEdges(TopoDS_Shape V, TopoDS_Shape E1, TopoDS_Shape E2, ref TopAbs_Orientation O1,
            ref TopAbs_Orientation O2)
        {
            throw new NotImplementedException();
        }

        public bool VertexConnectsEdgesClosing(TopoDS_Shape V, TopoDS_Shape E1, TopoDS_Shape E2)
        {
            throw new NotImplementedException();
        }

        public int NbClosingShapes(TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public void LocalD1(TopoDS_Shape F, TopoDS_Shape E, TopoDS_Shape V, gp_Pnt2d p2, gp_Vec2d v2)
        {
            throw new NotImplementedException();
        }

        public bool IsClosed(TopoDS_Shape E)
        {
            throw new NotImplementedException();
        }

        public bool IsUClosed(TopoDS_Shape E)
        {
            throw new NotImplementedException();
        }

        public bool IsVClosed(TopoDS_Shape E)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SNameVEE(TopoDS_Shape V, TopoDS_Shape E1, TopoDS_Shape E2)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString SNameVEL(TopoDS_Shape V, TopoDS_Shape E, TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRepBuild_WireEdgeSet
}