//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKService.Image;

namespace CascadeSharp.TKService.Graphic3d
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_MarkerImage
	//---------------------------------------------------------------------
	public  sealed class Graphic3d_MarkerImage : Standard_Transient
	{

		public Graphic3d_MarkerImage(Image_PixMap theImage)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_MarkerImage(TColStd_HArray1OfByte theBitMap, int theWidth, int theHeight)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_MarkerImage(Graphic3d_MarkerImage parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_MarkerImage()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfByte GetBitMapArray(double theAlphaValue)
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfByte GetBitMapArray()
		{
			throw new NotImplementedException();
		}

		public Image_PixMap GetImage()
		{
			throw new NotImplementedException();
		}

		public Image_PixMap GetImageAlpha()
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString GetImageId()
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString GetImageAlphaId()
		{
			throw new NotImplementedException();
		}

		public void GetTextureSize(ref int theWidth, ref int theHeight)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Graphic3d_MarkerImage

}
