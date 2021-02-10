//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_Filling
	//---------------------------------------------------------------------
	public  sealed class BRepFill_Filling
	{

		public BRepFill_Filling(int Degree, int NbPtsOnCur, int NbIter, bool An_isotropie, double Tol2d, double Tol3d, double TolAng, double TolCurv, int MaxDeg, int MaxSegments)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Filling(int Degree, int NbPtsOnCur, int NbIter, bool An_isotropie, double Tol2d, double Tol3d, double TolAng, double TolCurv, int MaxDeg)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Filling(int Degree, int NbPtsOnCur, int NbIter, bool An_isotropie, double Tol2d, double Tol3d, double TolAng, double TolCurv)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Filling(int Degree, int NbPtsOnCur, int NbIter, bool An_isotropie, double Tol2d, double Tol3d, double TolAng)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Filling(int Degree, int NbPtsOnCur, int NbIter, bool An_isotropie, double Tol2d, double Tol3d)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Filling(int Degree, int NbPtsOnCur, int NbIter, bool An_isotropie, double Tol2d)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Filling(int Degree, int NbPtsOnCur, int NbIter, bool An_isotropie)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Filling(int Degree, int NbPtsOnCur, int NbIter)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Filling(int Degree, int NbPtsOnCur)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Filling(int Degree)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Filling(BRepFill_Filling parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Filling()
		{
			throw new NotImplementedException();
		}

		public void SetConstrParam(double Tol2d, double Tol3d, double TolAng, double TolCurv)
		{
			throw new NotImplementedException();
		}

		public void SetConstrParam(double Tol2d, double Tol3d, double TolAng)
		{
			throw new NotImplementedException();
		}

		public void SetConstrParam(double Tol2d, double Tol3d)
		{
			throw new NotImplementedException();
		}

		public void SetConstrParam(double Tol2d)
		{
			throw new NotImplementedException();
		}

		public void SetConstrParam()
		{
			throw new NotImplementedException();
		}

		public void SetResolParam(int Degree, int NbPtsOnCur, int NbIter, bool An_isotropie)
		{
			throw new NotImplementedException();
		}

		public void SetResolParam(int Degree, int NbPtsOnCur, int NbIter)
		{
			throw new NotImplementedException();
		}

		public void SetResolParam(int Degree, int NbPtsOnCur)
		{
			throw new NotImplementedException();
		}

		public void SetResolParam(int Degree)
		{
			throw new NotImplementedException();
		}

		public void SetResolParam()
		{
			throw new NotImplementedException();
		}

		public void SetApproxParam(int MaxDeg, int MaxSegments)
		{
			throw new NotImplementedException();
		}

		public void SetApproxParam(int MaxDeg)
		{
			throw new NotImplementedException();
		}

		public void SetApproxParam()
		{
			throw new NotImplementedException();
		}

		public void LoadInitSurface(TopoDS_Face aFace)
		{
			throw new NotImplementedException();
		}

		public int Add(TopoDS_Edge anEdge, CascadeSharp.GeomAbs_Shape Order, bool IsBound)
		{
			throw new NotImplementedException();
		}

		public int Add(TopoDS_Edge anEdge, CascadeSharp.GeomAbs_Shape Order)
		{
			throw new NotImplementedException();
		}

		public int Add(TopoDS_Edge anEdge, TopoDS_Face Support, CascadeSharp.GeomAbs_Shape Order, bool IsBound)
		{
			throw new NotImplementedException();
		}

		public int Add(TopoDS_Edge anEdge, TopoDS_Face Support, CascadeSharp.GeomAbs_Shape Order)
		{
			throw new NotImplementedException();
		}

		public int Add(TopoDS_Face Support, CascadeSharp.GeomAbs_Shape Order)
		{
			throw new NotImplementedException();
		}

		public int Add(gp_Pnt Point)
		{
			throw new NotImplementedException();
		}

		public int Add(double U, double V, TopoDS_Face Support, CascadeSharp.GeomAbs_Shape Order)
		{
			throw new NotImplementedException();
		}

		public void Build()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Face()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Generated(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public double G0Error()
		{
			throw new NotImplementedException();
		}

		public double G1Error()
		{
			throw new NotImplementedException();
		}

		public double G2Error()
		{
			throw new NotImplementedException();
		}

		public double G0Error(int Index)
		{
			throw new NotImplementedException();
		}

		public double G1Error(int Index)
		{
			throw new NotImplementedException();
		}

		public double G2Error(int Index)
		{
			throw new NotImplementedException();
		}

		public void AddConstraints(BRepFill_SequenceOfEdgeFaceAndOrder SeqOfConstraints)
		{
			throw new NotImplementedException();
		}

		public void BuildWires(TopTools_ListOfShape EdgeL_ist, TopTools_ListOfShape WireL_ist)
		{
			throw new NotImplementedException();
		}

		public void FindExtremitiesOfHoles(TopTools_ListOfShape WireL_ist, TopTools_SequenceOfShape VerSeq)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFill_Filling

}
