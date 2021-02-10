//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Aspect;
using CascadeSharp.TKService.Font;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_TextLabel
    //---------------------------------------------------------------------
    public sealed class AIS_TextLabel : AIS_InteractiveObject
    {
        public AIS_TextLabel()
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_TextLabel(AIS_TextLabel parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool AcceptDisplayMode(int theMode)
        {
            throw new NotImplementedException();
        }

        public void SetColor(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public void SetTransparency(double theValue)
        {
            throw new NotImplementedException();
        }

        public void UnsetTransparency()
        {
            throw new NotImplementedException();
        }

        public void SetMaterial(Graphic3d_MaterialAspect parameter1)
        {
            throw new NotImplementedException();
        }

        public void SetText(TCollection_ExtendedString theText)
        {
            throw new NotImplementedException();
        }

        public void SetPosition(gp_Pnt thePosition)
        {
            throw new NotImplementedException();
        }

        public void SetHJustification(Graphic3d_HorizontalTextAlignment theHJust)
        {
            throw new NotImplementedException();
        }

        public void SetVJustification(Graphic3d_VerticalTextAlignment theVJust)
        {
            throw new NotImplementedException();
        }

        public void SetAngle(double theAngle)
        {
            throw new NotImplementedException();
        }

        public void SetZoomable(bool theIsZoomable)
        {
            throw new NotImplementedException();
        }

        public void SetHeight(double theHeight)
        {
            throw new NotImplementedException();
        }

        public void SetFontAspect(Font_FontAspect theFontAspect)
        {
            throw new NotImplementedException();
        }

        public void SetFont(string theFont)
        {
            throw new NotImplementedException();
        }

        public void SetOrientation3D(gp_Ax2 theOrientation)
        {
            throw new NotImplementedException();
        }

        public void UnsetOrientation3D()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Position()
        {
            throw new NotImplementedException();
        }

        public TCollection_ExtendedString Text()
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString FontName()
        {
            throw new NotImplementedException();
        }

        public Font_FontAspect FontAspect()
        {
            throw new NotImplementedException();
        }

        public gp_Ax2 Orientation3D()
        {
            throw new NotImplementedException();
        }

        public bool HasOrientation3D()
        {
            throw new NotImplementedException();
        }

        public void SetFlipping(bool theIsFlipping)
        {
            throw new NotImplementedException();
        }

        public bool HasFlipping()
        {
            throw new NotImplementedException();
        }

        public bool HasOwnAnchorPoint()
        {
            throw new NotImplementedException();
        }

        public void SetOwnAnchorPoint(bool theOwnAnchorPoint)
        {
            throw new NotImplementedException();
        }

        public void SetDisplayType(Aspect_TypeOfDisplayText theD_isplayType)
        {
            throw new NotImplementedException();
        }

        public void SetColorSubTitle(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public Font_TextFormatter TextFormatter()
        {
            throw new NotImplementedException();
        }

        public void SetTextFormatter(Font_TextFormatter theFormatter)
        {
            throw new NotImplementedException();
        }

        public void ComputeSelection(SelectMgr_Selection theSelection, int theMode)
        {
            throw new NotImplementedException();
        }

        public bool calculateLabelParams(gp_Pnt thePosition, gp_Pnt theCenterOfLabel, ref double theWidth,
            ref double theHeight)
        {
            throw new NotImplementedException();
        }

        public gp_Trsf calculateLabelTrsf(gp_Pnt thePosition, gp_Pnt theCenterOfLabel)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class AIS_TextLabel
}