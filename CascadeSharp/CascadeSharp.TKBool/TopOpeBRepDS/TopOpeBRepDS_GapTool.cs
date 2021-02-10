//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKBool.TopOpeBRepDS
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepDS_GapTool
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepDS_GapTool : Standard_Transient
	{

		public TopOpeBRepDS_GapTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_GapTool(TopOpeBRepDS_HDataStructure HDS)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_GapTool(TopOpeBRepDS_GapTool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopOpeBRepDS_HDataStructure HDS)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference Interferences(int IndexPoint)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference SameInterferences(TopOpeBRepDS_Interference I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference ChangeSameInterferences(TopOpeBRepDS_Interference I)
		{
			throw new NotImplementedException();
		}

		public bool Curve(TopOpeBRepDS_Interference I, TopOpeBRepDS_Curve C)
		{
			throw new NotImplementedException();
		}

		public bool EdgeSupport(TopOpeBRepDS_Interference I, TopoDS_Shape E)
		{
			throw new NotImplementedException();
		}

		public bool FacesSupport(TopOpeBRepDS_Interference I, TopoDS_Shape F1, TopoDS_Shape F2)
		{
			throw new NotImplementedException();
		}

		public bool ParameterOnEdge(TopOpeBRepDS_Interference I, TopoDS_Shape E, ref double U)
		{
			throw new NotImplementedException();
		}

		public void SetPoint(TopOpeBRepDS_Interference I, int IndexPoint)
		{
			throw new NotImplementedException();
		}

		public void SetParameterOnEdge(TopOpeBRepDS_Interference I, TopoDS_Shape E, double U)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class TopOpeBRepDS_GapTool

}
