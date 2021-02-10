//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BiTgte_Blend
	//---------------------------------------------------------------------
	public  sealed class BiTgte_Blend
	{

		public BiTgte_Blend()
			: base()
		{
			throw new NotImplementedException();
		}

		public BiTgte_Blend(TopoDS_Shape S, double Radius, double Tol, bool NUBS)
			: base()
		{
			throw new NotImplementedException();
		}

		public BiTgte_Blend(BiTgte_Blend parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape S, double Radius, double Tol, bool NUBS)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void SetFaces(TopoDS_Face F1, TopoDS_Face F2)
		{
			throw new NotImplementedException();
		}

		public void SetEdge(TopoDS_Edge Edge)
		{
			throw new NotImplementedException();
		}

		public void SetStoppingFace(TopoDS_Face Face)
		{
			throw new NotImplementedException();
		}

		public void Perform(bool BuildShape)
		{
			throw new NotImplementedException();
		}

		public void Perform()
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

		public int NbSurfaces()
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Surface(int Index)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Face(int Index)
		{
			throw new NotImplementedException();
		}

		public void CenterLines(TopTools_ListOfShape LC)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Surface(TopoDS_Shape CenterLine)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Face(TopoDS_Shape CenterLine)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.BiTgte_ContactType ContactType(int Index)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape SupportShape1(int Index)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape SupportShape2(int Index)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve CurveOnShape1(int Index)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve CurveOnShape2(int Index)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve PCurveOnFace1(int Index)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve PCurve1OnFillet(int Index)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve PCurveOnFace2(int Index)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve PCurve2OnFillet(int Index)
		{
			throw new NotImplementedException();
		}

		public int NbBranches()
		{
			throw new NotImplementedException();
		}

		public void IndicesOfBranche(int Index, ref int From, ref int To)
		{
			throw new NotImplementedException();
		}

		public void ComputeCenters()
		{
			throw new NotImplementedException();
		}

		public void ComputeSurfaces()
		{
			throw new NotImplementedException();
		}

		public void ComputeShape()
		{
			throw new NotImplementedException();
		}

		public bool Intersect(TopoDS_Shape Init, TopoDS_Face Face, TopTools_DataMapOfShapeBox MapSBox, BRepOffset_Offset OF1, BRepOffset_Inter3d Inter)
		{
			throw new NotImplementedException();
		}


	}; // class BiTgte_Blend

}
