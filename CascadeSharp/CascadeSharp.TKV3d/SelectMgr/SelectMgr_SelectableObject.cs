//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKV3d.PrsMgr;

namespace CascadeSharp.TKV3d.SelectMgr
{
    //---------------------------------------------------------------------
    //  Class  SelectMgr_SelectableObject
    //---------------------------------------------------------------------
    public abstract class SelectMgr_SelectableObject : PrsMgr_PresentableObject
    {
        public SelectMgr_SelectableObject(SelectMgr_SelectableObject parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public SelectMgr_SelectableObject()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void ComputeSelection(SelectMgr_Selection theSelection, int theMode)
        {
            throw new NotImplementedException();
        }

        public bool AcceptShapeDecomposition()
        {
            throw new NotImplementedException();
        }

        public void RecomputePrimitives()
        {
            throw new NotImplementedException();
        }

        public void RecomputePrimitives(int theMode)
        {
            throw new NotImplementedException();
        }

        public void AddSelection(SelectMgr_Selection aSelection, int aMode)
        {
            throw new NotImplementedException();
        }

        public void ClearSelections(bool update)
        {
            throw new NotImplementedException();
        }

        public void ClearSelections()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_Selection Selection(int theMode)
        {
            throw new NotImplementedException();
        }

        public bool HasSelection(int theMode)
        {
            throw new NotImplementedException();
        }

        public SelectMgr_SequenceOfSelection Selections()
        {
            throw new NotImplementedException();
        }

        public void ResetTransformation()
        {
            throw new NotImplementedException();
        }

        public void UpdateTransformation()
        {
            throw new NotImplementedException();
        }

        public void UpdateTransformations(SelectMgr_Selection aSelection)
        {
            throw new NotImplementedException();
        }

        public void ClearSelected()
        {
            throw new NotImplementedException();
        }

        public bool IsAutoHilight()
        {
            throw new NotImplementedException();
        }

        public void SetAutoHilight(bool theAutoHilight)
        {
            throw new NotImplementedException();
        }

        public void ErasePresentations(bool theToRemove)
        {
            throw new NotImplementedException();
        }

        public void SetZLayer(int theLayerId)
        {
            throw new NotImplementedException();
        }

        public void UpdateSelection(int theMode)
        {
            throw new NotImplementedException();
        }

        public void UpdateSelection()
        {
            throw new NotImplementedException();
        }

        public void SetAssemblyOwner(SelectMgr_EntityOwner theOwner, int theMode)
        {
            throw new NotImplementedException();
        }

        public void SetAssemblyOwner(SelectMgr_EntityOwner theOwner)
        {
            throw new NotImplementedException();
        }

        public int GlobalSelectionMode()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_EntityOwner GlobalSelOwner()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_EntityOwner GetAssemblyOwner()
        {
            throw new NotImplementedException();
        }

        public void setGlobalSelMode(int theMode)
        {
            throw new NotImplementedException();
        }

        public void UpdateClipping()
        {
            throw new NotImplementedException();
        }

        public void updateSelection(int theMode)
        {
            throw new NotImplementedException();
        }
    }; // class SelectMgr_SelectableObject
}