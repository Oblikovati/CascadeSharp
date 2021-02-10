//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.NCollection;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_DataMapOfShapeDrawer
    //---------------------------------------------------------------------
    public sealed class AIS_DataMapOfShapeDrawer
    {
        public AIS_DataMapOfShapeDrawer()
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_DataMapOfShapeDrawer(int theNbBuckets, NCollection_BaseAllocator theAllocator)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_DataMapOfShapeDrawer(int theNbBuckets)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_DataMapOfShapeDrawer(AIS_DataMapOfShapeDrawer theOther)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Exchange(AIS_DataMapOfShapeDrawer theOther)
        {
            throw new NotImplementedException();
        }

        public AIS_DataMapOfShapeDrawer Assign(AIS_DataMapOfShapeDrawer theOther)
        {
            throw new NotImplementedException();
        }

        public AIS_ColoredDrawer Bound(TopoDS_Shape theKey, AIS_ColoredDrawer theItem)
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

        public AIS_ColoredDrawer Seek(TopoDS_Shape theKey)
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public AIS_ColoredDrawer Find(TopoDS_Shape theKey)
        {
            throw new NotImplementedException();
        }

        public bool Find(TopoDS_Shape theKey, AIS_ColoredDrawer theValue)
        {
            throw new NotImplementedException();
        }

        public AIS_ColoredDrawer ChangeSeek(TopoDS_Shape theKey)
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public AIS_ColoredDrawer ChangeFind(TopoDS_Shape theKey)
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
    }; // class AIS_DataMapOfShapeDrawer
}