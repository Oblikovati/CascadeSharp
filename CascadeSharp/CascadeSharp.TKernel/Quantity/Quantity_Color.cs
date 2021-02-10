//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKernel.Quantity
{
    //---------------------------------------------------------------------
    //  Class  Quantity_Color
    //---------------------------------------------------------------------
    public sealed class Quantity_Color
    {
        public Quantity_Color()
            : base()
        {
            throw new NotImplementedException();
        }

        public Quantity_Color(Quantity_NameOfColor theName)
            : base()
        {
            throw new NotImplementedException();
        }

        public Quantity_Color(double theC1, double theC2, double theC3, Quantity_TypeOfColor theType)
            : base()
        {
            throw new NotImplementedException();
        }

        public Quantity_Color(Quantity_Color parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Quantity_NameOfColor Name()
        {
            throw new NotImplementedException();
        }

        public void SetValues(Quantity_NameOfColor theName)
        {
            throw new NotImplementedException();
        }

        public void Values(ref double theC1, ref double theC2, ref double theC3, Quantity_TypeOfColor theType)
        {
            throw new NotImplementedException();
        }

        public void SetValues(double theC1, double theC2, double theC3, Quantity_TypeOfColor theType)
        {
            throw new NotImplementedException();
        }

        public double Red()
        {
            throw new NotImplementedException();
        }

        public double Green()
        {
            throw new NotImplementedException();
        }

        public double Blue()
        {
            throw new NotImplementedException();
        }

        public double Hue()
        {
            throw new NotImplementedException();
        }

        public double Light()
        {
            throw new NotImplementedException();
        }

        public void ChangeIntensity(double theDelta)
        {
            throw new NotImplementedException();
        }

        public double Saturation()
        {
            throw new NotImplementedException();
        }

        public void ChangeContrast(double theDelta)
        {
            throw new NotImplementedException();
        }

        public bool IsDifferent(Quantity_Color theOther)
        {
            throw new NotImplementedException();
        }

        public bool IsEqual(Quantity_Color theOther)
        {
            throw new NotImplementedException();
        }

        public double Distance(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public double SquareDistance(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public void Delta(Quantity_Color theColor, ref double DC, ref double DI)
        {
            throw new NotImplementedException();
        }

        public double DeltaE2000(Quantity_Color theOther)
        {
            throw new NotImplementedException();
        }

        public Quantity_NameOfColor Name(double theR, double theG, double theB)
        {
            throw new NotImplementedException();
        }

        public string StringName(Quantity_NameOfColor theColor)
        {
            throw new NotImplementedException();
        }

        public bool ColorFromName(string theName, ref Quantity_NameOfColor theColor)
        {
            throw new NotImplementedException();
        }

        public bool ColorFromName(string theColorNameString, Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public bool ColorFromHex(string theHexColorString, Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString ColorToHex(Quantity_Color theColor, bool theToP_refixHash)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString ColorToHex(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public void Color2argb(Quantity_Color theColor, ref int theARGB)
        {
            throw new NotImplementedException();
        }

        public void Argb2color(int theARGB, Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public double Convert_LinearRGB_To_sRGB(double theLinearValue)
        {
            throw new NotImplementedException();
        }

        public float Convert_LinearRGB_To_sRGB(float theLinearValue)
        {
            throw new NotImplementedException();
        }

        public double Convert_sRGB_To_LinearRGB(double thesRGBValue)
        {
            throw new NotImplementedException();
        }

        public float Convert_sRGB_To_LinearRGB(float thesRGBValue)
        {
            throw new NotImplementedException();
        }

        public float Convert_LinearRGB_To_sRGB_approx22(float theLinearValue)
        {
            throw new NotImplementedException();
        }

        public float Convert_sRGB_To_LinearRGB_approx22(float thesRGBValue)
        {
            throw new NotImplementedException();
        }

        public void HlsRgb(double theH, double theL, double theS, ref double theR, ref double theG, ref double theB)
        {
            throw new NotImplementedException();
        }

        public void RgbHls(double theR, double theG, double theB, ref double theH, ref double theL, ref double theS)
        {
            throw new NotImplementedException();
        }

        public double Epsilon()
        {
            throw new NotImplementedException();
        }

        public void SetEpsilon(double theEpsilon)
        {
            throw new NotImplementedException();
        }
    }; // class Quantity_Color
}