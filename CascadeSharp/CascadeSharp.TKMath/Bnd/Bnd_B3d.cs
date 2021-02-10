//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKMath.Bnd
{
	//---------------------------------------------------------------------
	//  Class  Bnd_B3d
	//---------------------------------------------------------------------
	public  sealed class Bnd_B3d
	{

		public Bnd_B3d()
			: base()
		{
			throw new NotImplementedException();
		}

		public Bnd_B3d(gp_XYZ theCenter, gp_XYZ theHSize)
			: base()
		{
			throw new NotImplementedException();
		}

		public Bnd_B3d(Bnd_B3d parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public bool IsVoid()
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void Add(gp_XYZ thePnt)
		{
			throw new NotImplementedException();
		}

		public void Add(gp_Pnt thePnt)
		{
			throw new NotImplementedException();
		}

		public void Add(Bnd_B3d theBox)
		{
			throw new NotImplementedException();
		}

		public gp_XYZ CornerMin()
		{
			throw new NotImplementedException();
		}

		public gp_XYZ CornerMax()
		{
			throw new NotImplementedException();
		}

		public double SquareExtent()
		{
			throw new NotImplementedException();
		}

		public void Enlarge(double theDiff)
		{
			throw new NotImplementedException();
		}

		public bool Limit(Bnd_B3d theOtherBox)
		{
			throw new NotImplementedException();
		}

		public Bnd_B3d Transformed(gp_Trsf theTrsf)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(gp_XYZ thePnt)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(gp_XYZ theCenter, double theRadius, bool _isSphereHollow)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(gp_XYZ theCenter, double theRadius)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(Bnd_B3d theOtherBox)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(Bnd_B3d theOtherBox, gp_Trsf theTrsf)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(gp_Ax1 theLine, bool _isRay, double theOverthickness)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(gp_Ax1 theLine, bool _isRay)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(gp_Ax1 theLine)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(gp_Ax3 thePlane)
		{
			throw new NotImplementedException();
		}

		public bool IsIn(Bnd_B3d theBox)
		{
			throw new NotImplementedException();
		}

		public bool IsIn(Bnd_B3d theBox, gp_Trsf theTrsf)
		{
			throw new NotImplementedException();
		}

		public void SetCenter(gp_XYZ theCenter)
		{
			throw new NotImplementedException();
		}

		public void SetHSize(gp_XYZ theHSize)
		{
			throw new NotImplementedException();
		}


	}; // class Bnd_B3d

}
