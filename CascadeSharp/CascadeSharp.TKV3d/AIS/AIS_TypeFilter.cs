//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_TypeFilter
    //---------------------------------------------------------------------
    public class AIS_TypeFilter : SelectMgr_Filter
    {
        public AIS_TypeFilter(AIS_KindOfInteractive aGivenKind)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_TypeFilter(AIS_TypeFilter parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_TypeFilter()
        {
            throw new NotImplementedException();
        }

        public bool IsOk(SelectMgr_EntityOwner anobj)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class AIS_TypeFilter
}