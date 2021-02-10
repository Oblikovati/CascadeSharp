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
	//  Class  Graphic3d_CubeMap
	//---------------------------------------------------------------------
	public  abstract class Graphic3d_CubeMap : Graphic3d_TextureMap
	{

		public Graphic3d_CubeMap(TCollection_AsciiString theFileName, bool theToGenerateMipmaps)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_CubeMap(TCollection_AsciiString theFileName)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_CubeMap(Image_PixMap thePixmap, bool theToGenerateMipmaps)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_CubeMap(Image_PixMap thePixmap)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_CubeMap(Graphic3d_CubeMap parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_CubeMap()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool More()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_CubeMapSide CurrentSide()
		{
			throw new NotImplementedException();
		}

		public void Next()
		{
			throw new NotImplementedException();
		}

		public void SetZInversion(bool theZIsInverted)
		{
			throw new NotImplementedException();
		}

		public bool ZIsInverted()
		{
			throw new NotImplementedException();
		}

		public bool HasMipmaps()
		{
			throw new NotImplementedException();
		}

		public void SetMipmapsGeneration(bool theToGenerateMipmaps)
		{
			throw new NotImplementedException();
		}

		public Image_CompressedPixMap CompressedValue(Image_SupportedFormats theSupported)
		{
			throw new NotImplementedException();
		}

		public Image_PixMap Value(Image_SupportedFormats theSupported)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_CubeMap Reset()
		{
			throw new NotImplementedException();
		}


	}; // class Graphic3d_CubeMap

}
