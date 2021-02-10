//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKBool.TopOpeBRep
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRep_ShapeIntersector
    //---------------------------------------------------------------------
    public sealed class TopOpeBRep_ShapeIntersector
    {
        public TopOpeBRep_ShapeIntersector()
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRep_ShapeIntersector(TopOpeBRep_ShapeIntersector parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void InitIntersection(TopoDS_Shape S1, TopoDS_Shape S2)
        {
            throw new NotImplementedException();
        }

        public void InitIntersection(TopoDS_Shape S1, TopoDS_Shape S2, TopoDS_Face F1, TopoDS_Face F2)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape(int Index)
        {
            throw new NotImplementedException();
        }

        public bool MoreIntersection()
        {
            throw new NotImplementedException();
        }

        public void NextIntersection()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRep_FacesIntersector ChangeFacesIntersector()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRep_EdgesIntersector ChangeEdgesIntersector()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRep_FaceEdgeIntersector ChangeFaceEdgeIntersector()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape CurrentGeomShape(int Index)
        {
            throw new NotImplementedException();
        }

        public void GetTolerances(ref double tol1, ref double tol2)
        {
            throw new NotImplementedException();
        }

        public void DumpCurrent(int K)
        {
            throw new NotImplementedException();
        }

        public int Index(int K)
        {
            throw new NotImplementedException();
        }

        public void RejectedFaces(TopoDS_Shape anObj, TopoDS_Shape aReference, TopTools_ListOfShape aL_istOfShape)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Shape S1, TopoDS_Shape S2)
        {
            throw new NotImplementedException();
        }

        public void SetIntersectionDone()
        {
            throw new NotImplementedException();
        }

        public void InitFFIntersection()
        {
            throw new NotImplementedException();
        }

        public void FindFFIntersection()
        {
            throw new NotImplementedException();
        }

        public bool MoreFFCouple()
        {
            throw new NotImplementedException();
        }

        public void NextFFCouple()
        {
            throw new NotImplementedException();
        }

        public void InitEEFFIntersection()
        {
            throw new NotImplementedException();
        }

        public void FindEEFFIntersection()
        {
            throw new NotImplementedException();
        }

        public bool MoreEEFFCouple()
        {
            throw new NotImplementedException();
        }

        public void NextEEFFCouple()
        {
            throw new NotImplementedException();
        }

        public void InitFEIntersection()
        {
            throw new NotImplementedException();
        }

        public void FindFEIntersection()
        {
            throw new NotImplementedException();
        }

        public bool MoreFECouple()
        {
            throw new NotImplementedException();
        }

        public void NextFECouple()
        {
            throw new NotImplementedException();
        }

        public void InitEFIntersection()
        {
            throw new NotImplementedException();
        }

        public void FindEFIntersection()
        {
            throw new NotImplementedException();
        }

        public bool MoreEFCouple()
        {
            throw new NotImplementedException();
        }

        public void NextEFCouple()
        {
            throw new NotImplementedException();
        }

        public void InitEEIntersection()
        {
            throw new NotImplementedException();
        }

        public void FindEEIntersection()
        {
            throw new NotImplementedException();
        }

        public bool MoreEECouple()
        {
            throw new NotImplementedException();
        }

        public void NextEECouple()
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRep_ShapeIntersector
}