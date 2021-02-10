//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.TopOpeBRepBuild;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKFillet.ChFi3d;
using CascadeSharp.TKFillet.ChFiDS;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKGeomAlgo.Law;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKFillet.BRepFilletAPI
{
	//---------------------------------------------------------------------
	//  Class  BRepFilletAPI_MakeFillet
	//---------------------------------------------------------------------
	public  sealed class BRepFilletAPI_MakeFillet : BRepFilletAPI_LocalOperation
	{

		public BRepFilletAPI_MakeFillet(TopoDS_Shape S, ChFi3d_FilletShape FShape)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFilletAPI_MakeFillet(TopoDS_Shape S)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFilletAPI_MakeFillet(BRepFilletAPI_MakeFillet parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFilletAPI_MakeFillet()
		{
			throw new NotImplementedException();
		}

		public void SetParams(double Tang, double Tesp, double T2d, double TApp3d, double TolApp2d, double Fleche)
		{
			throw new NotImplementedException();
		}

		public void SetContinuity(GeomAbs_Shape InternalContinuity, double AngularTolerance)
		{
			throw new NotImplementedException();
		}

		public void Add(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void Add(double Radius, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void Add(double R1, double R2, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void Add(Law_Function L, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void Add(TColgp_Array1OfPnt2d UandR, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void SetRadius(double Radius, int IC, int IinC)
		{
			throw new NotImplementedException();
		}

		public void SetRadius(double R1, double R2, int IC, int IinC)
		{
			throw new NotImplementedException();
		}

		public void SetRadius(Law_Function L, int IC, int IinC)
		{
			throw new NotImplementedException();
		}

		public void SetRadius(TColgp_Array1OfPnt2d UandR, int IC, int IinC)
		{
			throw new NotImplementedException();
		}

		public void ResetContour(int IC)
		{
			throw new NotImplementedException();
		}

		public bool IsConstant(int IC)
		{
			throw new NotImplementedException();
		}

		public double Radius(int IC)
		{
			throw new NotImplementedException();
		}

		public bool IsConstant(int IC, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public double Radius(int IC, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void SetRadius(double Radius, int IC, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void SetRadius(double Radius, int IC, TopoDS_Vertex V)
		{
			throw new NotImplementedException();
		}

		public bool GetBounds(int IC, TopoDS_Edge E, ref double F, ref double L)
		{
			throw new NotImplementedException();
		}

		public Law_Function GetLaw(int IC, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void SetLaw(int IC, TopoDS_Edge E, Law_Function L)
		{
			throw new NotImplementedException();
		}

		public void SetFilletShape(ChFi3d_FilletShape FShape)
		{
			throw new NotImplementedException();
		}

		public ChFi3d_FilletShape GetFilletShape()
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

		public int NbSurfaces()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape NewFaces(int I)
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

		public int NbFaultyContours()
		{
			throw new NotImplementedException();
		}

		public int FaultyContour(int I)
		{
			throw new NotImplementedException();
		}

		public int NbComputedSurfaces(int IC)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface ComputedSurface(int IC, int IS)
		{
			throw new NotImplementedException();
		}

		public int NbFaultyVertices()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex FaultyVertex(int IV)
		{
			throw new NotImplementedException();
		}

		public bool HasResult()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape BadShape()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_ErrorStatus StripeStatus(int IC)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFilletAPI_MakeFillet

}
