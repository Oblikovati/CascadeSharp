//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Geom_Axis2Placement
	//---------------------------------------------------------------------
	public  sealed class Geom_Axis2Placement : CascadeSharp.Geom_AxisPlacement
	{

		public Geom_Axis2Placement(gp_Ax2 A2)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Axis2Placement(gp_Pnt P, gp_Dir N, gp_Dir Vx)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Axis2Placement(gp_Pnt P, gp_Dir Vz, gp_Dir Vx, gp_Dir Vy)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Axis2Placement(Geom_Axis2Placement parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Axis2Placement()
		{
			throw new NotImplementedException();
		}

		public void SetAx2(gp_Ax2 A2)
		{
			throw new NotImplementedException();
		}

		public void SetDirection(gp_Dir V)
		{
			throw new NotImplementedException();
		}

		public void SetXDirection(gp_Dir Vx)
		{
			throw new NotImplementedException();
		}

		public void SetYDirection(gp_Dir Vy)
		{
			throw new NotImplementedException();
		}

		public gp_Ax2 Ax2()
		{
			throw new NotImplementedException();
		}

		public gp_Dir XDirection()
		{
			throw new NotImplementedException();
		}

		public gp_Dir YDirection()
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

				
	}; // class Geom_Axis2Placement

}
