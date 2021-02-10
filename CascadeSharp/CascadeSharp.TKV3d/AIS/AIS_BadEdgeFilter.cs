//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_BadEdgeFilter
    //---------------------------------------------------------------------
    public sealed class AIS_BadEdgeFilter : SelectMgr_Filter
    {
        public AIS_BadEdgeFilter()
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_BadEdgeFilter(AIS_BadEdgeFilter parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool ActsOn(TopAbs_ShapeEnum aType)
        {
            throw new NotImplementedException();
        }

        public bool IsOk(SelectMgr_EntityOwner EO)
        {
            throw new NotImplementedException();
        }

        public void SetContour(int Index)
        {
            throw new NotImplementedException();
        }

        public void AddEdge(TopoDS_Edge anEdge, int Index)
        {
            throw new NotImplementedException();
        }

        public void RemoveEdges(int Index)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class AIS_BadEdgeFilter
}