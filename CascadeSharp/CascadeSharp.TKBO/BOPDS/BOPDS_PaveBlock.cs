//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.NCollection;
using CascadeSharp.TKMath.Bnd;

namespace CascadeSharp.TKBO.BOPDS
{
	//---------------------------------------------------------------------
	//  Class  BOPDS_PaveBlock
	//---------------------------------------------------------------------
	public  sealed class BOPDS_PaveBlock : Standard_Transient
	{

		public BOPDS_PaveBlock()
			: base()
		{
			throw new NotImplementedException();
		}

		public BOPDS_PaveBlock(NCollection_BaseAllocator theAllocator)
			: base()
		{
			throw new NotImplementedException();
		}

		public BOPDS_PaveBlock(BOPDS_PaveBlock parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetPave1(BOPDS_Pave thePave)
		{
			throw new NotImplementedException();
		}

		public BOPDS_Pave Pave1()
		{
			throw new NotImplementedException();
		}

		public void SetPave2(BOPDS_Pave thePave)
		{
			throw new NotImplementedException();
		}

		public BOPDS_Pave Pave2()
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

		public bool HasEdge()
		{
			throw new NotImplementedException();
		}

		public bool HasEdge(ref int theEdge)
		{
			throw new NotImplementedException();
		}

		public void SetOriginalEdge(int theEdge)
		{
			throw new NotImplementedException();
		}

		public int OriginalEdge()
		{
			throw new NotImplementedException();
		}

		public bool IsSplitEdge()
		{
			throw new NotImplementedException();
		}

		public void Range(ref double theT1, ref double theT2)
		{
			throw new NotImplementedException();
		}

		public bool HasSameBounds(BOPDS_PaveBlock theOther)
		{
			throw new NotImplementedException();
		}

		public void Indices(ref int theIndex1, ref int theIndex2)
		{
			throw new NotImplementedException();
		}

		public bool IsToUpdate()
		{
			throw new NotImplementedException();
		}

		public void AppendExtPave(BOPDS_Pave thePave)
		{
			throw new NotImplementedException();
		}

		public void AppendExtPave1(BOPDS_Pave thePave)
		{
			throw new NotImplementedException();
		}

		public void RemoveExtPave(int theVertNum)
		{
			throw new NotImplementedException();
		}

		public BOPDS_ListOfPave ExtPaves()
		{
			throw new NotImplementedException();
		}

		public BOPDS_ListOfPave ChangeExtPaves()
		{
			throw new NotImplementedException();
		}

		public void Update(BOPDS_ListOfPaveBlock theLPB, bool theFlag)
		{
			throw new NotImplementedException();
		}

		public void Update(BOPDS_ListOfPaveBlock theLPB)
		{
			throw new NotImplementedException();
		}

		public bool ContainsParameter(double thePrm, double theTol, ref int theInd)
		{
			throw new NotImplementedException();
		}

		public void SetShrunkData(double theTS1, double theTS2, Bnd_Box theBox, bool theIsSplittable)
		{
			throw new NotImplementedException();
		}

		public void ShrunkData(ref double theTS1, ref double theTS2, Bnd_Box theBox, ref bool theIsSplittable)
		{
			throw new NotImplementedException();
		}

		public bool HasShrunkData()
		{
			throw new NotImplementedException();
		}

		public void Dump()
		{
			throw new NotImplementedException();
		}

		public bool IsSplittable()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BOPDS_PaveBlock

}
