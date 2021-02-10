//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRep_EdgesIntersector
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRep_EdgesIntersector
	{

		public TopOpeBRep_EdgesIntersector()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_EdgesIntersector(TopOpeBRep_EdgesIntersector parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetFaces(TopoDS_Shape F1, TopoDS_Shape F2)
		{
			throw new NotImplementedException();
		}

		public void SetFaces(TopoDS_Shape F1, TopoDS_Shape F2, Bnd_Box B1, Bnd_Box B2)
		{
			throw new NotImplementedException();
		}

		public void ForceTolerances(double Tol1, double Tol2)
		{
			throw new NotImplementedException();
		}

		public void Dimension(int D)
		{
			throw new NotImplementedException();
		}

		public int Dimension()
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Shape E1, TopoDS_Shape E2, bool ReduceSegments)
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Shape E1, TopoDS_Shape E2)
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			throw new NotImplementedException();
		}

		public bool HasSegment()
		{
			throw new NotImplementedException();
		}

		public bool SameDomain()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Edge(int Index)
		{
			throw new NotImplementedException();
		}

		public Geom2dAdaptor_Curve Curve(int Index)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Face(int Index)
		{
			throw new NotImplementedException();
		}

		public BRepAdaptor_Surface Surface(int Index)
		{
			throw new NotImplementedException();
		}

		public bool SurfacesSameOriented()
		{
			throw new NotImplementedException();
		}

		public bool FacesSameOriented()
		{
			throw new NotImplementedException();
		}

		public double ToleranceMax()
		{
			throw new NotImplementedException();
		}

		public void Tolerances(ref double tol1, ref double tol2)
		{
			throw new NotImplementedException();
		}

		public int NbPoints()
		{
			throw new NotImplementedException();
		}

		public int NbSegments()
		{
			throw new NotImplementedException();
		}

		public void Dump(TCollection_AsciiString str, int ie1, int ie2)
		{
			throw new NotImplementedException();
		}

		public void Dump(TCollection_AsciiString str, int ie1)
		{
			throw new NotImplementedException();
		}

		public void Dump(TCollection_AsciiString str)
		{
			throw new NotImplementedException();
		}

		public void InitPoint(bool selectkeep)
		{
			throw new NotImplementedException();
		}

		public void InitPoint()
		{
			throw new NotImplementedException();
		}

		public bool MorePoint()
		{
			throw new NotImplementedException();
		}

		public void NextPoint()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_SequenceOfPoint2d Points()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_Point2d Point()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_Point2d Point(int I)
		{
			throw new NotImplementedException();
		}

		public bool ReduceSegment(TopOpeBRep_Point2d P1, TopOpeBRep_Point2d P2, TopOpeBRep_Point2d Pn)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopOpeBRep_P2Dstatus Status1()
		{
			throw new NotImplementedException();
		}

		public void Find()
		{
			throw new NotImplementedException();
		}

		public bool ComputeSameDomain()
		{
			throw new NotImplementedException();
		}

		public bool SetSameDomain(bool B)
		{
			throw new NotImplementedException();
		}

		public void MakePoints2d()
		{
			throw new NotImplementedException();
		}

		public void ReduceSegments()
		{
			throw new NotImplementedException();
		}

		public IntRes2d_IntersectionSegment Segment1()
		{
			throw new NotImplementedException();
		}

		public bool IsOpposite1()
		{
			throw new NotImplementedException();
		}

		public void InitPoint1()
		{
			throw new NotImplementedException();
		}

		public bool MorePoint1()
		{
			throw new NotImplementedException();
		}

		public void NextPoint1()
		{
			throw new NotImplementedException();
		}

		public IntRes2d_IntersectionPoint Point1()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Transition Transition1(int Index, CascadeSharp.TopAbs_Orientation EO)
		{
			throw new NotImplementedException();
		}

		public double Parameter1(int Index)
		{
			throw new NotImplementedException();
		}

		public bool IsVertex1(int Index)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Vertex1(int Index)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Value1()
		{
			throw new NotImplementedException();
		}

		public bool IsPointOfSegment1()
		{
			throw new NotImplementedException();
		}

		public int Index1()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopOpeBRepDS_Config EdgesConfig1()
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRep_EdgesIntersector

}
