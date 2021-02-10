//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Geom
{
	//---------------------------------------------------------------------
	//  Class  Geom_Vector
	//---------------------------------------------------------------------
	public  abstract class Geom_Vector : Geom_Geometry
	{

		public Geom_Vector()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Geom_Vector(Geom_Vector parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void Reverse()
		{
			throw new NotImplementedException();
		}

		public Geom_Vector Reversed()
		{
			throw new NotImplementedException();
		}

		public double Angle(Geom_Vector Other)
		{
			throw new NotImplementedException();
		}

		public double AngleWithRef(Geom_Vector Other, Geom_Vector VRef)
		{
			throw new NotImplementedException();
		}

		public void Coord(ref double X, ref double Y, ref double Z)
		{
			throw new NotImplementedException();
		}

		public double Magnitude()
		{
			throw new NotImplementedException();
		}

		public double SquareMagnitude()
		{
			throw new NotImplementedException();
		}

		public double X()
		{
			throw new NotImplementedException();
		}

		public double Y()
		{
			throw new NotImplementedException();
		}

		public double Z()
		{
			throw new NotImplementedException();
		}

		public void Cross(Geom_Vector Other)
		{
			throw new NotImplementedException();
		}

		public Geom_Vector Crossed(Geom_Vector Other)
		{
			throw new NotImplementedException();
		}

		public void CrossCross(Geom_Vector V1, Geom_Vector V2)
		{
			throw new NotImplementedException();
		}

		public Geom_Vector CrossCrossed(Geom_Vector V1, Geom_Vector V2)
		{
			throw new NotImplementedException();
		}

		public double Dot(Geom_Vector Other)
		{
			throw new NotImplementedException();
		}

		public double DotCross(Geom_Vector V1, Geom_Vector V2)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Vec()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Geom_Vector

}
