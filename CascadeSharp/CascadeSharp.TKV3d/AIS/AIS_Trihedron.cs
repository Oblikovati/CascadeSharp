//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.Prs3d;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_Trihedron
	//---------------------------------------------------------------------
	public  sealed class AIS_Trihedron : AIS_InteractiveObject
	{

		public AIS_Trihedron(Geom_Axis2Placement theComponent)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Trihedron(AIS_Trihedron parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Trihedron()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void SetDatumDisplayMode(Prs3d_DatumMode theMode)
		{
			throw new NotImplementedException();
		}

		public Prs3d_DatumMode DatumDisplayMode()
		{
			throw new NotImplementedException();
		}

		public Geom_Axis2Placement Component()
		{
			throw new NotImplementedException();
		}

		public void SetComponent(Geom_Axis2Placement theComponent)
		{
			throw new NotImplementedException();
		}

		public bool HasOwnSize()
		{
			throw new NotImplementedException();
		}

		public void SetSize(double theValue)
		{
			throw new NotImplementedException();
		}

		public void UnsetSize()
		{
			throw new NotImplementedException();
		}

		public double Size()
		{
			throw new NotImplementedException();
		}

		public bool AcceptDisplayMode(int theMode)
		{
			throw new NotImplementedException();
		}

		public int Signature()
		{
			throw new NotImplementedException();
		}

		public AIS_KindOfInteractive Type()
		{
			throw new NotImplementedException();
		}

		public void SetColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void SetTextColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public bool HasTextColor()
		{
			throw new NotImplementedException();
		}

		public Quantity_Color TextColor()
		{
			throw new NotImplementedException();
		}

		public void SetArrowColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public bool HasArrowColor()
		{
			throw new NotImplementedException();
		}

		public Quantity_Color ArrowColor()
		{
			throw new NotImplementedException();
		}

		public void UnsetColor()
		{
			throw new NotImplementedException();
		}

		public void SetDatumPartColor(Prs3d_DatumParts thePart, Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public Quantity_Color DatumPartColor(Prs3d_DatumParts thePart)
		{
			throw new NotImplementedException();
		}

		public void SetOriginColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void SetXAxisColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void SetYAxisColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void SetAxisColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public bool ToDrawArrows()
		{
			throw new NotImplementedException();
		}

		public void SetDrawArrows(bool theToDraw)
		{
			throw new NotImplementedException();
		}

		public void SetSelectionPriority(Prs3d_DatumParts thePart, int thePriority)
		{
			throw new NotImplementedException();
		}

		public int SelectionPriority(Prs3d_DatumParts thePart)
		{
			throw new NotImplementedException();
		}

		public void SetLabel(Prs3d_DatumParts thePart, TCollection_ExtendedString thePriority)
		{
			throw new NotImplementedException();
		}

		public TCollection_ExtendedString Label(Prs3d_DatumParts thePart)
		{
			throw new NotImplementedException();
		}

		public void ClearSelected()
		{
			throw new NotImplementedException();
		}

								public void ComputeSelection(SelectMgr_Selection theSelection, int theMode)
		{
			throw new NotImplementedException();
		}

										public void setOwnDatumAspect()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_ArrayOfPrimitives arrayOfPrimitives(Prs3d_DatumParts thePart)
		{
			throw new NotImplementedException();
		}

		public void updatePrimitives(Prs3d_DatumAspect theAspect, Prs3d_DatumMode theMode, gp_Pnt theOrigin, gp_Dir theXDir, gp_Dir theYDir, gp_Dir theZDir)
		{
			throw new NotImplementedException();
		}


	}; // class AIS_Trihedron

}
