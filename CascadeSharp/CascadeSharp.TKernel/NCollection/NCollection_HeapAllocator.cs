//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.NCollection
{
	//---------------------------------------------------------------------
	//  Class  NCollection_HeapAllocator
	//---------------------------------------------------------------------
	public  sealed class NCollection_HeapAllocator : NCollection_BaseAllocator
	{

		public NCollection_HeapAllocator()
			: base()
		{
			throw new NotImplementedException();
		}

		public NCollection_HeapAllocator(NCollection_HeapAllocator parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPtr Allocate(ulong theSize)
		{
			throw new NotImplementedException();
		}

		public void Free(IntPtr anAddress)
		{
			throw new NotImplementedException();
		}

		public NCollection_HeapAllocator GlobalHeapAllocator()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class NCollection_HeapAllocator

}
