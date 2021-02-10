//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Aspect;

namespace CascadeSharp.TKService.Graphic3d
{
    //---------------------------------------------------------------------
    //  Class  Graphic3d_ClipPlane
    //---------------------------------------------------------------------
    public sealed class Graphic3d_ClipPlane : Standard_Transient
    {
        public Graphic3d_ClipPlane()
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ClipPlane(Graphic3d_ClipPlane theOther)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ClipPlane(gp_Pln thePlane)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void SetEquation(gp_Pln thePlane)
        {
            throw new NotImplementedException();
        }

        public bool IsOn()
        {
            throw new NotImplementedException();
        }

        public void SetOn(bool theIsOn)
        {
            throw new NotImplementedException();
        }

        public void SetCapping(bool theIsOn)
        {
            throw new NotImplementedException();
        }

        public bool IsCapping()
        {
            throw new NotImplementedException();
        }

        public gp_Pln ToPlane()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ClipPlane Clone()
        {
            throw new NotImplementedException();
        }

        public bool IsChain()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ClipPlane ChainPreviousPlane()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ClipPlane ChainNextPlane()
        {
            throw new NotImplementedException();
        }

        public int NbChainNextPlanes()
        {
            throw new NotImplementedException();
        }

        public void SetChainNextPlane(Graphic3d_ClipPlane thePlane)
        {
            throw new NotImplementedException();
        }

        public Quantity_Color CappingColor()
        {
            throw new NotImplementedException();
        }

        public void SetCappingColor(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public void SetCappingMaterial(Graphic3d_MaterialAspect theMat)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_MaterialAspect CappingMaterial()
        {
            throw new NotImplementedException();
        }

        public void SetCappingTexture(Graphic3d_TextureMap theTexture)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TextureMap CappingTexture()
        {
            throw new NotImplementedException();
        }

        public void SetCappingHatch(Aspect_HatchStyle theStyle)
        {
            throw new NotImplementedException();
        }

        public Aspect_HatchStyle CappingHatch()
        {
            throw new NotImplementedException();
        }

        public void SetCappingCustomHatch(Graphic3d_HatchStyle theStyle)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_HatchStyle CappingCustomHatch()
        {
            throw new NotImplementedException();
        }

        public void SetCappingHatchOn()
        {
            throw new NotImplementedException();
        }

        public void SetCappingHatchOff()
        {
            throw new NotImplementedException();
        }

        public bool IsHatchOn()
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString GetId()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_AspectFillArea3d CappingAspect()
        {
            throw new NotImplementedException();
        }

        public void SetCappingAspect(Graphic3d_AspectFillArea3d theAspect)
        {
            throw new NotImplementedException();
        }

        public bool ToUseObjectMaterial()
        {
            throw new NotImplementedException();
        }

        public void SetUseObjectMaterial(bool theToUse)
        {
            throw new NotImplementedException();
        }

        public bool ToUseObjectTexture()
        {
            throw new NotImplementedException();
        }

        public void SetUseObjectTexture(bool theToUse)
        {
            throw new NotImplementedException();
        }

        public bool ToUseObjectShader()
        {
            throw new NotImplementedException();
        }

        public void SetUseObjectShader(bool theToUse)
        {
            throw new NotImplementedException();
        }

        public bool ToUseObjectProperties()
        {
            throw new NotImplementedException();
        }

        public uint MCountEquation()
        {
            throw new NotImplementedException();
        }

        public uint MCountAspect()
        {
            throw new NotImplementedException();
        }

        public void makeId()
        {
            throw new NotImplementedException();
        }

        public void setCappingFlag(bool theToUse, int theFlag)
        {
            throw new NotImplementedException();
        }

        public void updateChainLen()
        {
            throw new NotImplementedException();
        }

        public void updateInversedPlane()
        {
            throw new NotImplementedException();
        }
    }; // class Graphic3d_ClipPlane
}