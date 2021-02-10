//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKService.Image;

namespace CascadeSharp.TKService.Graphic3d
{
    //---------------------------------------------------------------------
    //  Class  Graphic3d_TextureMap
    //---------------------------------------------------------------------
    public class Graphic3d_TextureMap : Graphic3d_TextureRoot
    {
        public Graphic3d_TextureMap(TCollection_AsciiString theFileName, Graphic3d_TypeOfTexture theType)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TextureMap(Image_PixMap thePixMap, Graphic3d_TypeOfTexture theType)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TextureMap(Graphic3d_TextureMap parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TextureMap()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void EnableSmooth()
        {
            throw new NotImplementedException();
        }

        public bool IsSmoothed()
        {
            throw new NotImplementedException();
        }

        public void DisableSmooth()
        {
            throw new NotImplementedException();
        }

        public void EnableModulate()
        {
            throw new NotImplementedException();
        }

        public void DisableModulate()
        {
            throw new NotImplementedException();
        }

        public bool IsModulate()
        {
            throw new NotImplementedException();
        }

        public void EnableRepeat()
        {
            throw new NotImplementedException();
        }

        public void DisableRepeat()
        {
            throw new NotImplementedException();
        }

        public bool IsRepeat()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_LevelOfTextureAnisotropy AnisoFilter()
        {
            throw new NotImplementedException();
        }

        public void SetAnisoFilter(Graphic3d_LevelOfTextureAnisotropy theLevel)
        {
            throw new NotImplementedException();
        }
    }; // class Graphic3d_TextureMap
}