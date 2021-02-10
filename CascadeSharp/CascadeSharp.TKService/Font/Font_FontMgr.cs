//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.NCollection;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKernel.TColStd;

namespace CascadeSharp.TKService.Font
{
    //---------------------------------------------------------------------
    //  Class  Font_FontMgr
    //---------------------------------------------------------------------
    public sealed class Font_FontMgr : Standard_Transient
    {
        public Font_FontMgr()
            : base()
        {
            throw new NotImplementedException();
        }

        public Font_FontMgr(Font_FontMgr parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public Font_FontMgr GetInstance()
        {
            throw new NotImplementedException();
        }

        public char FontAspectToString(Font_FontAspect theAspect)
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public bool ToUseUnicodeSubsetFallback()
        {
            throw new NotImplementedException();
        }

        public void AvailableFonts(Font_NListOfSystemFont theL_ist)
        {
            throw new NotImplementedException();
        }

        public Font_NListOfSystemFont GetAvailableFonts()
        {
            throw new NotImplementedException();
        }

        public void GetAvailableFontsNames(TColStd_SequenceOfHAsciiString theFontsNames)
        {
            throw new NotImplementedException();
        }

        public Font_SystemFont GetFont(TCollection_HAsciiString theFontName, Font_FontAspect theFontAspect,
            int theFontSize)
        {
            throw new NotImplementedException();
        }

        public Font_SystemFont GetFont(TCollection_AsciiString theFontName)
        {
            throw new NotImplementedException();
        }

        public Font_SystemFont FindFont(TCollection_AsciiString theFontName, Font_StrictLevel theStrictLevel,
            ref Font_FontAspect theFontAspect, bool theDoFailMsg)
        {
            throw new NotImplementedException();
        }

        public Font_SystemFont FindFont(TCollection_AsciiString theFontName, Font_StrictLevel theStrictLevel,
            ref Font_FontAspect theFontAspect)
        {
            throw new NotImplementedException();
        }

        public Font_SystemFont FindFont(TCollection_AsciiString theFontName, ref Font_FontAspect theFontAspect)
        {
            throw new NotImplementedException();
        }

        public Font_SystemFont FindFallbackFont(Font_UnicodeSubset theSubset, Font_FontAspect theFontAspect)
        {
            throw new NotImplementedException();
        }

        public Font_SystemFont CheckFont(string theFontPath)
        {
            throw new NotImplementedException();
        }

        public bool RegisterFont(Font_SystemFont theFont, bool theToOverride)
        {
            throw new NotImplementedException();
        }

        public bool ToTraceAliases()
        {
            throw new NotImplementedException();
        }

        public void SetTraceAliases(bool theToTrace)
        {
            throw new NotImplementedException();
        }

        public void GetAllAliases(TColStd_SequenceOfHAsciiString theAliases)
        {
            throw new NotImplementedException();
        }

        public void GetFontAliases(TColStd_SequenceOfHAsciiString theFontNames, TCollection_AsciiString theAliasName)
        {
            throw new NotImplementedException();
        }

        public bool AddFontAlias(TCollection_AsciiString theAliasName, TCollection_AsciiString theFontName)
        {
            throw new NotImplementedException();
        }

        public bool RemoveFontAlias(TCollection_AsciiString theAliasName, TCollection_AsciiString theFontName)
        {
            throw new NotImplementedException();
        }

        public void InitFontDataBase()
        {
            throw new NotImplementedException();
        }

        public void ClearFontDataBase()
        {
            throw new NotImplementedException();
        }

        public NCollection_Buffer EmbedFallbackFont()
        {
            throw new NotImplementedException();
        }
    }; // class Font_FontMgr
}