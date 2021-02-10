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
    //  Class  AIS_C0RegularityFilter
    //---------------------------------------------------------------------
    public sealed class AIS_C0RegularityFilter : SelectMgr_Filter
    {
        public AIS_C0RegularityFilter(TopoDS_Shape aShape)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_C0RegularityFilter(AIS_C0RegularityFilter parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_C0RegularityFilter()
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

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class AIS_C0RegularityFilter
}