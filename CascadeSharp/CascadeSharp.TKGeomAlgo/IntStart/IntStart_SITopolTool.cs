//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  IntStart_SITopolTool
	//---------------------------------------------------------------------
	public  abstract class IntStart_SITopolTool : Standard_Transient
	{

		public IntStart_SITopolTool(IntStart_SITopolTool parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public IntStart_SITopolTool()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public CascadeSharp.TopAbs_State Classify(gp_Pnt2d P, double Tol)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class IntStart_SITopolTool

}
