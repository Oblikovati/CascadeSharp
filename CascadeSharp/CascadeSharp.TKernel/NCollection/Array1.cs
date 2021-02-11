using System;
using System.Collections.Generic;

namespace CascadeSharp.TKernel.NCollection
{


    /// <summary>
    /// Purpose: The class Array1 represents unidimensional arrays of fixed size known at run time.
    /// The range of the index is user defined.
    /// This functionality is useful to call methods expecting
    /// an Array1.It allows to carry the bounds inside the arrays.
    ///
    /// Examples:    Item tab[100]; //  An example with a C array
    /// Array1OfItem ttab(tab[0],1,100);
    ///
    /// Array1OfItem tttab(ttab(10),10,20); // a slice of ttab
    ///
    /// If you want to reindex an array from 1 to Length do :
    ///
    /// Array1 tab1(tab(tab.Lower()),1,tab.Length());
    ///
    /// Warning:     Programs client of such a class must be independant
    /// of the range of the first element.Then, a C++ for
    ///              loop must be written like this
    ///
    ///              for (i = A.Lower(); i <= A.Upper(); i++)
    ///
    /// Changes:     In comparison  to TCollection  the flag  isAllocated was
    /// renamed into myDeletable(alike in the Array2).  For naming
    /// compatibility the method IsAllocated remained in class along
    /// with IsDeletable.
    /// </summary>
    public class Array1<T> : List<T>
    {
        #region Constructors

        protected Array1(int theLength, bool isDeletable = false)
        {
            myDeletable = isDeletable;
            myLowerBound = 0;
            myUpperBound = theLength - 1;
            for (var i = 0; i <= myUpperBound; i++)
            {
                Add(default);
            }
        }

        //TODO: could we work always with zero indexed values and forget theLower?
        public Array1(int theLower, int theUpper, bool isDeletable = true)
        {
            myDeletable = isDeletable;
            myLowerBound = 0;
            myUpperBound = theUpper - theLower;

            for (var i = 0; i <= myUpperBound; i++)
            {
                Add(default);
            }
        }

        public Array1(Array1<T> theOther)
        {
            myDeletable = theOther.myDeletable;
            myLowerBound = theOther.myLowerBound;
            myUpperBound = theOther.myUpperBound;
            foreach (var item in theOther)
            {
                Add(item);
            }
        }

        #endregion

        #region Protected Objects

        protected int myLowerBound;
        protected int myUpperBound;
        protected bool myDeletable; //!< Flag showing who allocated the array

        #endregion

        #region Public Methods

        public void Init(T theValue)
        {
            for (var i = 0; i < this.Count; i++)
            {
                this[i] = theValue;
            }
        }

        public int Length()
        {
            return myUpperBound - myLowerBound + 1;
        }

        public int Size() => Length();

        public bool IsEmpty()
        {
            return myUpperBound < myLowerBound;
        }

        public int Lower()
        {
            return myLowerBound;
        }

        public int Upper()
        {
            return myUpperBound;
        }

        public bool IsDeletable()
        {
            return myDeletable;
        }

        public bool IsAllocated()
        {
            return myDeletable;
        }
        /// <summary>
        /// Copies data from theOther to this.
        /// This array should be pre-allocated and have the same length as theOther.
        /// For reference objects those must implement ICloneable for deep copy.
        /// </summary>
        /// <param name="theOther"></param>
        /// <returns></returns>
        public Array1<T> Assign(Array1<T> theOther)
        {
            if (ReferenceEquals(this, theOther))
                return this;

            if(this.Length() != theOther.Length())
                throw new ArgumentOutOfRangeException(nameof(theOther),
                    "To assign different arrays both must have the same length");

            if (theOther is Array1<ICloneable> cloneable)
            {
                for (var i = 0; i <= Upper(); i++)
                {
                    this[Lower() + i] = (T) cloneable[cloneable.Lower() + i].Clone();
                }
            }
            else
            {
                for (var i = 0; i <= Upper(); i++)
                {
                    this[Lower() + i] = theOther[theOther.Lower() + i];
                }
            }

            return this;
        }

        /// <summary>
        /// Moves data from theOther class to this.
        /// This array should be pre-allocated and have the same length as theOther.
        /// <typeparam name="B">Enforces this operation only happens to reference objects</typeparam>
        /// <param name="theOther">Array of reference object to be moved</param>
        /// <returns>This array reference object.</returns>
        public Array1<T> Move<TB>(Array1<TB> theOther) where TB : class, T 
        {
            if (ReferenceEquals(this, theOther))
                return this;

            if (Length() != theOther.Length())
                throw new ArgumentOutOfRangeException(nameof(theOther),
                    "To assign different arrays both must have the same length");

            for (var i = 0; i <= Upper(); i++)
            {
                this[Lower() + i] = theOther[theOther.Lower() + i];
            }
            
            return this;
        }
        public T First()
        {
            return this[myLowerBound];
        }

        public void ChangeFirst(ref T theReplacement)
        {
            this[myLowerBound] = theReplacement;
        }

        public T Last()
        {
            return this[myUpperBound];
        }

        public void ChangeLast(ref T theReplacement)
        {
            this[myUpperBound] = theReplacement;
        }

        public T Value(int theIndex)
        {
            CheckValidIndex(theIndex);
            return this[theIndex];
        }

        public T ChangeValue(int theIndex, ref T theReplacement)
        {
            CheckValidIndex(theIndex);
            this[theIndex] = theReplacement;
            return this[theIndex];
        }

        public void SetValue(int theIndex,ref T theReplacement)
        {
            CheckValidIndex(theIndex);
            this[theIndex] = theReplacement;
        }

        public void Resize(int theLower, int theUpper, bool theToCopyData)
        {
            T[] bkp = default;

            if (theUpper < theLower)
                throw new ArgumentOutOfRangeException(nameof(theUpper),
                    "TheUpper must be bigger than TheLower");
            
            if(theToCopyData)
                bkp = ToArray();

            Clear();

            if(theToCopyData)
                AddRange(bkp);
            else
            {
                for (var i = 0; i < theUpper - theLower; i++)
                {
                    Add(default);
                }
            }
        }

        #endregion

        #region Private Methods

        private void CheckValidIndex(int theIndex)
        {
            if (theIndex < myLowerBound || theIndex > myUpperBound)
                throw new ArgumentOutOfRangeException(nameof(theIndex),
                    "The index must be between Lower and Upper");
        }

        #endregion
    }
}