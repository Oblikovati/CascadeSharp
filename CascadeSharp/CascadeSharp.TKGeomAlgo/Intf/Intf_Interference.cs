//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKGeomAlgo.Intf
{
	//---------------------------------------------------------------------
	//  Class  Intf_Interference
	//---------------------------------------------------------------------
	public  class Intf_Interference
	{

		public Intf_Interference(bool Self)
			: base()
		{
			throw new NotImplementedException();
		}

		public Intf_Interference(Intf_Interference parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Intf_Interference()
		{
			throw new NotImplementedException();
		}

		public int NbSectionPoints()
		{
			throw new NotImplementedException();
		}

		public Intf_SectionPoint PntValue(int Index)
		{
			throw new NotImplementedException();
		}

		public int NbSectionLines()
		{
			throw new NotImplementedException();
		}

		public Intf_SectionLine LineValue(int Index)
		{
			throw new NotImplementedException();
		}

		public int NbTangentZones()
		{
			throw new NotImplementedException();
		}

		public Intf_TangentZone ZoneValue(int Index)
		{
			throw new NotImplementedException();
		}

		public double GetTolerance()
		{
			throw new NotImplementedException();
		}

		public bool Contains(Intf_SectionPoint ThePnt)
		{
			throw new NotImplementedException();
		}

		public bool Insert(Intf_TangentZone TheZone)
		{
			throw new NotImplementedException();
		}

		public void Insert(Intf_SectionPoint pdeb, Intf_SectionPoint pfin)
		{
			throw new NotImplementedException();
		}

		public void Dump()
		{
			throw new NotImplementedException();
		}

		public void SelfInterference(bool Self)
		{
			throw new NotImplementedException();
		}


	}; // class Intf_Interference

}
