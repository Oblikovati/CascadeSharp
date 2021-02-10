//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKService.Font
{
	//---------------------------------------------------------------------
	//  Class  Font_SystemFont
	//---------------------------------------------------------------------
	public  sealed class Font_SystemFont : Standard_Transient
	{

		public Font_SystemFont(TCollection_AsciiString theFontName)
			: base()
		{
			throw new NotImplementedException();
		}

		public Font_SystemFont(Font_SystemFont parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Font_SystemFont()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public TCollection_AsciiString FontKey()
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString FontName()
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString FontPath(Font_FontAspect theAspect)
		{
			throw new NotImplementedException();
		}

		public int FontFaceId(Font_FontAspect theAspect)
		{
			throw new NotImplementedException();
		}

		public void SetFontPath(Font_FontAspect theAspect, TCollection_AsciiString thePath, int theFaceId)
		{
			throw new NotImplementedException();
		}

		public void SetFontPath(Font_FontAspect theAspect, TCollection_AsciiString thePath)
		{
			throw new NotImplementedException();
		}

		public bool HasFontAspect(Font_FontAspect theAspect)
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString FontPathAny(Font_FontAspect theAspect, ref bool theToSynthesizeItalic, ref int theFaceId)
		{
			throw new NotImplementedException();
		}

		public bool IsEqual(Font_SystemFont theOtherFont)
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

		public TCollection_AsciiString ToString()
		{
			throw new NotImplementedException();
		}

		public int HashCode(Font_SystemFont theSystemFont, int theUpperBound)
		{
			throw new NotImplementedException();
		}

		public bool IsEqual(Font_SystemFont theFont1, Font_SystemFont theFont2)
		{
			throw new NotImplementedException();
		}


	}; // class Font_SystemFont

}
