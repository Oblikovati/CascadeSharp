//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKGeomBase.Approx;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKOffset.BRepOffsetAPI
{
	//---------------------------------------------------------------------
	//  Class  BRepOffsetAPI_ThruSections
	//---------------------------------------------------------------------
	public  sealed class BRepOffsetAPI_ThruSections : BRepBuilderAPI_MakeShape
	{

		public BRepOffsetAPI_ThruSections(bool _isSolid, bool ruled, double pres3d)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_ThruSections(bool _isSolid, bool ruled)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_ThruSections(bool _isSolid)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_ThruSections(BRepOffsetAPI_ThruSections parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_ThruSections()
		{
			throw new NotImplementedException();
		}

		public void Init(bool _isSolid, bool ruled, double pres3d)
		{
			throw new NotImplementedException();
		}

		public void Init(bool _isSolid, bool ruled)
		{
			throw new NotImplementedException();
		}

		public void Init(bool _isSolid)
		{
			throw new NotImplementedException();
		}

		public void Init()
		{
			throw new NotImplementedException();
		}

		public void AddWire(TopoDS_Wire wire)
		{
			throw new NotImplementedException();
		}

		public void AddVertex(TopoDS_Vertex aVertex)
		{
			throw new NotImplementedException();
		}

		public void CheckCompatibility(bool check)
		{
			throw new NotImplementedException();
		}

		public void CheckCompatibility()
		{
			throw new NotImplementedException();
		}

		public void SetSmoothing(bool UseSmoothing)
		{
			throw new NotImplementedException();
		}

		public void SetParType(Approx_ParametrizationType ParType)
		{
			throw new NotImplementedException();
		}

		public void SetContinuity(GeomAbs_Shape C)
		{
			throw new NotImplementedException();
		}

		public void SetCriteriumWeight(double W1, double W2, double W3)
		{
			throw new NotImplementedException();
		}

		public void SetMaxDegree(int MaxDeg)
		{
			throw new NotImplementedException();
		}

		public Approx_ParametrizationType ParType()
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public int MaxDegree()
		{
			throw new NotImplementedException();
		}

		public bool UseSmoothing()
		{
			throw new NotImplementedException();
		}

		public void CriteriumWeight(ref double W1, ref double W2, ref double W3)
		{
			throw new NotImplementedException();
		}

		public void Build()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape FirstShape()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape LastShape()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape GeneratedFace(TopoDS_Shape Edge)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Generated(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Wires()
		{
			throw new NotImplementedException();
		}

		public void CreateRuled()
		{
			throw new NotImplementedException();
		}

		public void CreateSmoothed()
		{
			throw new NotImplementedException();
		}

		public Geom_BSplineSurface TotalSurf(TopTools_Array1OfShape shapes, int NbSect, int NbEdges, bool w1Point, bool w2Point, bool vClosed)
		{
			throw new NotImplementedException();
		}


	}; // class BRepOffsetAPI_ThruSections

}
