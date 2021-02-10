//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKShHealing.ShapeAnalysis
{
	//---------------------------------------------------------------------
	//  Class  ShapeAnalysis_ShapeTolerance
	//---------------------------------------------------------------------
	public  sealed class ShapeAnalysis_ShapeTolerance
	{

		public ShapeAnalysis_ShapeTolerance()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_ShapeTolerance(ShapeAnalysis_ShapeTolerance parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public double Tolerance(TopoDS_Shape shape, int mode, TopAbs_ShapeEnum type)
		{
			throw new NotImplementedException();
		}

		public double Tolerance(TopoDS_Shape shape, int mode)
		{
			throw new NotImplementedException();
		}

		public TopTools_HSequenceOfShape OverTolerance(TopoDS_Shape shape, double value, TopAbs_ShapeEnum type)
		{
			throw new NotImplementedException();
		}

		public TopTools_HSequenceOfShape OverTolerance(TopoDS_Shape shape, double value)
		{
			throw new NotImplementedException();
		}

		public TopTools_HSequenceOfShape InTolerance(TopoDS_Shape shape, double valmin, double valmax, TopAbs_ShapeEnum type)
		{
			throw new NotImplementedException();
		}

		public TopTools_HSequenceOfShape InTolerance(TopoDS_Shape shape, double valmin, double valmax)
		{
			throw new NotImplementedException();
		}

		public void InitTolerance()
		{
			throw new NotImplementedException();
		}

		public void AddTolerance(TopoDS_Shape shape, TopAbs_ShapeEnum type)
		{
			throw new NotImplementedException();
		}

		public void AddTolerance(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public double GlobalTolerance(int mode)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeAnalysis_ShapeTolerance

}
