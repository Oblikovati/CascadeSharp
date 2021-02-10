//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKService.Image
{
    //---------------------------------------------------------------------
    //  Class  Image_SupportedFormats
    //---------------------------------------------------------------------
    public sealed class Image_SupportedFormats : Standard_Transient
    {
        public Image_SupportedFormats()
            : base()
        {
            throw new NotImplementedException();
        }

        public Image_SupportedFormats(Image_SupportedFormats parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public bool IsSupported(Image_Format theFormat)
        {
            throw new NotImplementedException();
        }

        public void Add(Image_Format theFormat)
        {
            throw new NotImplementedException();
        }

        public bool HasCompressed()
        {
            throw new NotImplementedException();
        }

        public bool IsSupported(Image_CompressedFormat theFormat)
        {
            throw new NotImplementedException();
        }

        public void Add(Image_CompressedFormat theFormat)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }; // class Image_SupportedFormats
}