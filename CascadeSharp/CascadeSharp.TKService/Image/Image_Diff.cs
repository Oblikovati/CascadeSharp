//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKService.Image
{
    //---------------------------------------------------------------------
    //  Class  Image_Diff
    //---------------------------------------------------------------------
    public sealed class Image_Diff : Standard_Transient
    {
        public Image_Diff()
            : base()
        {
            throw new NotImplementedException();
        }

        public Image_Diff(Image_Diff parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool Init(Image_PixMap theImageRef, Image_PixMap theImageNew, bool theToBlackWhite)
        {
            throw new NotImplementedException();
        }

        public bool Init(Image_PixMap theImageRef, Image_PixMap theImageNew)
        {
            throw new NotImplementedException();
        }

        public bool Init(TCollection_AsciiString theImgPathRef, TCollection_AsciiString theImgPathNew,
            bool theToBlackWhite)
        {
            throw new NotImplementedException();
        }

        public bool Init(TCollection_AsciiString theImgPathRef, TCollection_AsciiString theImgPathNew)
        {
            throw new NotImplementedException();
        }

        public void SetColorTolerance(double theTolerance)
        {
            throw new NotImplementedException();
        }

        public double ColorTolerance()
        {
            throw new NotImplementedException();
        }

        public void SetBorderFilterOn(bool theToIgnore)
        {
            throw new NotImplementedException();
        }

        public bool IsBorderFilterOn()
        {
            throw new NotImplementedException();
        }

        public int Compare()
        {
            throw new NotImplementedException();
        }

        public bool SaveDiffImage(Image_PixMap theDiffImage)
        {
            throw new NotImplementedException();
        }

        public bool SaveDiffImage(TCollection_AsciiString theDiffPath)
        {
            throw new NotImplementedException();
        }

        public int ignoreBorderEffect()
        {
            throw new NotImplementedException();
        }

        public void releaseGroupsOfDiffPixels()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Image_Diff
}