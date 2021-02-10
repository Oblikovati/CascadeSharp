//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Intf_TangentZone
	//---------------------------------------------------------------------
	public  sealed class Intf_TangentZone
	{

		public Intf_TangentZone()
			: base()
		{
			throw new NotImplementedException();
		}

		public Intf_TangentZone(Intf_TangentZone parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public int NumberOfPoints()
		{
			throw new NotImplementedException();
		}

		public Intf_SectionPoint GetPoint(int Index)
		{
			throw new NotImplementedException();
		}

		public bool IsEqual(Intf_TangentZone Other)
		{
			throw new NotImplementedException();
		}

		public bool Contains(Intf_SectionPoint ThePI)
		{
			throw new NotImplementedException();
		}

		public void ParamOnFirst(ref double paraMin, ref double paraMax)
		{
			throw new NotImplementedException();
		}

		public void ParamOnSecond(ref double paraMin, ref double paraMax)
		{
			throw new NotImplementedException();
		}

		public void InfoFirst(ref int segMin, ref double paraMin, ref int segMax, ref double paraMax)
		{
			throw new NotImplementedException();
		}

		public void InfoSecond(ref int segMin, ref double paraMin, ref int segMax, ref double paraMax)
		{
			throw new NotImplementedException();
		}

		public bool RangeContains(Intf_SectionPoint ThePI)
		{
			throw new NotImplementedException();
		}

		public bool HasCommonRange(Intf_TangentZone Other)
		{
			throw new NotImplementedException();
		}

		public void Append(Intf_SectionPoint Pi)
		{
			throw new NotImplementedException();
		}

		public void Append(Intf_TangentZone Tzi)
		{
			throw new NotImplementedException();
		}

		public bool Insert(Intf_SectionPoint Pi)
		{
			throw new NotImplementedException();
		}

		public void PolygonInsert(Intf_SectionPoint Pi)
		{
			throw new NotImplementedException();
		}

		public void InsertBefore(int Index, Intf_SectionPoint Pi)
		{
			throw new NotImplementedException();
		}

		public void InsertAfter(int Index, Intf_SectionPoint Pi)
		{
			throw new NotImplementedException();
		}

		public void Dump(int Indent)
		{
			throw new NotImplementedException();
		}


	}; // class Intf_TangentZone

}
