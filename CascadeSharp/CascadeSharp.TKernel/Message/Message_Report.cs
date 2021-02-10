//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKernel.Message
{
    //---------------------------------------------------------------------
    //  Class  Message_Report
    //---------------------------------------------------------------------
    public sealed class Message_Report : Standard_Transient
    {
        public Message_Report()
            : base()
        {
            throw new NotImplementedException();
        }

        public void AddAlert(Message_Gravity theGravity, Message_Alert theAlert)
        {
            throw new NotImplementedException();
        }

        public Message_ListOfAlert GetAlerts(Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }

        public bool IsActiveInMessenger(Message_Messenger theMessenger)
        {
            throw new NotImplementedException();
        }

        public bool IsActiveInMessenger()
        {
            throw new NotImplementedException();
        }

        public void ActivateInMessenger(bool toActivate, Message_Messenger theMessenger)
        {
            throw new NotImplementedException();
        }

        public void ActivateInMessenger(bool toActivate)
        {
            throw new NotImplementedException();
        }

        public void UpdateActiveInMessenger(Message_Messenger theMessenger)
        {
            throw new NotImplementedException();
        }

        public void UpdateActiveInMessenger()
        {
            throw new NotImplementedException();
        }

        public void AddLevel(Message_Level theLevel, TCollection_AsciiString theName)
        {
            throw new NotImplementedException();
        }

        public void RemoveLevel(Message_Level theLevel)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Clear(Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }

        public void SetActiveMetric(Message_MetricType theMetricType, bool theActivate)
        {
            throw new NotImplementedException();
        }

        public void ClearMetrics()
        {
            throw new NotImplementedException();
        }

        public int Limit()
        {
            throw new NotImplementedException();
        }

        public void SetLimit(int theLimit)
        {
            throw new NotImplementedException();
        }

        public void SendMessages(Message_Messenger theMessenger)
        {
            throw new NotImplementedException();
        }

        public void SendMessages(Message_Messenger theMessenger, Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }

        public void Merge(Message_Report theOther)
        {
            throw new NotImplementedException();
        }

        public void Merge(Message_Report theOther, Message_Gravity theGravity)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public Message_CompositeAlerts compositeAlerts(bool _isCreate)
        {
            throw new NotImplementedException();
        }

        public Message_CompositeAlerts compositeAlerts()
        {
            throw new NotImplementedException();
        }

        public void sendMessages(Message_Messenger theMessenger, Message_Gravity theGravity,
            Message_CompositeAlerts theCompositeAlert)
        {
            throw new NotImplementedException();
        }
    }; // class Message_Report
}