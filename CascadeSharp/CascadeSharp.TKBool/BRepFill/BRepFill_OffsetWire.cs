//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.TColgp;
using CascadeSharp.TKTopAlgo.Bisector;
using CascadeSharp.TKTopAlgo.BRepMAT2d;

namespace CascadeSharp.TKBool.BRepFill
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_OffsetWire
	//---------------------------------------------------------------------
	public  sealed class BRepFill_OffsetWire
	{

		public BRepFill_OffsetWire()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_OffsetWire(TopoDS_Face Spine, GeomAbs_JoinType Join, bool IsOpenResult)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_OffsetWire(TopoDS_Face Spine, GeomAbs_JoinType Join)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_OffsetWire(TopoDS_Face Spine)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_OffsetWire(BRepFill_OffsetWire parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Face Spine, GeomAbs_JoinType Join, bool IsOpenResult)
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Face Spine, GeomAbs_JoinType Join)
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Face Spine)
		{
			throw new NotImplementedException();
		}

		public void Perform(double Offset, double Alt)
		{
			throw new NotImplementedException();
		}

		public void Perform(double Offset)
		{
			throw new NotImplementedException();
		}

		public void PerformWithBiLo(TopoDS_Face WSP, double Offset, BRepMAT2d_BisectingLocus Locus, BRepMAT2d_LinkTopoBilo Link, GeomAbs_JoinType Join, double Alt)
		{
			throw new NotImplementedException();
		}

		public void PerformWithBiLo(TopoDS_Face WSP, double Offset, BRepMAT2d_BisectingLocus Locus, BRepMAT2d_LinkTopoBilo Link, GeomAbs_JoinType Join)
		{
			throw new NotImplementedException();
		}

		public void PerformWithBiLo(TopoDS_Face WSP, double Offset, BRepMAT2d_BisectingLocus Locus, BRepMAT2d_LinkTopoBilo Link)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Spine()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape GeneratedShapes(TopoDS_Shape SpineShape)
		{
			throw new NotImplementedException();
		}

		public GeomAbs_JoinType JoinType()
		{
			throw new NotImplementedException();
		}

		public BRepFill_IndexedDataMapOfOrientedShapeListOfShape Generated()
		{
			throw new NotImplementedException();
		}

		public void PrepareSpine()
		{
			throw new NotImplementedException();
		}

		public void Add(BRepFill_OffsetWire Other)
		{
			throw new NotImplementedException();
		}

		public void UpdateDetromp(BRepFill_DataMapOfOrientedShapeListOfShape Detromp, TopoDS_Shape Shape1, TopoDS_Shape Shape2, TopTools_SequenceOfShape Vertices, TColgp_SequenceOfPnt Params, Bisector_Bisec B_isec, bool SOnE, bool EOnE, BRepFill_TrimEdgeTool Trim)
		{
			throw new NotImplementedException();
		}

		public void MakeWires()
		{
			throw new NotImplementedException();
		}

		public void FixHoles()
		{
			throw new NotImplementedException();
		}


	}; // class BRepFill_OffsetWire

}
