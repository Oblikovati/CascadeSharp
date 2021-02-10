//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ShapeAnalysis_FreeBoundData
	//---------------------------------------------------------------------
	public  sealed class ShapeAnalysis_FreeBoundData : Standard_Transient
	{

		public ShapeAnalysis_FreeBoundData()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_FreeBoundData(TopoDS_Wire freebound)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_FreeBoundData(ShapeAnalysis_FreeBoundData parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void SetFreeBound(TopoDS_Wire freebound)
		{
			throw new NotImplementedException();
		}

		public void SetArea(double area)
		{
			throw new NotImplementedException();
		}

		public void SetPerimeter(double perimeter)
		{
			throw new NotImplementedException();
		}

		public void SetRatio(double ratio)
		{
			throw new NotImplementedException();
		}

		public void SetWidth(double width)
		{
			throw new NotImplementedException();
		}

		public void AddNotch(TopoDS_Wire notch, double width)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire FreeBound()
		{
			throw new NotImplementedException();
		}

		public double Area()
		{
			throw new NotImplementedException();
		}

		public double Perimeter()
		{
			throw new NotImplementedException();
		}

		public double Ratio()
		{
			throw new NotImplementedException();
		}

		public double Width()
		{
			throw new NotImplementedException();
		}

		public int NbNotches()
		{
			throw new NotImplementedException();
		}

		public TopTools_HSequenceOfShape Notches()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire Notch(int index)
		{
			throw new NotImplementedException();
		}

		public double NotchWidth(int index)
		{
			throw new NotImplementedException();
		}

		public double NotchWidth(TopoDS_Wire notch)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class ShapeAnalysis_FreeBoundData

}
