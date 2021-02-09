//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Bnd_Box2d
	//---------------------------------------------------------------------
	public  sealed class Bnd_Box2d
	{

		public Bnd_Box2d()
			: base()
		{
			throw new NotImplementedException();
		}

		public Bnd_Box2d(Bnd_Box2d parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetWhole()
		{
			throw new NotImplementedException();
		}

		public void SetVoid()
		{
			throw new NotImplementedException();
		}

		public void Set(gp_Pnt2d thePnt)
		{
			throw new NotImplementedException();
		}

		public void Set(gp_Pnt2d thePnt, gp_Dir2d theDir)
		{
			throw new NotImplementedException();
		}

		public void Update(double aXmin, double aYmin, double aXmax, double aYmax)
		{
			throw new NotImplementedException();
		}

		public void Update(double X, double Y)
		{
			throw new NotImplementedException();
		}

		public double GetGap()
		{
			throw new NotImplementedException();
		}

		public void SetGap(double Tol)
		{
			throw new NotImplementedException();
		}

		public void Enlarge(double theTol)
		{
			throw new NotImplementedException();
		}

		public void Get(ref double aXmin, ref double aYmin, ref double aXmax, ref double aYmax)
		{
			throw new NotImplementedException();
		}

		public void OpenXmin()
		{
			throw new NotImplementedException();
		}

		public void OpenXmax()
		{
			throw new NotImplementedException();
		}

		public void OpenYmin()
		{
			throw new NotImplementedException();
		}

		public void OpenYmax()
		{
			throw new NotImplementedException();
		}

		public bool IsOpenXmin()
		{
			throw new NotImplementedException();
		}

		public bool IsOpenXmax()
		{
			throw new NotImplementedException();
		}

		public bool IsOpenYmin()
		{
			throw new NotImplementedException();
		}

		public bool IsOpenYmax()
		{
			throw new NotImplementedException();
		}

		public bool IsWhole()
		{
			throw new NotImplementedException();
		}

		public bool IsVoid()
		{
			throw new NotImplementedException();
		}

		public Bnd_Box2d Transformed(gp_Trsf2d T)
		{
			throw new NotImplementedException();
		}

		public void Add(Bnd_Box2d Other)
		{
			throw new NotImplementedException();
		}

		public void Add(gp_Pnt2d thePnt)
		{
			throw new NotImplementedException();
		}

		public void Add(gp_Pnt2d thePnt, gp_Dir2d theDir)
		{
			throw new NotImplementedException();
		}

		public void Add(gp_Dir2d D)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(Bnd_Box2d Other)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(Bnd_Box2d theOther, gp_Trsf2d theTrsf)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(gp_Trsf2d T1, Bnd_Box2d Other, gp_Trsf2d T2)
		{
			throw new NotImplementedException();
		}

		public void Dump()
		{
			throw new NotImplementedException();
		}

		public double SquareExtent()
		{
			throw new NotImplementedException();
		}


		//---------------------------------------------------------------------
		//  Enum  MaskFlags
		//---------------------------------------------------------------------
		public		enum MaskFlags
		{
			VoidMask = 1,
			XminMask = 2,
			XmaxMask = 4,
			YminMask = 8,
			YmaxMask = 16,
			WholeMask = 30
		} // enum  class MaskFlags

	}; // class Bnd_Box2d

}
