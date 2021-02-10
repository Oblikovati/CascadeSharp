//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.NCollection
{
	//---------------------------------------------------------------------
	//  Class  NCollection_AlignedAllocator
	//---------------------------------------------------------------------
	public  sealed class NCollection_AlignedAllocator : NCollection_BaseAllocator
	{

		public NCollection_AlignedAllocator(UInt64 theAlignment)
			: base()
		{
			throw new NotImplementedException();
		}

		public NCollection_AlignedAllocator(NCollection_AlignedAllocator parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public NCollection_AlignedAllocator()
		{
			throw new NotImplementedException();
		}

		public IntPtr Allocate(UInt64 theSize)
		{
			throw new NotImplementedException();
		}

		public void Free(IntPtr thePtr)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class NCollection_AlignedAllocator

}
