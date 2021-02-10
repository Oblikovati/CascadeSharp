//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.NCollection;

namespace CascadeSharp.TKTopAlgo.BRepCheck
{
	//---------------------------------------------------------------------
	//  Class  BRepCheck_DataMapOfShapeResult
	//---------------------------------------------------------------------
	public  sealed class BRepCheck_DataMapOfShapeResult
	{

		public BRepCheck_DataMapOfShapeResult()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepCheck_DataMapOfShapeResult(int theNbBuckets, NCollection_BaseAllocator theAllocator)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepCheck_DataMapOfShapeResult(int theNbBuckets)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepCheck_DataMapOfShapeResult(BRepCheck_DataMapOfShapeResult theOther)
			: base()
		{
			throw new NotImplementedException();
		}

										public void Exchange(BRepCheck_DataMapOfShapeResult theOther)
		{
			throw new NotImplementedException();
		}

		public BRepCheck_DataMapOfShapeResult Assign(BRepCheck_DataMapOfShapeResult theOther)
		{
			throw new NotImplementedException();
		}

		public BRepCheck_Result Bound(TopoDS_Shape theKey, BRepCheck_Result theItem)
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

		public BRepCheck_Result Seek(TopoDS_Shape theKey)
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

		public BRepCheck_Result Find(TopoDS_Shape theKey)
		{
			throw new NotImplementedException();
		}

		public bool Find(TopoDS_Shape theKey, BRepCheck_Result theValue)
		{
			throw new NotImplementedException();
		}

		public BRepCheck_Result ChangeSeek(TopoDS_Shape theKey)
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

		public BRepCheck_Result ChangeFind(TopoDS_Shape theKey)
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

		
	}; // class BRepCheck_DataMapOfShapeResult

}
