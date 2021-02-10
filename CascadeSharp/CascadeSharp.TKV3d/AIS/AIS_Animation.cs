//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_Animation
    //---------------------------------------------------------------------
    public class AIS_Animation : Standard_Transient
    {
        public AIS_Animation(TCollection_AsciiString theAnimationName)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_Animation(AIS_Animation parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_Animation()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public TCollection_AsciiString Name()
        {
            throw new NotImplementedException();
        }

        public double StartPts()
        {
            throw new NotImplementedException();
        }

        public void SetStartPts(double thePtsStart)
        {
            throw new NotImplementedException();
        }

        public double Duration()
        {
            throw new NotImplementedException();
        }

        public void UpdateTotalDuration()
        {
            throw new NotImplementedException();
        }

        public bool HasOwnDuration()
        {
            throw new NotImplementedException();
        }

        public double OwnDuration()
        {
            throw new NotImplementedException();
        }

        public void SetOwnDuration(double theDuration)
        {
            throw new NotImplementedException();
        }

        public void Add(AIS_Animation theAnimation)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public AIS_Animation Find(TCollection_AsciiString theAnimationName)
        {
            throw new NotImplementedException();
        }

        public bool Remove(AIS_Animation theAnimation)
        {
            throw new NotImplementedException();
        }

        public bool Replace(AIS_Animation theAnimationOld, AIS_Animation theAnimationNew)
        {
            throw new NotImplementedException();
        }

        public void CopyFrom(AIS_Animation theOther)
        {
            throw new NotImplementedException();
        }

        public void StartTimer(double theStartPts, double thePlaySpeed, bool theToUpdate, bool theToStopTimer)
        {
            throw new NotImplementedException();
        }

        public void StartTimer(double theStartPts, double thePlaySpeed, bool theToUpdate)
        {
            throw new NotImplementedException();
        }

        public double UpdateTimer()
        {
            throw new NotImplementedException();
        }

        public double ElapsedTime()
        {
            throw new NotImplementedException();
        }

        public void Start(bool theToUpdate)
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public bool IsStopped()
        {
            throw new NotImplementedException();
        }

        public bool Update(double thePts)
        {
            throw new NotImplementedException();
        }

        public void updateWithChildren(AIS_AnimationProgress thePosition)
        {
            throw new NotImplementedException();
        }

        public void update(AIS_AnimationProgress theProgress)
        {
            throw new NotImplementedException();
        }


        //---------------------------------------------------------------------
        //  Enum  AnimationState
        //---------------------------------------------------------------------
        public enum AnimationState
        {
            AnimationState_Started = 0,
            AnimationState_Stopped = 1,
            AnimationState_Paused = 2
        } // enum  class AnimationState
    }; // class AIS_Animation
}