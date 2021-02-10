//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepAdaptor;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKFillet.ChFiDS
{
	//---------------------------------------------------------------------
	//  Class  ChFiDS_Spine
	//---------------------------------------------------------------------
	public  class ChFiDS_Spine : Standard_Transient
	{

		public ChFiDS_Spine()
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_Spine(double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_Spine(ChFiDS_Spine parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetEdges(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void SetOffsetEdges(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void PutInFirst(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void PutInFirstOffset(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public int NbEdges()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge Edges(int I)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge OffsetEdges(int I)
		{
			throw new NotImplementedException();
		}

		public void SetFirstStatus(ChFiDS_State S)
		{
			throw new NotImplementedException();
		}

		public void SetLastStatus(ChFiDS_State S)
		{
			throw new NotImplementedException();
		}

		public void AppendElSpine(ChFiDS_HElSpine Els)
		{
			throw new NotImplementedException();
		}

		public void AppendOffsetElSpine(ChFiDS_HElSpine Els)
		{
			throw new NotImplementedException();
		}

		public ChFiDS_HElSpine ElSpine(int IE)
		{
			throw new NotImplementedException();
		}

		public ChFiDS_HElSpine ElSpine(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public ChFiDS_HElSpine ElSpine(double W)
		{
			throw new NotImplementedException();
		}

		public ChFiDS_ListOfHElSpine ChangeElSpines()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_ListOfHElSpine ChangeOffsetElSpines()
		{
			throw new NotImplementedException();
		}

		public void Reset(bool AllData)
		{
			throw new NotImplementedException();
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}

		public bool SplitDone()
		{
			throw new NotImplementedException();
		}

		public void SplitDone(bool B)
		{
			throw new NotImplementedException();
		}

		public void Load()
		{
			throw new NotImplementedException();
		}

		public double Resolution(double R3d)
		{
			throw new NotImplementedException();
		}

		public bool IsClosed()
		{
			throw new NotImplementedException();
		}

		public double FirstParameter()
		{
			throw new NotImplementedException();
		}

		public double LastParameter()
		{
			throw new NotImplementedException();
		}

		public void SetFirstParameter(double Par)
		{
			throw new NotImplementedException();
		}

		public void SetLastParameter(double Par)
		{
			throw new NotImplementedException();
		}

		public double FirstParameter(int IndexSpine)
		{
			throw new NotImplementedException();
		}

		public double LastParameter(int IndexSpine)
		{
			throw new NotImplementedException();
		}

		public double Length(int IndexSpine)
		{
			throw new NotImplementedException();
		}

		public bool IsPeriodic()
		{
			throw new NotImplementedException();
		}

		public double Period()
		{
			throw new NotImplementedException();
		}

		public double Absc(double U)
		{
			throw new NotImplementedException();
		}

		public double Absc(double U, int I)
		{
			throw new NotImplementedException();
		}

		public void Parameter(double AbsC, ref double U, bool Oriented)
		{
			throw new NotImplementedException();
		}

		public void Parameter(double AbsC, ref double U)
		{
			throw new NotImplementedException();
		}

		public void Parameter(int Index, double AbsC, ref double U, bool Oriented)
		{
			throw new NotImplementedException();
		}

		public void Parameter(int Index, double AbsC, ref double U)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Value(double AbsC)
		{
			throw new NotImplementedException();
		}

		public void D0(double AbsC, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void D1(double AbsC, gp_Pnt P, gp_Vec V1)
		{
			throw new NotImplementedException();
		}

		public void D2(double AbsC, gp_Pnt P, gp_Vec V1, gp_Vec V2)
		{
			throw new NotImplementedException();
		}

		public void SetCurrent(int Index)
		{
			throw new NotImplementedException();
		}

		public BRepAdaptor_Curve CurrentElementarySpine(int Index)
		{
			throw new NotImplementedException();
		}

		public int CurrentIndexOfElementarySpine()
		{
			throw new NotImplementedException();
		}

		public GeomAbs_CurveType GetGeomType()
		{
			throw new NotImplementedException();
		}

		public gp_Lin Line()
		{
			throw new NotImplementedException();
		}

		public gp_Circ Circle()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_State FirstStatus()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_State LastStatus()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_State Status(bool IsFirst)
		{
			throw new NotImplementedException();
		}

		public ChFiDS_TypeOfConcavity GetTypeOfConcavity()
		{
			throw new NotImplementedException();
		}

		public void SetStatus(ChFiDS_State S, bool IsFirst)
		{
			throw new NotImplementedException();
		}

		public void SetTypeOfConcavity(ChFiDS_TypeOfConcavity theType)
		{
			throw new NotImplementedException();
		}

		public bool IsTangencyExtremity(bool IsFirst)
		{
			throw new NotImplementedException();
		}

		public void SetTangencyExtremity(bool IsTangency, bool IsFirst)
		{
			throw new NotImplementedException();
		}

		public double Absc(TopoDS_Vertex V)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex FirstVertex()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex LastVertex()
		{
			throw new NotImplementedException();
		}

		public void SetFirstTgt(double W)
		{
			throw new NotImplementedException();
		}

		public void SetLastTgt(double W)
		{
			throw new NotImplementedException();
		}

		public bool HasFirstTgt()
		{
			throw new NotImplementedException();
		}

		public bool HasLastTgt()
		{
			throw new NotImplementedException();
		}

		public void SetReference(double W)
		{
			throw new NotImplementedException();
		}

		public void SetReference(int I)
		{
			throw new NotImplementedException();
		}

		public int Index(double W, bool Forward)
		{
			throw new NotImplementedException();
		}

		public int Index(double W)
		{
			throw new NotImplementedException();
		}

		public int Index(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void UnsetReference()
		{
			throw new NotImplementedException();
		}

		public void SetErrorStatus(ChFiDS_ErrorStatus state)
		{
			throw new NotImplementedException();
		}

		public ChFiDS_ErrorStatus ErrorStatus()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_ChamfMode Mode()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Prepare(ref double L, ref int Index)
		{
			throw new NotImplementedException();
		}


	}; // class ChFiDS_Spine

}
