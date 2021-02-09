//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Enum  Message_MetricType
	//---------------------------------------------------------------------
	public	enum Message_MetricType
	{
		Message_MetricType_None = 0,
		Message_MetricType_ThreadCPUUserTime = 1,
		Message_MetricType_ThreadCPUSystemTime = 2,
		Message_MetricType_ProcessCPUUserTime = 3,
		Message_MetricType_ProcessCPUSystemTime = 4,
		Message_MetricType_MemPrivate = 5,
		Message_MetricType_MemVirtual = 6,
		Message_MetricType_MemWorkingSet = 7,
		Message_MetricType_MemWorkingSetPeak = 8,
		Message_MetricType_MemSwapUsage = 9,
		Message_MetricType_MemSwapUsagePeak = 10,
		Message_MetricType_MemHeapUsage = 11
	} // enum  class Message_MetricType

}
