//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKV3d.Prs3d;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_TrihedronOwner
	//---------------------------------------------------------------------
	public  sealed class AIS_TrihedronOwner : SelectMgr_EntityOwner
	{

		public AIS_TrihedronOwner(SelectMgr_SelectableObject theSelObject, Prs3d_DatumParts theDatumPart, int thePriority)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_TrihedronOwner(AIS_TrihedronOwner parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_TrihedronOwner()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public Prs3d_DatumParts DatumPart()
		{
			throw new NotImplementedException();
		}

						
	}; // class AIS_TrihedronOwner

}
