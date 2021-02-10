//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKernel.TColStd;

namespace CascadeSharp.TKernel.Units
{
	//---------------------------------------------------------------------
	//  Class  Units_UnitsSystem
	//---------------------------------------------------------------------
	public  sealed class Units_UnitsSystem : Standard_Transient
	{

		public Units_UnitsSystem()
			: base()
		{
			throw new NotImplementedException();
		}

		public Units_UnitsSystem(string aName, bool Verbose)
			: base()
		{
			throw new NotImplementedException();
		}

		public Units_UnitsSystem(string aName)
			: base()
		{
			throw new NotImplementedException();
		}

		public Units_UnitsSystem(Units_UnitsSystem parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Units_QuantitiesSequence QuantitiesSequence()
		{
			throw new NotImplementedException();
		}

		public TColStd_HSequenceOfInteger ActiveUnitsSequence()
		{
			throw new NotImplementedException();
		}

		public void Specify(string aquantity, string aunit)
		{
			throw new NotImplementedException();
		}

		public void Remove(string aquantity, string aunit)
		{
			throw new NotImplementedException();
		}

		public void Activate(string aquantity, string aunit)
		{
			throw new NotImplementedException();
		}

		public void Activates()
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString ActiveUnit(string aquantity)
		{
			throw new NotImplementedException();
		}

		public double ConvertValueToUserSystem(string aquantity, double avalue, string aunit)
		{
			throw new NotImplementedException();
		}

		public double ConvertSIValueToUserSystem(string aquantity, double avalue)
		{
			throw new NotImplementedException();
		}

		public double ConvertUserSystemValueToSI(string aquantity, double avalue)
		{
			throw new NotImplementedException();
		}

		public void Dump()
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Units_UnitsSystem

}
