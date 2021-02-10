//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.StdSelect
{
    //---------------------------------------------------------------------
    //  Class  StdSelect_EdgeFilter
    //---------------------------------------------------------------------
    public sealed class StdSelect_EdgeFilter : SelectMgr_Filter
    {
        public StdSelect_EdgeFilter(StdSelect_TypeOfEdge Edge)
            : base()
        {
            throw new NotImplementedException();
        }

        public StdSelect_EdgeFilter(StdSelect_EdgeFilter parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public StdSelect_EdgeFilter()
        {
            throw new NotImplementedException();
        }

        public void SetType(StdSelect_TypeOfEdge aNewType)
        {
            throw new NotImplementedException();
        }

        public StdSelect_TypeOfEdge Type()
        {
            throw new NotImplementedException();
        }

        public bool IsOk(SelectMgr_EntityOwner anobj)
        {
            throw new NotImplementedException();
        }

        public bool ActsOn(TopAbs_ShapeEnum aStandardMode)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class StdSelect_EdgeFilter
}