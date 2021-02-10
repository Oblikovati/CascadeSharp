//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRep_FacesIntersector
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRep_FacesIntersector
	{

		public TopOpeBRep_FacesIntersector()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_FacesIntersector(TopOpeBRep_FacesIntersector parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Shape S1, TopoDS_Shape S2)
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Shape S1, TopoDS_Shape S2, Bnd_Box B1, Bnd_Box B2)
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public bool SameDomain()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Face(int Index)
		{
			throw new NotImplementedException();
		}

		public bool SurfacesSameOriented()
		{
			throw new NotImplementedException();
		}

		public bool IsRestriction(TopoDS_Shape E)
		{
			throw new NotImplementedException();
		}

		public TopTools_IndexedMapOfShape Restrictions()
		{
			throw new NotImplementedException();
		}

		public void PrepareLines()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_HArray1OfLineInter Lines()
		{
			throw new NotImplementedException();
		}

		public int NbLines()
		{
			throw new NotImplementedException();
		}

		public void InitLine()
		{
			throw new NotImplementedException();
		}

		public bool MoreLine()
		{
			throw new NotImplementedException();
		}

		public void NextLine()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_LineInter CurrentLine()
		{
			throw new NotImplementedException();
		}

		public int CurrentLineIndex()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_LineInter ChangeLine(int IL)
		{
			throw new NotImplementedException();
		}

		public void ForceTolerances(double tolarc, double toltang)
		{
			throw new NotImplementedException();
		}

		public void GetTolerances(ref double tolarc, ref double toltang)
		{
			throw new NotImplementedException();
		}

		public void FindLine()
		{
			throw new NotImplementedException();
		}

		public void ResetIntersection()
		{
			throw new NotImplementedException();
		}

		public void ShapeTolerances(TopoDS_Shape S1, TopoDS_Shape S2)
		{
			throw new NotImplementedException();
		}

		public double ToleranceMax(TopoDS_Shape S, CascadeSharp.TopAbs_ShapeEnum T)
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRep_FacesIntersector

}
