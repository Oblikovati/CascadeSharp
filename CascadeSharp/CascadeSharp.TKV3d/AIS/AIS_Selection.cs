//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_Selection
    //---------------------------------------------------------------------
    public sealed class AIS_Selection : Standard_Transient
    {
        public AIS_Selection()
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_Selection(AIS_Selection parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public AIS_SelectStatus Select(SelectMgr_EntityOwner theObject)
        {
            throw new NotImplementedException();
        }

        public AIS_SelectStatus AddSelect(SelectMgr_EntityOwner theObject)
        {
            throw new NotImplementedException();
        }

        public void ClearAndSelect(SelectMgr_EntityOwner theObject)
        {
            throw new NotImplementedException();
        }

        public bool IsSelected(SelectMgr_EntityOwner theObject)
        {
            throw new NotImplementedException();
        }

        public AIS_NListOfEntityOwner Objects()
        {
            throw new NotImplementedException();
        }

        public int Extent()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public bool More()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_EntityOwner Value()
        {
            throw new NotImplementedException();
        }
    }; // class AIS_Selection
}