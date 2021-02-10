//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKService.Graphic3d
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_DataStructureManager
	//---------------------------------------------------------------------
	public  abstract class Graphic3d_DataStructureManager : Standard_Transient
	{

		public Graphic3d_DataStructureManager()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_DataStructureManager(Graphic3d_DataStructureManager parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public Graphic3d_Camera Camera()
		{
			throw new NotImplementedException();
		}

				
	}; // class Graphic3d_DataStructureManager

}
