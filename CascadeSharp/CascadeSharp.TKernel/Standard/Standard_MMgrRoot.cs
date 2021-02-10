//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.Standard
{
	//---------------------------------------------------------------------
	//  Class  Standard_MMgrRoot
	//---------------------------------------------------------------------
	public  abstract class Standard_MMgrRoot
	{

		public Standard_MMgrRoot(Standard_MMgrRoot parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Standard_MMgrRoot()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public IntPtr Allocate(ulong theSize)
		{
			throw new NotImplementedException();
		}

		public IntPtr Reallocate(IntPtr thePtr, ulong theSize)
		{
			throw new NotImplementedException();
		}

		public void Free(IntPtr thePtr)
		{
			throw new NotImplementedException();
		}

		public int Purge(bool _isDestroyed)
		{
			throw new NotImplementedException();
		}

		public int Purge()
		{
			throw new NotImplementedException();
		}


	}; // class Standard_MMgrRoot

}
