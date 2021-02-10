//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomBase.FEmTool
{
	//---------------------------------------------------------------------
	//  Class  FEmTool_LinearJerk
	//---------------------------------------------------------------------
	public  sealed class FEmTool_LinearJerk : FEmTool_ElementaryCriterion
	{

		public FEmTool_LinearJerk(int WorkDegree, GeomAbs_Shape ConstraintOrder)
			: base()
		{
			throw new NotImplementedException();
		}

		public FEmTool_LinearJerk(FEmTool_LinearJerk parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public FEmTool_LinearJerk()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray2OfInteger DependenceTable()
		{
			throw new NotImplementedException();
		}

		public double Value()
		{
			throw new NotImplementedException();
		}

		public void Hessian(int Dimension1, int Dimension2, math_Matrix H)
		{
			throw new NotImplementedException();
		}

		public void Gradient(int Dimension, math_Vector G)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class FEmTool_LinearJerk

}
