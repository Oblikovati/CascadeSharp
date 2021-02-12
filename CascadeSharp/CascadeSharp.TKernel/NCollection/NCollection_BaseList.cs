//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace CascadeSharp.TKernel.NCollection
{
    //---------------------------------------------------------------------
    //  Class  NCollection_BaseList
    //---------------------------------------------------------------------
    public class NCollection_BaseList
    {
        public NCollection_BaseList(NCollection_BaseAllocator theAllocator)
            : base()
        {
            throw new NotImplementedException();
        }

        public NCollection_BaseList(NCollection_BaseList parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public NCollection_BaseList()
        {
            throw new NotImplementedException();
        }

        public int Extent()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public NCollection_BaseAllocator Allocator()
        {
            throw new NotImplementedException();
        }

        public void PAppend(NCollection_BaseList theOther)
        {
            throw new NotImplementedException();
        }

        public void PPrepend(NCollection_BaseList theOther)
        {
            throw new NotImplementedException();
        }

        public void PReverse()
        {
            throw new NotImplementedException();
        }
        public class Iterator : IEnumerable
        {
            protected Iterator(NCollection_BaseList theList)
            {
                throw new NotImplementedException();
            }

            protected Iterator()
            {
                throw new NotImplementedException();
            }

            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}