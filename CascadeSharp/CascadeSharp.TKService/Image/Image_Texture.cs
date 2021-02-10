//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.NCollection;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKService.Image
{
    //---------------------------------------------------------------------
    //  Class  Image_Texture
    //---------------------------------------------------------------------
    public sealed class Image_Texture : Standard_Transient
    {
        public Image_Texture(TCollection_AsciiString theFileName)
            : base()
        {
            throw new NotImplementedException();
        }

        public Image_Texture(NCollection_Buffer theBuffer, TCollection_AsciiString theId)
            : base()
        {
            throw new NotImplementedException();
        }

        public Image_Texture(Image_Texture parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Image_Texture()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public TCollection_AsciiString TextureId()
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString FilePath()
        {
            throw new NotImplementedException();
        }

        public NCollection_Buffer DataBuffer()
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString ProbeImageFileFormat()
        {
            throw new NotImplementedException();
        }

        public Image_CompressedPixMap ReadCompressedImage(Image_SupportedFormats theSupported)
        {
            throw new NotImplementedException();
        }

        public Image_PixMap ReadImage(Image_SupportedFormats theSupported)
        {
            throw new NotImplementedException();
        }

        public bool WriteImage(TCollection_AsciiString theFile)
        {
            throw new NotImplementedException();
        }

        public int HashCode(Image_Texture theTexture, int theUpper)
        {
            throw new NotImplementedException();
        }

        public bool IsEqual(Image_Texture theTex1, Image_Texture theTex2)
        {
            throw new NotImplementedException();
        }

        public Image_PixMap loadImageFile(TCollection_AsciiString thePath)
        {
            throw new NotImplementedException();
        }

        public Image_PixMap loadImageBuffer(NCollection_Buffer theBuffer, TCollection_AsciiString theId)
        {
            throw new NotImplementedException();
        }
    }; // class Image_Texture
}