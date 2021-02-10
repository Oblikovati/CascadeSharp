//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Aspect;

namespace CascadeSharp.TKService.Graphic3d
{
    //---------------------------------------------------------------------
    //  Class  Graphic3d_TransformPers
    //---------------------------------------------------------------------
    public sealed class Graphic3d_TransformPers : Standard_Transient
    {
        public Graphic3d_TransformPers(Graphic3d_TransModeFlags theMode)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TransformPers(Graphic3d_TransModeFlags theMode, gp_Pnt thePnt)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TransformPers(Graphic3d_TransModeFlags theMode, Aspect_TypeOfTriedronPosition theCorner,
            Graphic3d_Vec2i theOffset)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TransformPers(Graphic3d_TransModeFlags theMode, Aspect_TypeOfTriedronPosition theCorner)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TransformPers(Graphic3d_TransformPers parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TransformPers()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public bool IsZoomOrRotate(Graphic3d_TransModeFlags theMode)
        {
            throw new NotImplementedException();
        }

        public bool IsTrihedronOr2d(Graphic3d_TransModeFlags theMode)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TransformPers FromDeprecatedParams(Graphic3d_TransModeFlags theFlag, gp_Pnt thePoint)
        {
            throw new NotImplementedException();
        }

        public bool IsZoomOrRotate()
        {
            throw new NotImplementedException();
        }

        public bool IsTrihedronOr2d()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TransModeFlags Mode()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TransModeFlags Flags()
        {
            throw new NotImplementedException();
        }

        public void SetPersistence(Graphic3d_TransModeFlags theMode, gp_Pnt thePnt)
        {
            throw new NotImplementedException();
        }

        public void SetPersistence(Graphic3d_TransModeFlags theMode, Aspect_TypeOfTriedronPosition theCorner,
            Graphic3d_Vec2i theOffset)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt AnchorPoint()
        {
            throw new NotImplementedException();
        }

        public void SetAnchorPoint(gp_Pnt thePnt)
        {
            throw new NotImplementedException();
        }

        public Aspect_TypeOfTriedronPosition Corner2d()
        {
            throw new NotImplementedException();
        }

        public void SetCorner2d(Aspect_TypeOfTriedronPosition thePos)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_Vec2i Offset2d()
        {
            throw new NotImplementedException();
        }

        public void SetOffset2d(Graphic3d_Vec2i theOffset)
        {
            throw new NotImplementedException();
        }
    }; // class Graphic3d_TransformPers
}