//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Geom
{
	//---------------------------------------------------------------------
	//  Class  Geom_Geometry
	//---------------------------------------------------------------------
	public  abstract class Geom_Geometry : Standard_Transient
	{

		public Geom_Geometry(Geom_Geometry parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Geom_Geometry()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void Mirror(gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void Mirror(gp_Ax1 A1)
		{
			throw new NotImplementedException();
		}

		public void Mirror(gp_Ax2 A2)
		{
			throw new NotImplementedException();
		}

		public void Rotate(gp_Ax1 A1, double Ang)
		{
			throw new NotImplementedException();
		}

		public void Scale(gp_Pnt P, double S)
		{
			throw new NotImplementedException();
		}

		public void Translate(gp_Vec V)
		{
			throw new NotImplementedException();
		}

		public void Translate(gp_Pnt P1, gp_Pnt P2)
		{
			throw new NotImplementedException();
		}

		public void Transform(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public Geom_Geometry Mirrored(gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public Geom_Geometry Mirrored(gp_Ax1 A1)
		{
			throw new NotImplementedException();
		}

		public Geom_Geometry Mirrored(gp_Ax2 A2)
		{
			throw new NotImplementedException();
		}

		public Geom_Geometry Rotated(gp_Ax1 A1, double Ang)
		{
			throw new NotImplementedException();
		}

		public Geom_Geometry Scaled(gp_Pnt P, double S)
		{
			throw new NotImplementedException();
		}

		public Geom_Geometry Transformed(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public Geom_Geometry Translated(gp_Vec V)
		{
			throw new NotImplementedException();
		}

		public Geom_Geometry Translated(gp_Pnt P1, gp_Pnt P2)
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

				
	}; // class Geom_Geometry

}
