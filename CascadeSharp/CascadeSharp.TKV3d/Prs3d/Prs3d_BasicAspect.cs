//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKV3d.Prs3d
{
	//---------------------------------------------------------------------
	//  Class  Prs3d_BasicAspect
	//---------------------------------------------------------------------
	public  abstract class Prs3d_BasicAspect : Standard_Transient
	{

		public Prs3d_BasicAspect(Prs3d_BasicAspect parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Prs3d_BasicAspect()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

								
	}; // class Prs3d_BasicAspect

}
