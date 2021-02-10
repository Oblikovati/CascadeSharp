//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKShHealing.ShapeExtend
{
	//---------------------------------------------------------------------
	//  Class  ShapeExtend_ComplexCurve
	//---------------------------------------------------------------------
	public  abstract class ShapeExtend_ComplexCurve : Geom_Curve
	{

		public ShapeExtend_ComplexCurve()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public ShapeExtend_ComplexCurve(ShapeExtend_ComplexCurve parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public int NbCurves()
		{
			throw new NotImplementedException();
		}

		public Geom_Curve Curve(int index)
		{
			throw new NotImplementedException();
		}

		public int LocateParameter(double U, ref double UOut)
		{
			throw new NotImplementedException();
		}

		public double LocalToGlobal(int index, double Ulocal)
		{
			throw new NotImplementedException();
		}

		public void Transform(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public double ReversedParameter(double U)
		{
			throw new NotImplementedException();
		}

		public double FirstParameter()
		{
			throw new NotImplementedException();
		}

		public double LastParameter()
		{
			throw new NotImplementedException();
		}

		public bool IsClosed()
		{
			throw new NotImplementedException();
		}

		public bool IsPeriodic()
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public bool IsCN(int N)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, gp_Pnt P, gp_Vec V1)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2, gp_Vec V3)
		{
			throw new NotImplementedException();
		}

		public gp_Vec DN(double U, int N)
		{
			throw new NotImplementedException();
		}

		public double GetScaleFactor(int ind)
		{
			throw new NotImplementedException();
		}

		public bool CheckConnectivity(double Preci)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void TransformDN(gp_Vec V, int ind, int N)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeExtend_ComplexCurve

}
