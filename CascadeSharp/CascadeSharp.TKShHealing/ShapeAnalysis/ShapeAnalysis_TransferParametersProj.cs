//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.TColStd;

namespace CascadeSharp.TKShHealing.ShapeAnalysis
{
	//---------------------------------------------------------------------
	//  Class  ShapeAnalysis_TransferParametersProj
	//---------------------------------------------------------------------
	public  sealed class ShapeAnalysis_TransferParametersProj : ShapeAnalysis_TransferParameters
	{

		public ShapeAnalysis_TransferParametersProj()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_TransferParametersProj(TopoDS_Edge E, TopoDS_Face F)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_TransferParametersProj(ShapeAnalysis_TransferParametersProj parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Edge E, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public TColStd_HSequenceOfReal Perform(TColStd_HSequenceOfReal Papams, bool To2d)
		{
			throw new NotImplementedException();
		}

		public double Perform(double Param, bool To2d)
		{
			throw new NotImplementedException();
		}

		public bool ForceProjection()
		{
			throw new NotImplementedException();
		}

		public void TransferRange(TopoDS_Edge newEdge, double prevPar, double currPar, bool Is2d)
		{
			throw new NotImplementedException();
		}

		public bool IsSameRange()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex CopyNMVertex(TopoDS_Vertex theVert, TopoDS_Edge toedge, TopoDS_Edge fromedge)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex CopyNMVertex(TopoDS_Vertex theVert, TopoDS_Face toFace, TopoDS_Face fromFace)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public double PreformSegment(double Param, bool To2d, double First, double Last)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeAnalysis_TransferParametersProj

}
