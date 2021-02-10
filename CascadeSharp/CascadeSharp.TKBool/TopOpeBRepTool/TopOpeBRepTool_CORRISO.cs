//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.GeomAdaptor;

namespace CascadeSharp.TKBool.TopOpeBRepTool
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepTool_CORRISO
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepTool_CORRISO
	{

		public TopOpeBRepTool_CORRISO()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepTool_CORRISO(TopoDS_Face FRef)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepTool_CORRISO(TopOpeBRepTool_CORRISO parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Fref()
		{
			throw new NotImplementedException();
		}

		public GeomAdaptor_Surface GASref()
		{
			throw new NotImplementedException();
		}

		public bool Refclosed(int x, ref double xperiod)
		{
			throw new NotImplementedException();
		}

		public bool Init(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape S()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Eds()
		{
			throw new NotImplementedException();
		}

		public bool UVClosed()
		{
			throw new NotImplementedException();
		}

		public double Tol(int I, double tol3d)
		{
			throw new NotImplementedException();
		}

		public bool PurgeFyClosingE(TopTools_ListOfShape ClEds, TopTools_ListOfShape fyClEds)
		{
			throw new NotImplementedException();
		}

		public int EdgeOUTofBoundsUV(TopoDS_Edge E, bool onU, double tolx, ref double parspE)
		{
			throw new NotImplementedException();
		}

		public bool EdgesOUTofBoundsUV(TopTools_ListOfShape EdsToCheck, bool onU, double tolx, TopTools_DataMapOfOrientedShapeInteger FyEds)
		{
			throw new NotImplementedException();
		}

		public bool EdgeWithFaultyUV(TopoDS_Edge E, ref int Ivfaulty)
		{
			throw new NotImplementedException();
		}

		public bool EdgesWithFaultyUV(TopTools_ListOfShape EdsToCheck, int nfybounds, TopTools_DataMapOfOrientedShapeInteger FyEds, bool stopatfirst)
		{
			throw new NotImplementedException();
		}

		public bool EdgesWithFaultyUV(TopTools_ListOfShape EdsToCheck, int nfybounds, TopTools_DataMapOfOrientedShapeInteger FyEds)
		{
			throw new NotImplementedException();
		}

		public bool EdgeWithFaultyUV(TopTools_ListOfShape EdsToCheck, int nfybounds, TopoDS_Shape fyE, ref int Ifaulty)
		{
			throw new NotImplementedException();
		}

		public bool TrslUV(bool onU, TopTools_DataMapOfOrientedShapeInteger FyEds)
		{
			throw new NotImplementedException();
		}

		public bool GetnewS(TopoDS_Face newS)
		{
			throw new NotImplementedException();
		}

		public bool UVRep(TopoDS_Edge E, TopOpeBRepTool_C2DF C2DF)
		{
			throw new NotImplementedException();
		}

		public bool SetUVRep(TopoDS_Edge E, TopOpeBRepTool_C2DF C2DF)
		{
			throw new NotImplementedException();
		}

		public bool Connexity(TopoDS_Vertex V, TopTools_ListOfShape Eds)
		{
			throw new NotImplementedException();
		}

		public bool SetConnexity(TopoDS_Vertex V, TopTools_ListOfShape Eds)
		{
			throw new NotImplementedException();
		}

		public bool AddNewConnexity(TopoDS_Vertex V, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public bool RemoveOldConnexity(TopoDS_Vertex V, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRepTool_CORRISO

}
