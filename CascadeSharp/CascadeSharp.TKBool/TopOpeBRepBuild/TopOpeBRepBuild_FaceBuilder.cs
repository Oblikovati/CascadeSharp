//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKBool.TopOpeBRepBuild
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepBuild_FaceBuilder
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepBuild_FaceBuilder
	{

		public TopOpeBRepBuild_FaceBuilder()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_FaceBuilder(TopOpeBRepBuild_WireEdgeSet ES, TopoDS_Shape F, bool ForceClass)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_FaceBuilder(TopOpeBRepBuild_WireEdgeSet ES, TopoDS_Shape F)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_FaceBuilder(TopOpeBRepBuild_FaceBuilder parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void InitFaceBuilder(TopOpeBRepBuild_WireEdgeSet ES, TopoDS_Shape F, bool ForceClass)
		{
			throw new NotImplementedException();
		}

		public void DetectUnclosedWire(TopTools_IndexedDataMapOfShapeShape mapVVsameG, TopTools_IndexedDataMapOfShapeShape mapVon1Edge)
		{
			throw new NotImplementedException();
		}

		public void CorrectGclosedWire(TopTools_IndexedDataMapOfShapeShape mapVV_ref, TopTools_IndexedDataMapOfShapeShape mapVon1Edge)
		{
			throw new NotImplementedException();
		}

		public void DetectPseudoInternalEdge(TopTools_IndexedMapOfShape mapE)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Face()
		{
			throw new NotImplementedException();
		}

		public int InitFace()
		{
			throw new NotImplementedException();
		}

		public bool MoreFace()
		{
			throw new NotImplementedException();
		}

		public void NextFace()
		{
			throw new NotImplementedException();
		}

		public int InitWire()
		{
			throw new NotImplementedException();
		}

		public bool MoreWire()
		{
			throw new NotImplementedException();
		}

		public void NextWire()
		{
			throw new NotImplementedException();
		}

		public bool IsOldWire()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape OldWire()
		{
			throw new NotImplementedException();
		}

		public void FindNextValidElement()
		{
			throw new NotImplementedException();
		}

		public int InitEdge()
		{
			throw new NotImplementedException();
		}

		public bool MoreEdge()
		{
			throw new NotImplementedException();
		}

		public void NextEdge()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Edge()
		{
			throw new NotImplementedException();
		}

		public int EdgeConnexity(TopoDS_Shape E)
		{
			throw new NotImplementedException();
		}

		public int AddEdgeWire(TopoDS_Shape E, TopoDS_Shape W)
		{
			throw new NotImplementedException();
		}

		public void MakeLoops(TopOpeBRepBuild_ShapeSet SS)
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRepBuild_FaceBuilder

}
