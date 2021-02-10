//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Font_FTFont
	//---------------------------------------------------------------------
	public  sealed class Font_FTFont : Standard_Transient
	{

		public Font_FTFont(Font_FTLibrary theFTLib)
			: base()
		{
			throw new NotImplementedException();
		}

		public Font_FTFont()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public Font_FTFont FindAndCreate(TCollection_AsciiString theFontName, CascadeSharp.Font_FontAspect theFontAspect, Font_FTFontParams theParams, CascadeSharp.Font_StrictLevel theStrictLevel)
		{
			throw new NotImplementedException();
		}

		public Font_FTFont FindAndCreate(TCollection_AsciiString theFontName, CascadeSharp.Font_FontAspect theFontAspect, Font_FTFontParams theParams)
		{
			throw new NotImplementedException();
		}

																public bool IsValid()
		{
			throw new NotImplementedException();
		}

		public Image_PixMap GlyphImage()
		{
			throw new NotImplementedException();
		}

		public bool Init(TCollection_AsciiString theFontPath, Font_FTFontParams theParams, int theFaceId)
		{
			throw new NotImplementedException();
		}

		public bool Init(TCollection_AsciiString theFontPath, Font_FTFontParams theParams)
		{
			throw new NotImplementedException();
		}

		public bool Init(NCollection_Buffer theData, TCollection_AsciiString theFileName, Font_FTFontParams theParams, int theFaceId)
		{
			throw new NotImplementedException();
		}

		public bool Init(NCollection_Buffer theData, TCollection_AsciiString theFileName, Font_FTFontParams theParams)
		{
			throw new NotImplementedException();
		}

		public bool FindAndInit(TCollection_AsciiString theFontName, CascadeSharp.Font_FontAspect theFontAspect, Font_FTFontParams theParams, CascadeSharp.Font_StrictLevel theStrictLevel)
		{
			throw new NotImplementedException();
		}

		public bool FindAndInit(TCollection_AsciiString theFontName, CascadeSharp.Font_FontAspect theFontAspect, Font_FTFontParams theParams)
		{
			throw new NotImplementedException();
		}

		public bool ToUseUnicodeSubsetFallback()
		{
			throw new NotImplementedException();
		}

		public void SetUseUnicodeSubsetFallback(bool theToFallback)
		{
			throw new NotImplementedException();
		}

		public bool IsSingleStrokeFont()
		{
			throw new NotImplementedException();
		}

		public void SetSingleStrokeFont(bool theIsSingleLine)
		{
			throw new NotImplementedException();
		}

		public bool ToSynthesizeItalic()
		{
			throw new NotImplementedException();
		}

		public void Release()
		{
			throw new NotImplementedException();
		}

				public uint GlyphMaxSizeX(bool theToIncludeFallback)
		{
			throw new NotImplementedException();
		}

		public uint GlyphMaxSizeX()
		{
			throw new NotImplementedException();
		}

		public uint GlyphMaxSizeY(bool theToIncludeFallback)
		{
			throw new NotImplementedException();
		}

		public uint GlyphMaxSizeY()
		{
			throw new NotImplementedException();
		}

		public float Ascender()
		{
			throw new NotImplementedException();
		}

		public float Descender()
		{
			throw new NotImplementedException();
		}

		public float LineSpacing()
		{
			throw new NotImplementedException();
		}

		public uint PointSize()
		{
			throw new NotImplementedException();
		}

		public float WidthScaling()
		{
			throw new NotImplementedException();
		}

		public void SetWidthScaling(float theScaleFactor)
		{
			throw new NotImplementedException();
		}

												public int GlyphsNumber(bool theToIncludeFallback)
		{
			throw new NotImplementedException();
		}

		public int GlyphsNumber()
		{
			throw new NotImplementedException();
		}

		public void GlyphRect(Font_Rect theRect)
		{
			throw new NotImplementedException();
		}

														public bool findAndInitFallback(CascadeSharp.Font_UnicodeSubset theSubset)
		{
			throw new NotImplementedException();
		}


	}; // class Font_FTFont

}
