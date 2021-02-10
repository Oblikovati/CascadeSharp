//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKTopAlgo.MAT
{
	//---------------------------------------------------------------------
	//  Class  MAT_Arc
	//---------------------------------------------------------------------
	public  sealed class MAT_Arc : Standard_Transient
	{

		public MAT_Arc(int ArcIndex, int GeomIndex, MAT_BasicElt FirstElement, MAT_BasicElt SecondElement)
			: base()
		{
			throw new NotImplementedException();
		}

		public MAT_Arc(MAT_Arc parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public MAT_Arc()
		{
			throw new NotImplementedException();
		}

		public int Index()
		{
			throw new NotImplementedException();
		}

		public int GeomIndex()
		{
			throw new NotImplementedException();
		}

		public MAT_BasicElt FirstElement()
		{
			throw new NotImplementedException();
		}

		public MAT_BasicElt SecondElement()
		{
			throw new NotImplementedException();
		}

		public MAT_Node FirstNode()
		{
			throw new NotImplementedException();
		}

		public MAT_Node SecondNode()
		{
			throw new NotImplementedException();
		}

		public MAT_Node TheOtherNode(MAT_Node aNode)
		{
			throw new NotImplementedException();
		}

		public bool HasNeighbour(MAT_Node aNode, MAT_Side aSide)
		{
			throw new NotImplementedException();
		}

		public MAT_Arc Neighbour(MAT_Node aNode, MAT_Side aSide)
		{
			throw new NotImplementedException();
		}

		public void SetIndex(int anInteger)
		{
			throw new NotImplementedException();
		}

		public void SetGeomIndex(int anInteger)
		{
			throw new NotImplementedException();
		}

		public void SetFirstElement(MAT_BasicElt aBasicElt)
		{
			throw new NotImplementedException();
		}

		public void SetSecondElement(MAT_BasicElt aBasicElt)
		{
			throw new NotImplementedException();
		}

		public void SetFirstNode(MAT_Node aNode)
		{
			throw new NotImplementedException();
		}

		public void SetSecondNode(MAT_Node aNode)
		{
			throw new NotImplementedException();
		}

		public void SetFirstArc(MAT_Side aSide, MAT_Arc anArc)
		{
			throw new NotImplementedException();
		}

		public void SetSecondArc(MAT_Side aSide, MAT_Arc anArc)
		{
			throw new NotImplementedException();
		}

		public void SetNeighbour(MAT_Side aSide, MAT_Node aNode, MAT_Arc anArc)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class MAT_Arc

}
