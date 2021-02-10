//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  AIS_Line
	//---------------------------------------------------------------------
	public  sealed class AIS_Line : CascadeSharp.AIS_InteractiveObject
	{

		public AIS_Line(Geom_Line aLine)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Line(Geom_Point aStartPoint, Geom_Point aEndPoint)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Line(AIS_Line parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Line()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public int Signature()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.AIS_KindOfInteractive Type()
		{
			throw new NotImplementedException();
		}

		public Geom_Line Line()
		{
			throw new NotImplementedException();
		}

		public void Points(Geom_Point thePStart, Geom_Point thePEnd)
		{
			throw new NotImplementedException();
		}

		public void SetLine(Geom_Line theLine)
		{
			throw new NotImplementedException();
		}

		public void SetPoints(Geom_Point thePStart, Geom_Point thePEnd)
		{
			throw new NotImplementedException();
		}

		public void SetColor(Quantity_Color aColor)
		{
			throw new NotImplementedException();
		}

		public void SetWidth(double aValue)
		{
			throw new NotImplementedException();
		}

		public void UnsetColor()
		{
			throw new NotImplementedException();
		}

		public void UnsetWidth()
		{
			throw new NotImplementedException();
		}

						public void ComputeSelection(SelectMgr_Selection aSelection, int aMode)
		{
			throw new NotImplementedException();
		}

		public void ComputeInfiniteLine(Graphic3d_Structure aPresentation)
		{
			throw new NotImplementedException();
		}

		public void ComputeSegmentLine(Graphic3d_Structure aPresentation)
		{
			throw new NotImplementedException();
		}

		public void ComputeInfiniteLineSelection(SelectMgr_Selection aSelection)
		{
			throw new NotImplementedException();
		}

		public void ComputeSegmentLineSelection(SelectMgr_Selection aSelection)
		{
			throw new NotImplementedException();
		}

		public void replaceWithNewLineAspect(Prs3d_LineAspect theAspect)
		{
			throw new NotImplementedException();
		}


	}; // class AIS_Line

}
