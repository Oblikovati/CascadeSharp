//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.Prs3d;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_Circle
	//---------------------------------------------------------------------
	public  sealed class AIS_Circle : AIS_InteractiveObject
	{

		public AIS_Circle(Geom_Circle aCircle)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Circle(Geom_Circle theCircle, double theUStart, double theUEnd, bool theIsFilledCircleSens)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Circle(Geom_Circle theCircle, double theUStart, double theUEnd)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Circle(AIS_Circle parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Circle()
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

		public AIS_KindOfInteractive Type()
		{
			throw new NotImplementedException();
		}

		public Geom_Circle Circle()
		{
			throw new NotImplementedException();
		}

		public void Parameters(ref double theU1, ref double theU2)
		{
			throw new NotImplementedException();
		}

		public void SetCircle(Geom_Circle theCircle)
		{
			throw new NotImplementedException();
		}

		public void SetFirstParam(double theU)
		{
			throw new NotImplementedException();
		}

		public void SetLastParam(double theU)
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

		public bool IsFilledCircleSens()
		{
			throw new NotImplementedException();
		}

		public void SetFilledCircleSens(bool theIsFilledCircleSens)
		{
			throw new NotImplementedException();
		}

						public void ComputeSelection(SelectMgr_Selection aSelection, int aMode)
		{
			throw new NotImplementedException();
		}

		public void ComputeCircle(Graphic3d_Structure aPresentation)
		{
			throw new NotImplementedException();
		}

		public void ComputeArc(Graphic3d_Structure aPresentation)
		{
			throw new NotImplementedException();
		}

		public void ComputeCircleSelection(SelectMgr_Selection aSelection)
		{
			throw new NotImplementedException();
		}

		public void ComputeArcSelection(SelectMgr_Selection aSelection)
		{
			throw new NotImplementedException();
		}

		public void replaceWithNewLineAspect(Prs3d_LineAspect theAspect)
		{
			throw new NotImplementedException();
		}


	}; // class AIS_Circle

}
