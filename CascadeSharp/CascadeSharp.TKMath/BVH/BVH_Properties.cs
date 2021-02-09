//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BVH_Properties
	//---------------------------------------------------------------------
	public  abstract class BVH_Properties : Standard_Transient
	{

		public BVH_Properties(BVH_Properties parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BVH_Properties()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BVH_Properties

}
