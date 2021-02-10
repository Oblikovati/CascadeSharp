//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ShapeAnalysis_FreeBoundsProperties
	//---------------------------------------------------------------------
	public  sealed class ShapeAnalysis_FreeBoundsProperties
	{

		public ShapeAnalysis_FreeBoundsProperties()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_FreeBoundsProperties(TopoDS_Shape shape, double tolerance, bool splitclosed, bool splitopen)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_FreeBoundsProperties(TopoDS_Shape shape, double tolerance, bool splitclosed)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_FreeBoundsProperties(TopoDS_Shape shape, double tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_FreeBoundsProperties(TopoDS_Shape shape, bool splitclosed, bool splitopen)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_FreeBoundsProperties(TopoDS_Shape shape, bool splitclosed)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_FreeBoundsProperties(TopoDS_Shape shape)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_FreeBoundsProperties(ShapeAnalysis_FreeBoundsProperties parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape shape, double tolerance, bool splitclosed, bool splitopen)
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape shape, double tolerance, bool splitclosed)
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape shape, double tolerance)
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape shape, bool splitclosed, bool splitopen)
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape shape, bool splitclosed)
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public bool Perform()
		{
			throw new NotImplementedException();
		}

		public bool IsLoaded()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public double Tolerance()
		{
			throw new NotImplementedException();
		}

		public int NbFreeBounds()
		{
			throw new NotImplementedException();
		}

		public int NbClosedFreeBounds()
		{
			throw new NotImplementedException();
		}

		public int NbOpenFreeBounds()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_HSequenceOfFreeBounds ClosedFreeBounds()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_HSequenceOfFreeBounds OpenFreeBounds()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_FreeBoundData ClosedFreeBound(int index)
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_FreeBoundData OpenFreeBound(int index)
		{
			throw new NotImplementedException();
		}

		public bool DispatchBounds()
		{
			throw new NotImplementedException();
		}

		public bool CheckContours(double prec)
		{
			throw new NotImplementedException();
		}

		public bool CheckContours()
		{
			throw new NotImplementedException();
		}

		public bool CheckNotches(double prec)
		{
			throw new NotImplementedException();
		}

		public bool CheckNotches()
		{
			throw new NotImplementedException();
		}

		public bool CheckNotches(ShapeAnalysis_FreeBoundData fbData, double prec)
		{
			throw new NotImplementedException();
		}

		public bool CheckNotches(ShapeAnalysis_FreeBoundData fbData)
		{
			throw new NotImplementedException();
		}

		public bool CheckNotches(TopoDS_Wire freebound, int num, TopoDS_Wire notch, ref double d_istMax, double prec)
		{
			throw new NotImplementedException();
		}

		public bool CheckNotches(TopoDS_Wire freebound, int num, TopoDS_Wire notch, ref double d_istMax)
		{
			throw new NotImplementedException();
		}

		public bool FillProperties(ShapeAnalysis_FreeBoundData fbData, double prec)
		{
			throw new NotImplementedException();
		}

		public bool FillProperties(ShapeAnalysis_FreeBoundData fbData)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeAnalysis_FreeBoundsProperties

}
