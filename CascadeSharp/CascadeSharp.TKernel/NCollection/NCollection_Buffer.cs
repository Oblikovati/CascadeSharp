//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKernel.NCollection
{
    //---------------------------------------------------------------------
    //  Class  NCollection_Buffer
    //---------------------------------------------------------------------
    public sealed class NCollection_Buffer : Standard_Transient
    {
        public NCollection_Buffer(NCollection_BaseAllocator theAlloc, ulong theSize, ref byte theData)
            : base()
        {
            throw new NotImplementedException();
        }

        public NCollection_Buffer(NCollection_BaseAllocator theAlloc, ulong theSize)
            : base()
        {
            throw new NotImplementedException();
        }

        public NCollection_Buffer(NCollection_BaseAllocator theAlloc)
            : base()
        {
            throw new NotImplementedException();
        }

        public NCollection_Buffer(NCollection_Buffer parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public NCollection_Buffer()
        {
            throw new NotImplementedException();
        }

        public byte Data()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public byte ChangeData()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public ulong Size()
        {
            throw new NotImplementedException();
        }

        public NCollection_BaseAllocator Allocator()
        {
            throw new NotImplementedException();
        }

        public void SetAllocator(NCollection_BaseAllocator theAlloc)
        {
            throw new NotImplementedException();
        }

        public bool Allocate(ulong theSize)
        {
            throw new NotImplementedException();
        }

        public void Free()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class NCollection_Buffer
}