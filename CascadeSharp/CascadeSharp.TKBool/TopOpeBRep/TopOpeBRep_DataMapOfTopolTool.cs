//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.NCollection;
using CascadeSharp.TKTopAlgo.BRepTopAdaptor;

namespace CascadeSharp.TKBool.TopOpeBRep
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRep_DataMapOfTopolTool
    //---------------------------------------------------------------------
    public sealed class TopOpeBRep_DataMapOfTopolTool
    {
        public TopOpeBRep_DataMapOfTopolTool()
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRep_DataMapOfTopolTool(int theNbBuckets, NCollection_BaseAllocator theAllocator)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRep_DataMapOfTopolTool(int theNbBuckets)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRep_DataMapOfTopolTool(TopOpeBRep_DataMapOfTopolTool theOther)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Exchange(TopOpeBRep_DataMapOfTopolTool theOther)
        {
            throw new NotImplementedException();
        }

        public TopOpeBRep_DataMapOfTopolTool Assign(TopOpeBRep_DataMapOfTopolTool theOther)
        {
            throw new NotImplementedException();
        }

        public BRepTopAdaptor_TopolTool Bound(TopoDS_Shape theKey, BRepTopAdaptor_TopolTool theItem)
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public bool IsBound(TopoDS_Shape theKey)
        {
            throw new NotImplementedException();
        }

        public bool UnBind(TopoDS_Shape theKey)
        {
            throw new NotImplementedException();
        }

        public BRepTopAdaptor_TopolTool Seek(TopoDS_Shape theKey)
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public BRepTopAdaptor_TopolTool Find(TopoDS_Shape theKey)
        {
            throw new NotImplementedException();
        }

        public bool Find(TopoDS_Shape theKey, BRepTopAdaptor_TopolTool theValue)
        {
            throw new NotImplementedException();
        }

        public BRepTopAdaptor_TopolTool ChangeSeek(TopoDS_Shape theKey)
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public BRepTopAdaptor_TopolTool ChangeFind(TopoDS_Shape theKey)
        {
            throw new NotImplementedException();
        }

        public void Clear(bool doReleaseMemory)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Clear(NCollection_BaseAllocator theAllocator)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRep_DataMapOfTopolTool
}