//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_ManipulatorOwner
    //---------------------------------------------------------------------
    public sealed class AIS_ManipulatorOwner : SelectMgr_EntityOwner
    {
        public AIS_ManipulatorOwner(SelectMgr_SelectableObject theSelObject, int theIndex, AIS_ManipulatorMode theMode,
            int thePriority)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_ManipulatorOwner(SelectMgr_SelectableObject theSelObject, int theIndex, AIS_ManipulatorMode theMode)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_ManipulatorOwner(AIS_ManipulatorOwner parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_ManipulatorOwner()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public AIS_ManipulatorMode Mode()
        {
            throw new NotImplementedException();
        }

        public int Index()
        {
            throw new NotImplementedException();
        }
    }; // class AIS_ManipulatorOwner
}