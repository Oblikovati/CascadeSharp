//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKService.Graphic3d
{
    //---------------------------------------------------------------------
    //  Class  Graphic3d_Camera
    //---------------------------------------------------------------------
    public sealed class Graphic3d_Camera : Standard_Transient
    {
        public Graphic3d_Camera()
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_Camera(Graphic3d_Camera theOther)
            : base()
        {
            throw new NotImplementedException();
        }

        public void CopyMappingData(Graphic3d_Camera theOtherCamera)
        {
            throw new NotImplementedException();
        }

        public void CopyOrientationData(Graphic3d_Camera theOtherCamera)
        {
            throw new NotImplementedException();
        }

        public void Copy(Graphic3d_Camera theOther)
        {
            throw new NotImplementedException();
        }

        public gp_Dir Direction()
        {
            throw new NotImplementedException();
        }

        public void SetDirectionFromEye(gp_Dir theDir)
        {
            throw new NotImplementedException();
        }

        public void SetDirection(gp_Dir theDir)
        {
            throw new NotImplementedException();
        }

        public gp_Dir Up()
        {
            throw new NotImplementedException();
        }

        public void SetUp(gp_Dir theUp)
        {
            throw new NotImplementedException();
        }

        public void OrthogonalizeUp()
        {
            throw new NotImplementedException();
        }

        public gp_Dir OrthogonalizedUp()
        {
            throw new NotImplementedException();
        }

        public gp_Dir SideRight()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Eye()
        {
            throw new NotImplementedException();
        }

        public void MoveEyeTo(gp_Pnt theEye)
        {
            throw new NotImplementedException();
        }

        public void SetEyeAndCenter(gp_Pnt theEye, gp_Pnt theCenter)
        {
            throw new NotImplementedException();
        }

        public void SetEye(gp_Pnt theEye)
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

        public double Distance()
        {
            throw new NotImplementedException();
        }

        public void SetDistance(double theD_istance)
        {
            throw new NotImplementedException();
        }

        public double Scale()
        {
            throw new NotImplementedException();
        }

        public void SetScale(double theScale)
        {
            throw new NotImplementedException();
        }

        public gp_XYZ AxialScale()
        {
            throw new NotImplementedException();
        }

        public void SetAxialScale(gp_XYZ theAxialScale)
        {
            throw new NotImplementedException();
        }

        public void SetProjectionType(Projection theProjection)
        {
            throw new NotImplementedException();
        }

        public Projection ProjectionType()
        {
            throw new NotImplementedException();
        }

        public bool IsOrthographic()
        {
            throw new NotImplementedException();
        }

        public bool IsStereo()
        {
            throw new NotImplementedException();
        }

        public void SetFOVy(double theFOVy)
        {
            throw new NotImplementedException();
        }

        public double FOVy()
        {
            throw new NotImplementedException();
        }

        public double FOVx()
        {
            throw new NotImplementedException();
        }

        public double FOV2d()
        {
            throw new NotImplementedException();
        }

        public void SetFOV2d(double theFOV)
        {
            throw new NotImplementedException();
        }

        public bool ZFitAll(double theScaleFactor, Bnd_Box theMinMax, Bnd_Box theGraphicBB, ref double theZNear,
            ref double theZFar)
        {
            throw new NotImplementedException();
        }

        public void ZFitAll(double theScaleFactor, Bnd_Box theMinMax, Bnd_Box theGraphicBB)
        {
            throw new NotImplementedException();
        }

        public void SetZRange(double theZNear, double theZFar)
        {
            throw new NotImplementedException();
        }

        public double ZNear()
        {
            throw new NotImplementedException();
        }

        public double ZFar()
        {
            throw new NotImplementedException();
        }

        public void SetAspect(double theAspect)
        {
            throw new NotImplementedException();
        }

        public double Aspect()
        {
            throw new NotImplementedException();
        }

        public void SetZFocus(FocusType theType, double theZFocus)
        {
            throw new NotImplementedException();
        }

        public double ZFocus()
        {
            throw new NotImplementedException();
        }

        public FocusType ZFocusType()
        {
            throw new NotImplementedException();
        }

        public void SetIOD(IODType theType, double theIOD)
        {
            throw new NotImplementedException();
        }

        public double IOD()
        {
            throw new NotImplementedException();
        }

        public IODType GetIODType()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_CameraTile Tile()
        {
            throw new NotImplementedException();
        }

        public void SetTile(Graphic3d_CameraTile theTile)
        {
            throw new NotImplementedException();
        }

        public void Transform(gp_Trsf theTrsf)
        {
            throw new NotImplementedException();
        }

        public gp_XYZ ViewDimensions()
        {
            throw new NotImplementedException();
        }

        public gp_XYZ ViewDimensions(double theZValue)
        {
            throw new NotImplementedException();
        }

        public double NDC2dOffsetX()
        {
            throw new NotImplementedException();
        }

        public double NDC2dOffsetY()
        {
            throw new NotImplementedException();
        }

        public void Frustum(gp_Pln theLeft, gp_Pln theRight, gp_Pln theBottom, gp_Pln theTop, gp_Pln theNear,
            gp_Pln theFar)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Project(gp_Pnt thePnt)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt UnProject(gp_Pnt thePnt)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt ConvertView2Proj(gp_Pnt thePnt)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt ConvertProj2View(gp_Pnt thePnt)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt ConvertWorld2View(gp_Pnt thePnt)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt ConvertView2World(gp_Pnt thePnt)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_WorldViewProjState WorldViewProjState()
        {
            throw new NotImplementedException();
        }

        public ulong ProjectionState()
        {
            throw new NotImplementedException();
        }

        public ulong WorldViewState()
        {
            throw new NotImplementedException();
        }

        public void InvalidateProjection()
        {
            throw new NotImplementedException();
        }

        public void InvalidateOrientation()
        {
            throw new NotImplementedException();
        }

        public void ResetCustomProjection()
        {
            throw new NotImplementedException();
        }

        public bool IsCustomStereoFrustum()
        {
            throw new NotImplementedException();
        }

        public bool IsCustomStereoProjection()
        {
            throw new NotImplementedException();
        }

        public bool IsCustomMonoProjection()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }


        //---------------------------------------------------------------------
        //  Enum  Projection
        //---------------------------------------------------------------------
        public enum Projection
        {
            Projection_Orthographic = 0,
            Projection_Perspective = 1,
            Projection_Stereo = 2,
            Projection_MonoLeftEye = 3,
            Projection_MonoRightEye = 4
        } // enum  class Projection

        //---------------------------------------------------------------------
        //  Enum  FocusType
        //---------------------------------------------------------------------
        public enum FocusType
        {
            FocusType_Absolute = 0,
            FocusType_Relative = 1
        } // enum  class FocusType

        //---------------------------------------------------------------------
        //  Enum  IODType
        //---------------------------------------------------------------------
        public enum IODType
        {
            IODType_Absolute = 0,
            IODType_Relative = 1
        } // enum  class IODType
    }; // class Graphic3d_Camera
}