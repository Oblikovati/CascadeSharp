//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Font;

namespace CascadeSharp.TKService.Graphic3d
{
    //---------------------------------------------------------------------
    //  Class  Graphic3d_Text
    //---------------------------------------------------------------------
    public sealed class Graphic3d_Text : Standard_Transient
    {
        public Graphic3d_Text(float theHeight)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_Text(Graphic3d_Text parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_Text()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void SetText(TCollection_AsciiString theText)
        {
            throw new NotImplementedException();
        }

        public void SetText(string theText)
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

        public gp_Pnt Position()
        {
            throw new NotImplementedException();
        }

        public void SetPosition(gp_Pnt thePoint)
        {
            throw new NotImplementedException();
        }

        public gp_Ax2 Orientation()
        {
            throw new NotImplementedException();
        }

        public bool HasPlane()
        {
            throw new NotImplementedException();
        }

        public void SetOrientation(gp_Ax2 theOrientation)
        {
            throw new NotImplementedException();
        }

        public void ResetOrientation()
        {
            throw new NotImplementedException();
        }

        public bool HasOwnAnchorPoint()
        {
            throw new NotImplementedException();
        }

        public void SetOwnAnchorPoint(bool theHasOwnAnchor)
        {
            throw new NotImplementedException();
        }

        public float Height()
        {
            throw new NotImplementedException();
        }

        public void SetHeight(float theHeight)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_HorizontalTextAlignment HorizontalAlignment()
        {
            throw new NotImplementedException();
        }

        public void SetHorizontalAlignment(Graphic3d_HorizontalTextAlignment theJustification)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_VerticalTextAlignment VerticalAlignment()
        {
            throw new NotImplementedException();
        }

        public void SetVerticalAlignment(Graphic3d_VerticalTextAlignment theJustification)
        {
            throw new NotImplementedException();
        }
    }; // class Graphic3d_Text
}