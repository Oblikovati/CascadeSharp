//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.NCollection;
using CascadeSharp.TKGeomAlgo.IntSurf;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
	//---------------------------------------------------------------------
	//  Class  IntPatch_TheIWLineOfTheIWalking
	//---------------------------------------------------------------------
	public  sealed class IntPatch_TheIWLineOfTheIWalking : Standard_Transient
	{

		public IntPatch_TheIWLineOfTheIWalking(NCollection_BaseAllocator theAllocator)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_TheIWLineOfTheIWalking(IntPatch_TheIWLineOfTheIWalking parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_TheIWLineOfTheIWalking()
		{
			throw new NotImplementedException();
		}

		public void Reverse()
		{
			throw new NotImplementedException();
		}

		public void Cut(int Index)
		{
			throw new NotImplementedException();
		}

		public void AddPoint(IntSurf_PntOn2S P)
		{
			throw new NotImplementedException();
		}

		public void AddStatusFirst(bool Closed, bool HasFirst)
		{
			throw new NotImplementedException();
		}

		public void AddStatusFirst(bool Closed, bool HasLast, int Index, IntSurf_PathPoint P)
		{
			throw new NotImplementedException();
		}

		public void AddStatusFirstLast(bool Closed, bool HasFirst, bool HasLast)
		{
			throw new NotImplementedException();
		}

		public void AddStatusLast(bool HasLast)
		{
			throw new NotImplementedException();
		}

		public void AddStatusLast(bool HasLast, int Index, IntSurf_PathPoint P)
		{
			throw new NotImplementedException();
		}

		public void AddIndexPassing(int Index)
		{
			throw new NotImplementedException();
		}

		public void SetTangentVector(gp_Vec V, int Index)
		{
			throw new NotImplementedException();
		}

		public void SetTangencyAtBegining(bool IsTangent)
		{
			throw new NotImplementedException();
		}

		public void SetTangencyAtEnd(bool IsTangent)
		{
			throw new NotImplementedException();
		}

		public int NbPoints()
		{
			throw new NotImplementedException();
		}

		public IntSurf_PntOn2S Value(int Index)
		{
			throw new NotImplementedException();
		}

		public IntSurf_LineOn2S Line()
		{
			throw new NotImplementedException();
		}

		public bool IsClosed()
		{
			throw new NotImplementedException();
		}

		public bool HasFirstPoint()
		{
			throw new NotImplementedException();
		}

		public bool HasLastPoint()
		{
			throw new NotImplementedException();
		}

		public IntSurf_PathPoint FirstPoint()
		{
			throw new NotImplementedException();
		}

		public int FirstPointIndex()
		{
			throw new NotImplementedException();
		}

		public IntSurf_PathPoint LastPoint()
		{
			throw new NotImplementedException();
		}

		public int LastPointIndex()
		{
			throw new NotImplementedException();
		}

		public int NbPassingPoint()
		{
			throw new NotImplementedException();
		}

		public void PassingPoint(int Index, ref int IndexLine, ref int IndexPnts)
		{
			throw new NotImplementedException();
		}

		public gp_Vec TangentVector(ref int Index)
		{
			throw new NotImplementedException();
		}

		public bool IsTangentAtBegining()
		{
			throw new NotImplementedException();
		}

		public bool IsTangentAtEnd()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class IntPatch_TheIWLineOfTheIWalking

}
