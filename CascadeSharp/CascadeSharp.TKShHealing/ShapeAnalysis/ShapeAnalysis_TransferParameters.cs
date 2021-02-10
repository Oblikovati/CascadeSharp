//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TColStd;

namespace CascadeSharp.TKShHealing.ShapeAnalysis
{
	//---------------------------------------------------------------------
	//  Class  ShapeAnalysis_TransferParameters
	//---------------------------------------------------------------------
	public  class ShapeAnalysis_TransferParameters : Standard_Transient
	{

		public ShapeAnalysis_TransferParameters()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_TransferParameters(TopoDS_Edge E, TopoDS_Face F)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_TransferParameters(ShapeAnalysis_TransferParameters parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Edge E, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void SetMaxTolerance(double maxtol)
		{
			throw new NotImplementedException();
		}

		public TColStd_HSequenceOfReal Perform(TColStd_HSequenceOfReal Params, bool To2d)
		{
			throw new NotImplementedException();
		}

		public double Perform(double Param, bool To2d)
		{
			throw new NotImplementedException();
		}

		public void TransferRange(TopoDS_Edge newEdge, double prevPar, double currPar, bool To2d)
		{
			throw new NotImplementedException();
		}

		public bool IsSameRange()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class ShapeAnalysis_TransferParameters

}
