//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKService.Image;

namespace CascadeSharp.TKService.Graphic3d
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_TextureRoot
	//---------------------------------------------------------------------
	public  class Graphic3d_TextureRoot : Standard_Transient
	{

		public Graphic3d_TextureRoot(TCollection_AsciiString theFileName, Graphic3d_TypeOfTexture theType)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_TextureRoot(Image_PixMap thePixmap, Graphic3d_TypeOfTexture theType)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_TextureRoot(Graphic3d_TextureRoot parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_TextureRoot()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public TCollection_AsciiString TexturesFolder()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

				public Graphic3d_TypeOfTexture Type()
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString GetId()
		{
			throw new NotImplementedException();
		}

		public ulong Revision()
		{
			throw new NotImplementedException();
		}

		public void UpdateRevision()
		{
			throw new NotImplementedException();
		}

		public Image_CompressedPixMap GetCompressedImage(Image_SupportedFormats theSupported)
		{
			throw new NotImplementedException();
		}

		public Image_PixMap GetImage(Image_SupportedFormats theSupported)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_TextureParams GetParams()
		{
			throw new NotImplementedException();
		}

		public bool IsColorMap()
		{
			throw new NotImplementedException();
		}

		public void SetColorMap(bool theIsColor)
		{
			throw new NotImplementedException();
		}

		public bool IsTopDown()
		{
			throw new NotImplementedException();
		}

		public void generateId()
		{
			throw new NotImplementedException();
		}

		public void convertToCompatible(Image_SupportedFormats theSupported, Image_PixMap theImage)
		{
			throw new NotImplementedException();
		}

		public Image_PixMap GetImage()
		{
			throw new NotImplementedException();
		}


	}; // class Graphic3d_TextureRoot

}
