//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKV3d.SelectMgr
{
    //---------------------------------------------------------------------
    //  Class  SelectMgr_SelectableObjectSet
    //---------------------------------------------------------------------
    public sealed class SelectMgr_SelectableObjectSet
    {
        public SelectMgr_SelectableObjectSet()
            : base()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_SelectableObjectSet(SelectMgr_SelectableObjectSet parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool Append(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public bool Remove(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public void ChangeSubset(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public void MarkDirty()
        {
            throw new NotImplementedException();
        }

        public bool Contains(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty(BVHSubset theSubset)
        {
            throw new NotImplementedException();
        }

        public SelectMgr_SelectableObject GetObjectById(BVHSubset theSubset, int theIndex)
        {
            throw new NotImplementedException();
        }

        public int appropriateSubset(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public int currentSubset(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }


        //---------------------------------------------------------------------
        //  Enum  BVHSubset
        //---------------------------------------------------------------------
        public enum BVHSubset
        {
            BVHSubset_3d = 0,
            BVHSubset_3dPersistent = 1,
            BVHSubset_2dPersistent = 2,
            BVHSubsetNb = 3
        } // enum  class BVHSubset
    }; // class SelectMgr_SelectableObjectSet
}