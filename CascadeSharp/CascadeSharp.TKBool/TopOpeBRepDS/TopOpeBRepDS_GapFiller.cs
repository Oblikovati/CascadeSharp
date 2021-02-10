//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.TColStd;

namespace CascadeSharp.TKBool.TopOpeBRepDS
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRepDS_GapFiller
    //---------------------------------------------------------------------
    public sealed class TopOpeBRepDS_GapFiller
    {
        public TopOpeBRepDS_GapFiller(TopOpeBRepDS_HDataStructure HDS)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_GapFiller(TopOpeBRepDS_GapFiller parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_GapFiller()
        {
            throw new NotImplementedException();
        }

        public void Perform()
        {
            throw new NotImplementedException();
        }

        public void FindAssociatedPoints(TopOpeBRepDS_Interference I, TopOpeBRepDS_ListOfInterference LI)
        {
            throw new NotImplementedException();
        }

        public bool CheckConnexity(TopOpeBRepDS_ListOfInterference LI)
        {
            throw new NotImplementedException();
        }

        public void AddPointsOnShape(TopoDS_Shape S, TopOpeBRepDS_ListOfInterference LI)
        {
            throw new NotImplementedException();
        }

        public void AddPointsOnConnexShape(TopoDS_Shape F, TopOpeBRepDS_ListOfInterference LI)
        {
            throw new NotImplementedException();
        }

        public void FilterByFace(TopoDS_Face F, TopOpeBRepDS_ListOfInterference LI)
        {
            throw new NotImplementedException();
        }

        public void FilterByEdge(TopoDS_Edge E, TopOpeBRepDS_ListOfInterference LI)
        {
            throw new NotImplementedException();
        }

        public void FilterByIncidentDistance(TopoDS_Face F, TopOpeBRepDS_Interference I,
            TopOpeBRepDS_ListOfInterference LI)
        {
            throw new NotImplementedException();
        }

        public bool IsOnFace(TopOpeBRepDS_Interference I, TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public bool IsOnEdge(TopOpeBRepDS_Interference I, TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public void BuildNewGeometries()
        {
            throw new NotImplementedException();
        }

        public void ReBuildGeom(TopOpeBRepDS_Interference I1, TColStd_MapOfInteger Done)
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRepDS_GapFiller
}