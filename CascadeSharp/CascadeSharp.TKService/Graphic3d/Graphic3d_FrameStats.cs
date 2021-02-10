//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKService.Graphic3d
{
    //---------------------------------------------------------------------
    //  Class  Graphic3d_FrameStats
    //---------------------------------------------------------------------
    public abstract class Graphic3d_FrameStats : Standard_Transient
    {
        public Graphic3d_FrameStats()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Graphic3d_FrameStats(Graphic3d_FrameStats parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public double UpdateInterval()
        {
            throw new NotImplementedException();
        }

        public void SetUpdateInterval(double theInterval)
        {
            throw new NotImplementedException();
        }

        public bool IsLongLineFormat()
        {
            throw new NotImplementedException();
        }

        public void SetLongLineFormat(bool theValue)
        {
            throw new NotImplementedException();
        }

        public void FrameStart(Graphic3d_CView theView, bool theIsImmediateOnly)
        {
            throw new NotImplementedException();
        }

        public void FrameEnd(Graphic3d_CView theView, bool theIsImmediateOnly)
        {
            throw new NotImplementedException();
        }

        public double FrameDuration()
        {
            throw new NotImplementedException();
        }

        public double FrameRate()
        {
            throw new NotImplementedException();
        }

        public double FrameRateCpu()
        {
            throw new NotImplementedException();
        }

        public ulong CounterValue(Graphic3d_FrameStatsCounter theCounter)
        {
            throw new NotImplementedException();
        }

        public double TimerValue(Graphic3d_FrameStatsTimer theTimer)
        {
            throw new NotImplementedException();
        }

        public bool HasCulledLayers()
        {
            throw new NotImplementedException();
        }

        public bool HasCulledStructs()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_FrameStatsData LastDataFrame()
        {
            throw new NotImplementedException();
        }

        public int LastDataFrameIndex()
        {
            throw new NotImplementedException();
        }

        public ulong ChangeCounter(Graphic3d_FrameStatsCounter theCounter)
        {
            throw new NotImplementedException();
        }

        public double ChangeTimer(Graphic3d_FrameStatsTimer theTimer)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_FrameStatsDataTmp ActiveDataFrame()
        {
            throw new NotImplementedException();
        }

        public void updateStatistics(Graphic3d_CView theView, bool theIsImmediateOnly)
        {
            throw new NotImplementedException();
        }
    }; // class Graphic3d_FrameStats
}