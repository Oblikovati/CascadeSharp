//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Aspect_OpenVRSession
	//---------------------------------------------------------------------
	public  sealed class Aspect_OpenVRSession : CascadeSharp.Aspect_XRSession
	{

		public Aspect_OpenVRSession()
			: base()
		{
			throw new NotImplementedException();
		}

		public Aspect_OpenVRSession(Aspect_OpenVRSession parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IsHmdPresent()
		{
			throw new NotImplementedException();
		}

		public bool IsOpen()
		{
			throw new NotImplementedException();
		}

		public bool Open()
		{
			throw new NotImplementedException();
		}

		public void Close()
		{
			throw new NotImplementedException();
		}

		public bool WaitPoses()
		{
			throw new NotImplementedException();
		}

								public bool HasProjectionFrustums()
		{
			throw new NotImplementedException();
		}

		public void ProcessEvents()
		{
			throw new NotImplementedException();
		}

		public bool SubmitEye(IntPtr theTexture, CascadeSharp.Aspect_GraphicsLibrary theGraphicsLib, CascadeSharp.Aspect_ColorSpace theColorSpace, CascadeSharp.Aspect_Eye theEye)
		{
			throw new NotImplementedException();
		}

				public int NamedTrackedDevice(CascadeSharp.Aspect_XRTrackedDeviceRole theDevice)
		{
			throw new NotImplementedException();
		}

		public Aspect_XRDigitalActionData GetDigitalActionData(Aspect_XRAction theAction)
		{
			throw new NotImplementedException();
		}

		public Aspect_XRAnalogActionData GetAnalogActionData(Aspect_XRAction theAction)
		{
			throw new NotImplementedException();
		}

		public Aspect_XRPoseActionData GetPoseActionDataForNextFrame(Aspect_XRAction theAction)
		{
			throw new NotImplementedException();
		}

				public TCollection_AsciiString defaultActionsManifest()
		{
			throw new NotImplementedException();
		}

		public void closeVR()
		{
			throw new NotImplementedException();
		}

		public void updateProjectionFrustums()
		{
			throw new NotImplementedException();
		}

		public bool initInput()
		{
			throw new NotImplementedException();
		}

		public void onTrackedDeviceActivated(int theDeviceIndex)
		{
			throw new NotImplementedException();
		}

		public void onTrackedDeviceDeactivated(int theDeviceIndex)
		{
			throw new NotImplementedException();
		}

		public void onTrackedDeviceUpdated(int theDeviceIndex)
		{
			throw new NotImplementedException();
		}

		public void triggerHapticVibrationAction(Aspect_XRAction theAction, Aspect_XRHapticActionData theParams)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_ArrayOfTriangles loadRenderModel(int theDevice, bool theToApplyUnitFactor, Image_Texture theTexture)
		{
			throw new NotImplementedException();
		}

		public IntPtr getVRSystem()
		{
			throw new NotImplementedException();
		}


	}; // class Aspect_OpenVRSession

}
