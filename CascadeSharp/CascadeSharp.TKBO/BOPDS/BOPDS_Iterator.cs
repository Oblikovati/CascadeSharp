//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBO.IntTools;
using CascadeSharp.TKernel.NCollection;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBO.BOPDS
{
    //---------------------------------------------------------------------
    //  Class  BOPDS_Iterator
    //---------------------------------------------------------------------
    public class BOPDS_Iterator
    {
        public BOPDS_Iterator()
            : base()
        {
            throw new NotImplementedException();
        }

        public BOPDS_Iterator(NCollection_BaseAllocator theAllocator)
            : base()
        {
            throw new NotImplementedException();
        }

        public BOPDS_Iterator(BOPDS_Iterator parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void SetDS(BOPDS_DS pDS)
        {
            throw new NotImplementedException();
        }

        public BOPDS_DS DS()
        {
            throw new NotImplementedException();
        }

        public void Initialize(TopAbs_ShapeEnum theType1, TopAbs_ShapeEnum theType2)
        {
            throw new NotImplementedException();
        }

        public bool More()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Value(ref int theIndex1, ref int theIndex2)
        {
            throw new NotImplementedException();
        }

        public void Prepare(IntTools_Context theCtx, bool theCheckOBB, double theFuzzyValue)
        {
            throw new NotImplementedException();
        }

        public void Prepare(IntTools_Context theCtx, bool theCheckOBB)
        {
            throw new NotImplementedException();
        }

        public void Prepare(IntTools_Context theCtx)
        {
            throw new NotImplementedException();
        }

        public void Prepare()
        {
            throw new NotImplementedException();
        }

        public void IntersectExt(TColStd_MapOfInteger theIndicies)
        {
            throw new NotImplementedException();
        }

        public int ExpectedLength()
        {
            throw new NotImplementedException();
        }

        public int BlockLength()
        {
            throw new NotImplementedException();
        }

        public void SetRunParallel(bool theFlag)
        {
            throw new NotImplementedException();
        }

        public bool RunParallel()
        {
            throw new NotImplementedException();
        }

        public int NbExtInterfs()
        {
            throw new NotImplementedException();
        }

        public void Intersect(IntTools_Context theCtx, bool theCheckOBB, double theFuzzyValue)
        {
            throw new NotImplementedException();
        }

        public void Intersect(IntTools_Context theCtx, bool theCheckOBB)
        {
            throw new NotImplementedException();
        }

        public void Intersect(IntTools_Context theCtx)
        {
            throw new NotImplementedException();
        }

        public void Intersect()
        {
            throw new NotImplementedException();
        }
    }; // class BOPDS_Iterator
}