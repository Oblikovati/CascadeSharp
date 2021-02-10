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
    //  Class  StdSelect_FaceFilter
    //---------------------------------------------------------------------
    public sealed class StdSelect_FaceFilter : SelectMgr_Filter
    {
        public StdSelect_FaceFilter(StdSelect_TypeOfFace aTypeOfFace)
            : base()
        {
            throw new NotImplementedException();
        }

        public StdSelect_FaceFilter(StdSelect_FaceFilter parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public StdSelect_FaceFilter()
        {
            throw new NotImplementedException();
        }

        public void SetType(StdSelect_TypeOfFace aNewType)
        {
            throw new NotImplementedException();
        }

        public StdSelect_TypeOfFace Type()
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
    }; // class StdSelect_FaceFilter
}