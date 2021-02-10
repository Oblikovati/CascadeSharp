//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.NCollection
{
    //---------------------------------------------------------------------
    //  Class  NCollection_IncAllocator
    //---------------------------------------------------------------------
    public sealed class NCollection_IncAllocator : NCollection_BaseAllocator
    {
        public NCollection_IncAllocator(ulong theBlockSize)
            : base()
        {
            throw new NotImplementedException();
        }

        public NCollection_IncAllocator(NCollection_IncAllocator parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public NCollection_IncAllocator()
        {
            throw new NotImplementedException();
        }

        public void SetThreadSafe(bool theIsThreadSafe)
        {
            throw new NotImplementedException();
        }

        public void SetThreadSafe()
        {
            throw new NotImplementedException();
        }

        public IntPtr Allocate(ulong size)
        {
            throw new NotImplementedException();
        }

        public void Free(IntPtr anAddress)
        {
            throw new NotImplementedException();
        }

        public ulong GetMemSize()
        {
            throw new NotImplementedException();
        }

        public IntPtr Reallocate(IntPtr anAddress, ulong oldSize, ulong newSize)
        {
            throw new NotImplementedException();
        }

        public void Reset(bool doReleaseMem)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Clean()
        {
            throw new NotImplementedException();
        }

        public IntPtr allocateNewBlock(ulong cSize)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class NCollection_IncAllocator
}