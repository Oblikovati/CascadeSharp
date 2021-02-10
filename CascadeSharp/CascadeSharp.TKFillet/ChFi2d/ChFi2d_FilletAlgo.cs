//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ChFi2d_FilletAlgo
	//---------------------------------------------------------------------
	public  sealed class ChFi2d_FilletAlgo
	{

		public ChFi2d_FilletAlgo()
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFi2d_FilletAlgo(TopoDS_Wire theWire, gp_Pln thePlane)
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFi2d_FilletAlgo(TopoDS_Edge theEdge1, TopoDS_Edge theEdge2, gp_Pln thePlane)
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFi2d_FilletAlgo(ChFi2d_FilletAlgo parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Wire theWire, gp_Pln thePlane)
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Edge theEdge1, TopoDS_Edge theEdge2, gp_Pln thePlane)
		{
			throw new NotImplementedException();
		}

		public bool Perform(double theRadius)
		{
			throw new NotImplementedException();
		}

		public int NbResults(gp_Pnt thePoint)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge Result(gp_Pnt thePoint, TopoDS_Edge theEdge1, TopoDS_Edge theEdge2, int iSolution)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge Result(gp_Pnt thePoint, TopoDS_Edge theEdge1, TopoDS_Edge theEdge2)
		{
			throw new NotImplementedException();
		}

		public void FillPoint(FilletPoint parameter1, double theLimit)
		{
			throw new NotImplementedException();
		}

		public void FillDiff(FilletPoint parameter1, double theDiffStep, bool theFront)
		{
			throw new NotImplementedException();
		}

		public void PerformNewton(FilletPoint parameter1, FilletPoint parameter2)
		{
			throw new NotImplementedException();
		}

		public bool ProcessPoint(FilletPoint parameter1, FilletPoint parameter2, double parameter3)
		{
			throw new NotImplementedException();
		}


	}; // class ChFi2d_FilletAlgo

}
