//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_ValueInterface
	//---------------------------------------------------------------------
	public  abstract class Graphic3d_ValueInterface
	{

		public Graphic3d_ValueInterface(Graphic3d_ValueInterface parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_ValueInterface()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public ulong TypeID()
		{
			throw new NotImplementedException();
		}


	}; // class Graphic3d_ValueInterface

}
