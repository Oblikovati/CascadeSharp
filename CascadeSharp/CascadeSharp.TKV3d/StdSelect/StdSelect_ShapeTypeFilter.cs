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
    //  Class  StdSelect_ShapeTypeFilter
    //---------------------------------------------------------------------
    public sealed class StdSelect_ShapeTypeFilter : SelectMgr_Filter
    {
        public StdSelect_ShapeTypeFilter(TopAbs_ShapeEnum aType)
            : base()
        {
            throw new NotImplementedException();
        }

        public StdSelect_ShapeTypeFilter(StdSelect_ShapeTypeFilter parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public StdSelect_ShapeTypeFilter()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public TopAbs_ShapeEnum Type()
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
    }; // class StdSelect_ShapeTypeFilter
}