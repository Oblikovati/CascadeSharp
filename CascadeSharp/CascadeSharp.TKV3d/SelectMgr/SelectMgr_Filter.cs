//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKV3d.SelectMgr
{
	//---------------------------------------------------------------------
	//  Class  SelectMgr_Filter
	//---------------------------------------------------------------------
	public  abstract class SelectMgr_Filter : Standard_Transient
	{

		public SelectMgr_Filter(SelectMgr_Filter parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public SelectMgr_Filter()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public bool IsOk(SelectMgr_EntityOwner anObj)
		{
			throw new NotImplementedException();
		}

		public bool ActsOn(TopAbs_ShapeEnum aStandardMode)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class SelectMgr_Filter

}
