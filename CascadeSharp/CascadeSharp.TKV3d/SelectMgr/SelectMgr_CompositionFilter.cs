//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKV3d.SelectMgr
{
    //---------------------------------------------------------------------
    //  Class  SelectMgr_CompositionFilter
    //---------------------------------------------------------------------
    public abstract class SelectMgr_CompositionFilter : SelectMgr_Filter
    {
        public SelectMgr_CompositionFilter(SelectMgr_CompositionFilter parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public SelectMgr_CompositionFilter()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void Add(SelectMgr_Filter afilter)
        {
            throw new NotImplementedException();
        }

        public void Remove(SelectMgr_Filter aFilter)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool IsIn(SelectMgr_Filter aFilter)
        {
            throw new NotImplementedException();
        }

        public SelectMgr_ListOfFilter StoredFilters()
        {
            throw new NotImplementedException();
        }

        public void Clear()
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
    }; // class SelectMgr_CompositionFilter
}