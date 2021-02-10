//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKService.Image;

namespace CascadeSharp.TKService.Graphic3d
{
    //---------------------------------------------------------------------
    //  Class  Graphic3d_CubeMapSeparate
    //---------------------------------------------------------------------
    public sealed class Graphic3d_CubeMapSeparate : Graphic3d_CubeMap
    {
        public Graphic3d_CubeMapSeparate(Graphic3d_CubeMapSeparate parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_CubeMapSeparate()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public Image_CompressedPixMap CompressedValue(Image_SupportedFormats theSupported)
        {
            throw new NotImplementedException();
        }

        public Image_PixMap Value(Image_SupportedFormats theSupported)
        {
            throw new NotImplementedException();
        }

        public Image_PixMap GetImage(Image_SupportedFormats parameter1)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public void resetImages()
        {
            throw new NotImplementedException();
        }
    }; // class Graphic3d_CubeMapSeparate
}