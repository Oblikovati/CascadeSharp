//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;

namespace CascadeSharp.TKTopAlgo.BRepCheck
{
	//---------------------------------------------------------------------
	//  Class  BRepCheck_Edge
	//---------------------------------------------------------------------
	public  sealed class BRepCheck_Edge : BRepCheck_Result
	{

		public BRepCheck_Edge(TopoDS_Edge E)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepCheck_Edge(BRepCheck_Edge parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepCheck_Edge()
		{
			throw new NotImplementedException();
		}

		public void InContext(TopoDS_Shape ContextShape)
		{
			throw new NotImplementedException();
		}

		public void Minimum()
		{
			throw new NotImplementedException();
		}

		public void Blind()
		{
			throw new NotImplementedException();
		}

		public bool GeometricControls()
		{
			throw new NotImplementedException();
		}

		public void GeometricControls(bool B)
		{
			throw new NotImplementedException();
		}

		public double Tolerance()
		{
			throw new NotImplementedException();
		}

		public void SetStatus(BRepCheck_Status theStatus)
		{
			throw new NotImplementedException();
		}

		public BRepCheck_Status CheckPolygonOnTriangulation(TopoDS_Edge theEdge)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRepCheck_Edge

}
