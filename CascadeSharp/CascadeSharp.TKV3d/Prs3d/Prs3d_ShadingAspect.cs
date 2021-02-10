//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKService.Aspect;
using CascadeSharp.TKService.Graphic3d;

namespace CascadeSharp.TKV3d.Prs3d
{
    //---------------------------------------------------------------------
    //  Class  Prs3d_ShadingAspect
    //---------------------------------------------------------------------
    public sealed class Prs3d_ShadingAspect : Prs3d_BasicAspect
    {
        public Prs3d_ShadingAspect()
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_ShadingAspect(Graphic3d_AspectFillArea3d theAspect)
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_ShadingAspect(Prs3d_ShadingAspect parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void SetColor(Quantity_Color aColor, Aspect_TypeOfFacingModel aModel)
        {
            throw new NotImplementedException();
        }

        public void SetColor(Quantity_Color aColor)
        {
            throw new NotImplementedException();
        }

        public void SetMaterial(Graphic3d_MaterialAspect aMaterial, Aspect_TypeOfFacingModel aModel)
        {
            throw new NotImplementedException();
        }

        public void SetMaterial(Graphic3d_MaterialAspect aMaterial)
        {
            throw new NotImplementedException();
        }

        public void SetTransparency(double aValue, Aspect_TypeOfFacingModel aModel)
        {
            throw new NotImplementedException();
        }

        public void SetTransparency(double aValue)
        {
            throw new NotImplementedException();
        }

        public Quantity_Color Color(Aspect_TypeOfFacingModel aModel)
        {
            throw new NotImplementedException();
        }

        public Quantity_Color Color()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_MaterialAspect Material(Aspect_TypeOfFacingModel aModel)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_MaterialAspect Material()
        {
            throw new NotImplementedException();
        }

        public double Transparency(Aspect_TypeOfFacingModel aModel)
        {
            throw new NotImplementedException();
        }

        public double Transparency()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_AspectFillArea3d Aspect()
        {
            throw new NotImplementedException();
        }

        public void SetAspect(Graphic3d_AspectFillArea3d theAspect)
        {
            throw new NotImplementedException();
        }
    }; // class Prs3d_ShadingAspect
}