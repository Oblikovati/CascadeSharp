//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  StdFail_Undefined
	//---------------------------------------------------------------------
	public  sealed class StdFail_Undefined : CascadeSharp.Standard_Failure
	{

		public StdFail_Undefined()
			: base()
		{
			throw new NotImplementedException();
		}

		public StdFail_Undefined(string theMessage)
			: base()
		{
			throw new NotImplementedException();
		}

		public StdFail_Undefined(StdFail_Undefined parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Throw()
		{
			throw new NotImplementedException();
		}

		public void Raise(string theMessage)
		{
			throw new NotImplementedException();
		}

		public void Raise()
		{
			throw new NotImplementedException();
		}

				public StdFail_Undefined NewInstance(string theMessage)
		{
			throw new NotImplementedException();
		}

		public StdFail_Undefined NewInstance()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class StdFail_Undefined

}
