//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKService.Aspect;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKService.Image;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_XRTrackedDevice
	//---------------------------------------------------------------------
	public  sealed class AIS_XRTrackedDevice : AIS_InteractiveObject
	{

		public AIS_XRTrackedDevice(Graphic3d_ArrayOfTriangles theTr_is, Image_Texture theTexture)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_XRTrackedDevice()
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_XRTrackedDevice(AIS_XRTrackedDevice parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public Aspect_XRTrackedDeviceRole Role()
		{
			throw new NotImplementedException();
		}

		public void SetRole(Aspect_XRTrackedDeviceRole theRole)
		{
			throw new NotImplementedException();
		}

		public Quantity_Color LaserColor()
		{
			throw new NotImplementedException();
		}

		public void SetLaserColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public float LaserLength()
		{
			throw new NotImplementedException();
		}

		public void SetLaserLength(float theLength)
		{
			throw new NotImplementedException();
		}

		public float UnitFactor()
		{
			throw new NotImplementedException();
		}

		public void SetUnitFactor(float theFactor)
		{
			throw new NotImplementedException();
		}

		public bool AcceptDisplayMode(int theMode)
		{
			throw new NotImplementedException();
		}

				public void ComputeSelection(SelectMgr_Selection theSel, int theMode)
		{
			throw new NotImplementedException();
		}

		public void computeLaserRay()
		{
			throw new NotImplementedException();
		}


	}; // class AIS_XRTrackedDevice

}
