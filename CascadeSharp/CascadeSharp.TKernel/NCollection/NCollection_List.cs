using System.Collections.Generic;

namespace CascadeSharp.TKernel.NCollection
{
    public class NCollection_List<T>  : List<T>
    {
        public NCollection_List()
        {
            
        }

        public NCollection_List(NCollection_List<T> theOther)
        {
            Assign(theOther);
        }
        public int Size()
        {
            return Count;
        }

        public NCollection_List<T> Assign(NCollection_List<T> theOther)
        {
            if (ReferenceEquals(this, theOther))
                return this;
            Clear();
            AddRange(theOther);
            return this;
        }

        public T First
        {
            get => Count == 0 ? default : this[0];
            set
            {
                if(Count ==0)
                    Add(value);
                else
                    this[0] = value;
            } 
        }

        public T Last
        {
            get => Count == 0 ? default : this[Count-1];
            set
            {
                if (Count == 0)
                    Add(value);
                else
                    this[Count -1] = value;
            }
        }

        public IEnumerator<T> Append(T theItem)
        {
            Add(theItem);
            return GetEnumerator();
        }
        public IEnumerator<T> Append(NCollection_List<T> theItem)
        {
            if (ReferenceEquals(this, theItem))
                return GetEnumerator();

            AddRange(theItem);
            return GetEnumerator();
        }

        public T Prepend(T theItem)
        {
            Insert(0, theItem);
            return this[0];
        }
        public void Prepend(NCollection_List<T> theItem)
        {
            if(ReferenceEquals(this, theItem))
                return;
            
            InsertRange(0, theItem);
        }

        public void RemoveFirst()
        {
            if(Count > 0)
                RemoveAt(0);
        }

        public void Remove(int theIndex)
        {
            if(theIndex < Count)
                RemoveAt(theIndex);
        }

        public void InsertBefore(T theItem, int theIndex)
        {
            Insert(theIndex,theItem);
        }

        public void InsertBefore(NCollection_List<T> theOther, int theIndex)
        {
            InsertRange(theIndex,theOther);
        }
        public void InsertAfter(T theItem, int theIndex)
        {
            Insert(theIndex +1, theItem);
        }

        public void InsertAfter(NCollection_List<T> theOther, int theIndex)
        {
            InsertRange(theIndex +1, theOther);
        }
        public class Iterator : NCollection_TListIterator<T>
        {
            public Iterator()
            {
                
            }
            protected Iterator(NCollection_List<T> list)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}