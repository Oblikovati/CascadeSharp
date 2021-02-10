//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_Texture2D
	//---------------------------------------------------------------------
	public  class Graphic3d_Texture2D : CascadeSharp.Graphic3d_TextureMap
	{

		public Graphic3d_Texture2D(TCollection_AsciiString theFileName, CascadeSharp.Graphic3d_TypeOfTexture theType)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Texture2D(CascadeSharp.Graphic3d_NameOfTexture2D theName, CascadeSharp.Graphic3d_TypeOfTexture theType)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Texture2D(Image_PixMap thePixMap, CascadeSharp.Graphic3d_TypeOfTexture theType)
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

		public CascadeSharp.Graphic3d_NameOfTexture2D Name()
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
