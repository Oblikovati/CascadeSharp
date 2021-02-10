//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKGeomAlgo.IntSurf;
using CascadeSharp.TKGeomBase.IntAna;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
	//---------------------------------------------------------------------
	//  Class  IntPatch_ALine
	//---------------------------------------------------------------------
	public  sealed class IntPatch_ALine : IntPatch_Line
	{

		public IntPatch_ALine(IntAna_Curve C, bool Tang, IntSurf_TypeTrans Trans1, IntSurf_TypeTrans Trans2)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_ALine(IntAna_Curve C, bool Tang, IntSurf_Situation Situ1, IntSurf_Situation Situ2)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_ALine(IntAna_Curve C, bool Tang)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_ALine(IntPatch_ALine parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_ALine()
		{
			throw new NotImplementedException();
		}

		public void AddVertex(IntPatch_Point Pnt)
		{
			throw new NotImplementedException();
		}

		public void Replace(int Index, IntPatch_Point Pnt)
		{
			throw new NotImplementedException();
		}

		public void SetFirstPoint(int IndFirst)
		{
			throw new NotImplementedException();
		}

		public void SetLastPoint(int IndLast)
		{
			throw new NotImplementedException();
		}

		public double FirstParameter(ref bool IsIncluded)
		{
			throw new NotImplementedException();
		}

		public double LastParameter(ref bool IsIncluded)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Value(double U)
		{
			throw new NotImplementedException();
		}

		public bool D1(double U, gp_Pnt P, gp_Vec Du)
		{
			throw new NotImplementedException();
		}

		public void FindParameter(gp_Pnt P, TColStd_ListOfReal theParams)
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

		public IntPatch_Point FirstPoint()
		{
			throw new NotImplementedException();
		}

		public IntPatch_Point LastPoint()
		{
			throw new NotImplementedException();
		}

		public int NbVertex()
		{
			throw new NotImplementedException();
		}

		public IntPatch_Point Vertex(int Index)
		{
			throw new NotImplementedException();
		}

		public IntPatch_Point ChangeVertex(int theIndex)
		{
			throw new NotImplementedException();
		}

		public void ComputeVertexParameters(double Tol)
		{
			throw new NotImplementedException();
		}

		public IntAna_Curve Curve()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class IntPatch_ALine

}
