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
    //  Class  Graphic3d_TextureEnv
    //---------------------------------------------------------------------
    public sealed class Graphic3d_TextureEnv : Graphic3d_TextureRoot
    {
        public Graphic3d_TextureEnv(TCollection_AsciiString theFileName)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TextureEnv(Graphic3d_NameOfTextureEnv theName)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TextureEnv(Image_PixMap thePixMap)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TextureEnv(Graphic3d_TextureEnv parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TextureEnv()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_NameOfTextureEnv Name()
        {
            throw new NotImplementedException();
        }

        public int NumberOfTextures()
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString TextureName(int theRank)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Graphic3d_TextureEnv
}