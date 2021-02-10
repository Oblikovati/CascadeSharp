//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKGeomAlgo.Law;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_CoonsAlgPatch
	//---------------------------------------------------------------------
	public  sealed class GeomFill_CoonsAlgPatch : Standard_Transient
	{

		public GeomFill_CoonsAlgPatch(GeomFill_Boundary B1, GeomFill_Boundary B2, GeomFill_Boundary B3, GeomFill_Boundary B4)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_CoonsAlgPatch(GeomFill_CoonsAlgPatch parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_CoonsAlgPatch()
		{
			throw new NotImplementedException();
		}

		public void Func(Law_Function f1, Law_Function f2)
		{
			throw new NotImplementedException();
		}

		public void SetFunc(Law_Function f1, Law_Function f2)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Value(double U, double V)
		{
			throw new NotImplementedException();
		}

		public gp_Vec D1U(double U, double V)
		{
			throw new NotImplementedException();
		}

		public gp_Vec D1V(double U, double V)
		{
			throw new NotImplementedException();
		}

		public gp_Vec DUV(double U, double V)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Corner(int I)
		{
			throw new NotImplementedException();
		}

		public GeomFill_Boundary Bound(int I)
		{
			throw new NotImplementedException();
		}

		public Law_Function Func(int I)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class GeomFill_CoonsAlgPatch

}
