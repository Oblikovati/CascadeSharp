//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKMath.TColgp;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKShHealing.ShapeConstruct
{
	//---------------------------------------------------------------------
	//  Class  ShapeConstruct_MakeTriangulation
	//---------------------------------------------------------------------
	public  sealed class ShapeConstruct_MakeTriangulation : BRepBuilderAPI_MakeShape
	{

		public ShapeConstruct_MakeTriangulation(TColgp_Array1OfPnt pnts, double prec)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeConstruct_MakeTriangulation(TColgp_Array1OfPnt pnts)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeConstruct_MakeTriangulation(TopoDS_Wire wire, double prec)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeConstruct_MakeTriangulation(TopoDS_Wire wire)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeConstruct_MakeTriangulation(ShapeConstruct_MakeTriangulation parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeConstruct_MakeTriangulation()
		{
			throw new NotImplementedException();
		}

		public void Build()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public void Triangulate(TopoDS_Wire wire)
		{
			throw new NotImplementedException();
		}

		public void AddFacet(TopoDS_Wire wire)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeConstruct_MakeTriangulation

}
