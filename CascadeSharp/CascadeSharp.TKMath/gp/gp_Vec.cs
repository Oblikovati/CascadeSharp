//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  gp_Vec
	//---------------------------------------------------------------------
	public  sealed class gp_Vec
	{

		public gp_Vec()
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Vec(gp_Dir V)
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Vec(gp_XYZ Coord)
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Vec(double Xv, double Yv, double Zv)
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Vec(gp_Pnt P1, gp_Pnt P2)
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Vec(gp_Vec parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetCoord(int Index, double Xi)
		{
			throw new NotImplementedException();
		}

		public void SetCoord(double Xv, double Yv, double Zv)
		{
			throw new NotImplementedException();
		}

		public void SetX(double X)
		{
			throw new NotImplementedException();
		}

		public void SetY(double Y)
		{
			throw new NotImplementedException();
		}

		public void SetZ(double Z)
		{
			throw new NotImplementedException();
		}

		public void SetXYZ(gp_XYZ Coord)
		{
			throw new NotImplementedException();
		}

		public double Coord(int Index)
		{
			throw new NotImplementedException();
		}

		public void Coord(ref double Xv, ref double Yv, ref double Zv)
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

		public gp_XYZ XYZ()
		{
			throw new NotImplementedException();
		}

		public bool IsEqual(gp_Vec Other, double LinearTolerance, double AngularTolerance)
		{
			throw new NotImplementedException();
		}

		public bool IsNormal(gp_Vec Other, double AngularTolerance)
		{
			throw new NotImplementedException();
		}

		public bool IsOpposite(gp_Vec Other, double AngularTolerance)
		{
			throw new NotImplementedException();
		}

		public bool IsParallel(gp_Vec Other, double AngularTolerance)
		{
			throw new NotImplementedException();
		}

		public double Angle(gp_Vec Other)
		{
			throw new NotImplementedException();
		}

		public double AngleWithRef(gp_Vec Other, gp_Vec VRef)
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

		public void Add(gp_Vec Other)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Added(gp_Vec Other)
		{
			throw new NotImplementedException();
		}

		public void Subtract(gp_Vec Right)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Subtracted(gp_Vec Right)
		{
			throw new NotImplementedException();
		}

		public void Multiply(double Scalar)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Multiplied(double Scalar)
		{
			throw new NotImplementedException();
		}

		public void Divide(double Scalar)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Divided(double Scalar)
		{
			throw new NotImplementedException();
		}

		public void Cross(gp_Vec Right)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Crossed(gp_Vec Right)
		{
			throw new NotImplementedException();
		}

		public double CrossMagnitude(gp_Vec Right)
		{
			throw new NotImplementedException();
		}

		public double CrossSquareMagnitude(gp_Vec Right)
		{
			throw new NotImplementedException();
		}

		public void CrossCross(gp_Vec V1, gp_Vec V2)
		{
			throw new NotImplementedException();
		}

		public gp_Vec CrossCrossed(gp_Vec V1, gp_Vec V2)
		{
			throw new NotImplementedException();
		}

		public double Dot(gp_Vec Other)
		{
			throw new NotImplementedException();
		}

		public double DotCross(gp_Vec V1, gp_Vec V2)
		{
			throw new NotImplementedException();
		}

		public void Normalize()
		{
			throw new NotImplementedException();
		}

		public gp_Vec Normalized()
		{
			throw new NotImplementedException();
		}

		public void Reverse()
		{
			throw new NotImplementedException();
		}

		public gp_Vec Reversed()
		{
			throw new NotImplementedException();
		}

		public void SetLinearForm(double A1, gp_Vec V1, double A2, gp_Vec V2, double A3, gp_Vec V3, gp_Vec V4)
		{
			throw new NotImplementedException();
		}

		public void SetLinearForm(double A1, gp_Vec V1, double A2, gp_Vec V2, double A3, gp_Vec V3)
		{
			throw new NotImplementedException();
		}

		public void SetLinearForm(double A1, gp_Vec V1, double A2, gp_Vec V2, gp_Vec V3)
		{
			throw new NotImplementedException();
		}

		public void SetLinearForm(double A1, gp_Vec V1, double A2, gp_Vec V2)
		{
			throw new NotImplementedException();
		}

		public void SetLinearForm(double A1, gp_Vec V1, gp_Vec V2)
		{
			throw new NotImplementedException();
		}

		public void SetLinearForm(gp_Vec V1, gp_Vec V2)
		{
			throw new NotImplementedException();
		}

		public void Mirror(gp_Vec V)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Mirrored(gp_Vec V)
		{
			throw new NotImplementedException();
		}

		public void Mirror(gp_Ax1 A1)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Mirrored(gp_Ax1 A1)
		{
			throw new NotImplementedException();
		}

		public void Mirror(gp_Ax2 A2)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Mirrored(gp_Ax2 A2)
		{
			throw new NotImplementedException();
		}

		public void Rotate(gp_Ax1 A1, double Ang)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Rotated(gp_Ax1 A1, double Ang)
		{
			throw new NotImplementedException();
		}

		public void Scale(double S)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Scaled(double S)
		{
			throw new NotImplementedException();
		}

		public void Transform(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Transformed(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

				
	}; // class gp_Vec

}
