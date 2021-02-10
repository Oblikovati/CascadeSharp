//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.NCollection
{
    //---------------------------------------------------------------------
    //  Class  NCollection_WinHeapAllocator
    //---------------------------------------------------------------------
    public sealed class NCollection_WinHeapAllocator : NCollection_BaseAllocator
    {
        public NCollection_WinHeapAllocator(ulong theInitSizeBytes)
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