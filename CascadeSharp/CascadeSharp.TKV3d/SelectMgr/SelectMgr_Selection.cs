//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKV3d.SelectMgr
{
    //---------------------------------------------------------------------
    //  Class  SelectMgr_Selection
    //---------------------------------------------------------------------
    public sealed class SelectMgr_Selection : Standard_Transient
    {
        public SelectMgr_Selection(int theModeIdx)
            : base()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_Selection(SelectMgr_Selection parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_Selection()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public int Mode()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_TypeOfUpdate UpdateStatus()
        {
            throw new NotImplementedException();
        }

        public void UpdateStatus(SelectMgr_TypeOfUpdate theStatus)
        {
            throw new NotImplementedException();
        }

        public void UpdateBVHStatus(SelectMgr_TypeOfBVHUpdate theStatus)
        {
            throw new NotImplementedException();
        }

        public SelectMgr_TypeOfBVHUpdate BVHUpdateStatus()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_StateOfSelection GetSelectionState()
        {
            throw new NotImplementedException();
        }

        public void SetSelectionState(SelectMgr_StateOfSelection theState)
        {
            throw new NotImplementedException();
        }

        public int Sensitivity()
        {
            throw new NotImplementedException();
        }

        public void SetSensitivity(int theNewSens)
        {
            throw new NotImplementedException();
        }
    }; // class SelectMgr_Selection
}