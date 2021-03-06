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
    //  Class  Prs3d_LineAspect
    //---------------------------------------------------------------------
    public class Prs3d_LineAspect : Prs3d_BasicAspect
    {
        public Prs3d_LineAspect(Quantity_Color theColor, Aspect_TypeOfLine theType, double theWidth)
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_LineAspect(Graphic3d_AspectLine3d theAspect)
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_LineAspect(Prs3d_LineAspect parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_LineAspect()
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

        public void SetTypeOfLine(Aspect_TypeOfLine theType)
        {
            throw new NotImplementedException();
        }

        public void SetWidth(double theWidth)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_AspectLine3d Aspect()
        {
            throw new NotImplementedException();
        }

        public void SetAspect(Graphic3d_AspectLine3d theAspect)
        {
            throw new NotImplementedException();
        }
    }; // class Prs3d_LineAspect
}