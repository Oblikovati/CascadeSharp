//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  IntTools_EdgeEdge
	//---------------------------------------------------------------------
	public  sealed class IntTools_EdgeEdge
	{

		public IntTools_EdgeEdge()
			: base()
		{
			throw new NotImplementedException();
		}

		public IntTools_EdgeEdge(TopoDS_Edge theEdge1, TopoDS_Edge theEdge2)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntTools_EdgeEdge(TopoDS_Edge theEdge1, double aT11, double aT12, TopoDS_Edge theEdge2, double aT21, double aT22)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntTools_EdgeEdge(IntTools_EdgeEdge parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetEdge1(TopoDS_Edge theEdge)
		{
			throw new NotImplementedException();
		}

		public void SetEdge1(TopoDS_Edge theEdge, double aT1, double aT2)
		{
			throw new NotImplementedException();
		}

		public void SetRange1(IntTools_Range theRange1)
		{
			throw new NotImplementedException();
		}

		public void SetRange1(double aT1, double aT2)
		{
			throw new NotImplementedException();
		}

		public void SetEdge2(TopoDS_Edge theEdge)
		{
			throw new NotImplementedException();
		}

		public void SetEdge2(TopoDS_Edge theEdge, double aT1, double aT2)
		{
			throw new NotImplementedException();
		}

		public void SetRange2(IntTools_Range theRange)
		{
			throw new NotImplementedException();
		}

		public void SetRange2(double aT1, double aT2)
		{
			throw new NotImplementedException();
		}

		public void SetFuzzyValue(double theFuzz)
		{
			throw new NotImplementedException();
		}

		public void Perform()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public double FuzzyValue()
		{
			throw new NotImplementedException();
		}

		public IntTools_SequenceOfCommonPrts CommonParts()
		{
			throw new NotImplementedException();
		}

		public void UseQuickCoincidenceCheck(bool bFlag)
		{
			throw new NotImplementedException();
		}

		public bool IsCoincidenceCheckedQuickly()
		{
			throw new NotImplementedException();
		}

		public void CheckData()
		{
			throw new NotImplementedException();
		}

		public void Prepare()
		{
			throw new NotImplementedException();
		}

		public void ComputeLineLine()
		{
			throw new NotImplementedException();
		}

		public void FindSolutions(IntTools_SequenceOfRanges theRanges1, IntTools_SequenceOfRanges theRanges2, ref bool bSplit2)
		{
			throw new NotImplementedException();
		}

		public void FindSolutions(IntTools_Range theR1, Bnd_Box theBox1, IntTools_Range theR2, Bnd_Box theBox2, IntTools_SequenceOfRanges theRanges1, IntTools_SequenceOfRanges theRanges2)
		{
			throw new NotImplementedException();
		}

		public void MergeSolutions(IntTools_SequenceOfRanges theRanges1, IntTools_SequenceOfRanges theRanges2, bool bSplit2)
		{
			throw new NotImplementedException();
		}

		public bool FindParameters(BRepAdaptor_Curve theBAC, double aT1, double aT2, double theTol, double theRes, double thePTol, double theResCoeff, Bnd_Box theCBox, ref double aTB1, ref double aTB2)
		{
			throw new NotImplementedException();
		}

		public int CheckCoincidence(double aT11, double aT12, double aT21, double aT22, double theCriteria, double theCurveRes1)
		{
			throw new NotImplementedException();
		}

		public void AddSolution(double aT11, double aT12, double aT21, double aT22, CascadeSharp.TopAbs_ShapeEnum theType)
		{
			throw new NotImplementedException();
		}

		public void FindBestSolution(double aT11, double aT12, double aT21, double aT22, ref double aT1, ref double aT2)
		{
			throw new NotImplementedException();
		}

		public bool IsIntersection(double aT11, double aT12, double aT21, double aT22)
		{
			throw new NotImplementedException();
		}

		public bool IsCoincident()
		{
			throw new NotImplementedException();
		}


	}; // class IntTools_EdgeEdge

}
