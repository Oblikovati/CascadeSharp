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
	//  Class  AIS_ExclusionFilter
	//---------------------------------------------------------------------
	public  sealed class AIS_ExclusionFilter : SelectMgr_Filter
	{

		public AIS_ExclusionFilter(bool ExclusionFlagOn)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_ExclusionFilter(AIS_KindOfInteractive TypeToExclude, bool ExclusionFlagOn)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_ExclusionFilter(AIS_KindOfInteractive TypeToExclude)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_ExclusionFilter(AIS_KindOfInteractive TypeToExclude, int SignatureInType, bool ExclusionFlagOn)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_ExclusionFilter(AIS_KindOfInteractive TypeToExclude, int SignatureInType)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_ExclusionFilter(AIS_ExclusionFilter parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_ExclusionFilter()
		{
			throw new NotImplementedException();
		}

		public bool IsOk(SelectMgr_EntityOwner anObj)
		{
			throw new NotImplementedException();
		}

		public bool Add(AIS_KindOfInteractive TypeToExclude)
		{
			throw new NotImplementedException();
		}

		public bool Add(AIS_KindOfInteractive TypeToExclude, int SignatureInType)
		{
			throw new NotImplementedException();
		}

		public bool Remove(AIS_KindOfInteractive TypeToExclude)
		{
			throw new NotImplementedException();
		}

		public bool Remove(AIS_KindOfInteractive TypeToExclude, int SignatureInType)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool IsExclusionFlagOn()
		{
			throw new NotImplementedException();
		}

		public void SetExclusionFlag(bool Status)
		{
			throw new NotImplementedException();
		}

		public bool IsStored(AIS_KindOfInteractive aType)
		{
			throw new NotImplementedException();
		}

		public void ListOfStoredTypes(TColStd_ListOfInteger TheL_ist)
		{
			throw new NotImplementedException();
		}

		public void ListOfSignature(AIS_KindOfInteractive aType, TColStd_ListOfInteger TheStoredL_ist)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IsSignatureIn(AIS_KindOfInteractive aType, int aSignature)
		{
			throw new NotImplementedException();
		}


	}; // class AIS_ExclusionFilter

}
