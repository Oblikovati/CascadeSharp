//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKService.Aspect;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_RubberBand
	//---------------------------------------------------------------------
	public  sealed class AIS_RubberBand : AIS_InteractiveObject
	{

		public AIS_RubberBand()
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_RubberBand(Quantity_Color theLineColor, Aspect_TypeOfLine theType, double theLineWidth, bool theIsPolygonClosed)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_RubberBand(Quantity_Color theLineColor, Aspect_TypeOfLine theType, double theLineWidth)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_RubberBand(Quantity_Color theLineColor, Aspect_TypeOfLine theType)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_RubberBand(Quantity_Color theLineColor, Aspect_TypeOfLine theType, Quantity_Color theFillColor, double theTransparency, double theLineWidth, bool theIsPolygonClosed)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_RubberBand(Quantity_Color theLineColor, Aspect_TypeOfLine theType, Quantity_Color theFillColor, double theTransparency, double theLineWidth)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_RubberBand(Quantity_Color theLineColor, Aspect_TypeOfLine theType, Quantity_Color theFillColor, double theTransparency)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_RubberBand(Quantity_Color theLineColor, Aspect_TypeOfLine theType, Quantity_Color theFillColor)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_RubberBand(AIS_RubberBand parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void SetRectangle(int theMinX, int theMinY, int theMaxX, int theMaxY)
		{
			throw new NotImplementedException();
		}

		public void AddPoint(Graphic3d_Vec2i thePoint)
		{
			throw new NotImplementedException();
		}

		public void RemoveLastPoint()
		{
			throw new NotImplementedException();
		}

				public void ClearPoints()
		{
			throw new NotImplementedException();
		}

		public Quantity_Color LineColor()
		{
			throw new NotImplementedException();
		}

		public void SetLineColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public Quantity_Color FillColor()
		{
			throw new NotImplementedException();
		}

		public void SetFillColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void SetLineWidth(double theWidth)
		{
			throw new NotImplementedException();
		}

		public double LineWidth()
		{
			throw new NotImplementedException();
		}

		public void SetLineType(Aspect_TypeOfLine theType)
		{
			throw new NotImplementedException();
		}

		public Aspect_TypeOfLine LineType()
		{
			throw new NotImplementedException();
		}

		public void SetFillTransparency(double theValue)
		{
			throw new NotImplementedException();
		}

		public double FillTransparency()
		{
			throw new NotImplementedException();
		}

		public void SetFilling(bool theIsFilling)
		{
			throw new NotImplementedException();
		}

		public void SetFilling(Quantity_Color theColor, double theTransparency)
		{
			throw new NotImplementedException();
		}

		public bool IsFilling()
		{
			throw new NotImplementedException();
		}

		public bool IsPolygonClosed()
		{
			throw new NotImplementedException();
		}

		public void SetPolygonClosed(bool theIsPolygonClosed)
		{
			throw new NotImplementedException();
		}

				public void ComputeSelection(SelectMgr_Selection parameter1, int parameter2)
		{
			throw new NotImplementedException();
		}

		public bool fillTriangles()
		{
			throw new NotImplementedException();
		}


	}; // class AIS_RubberBand

}
