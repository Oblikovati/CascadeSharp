//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepTools;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKOffset.BRepOffset
{
	//---------------------------------------------------------------------
	//  Class  BRepOffset_SimpleOffset
	//---------------------------------------------------------------------
	public  sealed class BRepOffset_SimpleOffset : BRepTools_Modification
	{

		public BRepOffset_SimpleOffset(TopoDS_Shape theInputShape, double theOffsetValue, double theTolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_SimpleOffset(BRepOffset_SimpleOffset parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_SimpleOffset()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool NewSurface(TopoDS_Face F, Geom_Surface S, TopLoc_Location L, ref double Tol, ref bool RevWires, ref bool RevFace)
		{
			throw new NotImplementedException();
		}

		public bool NewCurve(TopoDS_Edge E, Geom_Curve C, TopLoc_Location L, ref double Tol)
		{
			throw new NotImplementedException();
		}

		public bool NewPoint(TopoDS_Vertex V, gp_Pnt P, ref double Tol)
		{
			throw new NotImplementedException();
		}

		public bool NewCurve2d(TopoDS_Edge E, TopoDS_Face F, TopoDS_Edge NewE, TopoDS_Face NewF, Geom2d_Curve C, ref double Tol)
		{
			throw new NotImplementedException();
		}

		public bool NewParameter(TopoDS_Vertex V, TopoDS_Edge E, ref double P, ref double Tol)
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape Continuity(TopoDS_Edge E, TopoDS_Face F1, TopoDS_Face F2, TopoDS_Edge NewE, TopoDS_Face NewF1, TopoDS_Face NewF2)
		{
			throw new NotImplementedException();
		}

		public void FillFaceData(TopoDS_Face theFace)
		{
			throw new NotImplementedException();
		}

		public void FillEdgeData(TopoDS_Edge theEdge, TopTools_IndexedDataMapOfShapeListOfShape theEdgeFaceMap, int theIdx)
		{
			throw new NotImplementedException();
		}

		public void FillVertexData(TopoDS_Vertex theVertex, TopTools_IndexedDataMapOfShapeListOfShape theVertexEdgeMap, int theIdx)
		{
			throw new NotImplementedException();
		}

		public void FillOffsetData(TopoDS_Shape theInputShape)
		{
			throw new NotImplementedException();
		}


	}; // class BRepOffset_SimpleOffset

}
