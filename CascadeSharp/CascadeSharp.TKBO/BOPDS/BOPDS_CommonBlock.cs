//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.NCollection;
using CascadeSharp.TKernel.TColStd;

namespace CascadeSharp.TKBO.BOPDS
{
	//---------------------------------------------------------------------
	//  Class  BOPDS_CommonBlock
	//---------------------------------------------------------------------
	public  sealed class BOPDS_CommonBlock : Standard_Transient
	{

		public BOPDS_CommonBlock()
			: base()
		{
			throw new NotImplementedException();
		}

		public BOPDS_CommonBlock(NCollection_BaseAllocator theAllocator)
			: base()
		{
			throw new NotImplementedException();
		}

		public BOPDS_CommonBlock(BOPDS_CommonBlock parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void AddPaveBlock(BOPDS_PaveBlock aPB)
		{
			throw new NotImplementedException();
		}

		public void SetPaveBlocks(BOPDS_ListOfPaveBlock aLPB)
		{
			throw new NotImplementedException();
		}

		public void AddFace(int aF)
		{
			throw new NotImplementedException();
		}

		public void SetFaces(TColStd_ListOfInteger aLF)
		{
			throw new NotImplementedException();
		}

		public void AppendFaces(TColStd_ListOfInteger aLF)
		{
			throw new NotImplementedException();
		}

		public BOPDS_ListOfPaveBlock PaveBlocks()
		{
			throw new NotImplementedException();
		}

		public TColStd_ListOfInteger Faces()
		{
			throw new NotImplementedException();
		}

		public BOPDS_PaveBlock PaveBlock1()
		{
			throw new NotImplementedException();
		}

		public BOPDS_PaveBlock PaveBlockOnEdge(int theIndex)
		{
			throw new NotImplementedException();
		}

		public bool IsPaveBlockOnFace(int theIndex)
		{
			throw new NotImplementedException();
		}

		public bool IsPaveBlockOnEdge(int theIndex)
		{
			throw new NotImplementedException();
		}

		public bool Contains(BOPDS_PaveBlock thePB)
		{
			throw new NotImplementedException();
		}

		public bool Contains(int theF)
		{
			throw new NotImplementedException();
		}

		public void SetEdge(int theEdge)
		{
			throw new NotImplementedException();
		}

		public int Edge()
		{
			throw new NotImplementedException();
		}

		public void Dump()
		{
			throw new NotImplementedException();
		}

		public void SetRealPaveBlock(BOPDS_PaveBlock thePB)
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(double theTol)
		{
			throw new NotImplementedException();
		}

		public double Tolerance()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BOPDS_CommonBlock

}
