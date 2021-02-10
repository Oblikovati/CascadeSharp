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
    //  Class  TopOpeBRep_FaceEdgeFiller
    //---------------------------------------------------------------------
    public sealed class TopOpeBRep_FaceEdgeFiller
    {
        public TopOpeBRep_FaceEdgeFiller()
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRep_FaceEdgeFiller(TopOpeBRep_FaceEdgeFiller parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Insert(TopoDS_Shape F, TopoDS_Shape E, TopOpeBRep_FaceEdgeIntersector FEINT,
            TopOpeBRepDS_HDataStructure HDS)
        {
            throw new NotImplementedException();
        }

        public int MakeGeometry(TopOpeBRep_FaceEdgeIntersector EI, TopOpeBRepDS_DataStructure DS)
        {
            throw new NotImplementedException();
        }

        public bool GetGeometry(TopOpeBRepDS_ListOfInterference L, TopOpeBRepDS_Point DSP, ref int G,
            TopOpeBRepDS_DataStructure DS)
        {
            throw new NotImplementedException();
        }

        public void StoreInterference(TopOpeBRepDS_Interference I, TopOpeBRepDS_ListOfInterference LI,
            TopOpeBRepDS_DataStructure BDS)
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRep_FaceEdgeFiller
}