//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepMAT2d_BisectingLocus
	//---------------------------------------------------------------------
	public  sealed class BRepMAT2d_BisectingLocus
	{

		public BRepMAT2d_BisectingLocus()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepMAT2d_BisectingLocus(BRepMAT2d_BisectingLocus parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Compute(BRepMAT2d_Explorer anExplo, int LineIndex, CascadeSharp.MAT_Side aSide, CascadeSharp.GeomAbs_JoinType aJoinType, bool IsOpenResult)
		{
			throw new NotImplementedException();
		}

		public void Compute(BRepMAT2d_Explorer anExplo, int LineIndex, CascadeSharp.MAT_Side aSide, CascadeSharp.GeomAbs_JoinType aJoinType)
		{
			throw new NotImplementedException();
		}

		public void Compute(BRepMAT2d_Explorer anExplo, int LineIndex, CascadeSharp.MAT_Side aSide)
		{
			throw new NotImplementedException();
		}

		public void Compute(BRepMAT2d_Explorer anExplo, int LineIndex)
		{
			throw new NotImplementedException();
		}

		public void Compute(BRepMAT2d_Explorer anExplo)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public MAT_Graph Graph()
		{
			throw new NotImplementedException();
		}

		public int NumberOfContours()
		{
			throw new NotImplementedException();
		}

		public int NumberOfElts(int IndLine)
		{
			throw new NotImplementedException();
		}

		public int NumberOfSections(int IndLine, int Index)
		{
			throw new NotImplementedException();
		}

		public MAT_BasicElt BasicElt(int IndLine, int Index)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Geometry GeomElt(MAT_BasicElt aBasicElt)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d GeomElt(MAT_Node aNode)
		{
			throw new NotImplementedException();
		}

		public Bisector_Bisec GeomBis(MAT_Arc anArc, ref bool Reverse)
		{
			throw new NotImplementedException();
		}

		public void Fusion()
		{
			throw new NotImplementedException();
		}

		public void RenumerationAndFusion(int IndexLine, int LengthLine, ref int IndexLast, MAT_DataMapOfIntegerBasicElt NewMap)
		{
			throw new NotImplementedException();
		}


	}; // class BRepMAT2d_BisectingLocus

}
