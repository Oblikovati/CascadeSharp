//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKService.Aspect;
using CascadeSharp.TKService.Graphic3d;

namespace CascadeSharp.TKV3d.Prs3d
{
    //---------------------------------------------------------------------
    //  Class  Prs3d_PointAspect
    //---------------------------------------------------------------------
    public sealed class Prs3d_PointAspect : Prs3d_BasicAspect
    {
        public Prs3d_PointAspect(Aspect_TypeOfMarker theType, Quantity_Color theColor, double theScale)
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_PointAspect(Quantity_Color theColor, int theWidth, int theHeight, TColStd_HArray1OfByte theTexture)
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_PointAspect(Graphic3d_AspectMarker3d theAspect)
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_PointAspect(Prs3d_PointAspect parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_PointAspect()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void SetColor(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public void SetTypeOfMarker(Aspect_TypeOfMarker theType)
        {
            throw new NotImplementedException();
        }

        public void SetScale(double theScale)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_AspectMarker3d Aspect()
        {
            throw new NotImplementedException();
        }

        public void SetAspect(Graphic3d_AspectMarker3d theAspect)
        {
            throw new NotImplementedException();
        }

        public void GetTextureSize(ref int theWidth, ref int theHeight)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_MarkerImage GetTexture()
        {
            throw new NotImplementedException();
        }
    }; // class Prs3d_PointAspect
}