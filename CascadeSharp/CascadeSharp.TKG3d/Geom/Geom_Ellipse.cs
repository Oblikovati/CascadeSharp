//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Geom
{
	//---------------------------------------------------------------------
	//  Class  Geom_Ellipse
	//---------------------------------------------------------------------
	public  sealed class Geom_Ellipse : Geom_Conic
	{

		public Geom_Ellipse(gp_Elips E)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Ellipse(gp_Ax2 A2, double MajorRadius, double MinorRadius)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Ellipse(Geom_Ellipse parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Ellipse()
		{
			throw new NotImplementedException();
		}

		public void SetElips(gp_Elips E)
		{
			throw new NotImplementedException();
		}

		public void SetMajorRadius(double MajorRadius)
		{
			throw new NotImplementedException();
		}

		public void SetMinorRadius(double MinorRadius)
		{
			throw new NotImplementedException();
		}

		public gp_Elips Elips()
		{
			throw new NotImplementedException();
		}

		public double ReversedParameter(double U)
		{
			throw new NotImplementedException();
		}

		public gp_Ax1 Directrix1()
		{
			throw new NotImplementedException();
		}

		public gp_Ax1 Directrix2()
		{
			throw new NotImplementedException();
		}

		public double Eccentricity()
		{
			throw new NotImplementedException();
		}

		public double Focal()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Focus1()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Focus2()
		{
			throw new NotImplementedException();
		}

		public double MajorRadius()
		{
			throw new NotImplementedException();
		}

		public double MinorRadius()
		{
			throw new NotImplementedException();
		}

		public double Parameter()
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

		public void Transform(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public Geom_Geometry Copy()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Geom_Ellipse

}
