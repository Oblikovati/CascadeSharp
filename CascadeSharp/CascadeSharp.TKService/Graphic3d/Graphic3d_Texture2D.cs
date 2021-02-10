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
	//  Class  Graphic3d_Texture2D
	//---------------------------------------------------------------------
	public  class Graphic3d_Texture2D : Graphic3d_TextureMap
	{

		public Graphic3d_Texture2D(TCollection_AsciiString theFileName, Graphic3d_TypeOfTexture theType)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Texture2D(Graphic3d_NameOfTexture2D theName, Graphic3d_TypeOfTexture theType)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Texture2D(Image_PixMap thePixMap, Graphic3d_TypeOfTexture theType)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Texture2D(Graphic3d_Texture2D parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Texture2D()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public int NumberOfTextures()
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString TextureName(int theRank)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_NameOfTexture2D Name()
		{
			throw new NotImplementedException();
		}

		public void SetImage(Image_PixMap thePixMap)
		{
			throw new NotImplementedException();
		}

		public bool HasMipMaps()
		{
			throw new NotImplementedException();
		}

		public void SetMipMaps(bool theToUse)
		{
			throw new NotImplementedException();
		}


	}; // class Graphic3d_Texture2D

}
