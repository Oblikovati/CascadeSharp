//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  AIS_Axis
	//---------------------------------------------------------------------
	public  sealed class AIS_Axis : CascadeSharp.AIS_InteractiveObject
	{

		public AIS_Axis(Geom_Line aComponent)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Axis(Geom_Axis2Placement aComponent, CascadeSharp.AIS_TypeOfAxis anAx_isType)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Axis(Geom_Axis1Placement anAx_is)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Axis(AIS_Axis parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Axis()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public Geom_Line Component()
		{
			throw new NotImplementedException();
		}

		public void SetComponent(Geom_Line aComponent)
		{
			throw new NotImplementedException();
		}

		public Geom_Axis2Placement Axis2Placement()
		{
			throw new NotImplementedException();
		}

		public void SetAxis2Placement(Geom_Axis2Placement aComponent, CascadeSharp.AIS_TypeOfAxis anAx_isType)
		{
			throw new NotImplementedException();
		}

		public void SetAxis1Placement(Geom_Axis1Placement anAx_is)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.AIS_TypeOfAxis TypeOfAxis()
		{
			throw new NotImplementedException();
		}

		public void SetTypeOfAxis(CascadeSharp.AIS_TypeOfAxis theTypeAx_is)
		{
			throw new NotImplementedException();
		}

		public bool IsXYZAxis()
		{
			throw new NotImplementedException();
		}

		public bool AcceptDisplayMode(int aMode)
		{
			throw new NotImplementedException();
		}

		public int Signature()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.AIS_KindOfInteractive Type()
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

		public void ComputeFields()
		{
			throw new NotImplementedException();
		}


	}; // class AIS_Axis

}
