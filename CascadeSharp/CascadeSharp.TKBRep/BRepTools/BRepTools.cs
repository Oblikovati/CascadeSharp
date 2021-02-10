//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRep;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKernel.Message;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.Bnd;

namespace CascadeSharp.TKBRep.BRepTools
{
	//---------------------------------------------------------------------
	//  Class  BRepTools
	//---------------------------------------------------------------------
	public  sealed class BRepTools
	{

		public BRepTools()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepTools(BRepTools parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void UVBounds(TopoDS_Face F, ref double UMin, ref double UMax, ref double VMin, ref double VMax)
		{
			throw new NotImplementedException();
		}

		public void UVBounds(TopoDS_Face F, TopoDS_Wire W, ref double UMin, ref double UMax, ref double VMin, ref double VMax)
		{
			throw new NotImplementedException();
		}

		public void UVBounds(TopoDS_Face F, TopoDS_Edge E, ref double UMin, ref double UMax, ref double VMin, ref double VMax)
		{
			throw new NotImplementedException();
		}

		public void AddUVBounds(TopoDS_Face F, Bnd_Box2d B)
		{
			throw new NotImplementedException();
		}

		public void AddUVBounds(TopoDS_Face F, TopoDS_Wire W, Bnd_Box2d B)
		{
			throw new NotImplementedException();
		}

		public void AddUVBounds(TopoDS_Face F, TopoDS_Edge E, Bnd_Box2d B)
		{
			throw new NotImplementedException();
		}

		public void Update(TopoDS_Vertex V)
		{
			throw new NotImplementedException();
		}

		public void Update(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void Update(TopoDS_Wire W)
		{
			throw new NotImplementedException();
		}

		public void Update(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void Update(TopoDS_Shell S)
		{
			throw new NotImplementedException();
		}

		public void Update(TopoDS_Solid S)
		{
			throw new NotImplementedException();
		}

		public void Update(TopoDS_CompSolid C)
		{
			throw new NotImplementedException();
		}

		public void Update(TopoDS_Compound C)
		{
			throw new NotImplementedException();
		}

		public void Update(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void UpdateFaceUVPoints(TopoDS_Face theF)
		{
			throw new NotImplementedException();
		}

		public void Clean(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void CleanGeometry(TopoDS_Shape theShape)
		{
			throw new NotImplementedException();
		}

		public void RemoveUnusedPCurves(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public bool Triangulation(TopoDS_Shape theShape, double theLinDefl, bool theToCheckFreeEdges)
		{
			throw new NotImplementedException();
		}

		public bool Triangulation(TopoDS_Shape theShape, double theLinDefl)
		{
			throw new NotImplementedException();
		}

		public bool Compare(TopoDS_Vertex V1, TopoDS_Vertex V2)
		{
			throw new NotImplementedException();
		}

		public bool Compare(TopoDS_Edge E1, TopoDS_Edge E2)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire OuterWire(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void Map3DEdges(TopoDS_Shape S, TopTools_IndexedMapOfShape M)
		{
			throw new NotImplementedException();
		}

		public bool IsReallyClosed(TopoDS_Edge E, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void DetectClosedness(TopoDS_Face theFace, ref bool theUclosed, ref bool theVclosed)
		{
			throw new NotImplementedException();
		}

												public bool Write(TopoDS_Shape Sh, string File, Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public bool Write(TopoDS_Shape Sh, string File)
		{
			throw new NotImplementedException();
		}

		public bool Read(TopoDS_Shape Sh, string File, BRep_Builder B, Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public bool Read(TopoDS_Shape Sh, string File, BRep_Builder B)
		{
			throw new NotImplementedException();
		}

		public double EvalAndUpdateTol(TopoDS_Edge theE, Geom_Curve theC3d, Geom2d_Curve theC2d, Geom_Surface theS, double theF, double theL)
		{
			throw new NotImplementedException();
		}

		public TopAbs_Orientation OriEdgeInFace(TopoDS_Edge theEdge, TopoDS_Face theFace)
		{
			throw new NotImplementedException();
		}

		public void RemoveInternals(TopoDS_Shape theS, bool theForce)
		{
			throw new NotImplementedException();
		}

		public void RemoveInternals(TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}


	}; // class BRepTools

}
