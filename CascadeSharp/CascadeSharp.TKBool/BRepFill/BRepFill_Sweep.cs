//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKGeomAlgo.GeomFill;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKBool.BRepFill
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_Sweep
	//---------------------------------------------------------------------
	public  sealed class BRepFill_Sweep
	{

		public BRepFill_Sweep(BRepFill_SectionLaw Section, BRepFill_LocationLaw Location, bool WithKPart)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Sweep(BRepFill_Sweep parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Sweep()
		{
			throw new NotImplementedException();
		}

		public void SetBounds(TopoDS_Wire FirstShape, TopoDS_Wire LastShape)
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(double Tol3d, double BoundTol, double Tol2d, double TolAngular)
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(double Tol3d, double BoundTol, double Tol2d)
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(double Tol3d, double BoundTol)
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(double Tol3d)
		{
			throw new NotImplementedException();
		}

		public void SetAngularControl(double AngleMin, double AngleMax)
		{
			throw new NotImplementedException();
		}

		public void SetAngularControl(double AngleMin)
		{
			throw new NotImplementedException();
		}

		public void SetAngularControl()
		{
			throw new NotImplementedException();
		}

		public void SetForceApproxC1(bool ForceApproxC1)
		{
			throw new NotImplementedException();
		}

		public void Build(TopTools_MapOfShape ReversedEdges, BRepFill_DataMapOfShapeHArray2OfShape Tapes, BRepFill_DataMapOfShapeHArray2OfShape Rails, BRepFill_TransitionStyle Transition, GeomAbs_Shape Continuity, GeomFill_ApproxStyle Approx, int Degmax, int Segmax)
		{
			throw new NotImplementedException();
		}

		public void Build(TopTools_MapOfShape ReversedEdges, BRepFill_DataMapOfShapeHArray2OfShape Tapes, BRepFill_DataMapOfShapeHArray2OfShape Rails, BRepFill_TransitionStyle Transition, GeomAbs_Shape Continuity, GeomFill_ApproxStyle Approx, int Degmax)
		{
			throw new NotImplementedException();
		}

		public void Build(TopTools_MapOfShape ReversedEdges, BRepFill_DataMapOfShapeHArray2OfShape Tapes, BRepFill_DataMapOfShapeHArray2OfShape Rails, BRepFill_TransitionStyle Transition, GeomAbs_Shape Continuity, GeomFill_ApproxStyle Approx)
		{
			throw new NotImplementedException();
		}

		public void Build(TopTools_MapOfShape ReversedEdges, BRepFill_DataMapOfShapeHArray2OfShape Tapes, BRepFill_DataMapOfShapeHArray2OfShape Rails, BRepFill_TransitionStyle Transition, GeomAbs_Shape Continuity)
		{
			throw new NotImplementedException();
		}

		public void Build(TopTools_MapOfShape ReversedEdges, BRepFill_DataMapOfShapeHArray2OfShape Tapes, BRepFill_DataMapOfShapeHArray2OfShape Rails, BRepFill_TransitionStyle Transition)
		{
			throw new NotImplementedException();
		}

		public void Build(TopTools_MapOfShape ReversedEdges, BRepFill_DataMapOfShapeHArray2OfShape Tapes, BRepFill_DataMapOfShapeHArray2OfShape Rails)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public double ErrorOnSurface()
		{
			throw new NotImplementedException();
		}

		public TopTools_HArray2OfShape SubShape()
		{
			throw new NotImplementedException();
		}

		public TopTools_HArray2OfShape InterFaces()
		{
			throw new NotImplementedException();
		}

		public TopTools_HArray2OfShape Sections()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Tape(int Index)
		{
			throw new NotImplementedException();
		}

		public bool CorrectApproxParameters()
		{
			throw new NotImplementedException();
		}

		public bool BuildWire(BRepFill_TransitionStyle Transition)
		{
			throw new NotImplementedException();
		}

		public bool BuildShell(BRepFill_TransitionStyle Transition, int Vf, int Vl, TopTools_MapOfShape ReversedEdges, BRepFill_DataMapOfShapeHArray2OfShape Tapes, BRepFill_DataMapOfShapeHArray2OfShape Rails, double ExtendFirst, double ExtendLast)
		{
			throw new NotImplementedException();
		}

		public bool BuildShell(BRepFill_TransitionStyle Transition, int Vf, int Vl, TopTools_MapOfShape ReversedEdges, BRepFill_DataMapOfShapeHArray2OfShape Tapes, BRepFill_DataMapOfShapeHArray2OfShape Rails, double ExtendFirst)
		{
			throw new NotImplementedException();
		}

		public bool BuildShell(BRepFill_TransitionStyle Transition, int Vf, int Vl, TopTools_MapOfShape ReversedEdges, BRepFill_DataMapOfShapeHArray2OfShape Tapes, BRepFill_DataMapOfShapeHArray2OfShape Rails)
		{
			throw new NotImplementedException();
		}

		public bool PerformCorner(int Index, BRepFill_TransitionStyle Transition, TopTools_HArray2OfShape Bounds)
		{
			throw new NotImplementedException();
		}

		public double EvalExtrapol(int Index, BRepFill_TransitionStyle Transition)
		{
			throw new NotImplementedException();
		}

		public bool MergeVertex(TopoDS_Shape V1, TopoDS_Shape V2)
		{
			throw new NotImplementedException();
		}

		public void UpdateVertex(int Ipath, int Isec, double Error, double Param, TopoDS_Shape V)
		{
			throw new NotImplementedException();
		}

		public void RebuildTopOrBottomEdge(TopoDS_Edge aNewEdge, TopoDS_Edge anEdge, TopTools_MapOfShape ReversedEdges)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFill_Sweep

}
