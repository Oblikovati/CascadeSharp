//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKernel.Units
{
	//---------------------------------------------------------------------
	//  Class  Units_Quantity
	//---------------------------------------------------------------------
	public  sealed class Units_Quantity : Standard_Transient
	{

		public Units_Quantity(string aname, Units_Dimensions adimensions, Units_UnitsSequence aunitssequence)
			: base()
		{
			throw new NotImplementedException();
		}

		public Units_Quantity(Units_Quantity parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Units_Quantity()
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString Name()
		{
			throw new NotImplementedException();
		}

		public Units_Dimensions Dimensions()
		{
			throw new NotImplementedException();
		}

		public Units_UnitsSequence Sequence()
		{
			throw new NotImplementedException();
		}

		public bool IsEqual(string astring)
		{
			throw new NotImplementedException();
		}

		public void Dump(int ashift, int alevel)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Units_Quantity

}
