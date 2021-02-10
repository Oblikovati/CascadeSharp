//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_NSections
	//---------------------------------------------------------------------
	public  sealed class BRepFill_NSections : CascadeSharp.BRepFill_SectionLaw
	{

		public BRepFill_NSections(TopTools_SequenceOfShape S, bool Build)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_NSections(TopTools_SequenceOfShape S)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_NSections(TopTools_SequenceOfShape S, GeomFill_SequenceOfTrsf Trsfs, TColStd_SequenceOfReal P, double VF, double VL, bool Build)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_NSections(TopTools_SequenceOfShape S, GeomFill_SequenceOfTrsf Trsfs, TColStd_SequenceOfReal P, double VF, double VL)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_NSections(BRepFill_NSections parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_NSections()
		{
			throw new NotImplementedException();
		}

		public bool IsVertex()
		{
			throw new NotImplementedException();
		}

		public bool IsConstant()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SectionLaw ConcatenedLaw()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_Shape Continuity(int Index, double TolAngular)
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

		public void D0(double Param, TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Init(TColStd_SequenceOfReal P, bool B)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFill_NSections

}
