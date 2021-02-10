//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKShHealing.ShapeAnalysis;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeFix
{
	//---------------------------------------------------------------------
	//  Class  ShapeFix_Face
	//---------------------------------------------------------------------
	public  sealed class ShapeFix_Face : ShapeFix_Root
	{

		public ShapeFix_Face()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeFix_Face(TopoDS_Face face)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeFix_Face(ShapeFix_Face parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void ClearModes()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Surface surf, double preci, bool fwd)
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Surface surf, double preci)
		{
			throw new NotImplementedException();
		}

		public void Init(ShapeAnalysis_Surface surf, double preci, bool fwd)
		{
			throw new NotImplementedException();
		}

		public void Init(ShapeAnalysis_Surface surf, double preci)
		{
			throw new NotImplementedException();
		}

		public void SetMsgRegistrator(ShapeExtend_BasicMsgRegistrator msgreg)
		{
			throw new NotImplementedException();
		}

		public void SetPrecision(double preci)
		{
			throw new NotImplementedException();
		}

		public void SetMinTolerance(double mintol)
		{
			throw new NotImplementedException();
		}

		public void SetMaxTolerance(double maxtol)
		{
			throw new NotImplementedException();
		}

		public int FixWireMode()
		{
			throw new NotImplementedException();
		}

		public int FixOrientationMode()
		{
			throw new NotImplementedException();
		}

		public int FixAddNaturalBoundMode()
		{
			throw new NotImplementedException();
		}

		public int FixMissingSeamMode()
		{
			throw new NotImplementedException();
		}

		public int FixSmallAreaWireMode()
		{
			throw new NotImplementedException();
		}

		public int RemoveSmallAreaFaceMode()
		{
			throw new NotImplementedException();
		}

		public int FixIntersectingWiresMode()
		{
			throw new NotImplementedException();
		}

		public int FixLoopWiresMode()
		{
			throw new NotImplementedException();
		}

		public int FixSplitFaceMode()
		{
			throw new NotImplementedException();
		}

		public int AutoCorrectPrecisionMode()
		{
			throw new NotImplementedException();
		}

		public int FixPeriodicDegeneratedMode()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Face()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Result()
		{
			throw new NotImplementedException();
		}

		public void Add(TopoDS_Wire wire)
		{
			throw new NotImplementedException();
		}

		public bool Perform()
		{
			throw new NotImplementedException();
		}

		public bool FixOrientation()
		{
			throw new NotImplementedException();
		}

		public bool FixOrientation(TopTools_DataMapOfShapeListOfShape MapWires)
		{
			throw new NotImplementedException();
		}

		public bool FixAddNaturalBound()
		{
			throw new NotImplementedException();
		}

		public bool FixMissingSeam()
		{
			throw new NotImplementedException();
		}

		public bool FixSmallAreaWire(bool theIsRemoveSmallFace)
		{
			throw new NotImplementedException();
		}

		public bool FixLoopWire(TopTools_SequenceOfShape aResWires)
		{
			throw new NotImplementedException();
		}

		public bool FixIntersectingWires()
		{
			throw new NotImplementedException();
		}

		public bool FixWiresTwoCoincEdges()
		{
			throw new NotImplementedException();
		}

		public bool FixSplitFace(TopTools_DataMapOfShapeListOfShape MapWires)
		{
			throw new NotImplementedException();
		}

		public bool FixPeriodicDegenerated()
		{
			throw new NotImplementedException();
		}

		public bool Status(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public ShapeFix_Wire FixWireTool()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool SplitEdge(ShapeExtend_WireData sewd, int num, double param, TopoDS_Vertex vert, double preci, ShapeFix_DataMapOfShapeBox2d boxes)
		{
			throw new NotImplementedException();
		}

		public bool SplitEdge(ShapeExtend_WireData sewd, int num, double param1, double param2, TopoDS_Vertex vert, double preci, ShapeFix_DataMapOfShapeBox2d boxes)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeFix_Face

}
