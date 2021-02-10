//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_Boundary
	//---------------------------------------------------------------------
	public  abstract class GeomFill_Boundary : Standard_Transient
	{

		public GeomFill_Boundary(double Tol3d, double Tolang)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public GeomFill_Boundary(GeomFill_Boundary parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public GeomFill_Boundary()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Value(double U)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, gp_Pnt P, gp_Vec V)
		{
			throw new NotImplementedException();
		}

		public bool HasNormals()
		{
			throw new NotImplementedException();
		}

		public gp_Vec Norm(double U)
		{
			throw new NotImplementedException();
		}

		public void D1Norm(double U, gp_Vec N, gp_Vec DN)
		{
			throw new NotImplementedException();
		}

		public void Reparametrize(double First, double Last, bool HasDF, bool HasDL, double DF, double DL, bool Rev)
		{
			throw new NotImplementedException();
		}

		public void Points(gp_Pnt PFirst, gp_Pnt PLast)
		{
			throw new NotImplementedException();
		}

		public void Bounds(ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public bool IsDegenerated()
		{
			throw new NotImplementedException();
		}

		public double Tol3d()
		{
			throw new NotImplementedException();
		}

		public void Tol3d(double Tol)
		{
			throw new NotImplementedException();
		}

		public double Tolang()
		{
			throw new NotImplementedException();
		}

		public void Tolang(double Tol)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class GeomFill_Boundary

}
