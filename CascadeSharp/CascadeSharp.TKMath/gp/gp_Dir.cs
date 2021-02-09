//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  gp_Dir
	//---------------------------------------------------------------------
	public  sealed class gp_Dir
	{

		public gp_Dir()
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Dir(gp_Vec V)
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Dir(gp_XYZ Coord)
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Dir(double Xv, double Yv, double Zv)
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Dir(gp_Dir parameter1)
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

		public bool IsEqual(gp_Dir Other, double AngularTolerance)
		{
			throw new NotImplementedException();
		}

		public bool IsNormal(gp_Dir Other, double AngularTolerance)
		{
			throw new NotImplementedException();
		}

		public bool IsOpposite(gp_Dir Other, double AngularTolerance)
		{
			throw new NotImplementedException();
		}

		public bool IsParallel(gp_Dir Other, double AngularTolerance)
		{
			throw new NotImplementedException();
		}

		public double Angle(gp_Dir Other)
		{
			throw new NotImplementedException();
		}

		public double AngleWithRef(gp_Dir Other, gp_Dir VRef)
		{
			throw new NotImplementedException();
		}

		public void Cross(gp_Dir Right)
		{
			throw new NotImplementedException();
		}

		public gp_Dir Crossed(gp_Dir Right)
		{
			throw new NotImplementedException();
		}

		public void CrossCross(gp_Dir V1, gp_Dir V2)
		{
			throw new NotImplementedException();
		}

		public gp_Dir CrossCrossed(gp_Dir V1, gp_Dir V2)
		{
			throw new NotImplementedException();
		}

		public double Dot(gp_Dir Other)
		{
			throw new NotImplementedException();
		}

		public double DotCross(gp_Dir V1, gp_Dir V2)
		{
			throw new NotImplementedException();
		}

		public void Reverse()
		{
			throw new NotImplementedException();
		}

		public gp_Dir Reversed()
		{
			throw new NotImplementedException();
		}

		public void Mirror(gp_Dir V)
		{
			throw new NotImplementedException();
		}

		public gp_Dir Mirrored(gp_Dir V)
		{
			throw new NotImplementedException();
		}

		public void Mirror(gp_Ax1 A1)
		{
			throw new NotImplementedException();
		}

		public gp_Dir Mirrored(gp_Ax1 A1)
		{
			throw new NotImplementedException();
		}

		public void Mirror(gp_Ax2 A2)
		{
			throw new NotImplementedException();
		}

		public gp_Dir Mirrored(gp_Ax2 A2)
		{
			throw new NotImplementedException();
		}

		public void Rotate(gp_Ax1 A1, double Ang)
		{
			throw new NotImplementedException();
		}

		public gp_Dir Rotated(gp_Ax1 A1, double Ang)
		{
			throw new NotImplementedException();
		}

		public void Transform(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public gp_Dir Transformed(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

						
	}; // class gp_Dir

}
