//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Message_AttributeMeter
	//---------------------------------------------------------------------
	public  sealed class Message_AttributeMeter : CascadeSharp.Message_Attribute
	{

		public Message_AttributeMeter(TCollection_AsciiString theName)
			: base()
		{
			throw new NotImplementedException();
		}

		public Message_AttributeMeter(Message_AttributeMeter parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Message_AttributeMeter()
		{
			throw new NotImplementedException();
		}

		public double UndefinedMetricValue()
		{
			throw new NotImplementedException();
		}

		public bool HasMetric( ref CascadeSharp.Message_MetricType theMetric)
		{
			throw new NotImplementedException();
		}

		public bool IsMetricValid( ref CascadeSharp.Message_MetricType theMetric)
		{
			throw new NotImplementedException();
		}

		public double StartValue( ref CascadeSharp.Message_MetricType theMetric)
		{
			throw new NotImplementedException();
		}

		public void SetStartValue( ref CascadeSharp.Message_MetricType theMetric, double theValue)
		{
			throw new NotImplementedException();
		}

		public double StopValue( ref CascadeSharp.Message_MetricType theMetric)
		{
			throw new NotImplementedException();
		}

		public void SetStopValue( ref CascadeSharp.Message_MetricType theMetric, double theValue)
		{
			throw new NotImplementedException();
		}

		public void StartAlert(Message_AlertExtended theAlert)
		{
			throw new NotImplementedException();
		}

		public void StopAlert(Message_AlertExtended theAlert)
		{
			throw new NotImplementedException();
		}

		public void SetAlertMetrics(Message_AlertExtended theAlert, bool theStartValue)
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Message_AttributeMeter

}
