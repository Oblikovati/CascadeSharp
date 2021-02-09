//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Geom_ElementarySurface
	//---------------------------------------------------------------------
	public  abstract class Geom_ElementarySurface : CascadeSharp.Geom_Surface
	{

		public Geom_ElementarySurface()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Geom_ElementarySurface(Geom_ElementarySurface parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void SetAxis(gp_Ax1 theA1)
		{
			throw new NotImplementedException();
		}

		public void SetLocation(gp_Pnt theLoc)
		{
			throw new NotImplementedException();
		}

		public void SetPosition(gp_Ax3 theAx3)
		{
			throw new NotImplementedException();
		}

		public gp_Ax1 Axis()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Location()
		{
			throw new NotImplementedException();
		}

		public gp_Ax3 Position()
		{
			throw new NotImplementedException();
		}

		public void UReverse()
		{
			throw new NotImplementedException();
		}

		public double UReversedParameter(double U)
		{
			throw new NotImplementedException();
		}

		public void VReverse()
		{
			throw new NotImplementedException();
		}

		public double VReversedParameter(double V)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public bool IsCNu(int N)
		{
			throw new NotImplementedException();
		}

		public bool IsCNv(int N)
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Geom_ElementarySurface

}
