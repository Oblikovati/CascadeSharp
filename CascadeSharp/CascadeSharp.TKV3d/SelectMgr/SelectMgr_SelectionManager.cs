//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKV3d.SelectMgr
{
    //---------------------------------------------------------------------
    //  Class  SelectMgr_SelectionManager
    //---------------------------------------------------------------------
    public sealed class SelectMgr_SelectionManager : Standard_Transient
    {
        public SelectMgr_SelectionManager(SelectMgr_ViewerSelector theSelector)
            : base()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_SelectionManager(SelectMgr_SelectionManager parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_SelectionManager()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public SelectMgr_ViewerSelector Selector()
        {
            throw new NotImplementedException();
        }

        public bool Contains(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public void Load(SelectMgr_SelectableObject theObject, int theMode)
        {
            throw new NotImplementedException();
        }

        public void Load(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public void Remove(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public void Activate(SelectMgr_SelectableObject theObject, int theMode)
        {
            throw new NotImplementedException();
        }

        public void Activate(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public void Deactivate(SelectMgr_SelectableObject theObject, int theMode)
        {
            throw new NotImplementedException();
        }

        public void Deactivate(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public bool IsActivated(SelectMgr_SelectableObject theObject, int theMode)
        {
            throw new NotImplementedException();
        }

        public bool IsActivated(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public void ClearSelectionStructures(SelectMgr_SelectableObject theObj, int theMode)
        {
            throw new NotImplementedException();
        }

        public void ClearSelectionStructures(SelectMgr_SelectableObject theObj)
        {
            throw new NotImplementedException();
        }

        public void RestoreSelectionStructures(SelectMgr_SelectableObject theObj, int theMode)
        {
            throw new NotImplementedException();
        }

        public void RestoreSelectionStructures(SelectMgr_SelectableObject theObj)
        {
            throw new NotImplementedException();
        }

        public void RecomputeSelection(SelectMgr_SelectableObject theObject, bool theIsForce, int theMode)
        {
            throw new NotImplementedException();
        }

        public void RecomputeSelection(SelectMgr_SelectableObject theObject, bool theIsForce)
        {
            throw new NotImplementedException();
        }

        public void RecomputeSelection(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public void Update(SelectMgr_SelectableObject theObject, bool theIsForce)
        {
            throw new NotImplementedException();
        }

        public void Update(SelectMgr_SelectableObject theObject)
        {
            throw new NotImplementedException();
        }

        public void SetUpdateMode(SelectMgr_SelectableObject theObject, SelectMgr_TypeOfUpdate theType)
        {
            throw new NotImplementedException();
        }

        public void SetUpdateMode(SelectMgr_SelectableObject theObject, int theMode, SelectMgr_TypeOfUpdate theType)
        {
            throw new NotImplementedException();
        }

        public void SetSelectionSensitivity(SelectMgr_SelectableObject theObject, int theMode, int theNewSens)
        {
            throw new NotImplementedException();
        }

        public void UpdateSelection(SelectMgr_SelectableObject theObj)
        {
            throw new NotImplementedException();
        }

        public void recomputeSelectionMode(SelectMgr_SelectableObject theObject, SelectMgr_Selection theSelection,
            int theMode)
        {
            throw new NotImplementedException();
        }

        public void loadMode(SelectMgr_SelectableObject theObject, int theMode)
        {
            throw new NotImplementedException();
        }

        public void buildBVH(SelectMgr_Selection theSelection)
        {
            throw new NotImplementedException();
        }
    }; // class SelectMgr_SelectionManager
}