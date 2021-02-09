//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  NCollection_AccAllocator
	//---------------------------------------------------------------------
	public  sealed class NCollection_AccAllocator : CascadeSharp.NCollection_BaseAllocator
	{

		public NCollection_AccAllocator(UInt64 theBlockSize)
			: base()
		{
			throw new NotImplementedException();
		}

		public NCollection_AccAllocator(NCollection_AccAllocator parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public NCollection_AccAllocator()
		{
			throw new NotImplementedException();
		}

		public IntPtr Allocate(UInt64 theSize)
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

				
	}; // class NCollection_AccAllocator

}
