//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.TopOpeBRepDS;
using CascadeSharp.TKBRep.TopoDS;

namespace CascadeSharp.TKBool.TopOpeBRep
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRep_EdgesFiller
    //---------------------------------------------------------------------
    public sealed class TopOpeBRep_EdgesFiller
    {
        public TopOpeBRep_EdgesFiller()
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRep_EdgesFiller(TopOpeBRep_EdgesFiller parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Insert(TopoDS_Shape E1, TopoDS_Shape E2, TopOpeBRep_EdgesIntersector EI,
            TopOpeBRepDS_HDataStructure HDS)
        {
            throw new NotImplementedException();
        }

        public void Face(int I, TopoDS_Shape F)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Face(int I)
        {
            throw new NotImplementedException();
        }

        public bool MakeGeometry(TopOpeBRep_Point2d P, ref int G, ref TopOpeBRepDS_Kind K)
        {
            throw new NotImplementedException();
        }

        public void SetShapeTransition(TopOpeBRep_Point2d P, TopOpeBRepDS_Transition T1, TopOpeBRepDS_Transition T2)
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_Interference StorePI(TopOpeBRep_Point2d P, TopOpeBRepDS_Transition T, int EI, int PI,
            double p, int IE)
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_Interference StoreVI(TopOpeBRep_Point2d P, TopOpeBRepDS_Transition T, int EI, int VI,
            bool VB, TopOpeBRepDS_Config C, double p, int IE)
        {
            throw new NotImplementedException();
        }

        public bool ToRecompute(TopOpeBRep_Point2d P, TopOpeBRepDS_Interference I, int IEmother)
        {
            throw new NotImplementedException();
        }

        public void StoreRecompute(TopOpeBRepDS_Interference I, int IEmother)
        {
            throw new NotImplementedException();
        }

        public void RecomputeInterferences(TopoDS_Edge E, TopOpeBRepDS_ListOfInterference LOI)
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRep_EdgesFiller
}