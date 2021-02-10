//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeFix
{
	//---------------------------------------------------------------------
	//  Class  ShapeFix_Wireframe
	//---------------------------------------------------------------------
	public  sealed class ShapeFix_Wireframe : ShapeFix_Root
	{

		public ShapeFix_Wireframe()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeFix_Wireframe(TopoDS_Shape shape)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeFix_Wireframe(ShapeFix_Wireframe parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void ClearStatuses()
		{
			throw new NotImplementedException();
		}

		public void Load(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public bool FixWireGaps()
		{
			throw new NotImplementedException();
		}

		public bool FixSmallEdges()
		{
			throw new NotImplementedException();
		}

		public bool CheckSmallEdges(TopTools_MapOfShape theSmallEdges, TopTools_DataMapOfShapeListOfShape theEdgeToFaces, TopTools_DataMapOfShapeListOfShape theFaceWithSmall, TopTools_MapOfShape theMultyEdges)
		{
			throw new NotImplementedException();
		}

		public bool MergeSmallEdges(TopTools_MapOfShape theSmallEdges, TopTools_DataMapOfShapeListOfShape theEdgeToFaces, TopTools_DataMapOfShapeListOfShape theFaceWithSmall, TopTools_MapOfShape theMultyEdges, bool theModeDrop, double theLimitAngle)
		{
			throw new NotImplementedException();
		}

		public bool MergeSmallEdges(TopTools_MapOfShape theSmallEdges, TopTools_DataMapOfShapeListOfShape theEdgeToFaces, TopTools_DataMapOfShapeListOfShape theFaceWithSmall, TopTools_MapOfShape theMultyEdges, bool theModeDrop)
		{
			throw new NotImplementedException();
		}

		public bool MergeSmallEdges(TopTools_MapOfShape theSmallEdges, TopTools_DataMapOfShapeListOfShape theEdgeToFaces, TopTools_DataMapOfShapeListOfShape theFaceWithSmall, TopTools_MapOfShape theMultyEdges)
		{
			throw new NotImplementedException();
		}

		public bool StatusWireGaps(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public bool StatusSmallEdges(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public bool ModeDropSmallEdges()
		{
			throw new NotImplementedException();
		}

		public void SetLimitAngle(double theLimitAngle)
		{
			throw new NotImplementedException();
		}

		public double LimitAngle()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class ShapeFix_Wireframe

}
