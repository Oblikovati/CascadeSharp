//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ChFi2d_FilletAPI
	//---------------------------------------------------------------------
	public  sealed class ChFi2d_FilletAPI
	{

		public ChFi2d_FilletAPI()
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFi2d_FilletAPI(TopoDS_Wire theWire, gp_Pln thePlane)
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFi2d_FilletAPI(TopoDS_Edge theEdge1, TopoDS_Edge theEdge2, gp_Pln thePlane)
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFi2d_FilletAPI(ChFi2d_FilletAPI parameter1)
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

		public bool IsAnalytical(TopoDS_Edge theEdge1, TopoDS_Edge theEdge2)
		{
			throw new NotImplementedException();
		}


	}; // class ChFi2d_FilletAPI

}
