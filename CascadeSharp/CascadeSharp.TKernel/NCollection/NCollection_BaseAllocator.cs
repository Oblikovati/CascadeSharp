//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  NCollection_BaseAllocator
	//---------------------------------------------------------------------
	public  class NCollection_BaseAllocator : Standard_Transient
	{

		public NCollection_BaseAllocator()
			: base()
		{
			throw new NotImplementedException();
		}

		public NCollection_BaseAllocator(NCollection_BaseAllocator parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPtr Allocate(UInt64 size)
		{
			throw new NotImplementedException();
		}

		public void Free(IntPtr anAddress)
		{
			throw new NotImplementedException();
		}

		public NCollection_BaseAllocator CommonBaseAllocator()
		{
			throw new NotImplementedException();
		}

		public void StandardCallBack(bool theIsAlloc, IntPtr theStorage, ulong theRoundSize, ulong theSize)
		{
			throw new NotImplementedException();
		}

		public void PrintMemUsageStatistics()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class NCollection_BaseAllocator

}
