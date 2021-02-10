//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.Message
{
    //---------------------------------------------------------------------
    //  Class  Message_ExecStatus
    //---------------------------------------------------------------------
    public sealed class Message_ExecStatus
    {
        public Message_ExecStatus()
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_ExecStatus(Message_Status status)
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_ExecStatus(Message_ExecStatus parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public int getBitFlag(int status)
        {
            throw new NotImplementedException();
        }

        public void Set(Message_Status status)
        {
            throw new NotImplementedException();
        }

        public bool IsSet(Message_Status status)
        {
            throw new NotImplementedException();
        }

        public void Clear(Message_Status status)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public bool IsFail()
        {
            throw new NotImplementedException();
        }

        public bool IsWarn()
        {
            throw new NotImplementedException();
        }

        public bool IsAlarm()
        {
            throw new NotImplementedException();
        }

        public void SetAllDone()
        {
            throw new NotImplementedException();
        }

        public void SetAllWarn()
        {
            throw new NotImplementedException();
        }

        public void SetAllAlarm()
        {
            throw new NotImplementedException();
        }

        public void SetAllFail()
        {
            throw new NotImplementedException();
        }

        public void ClearAllDone()
        {
            throw new NotImplementedException();
        }

        public void ClearAllWarn()
        {
            throw new NotImplementedException();
        }

        public void ClearAllAlarm()
        {
            throw new NotImplementedException();
        }

        public void ClearAllFail()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Add(Message_ExecStatus theOther)
        {
            throw new NotImplementedException();
        }

        public void And(Message_ExecStatus theOther)
        {
            throw new NotImplementedException();
        }

        public int StatusIndex(Message_Status status)
        {
            throw new NotImplementedException();
        }

        public int LocalStatusIndex(Message_Status status)
        {
            throw new NotImplementedException();
        }

        public Message_StatusType TypeOfStatus(Message_Status status)
        {
            throw new NotImplementedException();
        }

        public Message_Status StatusByIndex(int theIndex)
        {
            throw new NotImplementedException();
        }


        //---------------------------------------------------------------------
        //  Enum  StatusMask
        //---------------------------------------------------------------------
        public enum StatusMask
        {
            MType = 65280,
            MIndex = 255
        } // enum  class StatusMask

        //---------------------------------------------------------------------
        //  Enum  StatusRange
        //---------------------------------------------------------------------
        public enum StatusRange
        {
            FirstStatus = 1,
            StatusesPerType = 32,
            NbStatuses = 128,
            LastStatus = 129
        } // enum  class StatusRange
    }; // class Message_ExecStatus
}