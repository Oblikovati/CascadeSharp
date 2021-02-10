//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_Plane
	//---------------------------------------------------------------------
	public  sealed class AIS_Plane : AIS_InteractiveObject
	{

		public AIS_Plane(Geom_Plane aComponent, bool aCurrentMode)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Plane(Geom_Plane aComponent)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Plane(Geom_Plane aComponent, gp_Pnt aCenter, bool aCurrentMode)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Plane(Geom_Plane aComponent, gp_Pnt aCenter)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Plane(Geom_Plane aComponent, gp_Pnt aCenter, gp_Pnt aPmin, gp_Pnt aPmax, bool aCurrentMode)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Plane(Geom_Plane aComponent, gp_Pnt aCenter, gp_Pnt aPmin, gp_Pnt aPmax)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Plane(Geom_Axis2Placement aComponent, AIS_TypeOfPlane aPlaneType, bool aCurrentMode)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Plane(Geom_Axis2Placement aComponent, AIS_TypeOfPlane aPlaneType)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Plane(AIS_Plane parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Plane()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void SetSize(double aValue)
		{
			throw new NotImplementedException();
		}

		public void SetSize(double Xval, double YVal)
		{
			throw new NotImplementedException();
		}

		public void UnsetSize()
		{
			throw new NotImplementedException();
		}

		public bool Size(ref double X, ref double Y)
		{
			throw new NotImplementedException();
		}

		public bool HasOwnSize()
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

		public Geom_Plane Component()
		{
			throw new NotImplementedException();
		}

		public void SetComponent(Geom_Plane aComponent)
		{
			throw new NotImplementedException();
		}

		public bool PlaneAttributes(Geom_Plane aComponent, gp_Pnt aCenter, gp_Pnt aPmin, gp_Pnt aPmax)
		{
			throw new NotImplementedException();
		}

		public void SetPlaneAttributes(Geom_Plane aComponent, gp_Pnt aCenter, gp_Pnt aPmin, gp_Pnt aPmax)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Center()
		{
			throw new NotImplementedException();
		}

		public void SetCenter(gp_Pnt theCenter)
		{
			throw new NotImplementedException();
		}

		public void SetAxis2Placement(Geom_Axis2Placement aComponent, AIS_TypeOfPlane aPlaneType)
		{
			throw new NotImplementedException();
		}

		public Geom_Axis2Placement Axis2Placement()
		{
			throw new NotImplementedException();
		}

		public AIS_TypeOfPlane TypeOfPlane()
		{
			throw new NotImplementedException();
		}

		public bool IsXYZPlane()
		{
			throw new NotImplementedException();
		}

		public bool CurrentMode()
		{
			throw new NotImplementedException();
		}

		public void SetCurrentMode(bool theCurrentMode)
		{
			throw new NotImplementedException();
		}

		public bool AcceptDisplayMode(int aMode)
		{
			throw new NotImplementedException();
		}

		public void SetContext(AIS_InteractiveContext aCtx)
		{
			throw new NotImplementedException();
		}

						public void ComputeSelection(SelectMgr_Selection theSelection, int theMode)
		{
			throw new NotImplementedException();
		}

		public void SetColor(Quantity_Color aColor)
		{
			throw new NotImplementedException();
		}

		public void UnsetColor()
		{
			throw new NotImplementedException();
		}

						public void ComputeFrame()
		{
			throw new NotImplementedException();
		}

		public void ComputeFields()
		{
			throw new NotImplementedException();
		}

		public void InitDrawerAttributes()
		{
			throw new NotImplementedException();
		}


	}; // class AIS_Plane

}
