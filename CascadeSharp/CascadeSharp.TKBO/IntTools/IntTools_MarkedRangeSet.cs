//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;

namespace CascadeSharp.TKBO.IntTools
{
    //---------------------------------------------------------------------
    //  Class  IntTools_MarkedRangeSet
    //---------------------------------------------------------------------
    public sealed class IntTools_MarkedRangeSet
    {
        public IntTools_MarkedRangeSet()
            : base()
        {
            throw new NotImplementedException();
        }

        public IntTools_MarkedRangeSet(double theFirstBoundary, double theLastBoundary, int theInitFlag)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntTools_MarkedRangeSet(IntTools_CArray1OfReal theSortedArray, int theInitFlag)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntTools_MarkedRangeSet(IntTools_MarkedRangeSet parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void SetBoundaries(double theFirstBoundary, double theLastBoundary, int theInitFlag)
        {
            throw new NotImplementedException();
        }

        public void SetRanges(IntTools_CArray1OfReal theSortedArray, int theInitFlag)
        {
            throw new NotImplementedException();
        }

        public bool InsertRange(double theFirstBoundary, double theLastBoundary, int theFlag)
        {
            throw new NotImplementedException();
        }

        public bool InsertRange(IntTools_Range theRange, int theFlag)
        {
            throw new NotImplementedException();
        }

        public bool InsertRange(double theFirstBoundary, double theLastBoundary, int theFlag, int theIndex)
        {
            throw new NotImplementedException();
        }

        public bool InsertRange(IntTools_Range theRange, int theFlag, int theIndex)
        {
            throw new NotImplementedException();
        }

        public void SetFlag(int theIndex, int theFlag)
        {
            throw new NotImplementedException();
        }

        public int Flag(int theIndex)
        {
            throw new NotImplementedException();
        }

        public int GetIndex(double theValue)
        {
            throw new NotImplementedException();
        }

        public TColStd_SequenceOfInteger GetIndices(double theValue)
        {
            throw new NotImplementedException();
        }

        public int GetIndex(double theValue, bool UseLower)
        {
            throw new NotImplementedException();
        }

        public int Length()
        {
            throw new NotImplementedException();
        }

        public IntTools_Range Range(int theIndex)
        {
            throw new NotImplementedException();
        }
    }; // class IntTools_MarkedRangeSet
}