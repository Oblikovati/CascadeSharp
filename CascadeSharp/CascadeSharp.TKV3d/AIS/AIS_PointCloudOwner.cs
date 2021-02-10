//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_PointCloudOwner
	//---------------------------------------------------------------------
	public  sealed class AIS_PointCloudOwner : SelectMgr_EntityOwner
	{

		public AIS_PointCloudOwner(AIS_PointCloud theOrigin)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_PointCloudOwner(AIS_PointCloudOwner parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_PointCloudOwner()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public TColStd_HPackedMapOfInteger SelectedPoints()
		{
			throw new NotImplementedException();
		}

		public TColStd_HPackedMapOfInteger DetectedPoints()
		{
			throw new NotImplementedException();
		}

		public bool IsForcedHilight()
		{
			throw new NotImplementedException();
		}

						
	}; // class AIS_PointCloudOwner

}
