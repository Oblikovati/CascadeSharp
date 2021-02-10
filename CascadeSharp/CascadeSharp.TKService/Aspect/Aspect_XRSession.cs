//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKService.Image;

namespace CascadeSharp.TKService.Aspect
{
    //---------------------------------------------------------------------
    //  Class  Aspect_XRSession
    //---------------------------------------------------------------------
    public abstract class Aspect_XRSession : Standard_Transient
    {
        public Aspect_XRSession()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Aspect_XRSession(Aspect_XRSession parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
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

        public bool SubmitEye(IntPtr theTexture, Aspect_GraphicsLibrary theGraphicsLib, Aspect_ColorSpace theColorSpace,
            Aspect_Eye theEye)
        {
            throw new NotImplementedException();
        }

        public double UnitFactor()
        {
            throw new NotImplementedException();
        }

        public void SetUnitFactor(double theFactor)
        {
            throw new NotImplementedException();
        }

        public double Aspect()
        {
            throw new NotImplementedException();
        }

        public double FieldOfView()
        {
            throw new NotImplementedException();
        }

        public double IOD()
        {
            throw new NotImplementedException();
        }

        public float DisplayFrequency()
        {
            throw new NotImplementedException();
        }

        public gp_Trsf HeadPose()
        {
            throw new NotImplementedException();
        }

        public gp_Trsf LeftHandPose()
        {
            throw new NotImplementedException();
        }

        public gp_Trsf RightHandPose()
        {
            throw new NotImplementedException();
        }

        public Aspect_TrackedDevicePoseArray TrackedPoses()
        {
            throw new NotImplementedException();
        }

        public bool HasTrackedPose(int theDevice)
        {
            throw new NotImplementedException();
        }

        public int NamedTrackedDevice(Aspect_XRTrackedDeviceRole theDevice)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ArrayOfTriangles LoadRenderModel(int theDevice, Image_Texture theTexture)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ArrayOfTriangles LoadRenderModel(int theDevice, bool theToApplyUnitFactor,
            Image_Texture theTexture)
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

        public void TriggerHapticVibrationAction(Aspect_XRAction theAction, Aspect_XRHapticActionData theParams)
        {
            throw new NotImplementedException();
        }

        public void AbortHapticVibrationAction(Aspect_XRAction theAction)
        {
            throw new NotImplementedException();
        }

        public TrackingUniverseOrigin TrackingOrigin()
        {
            throw new NotImplementedException();
        }

        public void SetTrackingOrigin(TrackingUniverseOrigin theOrigin)
        {
            throw new NotImplementedException();
        }

        public Aspect_XRAction GenericAction(Aspect_XRTrackedDeviceRole theDevice, Aspect_XRGenericAction theAction)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString GetString(InfoString theInfo)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ArrayOfTriangles loadRenderModel(int theDevice, bool theToApplyUnitFactor,
            Image_Texture theTexture)
        {
            throw new NotImplementedException();
        }

        public void triggerHapticVibrationAction(Aspect_XRAction theAction, Aspect_XRHapticActionData theParams)
        {
            throw new NotImplementedException();
        }


        //---------------------------------------------------------------------
        //  Enum  TrackingUniverseOrigin
        //---------------------------------------------------------------------
        public enum TrackingUniverseOrigin
        {
            TrackingUniverseOrigin_Seated = 0,
            TrackingUniverseOrigin_Standing = 1
        } // enum  class TrackingUniverseOrigin

        //---------------------------------------------------------------------
        //  Enum  InfoString
        //---------------------------------------------------------------------
        public enum InfoString
        {
            InfoString_Vendor = 0,
            InfoString_Device = 1,
            InfoString_Tracker = 2,
            InfoString_SerialNumber = 3
        } // enum  class InfoString
    }; // class Aspect_XRSession
}