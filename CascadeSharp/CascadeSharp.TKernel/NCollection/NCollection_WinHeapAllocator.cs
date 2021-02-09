//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  NCollection_WinHeapAllocator
	//---------------------------------------------------------------------
	public  sealed class NCollection_WinHeapAllocator : CascadeSharp.NCollection_BaseAllocator
	{

		public NCollection_WinHeapAllocator(UInt64 theInitSizeBytes)
			: base()
		{
			throw new NotImplementedException();
		}

		public NCollection_WinHeapAllocator(NCollection_WinHeapAllocator parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public NCollection_WinHeapAllocator()
		{
			throw new NotImplementedException();
		}

		public IntPtr Allocate(ulong theSize)
		{
			throw new NotImplementedException();
		}

		public void Free(IntPtr theAddress)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class NCollection_WinHeapAllocator

}
