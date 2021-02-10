//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;
using CascadeSharp.TKGeomAlgo.GeomFill;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKBool.BRepFill
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_SectionLaw
	//---------------------------------------------------------------------
	public  abstract class BRepFill_SectionLaw : Standard_Transient
	{

		public BRepFill_SectionLaw(BRepFill_SectionLaw parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BRepFill_SectionLaw()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public int NbLaw()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SectionLaw Law(int Index)
		{
			throw new NotImplementedException();
		}

		public int IndexOfEdge(TopoDS_Shape anEdge)
		{
			throw new NotImplementedException();
		}

		public bool IsConstant()
		{
			throw new NotImplementedException();
		}

		public bool IsUClosed()
		{
			throw new NotImplementedException();
		}

		public bool IsVClosed()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public bool IsVertex()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SectionLaw ConcatenedLaw()
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape Continuity(int Index, double TolAngular)
		{
			throw new NotImplementedException();
		}

		public double VertexTol(int Index, double Param)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex Vertex(int Index, double Param)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Wire W)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge CurrentEdge()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRepFill_SectionLaw

}
