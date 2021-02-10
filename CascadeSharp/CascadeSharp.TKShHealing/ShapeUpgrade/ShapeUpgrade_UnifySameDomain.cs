//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepTools;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKShHealing.ShapeUpgrade
{
	//---------------------------------------------------------------------
	//  Class  ShapeUpgrade_UnifySameDomain
	//---------------------------------------------------------------------
	public  sealed class ShapeUpgrade_UnifySameDomain : Standard_Transient
	{

		public ShapeUpgrade_UnifySameDomain()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeUpgrade_UnifySameDomain(TopoDS_Shape aShape, bool UnifyEdges, bool UnifyFaces, bool ConcatBSplines)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeUpgrade_UnifySameDomain(TopoDS_Shape aShape, bool UnifyEdges, bool UnifyFaces)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeUpgrade_UnifySameDomain(TopoDS_Shape aShape, bool UnifyEdges)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeUpgrade_UnifySameDomain(TopoDS_Shape aShape)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeUpgrade_UnifySameDomain(ShapeUpgrade_UnifySameDomain parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Shape aShape, bool UnifyEdges, bool UnifyFaces, bool ConcatBSplines)
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Shape aShape, bool UnifyEdges, bool UnifyFaces)
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Shape aShape, bool UnifyEdges)
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Shape aShape)
		{
			throw new NotImplementedException();
		}

		public void AllowInternalEdges(bool theValue)
		{
			throw new NotImplementedException();
		}

		public void KeepShape(TopoDS_Shape theShape)
		{
			throw new NotImplementedException();
		}

		public void KeepShapes(TopTools_MapOfShape theShapes)
		{
			throw new NotImplementedException();
		}

		public void SetSafeInputMode(bool theValue)
		{
			throw new NotImplementedException();
		}

		public void SetLinearTolerance(double theValue)
		{
			throw new NotImplementedException();
		}

		public void SetAngularTolerance(double theValue)
		{
			throw new NotImplementedException();
		}

		public void Build()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public BRepTools_History History()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void UnifyFaces()
		{
			throw new NotImplementedException();
		}

		public void UnifyEdges()
		{
			throw new NotImplementedException();
		}

		public void IntUnifyFaces(TopoDS_Shape theInpShape, TopTools_IndexedDataMapOfShapeListOfShape theGMapEdgeFaces)
		{
			throw new NotImplementedException();
		}

		public void FillHistory()
		{
			throw new NotImplementedException();
		}


	}; // class ShapeUpgrade_UnifySameDomain

}
