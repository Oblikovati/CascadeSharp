//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepDS_InterferenceTool
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepDS_InterferenceTool
	{

		public TopOpeBRepDS_InterferenceTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_InterferenceTool(TopOpeBRepDS_InterferenceTool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Interference MakeEdgeInterference(TopOpeBRepDS_Transition T, CascadeSharp.TopOpeBRepDS_Kind SK, int SI, CascadeSharp.TopOpeBRepDS_Kind GK, int GI, double P)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Interference MakeCurveInterference(TopOpeBRepDS_Transition T, CascadeSharp.TopOpeBRepDS_Kind SK, int SI, CascadeSharp.TopOpeBRepDS_Kind GK, int GI, double P)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Interference DuplicateCurvePointInterference(TopOpeBRepDS_Interference I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Interference MakeFaceCurveInterference(TopOpeBRepDS_Transition Transition, int FaceI, int CurveI, Geom2d_Curve PC)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Interference MakeSolidSurfaceInterference(TopOpeBRepDS_Transition Transition, int SolidI, int SurfaceI)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Interference MakeEdgeVertexInterference(TopOpeBRepDS_Transition Transition, int EdgeI, int VertexI, bool VertexIsBound, CascadeSharp.TopOpeBRepDS_Config Config, double param)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Interference MakeFaceEdgeInterference(TopOpeBRepDS_Transition Transition, int FaceI, int EdgeI, bool EdgeIsBound, CascadeSharp.TopOpeBRepDS_Config Config)
		{
			throw new NotImplementedException();
		}

		public double Parameter(TopOpeBRepDS_Interference CPI)
		{
			throw new NotImplementedException();
		}

		public void Parameter(TopOpeBRepDS_Interference CPI, double Par)
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRepDS_InterferenceTool

}
