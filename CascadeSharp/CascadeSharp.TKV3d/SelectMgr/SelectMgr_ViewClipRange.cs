//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Graphic3d;

namespace CascadeSharp.TKV3d.SelectMgr
{
    //---------------------------------------------------------------------
    //  Class  SelectMgr_ViewClipRange
    //---------------------------------------------------------------------
    public sealed class SelectMgr_ViewClipRange
    {
        public SelectMgr_ViewClipRange()
            : base()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_ViewClipRange(SelectMgr_ViewClipRange parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool IsClipped(double theDepth)
        {
            throw new NotImplementedException();
        }

        public bool GetNearestDepth(Bnd_Range theRange, ref double theDepth)
        {
            throw new NotImplementedException();
        }

        public void SetVoid()
        {
            throw new NotImplementedException();
        }

        public void AddClippingPlanes(Graphic3d_SequenceOfHClipPlane thePlanes, gp_Ax1 thePickRay)
        {
            throw new NotImplementedException();
        }

        public Bnd_Range ChangeUnclipRange()
        {
            throw new NotImplementedException();
        }

        public void AddClipSubRange(Bnd_Range theRange)
        {
            throw new NotImplementedException();
        }
    }; // class SelectMgr_ViewClipRange
}