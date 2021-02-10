//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.TopOpeBRepBuild;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKFillet.ChFiDS;

namespace CascadeSharp.TKFillet.BRepFilletAPI
{
	//---------------------------------------------------------------------
	//  Class  BRepFilletAPI_MakeChamfer
	//---------------------------------------------------------------------
	public  sealed class BRepFilletAPI_MakeChamfer : BRepFilletAPI_LocalOperation
	{

		public BRepFilletAPI_MakeChamfer(TopoDS_Shape S)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFilletAPI_MakeChamfer(BRepFilletAPI_MakeChamfer parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFilletAPI_MakeChamfer()
		{
			throw new NotImplementedException();
		}

		public void Add(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void Add(double D_is, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void SetDist(double D_is, int IC, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void GetDist(int IC, ref double D_is)
		{
			throw new NotImplementedException();
		}

		public void Add(double D_is1, double D_is2, TopoDS_Edge E, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void SetDists(double D_is1, double D_is2, int IC, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void Dists(int IC, ref double D_is1, ref double D_is2)
		{
			throw new NotImplementedException();
		}

		public void AddDA(double D_is, double Angle, TopoDS_Edge E, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void SetDistAngle(double D_is, double Angle, int IC, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void GetDistAngle(int IC, ref double D_is, ref double Angle)
		{
			throw new NotImplementedException();
		}

		public void SetMode(ChFiDS_ChamfMode theMode)
		{
			throw new NotImplementedException();
		}

		public bool IsSymetric(int IC)
		{
			throw new NotImplementedException();
		}

		public bool IsTwoDistances(int IC)
		{
			throw new NotImplementedException();
		}

		public bool IsDistanceAngle(int IC)
		{
			throw new NotImplementedException();
		}

		public void ResetContour(int IC)
		{
			throw new NotImplementedException();
		}

		public int NbContours()
		{
			throw new NotImplementedException();
		}

		public int Contour(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public int NbEdges(int I)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge Edge(int I, int J)
		{
			throw new NotImplementedException();
		}

		public void Remove(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public double Length(int IC)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex FirstVertex(int IC)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex LastVertex(int IC)
		{
			throw new NotImplementedException();
		}

		public double Abscissa(int IC, TopoDS_Vertex V)
		{
			throw new NotImplementedException();
		}

		public double RelativeAbscissa(int IC, TopoDS_Vertex V)
		{
			throw new NotImplementedException();
		}

		public bool ClosedAndTangent(int IC)
		{
			throw new NotImplementedException();
		}

		public bool Closed(int IC)
		{
			throw new NotImplementedException();
		}

		public void Build()
		{
			throw new NotImplementedException();
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_HBuilder Builder()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Generated(TopoDS_Shape EorV)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Modified(TopoDS_Shape F)
		{
			throw new NotImplementedException();
		}

		public bool IsDeleted(TopoDS_Shape F)
		{
			throw new NotImplementedException();
		}

		public void Simulate(int IC)
		{
			throw new NotImplementedException();
		}

		public int NbSurf(int IC)
		{
			throw new NotImplementedException();
		}

		public ChFiDS_SecHArray1 Sect(int IC, int IS)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFilletAPI_MakeChamfer

}
