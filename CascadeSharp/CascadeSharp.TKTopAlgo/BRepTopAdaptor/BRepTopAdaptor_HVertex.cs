//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepTopAdaptor_HVertex
	//---------------------------------------------------------------------
	public  sealed class BRepTopAdaptor_HVertex : CascadeSharp.Adaptor3d_HVertex
	{

		public BRepTopAdaptor_HVertex(TopoDS_Vertex Vtx, BRepAdaptor_HCurve2d Curve)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepTopAdaptor_HVertex(BRepTopAdaptor_HVertex parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepTopAdaptor_HVertex()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex Vertex()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex ChangeVertex()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d Value()
		{
			throw new NotImplementedException();
		}

		public double Parameter(Adaptor2d_HCurve2d C)
		{
			throw new NotImplementedException();
		}

		public double Resolution(Adaptor2d_HCurve2d C)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_Orientation Orientation()
		{
			throw new NotImplementedException();
		}

		public bool IsSame(Adaptor3d_HVertex Other)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRepTopAdaptor_HVertex

}
