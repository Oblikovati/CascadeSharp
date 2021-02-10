//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.NCollection
{
    //---------------------------------------------------------------------
    //  Class  NCollection_AccAllocator
    //---------------------------------------------------------------------
    public sealed class NCollection_AccAllocator : NCollection_BaseAllocator
    {
        public NCollection_AccAllocator(ulong theBlockSize)
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
    }; // class NCollection_AccAllocator
}