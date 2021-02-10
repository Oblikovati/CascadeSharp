//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Image_PixMap
	//---------------------------------------------------------------------
	public  class Image_PixMap : Standard_Transient
	{

		public Image_PixMap()
			: base()
		{
			throw new NotImplementedException();
		}

		public Image_PixMap(Image_PixMap parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IsBigEndianHost()
		{
			throw new NotImplementedException();
		}

		public bool SwapRgbaBgra(Image_PixMap theImage)
		{
			throw new NotImplementedException();
		}

		public void ToBlackWhite(Image_PixMap theImage)
		{
			throw new NotImplementedException();
		}

		public NCollection_BaseAllocator DefaultAllocator()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Image_Format Format()
		{
			throw new NotImplementedException();
		}

		public void SetFormat(CascadeSharp.Image_Format thePixelFormat)
		{
			throw new NotImplementedException();
		}

		public ulong Width()
		{
			throw new NotImplementedException();
		}

		public ulong Height()
		{
			throw new NotImplementedException();
		}

		public ulong SizeX()
		{
			throw new NotImplementedException();
		}

		public ulong SizeY()
		{
			throw new NotImplementedException();
		}

		public double Ratio()
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			throw new NotImplementedException();
		}

		public Quantity_ColorRGBA PixelColor(int theX, int theY, bool theToLinearize)
		{
			throw new NotImplementedException();
		}

		public Quantity_ColorRGBA PixelColor(int theX, int theY)
		{
			throw new NotImplementedException();
		}

		public void SetPixelColor(int theX, int theY, Quantity_Color theColor, bool theToDeLinearize)
		{
			throw new NotImplementedException();
		}

		public void SetPixelColor(int theX, int theY, Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void SetPixelColor(int theX, int theY, Quantity_ColorRGBA theColor, bool theToDeLinearize)
		{
			throw new NotImplementedException();
		}

		public void SetPixelColor(int theX, int theY, Quantity_ColorRGBA theColor)
		{
			throw new NotImplementedException();
		}

		public bool InitWrapper(CascadeSharp.Image_Format thePixelFormat, ref byte theDataPtr, ulong theSizeX, ulong theSizeY, ulong theSizeRowBytes)
		{
			throw new NotImplementedException();
		}

		public bool InitWrapper(CascadeSharp.Image_Format thePixelFormat, ref byte theDataPtr, ulong theSizeX, ulong theSizeY)
		{
			throw new NotImplementedException();
		}

		public bool InitTrash(CascadeSharp.Image_Format thePixelFormat, ulong theSizeX, ulong theSizeY, ulong theSizeRowBytes)
		{
			throw new NotImplementedException();
		}

		public bool InitTrash(CascadeSharp.Image_Format thePixelFormat, ulong theSizeX, ulong theSizeY)
		{
			throw new NotImplementedException();
		}

		public bool InitCopy(Image_PixMap theCopy)
		{
			throw new NotImplementedException();
		}

		public bool InitZero(CascadeSharp.Image_Format thePixelFormat, ulong theSizeX, ulong theSizeY, ulong theSizeRowBytes, byte theValue)
		{
			throw new NotImplementedException();
		}

		public bool InitZero(CascadeSharp.Image_Format thePixelFormat, ulong theSizeX, ulong theSizeY, ulong theSizeRowBytes)
		{
			throw new NotImplementedException();
		}

		public bool InitZero(CascadeSharp.Image_Format thePixelFormat, ulong theSizeX, ulong theSizeY)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool IsTopDown()
		{
			throw new NotImplementedException();
		}

		public void SetTopDown(bool theIsTopDown)
		{
			throw new NotImplementedException();
		}

		public ulong TopDownInc()
		{
			throw new NotImplementedException();
		}

		public byte Data()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

		public byte ChangeData()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

		public byte Row(ulong theRow)
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

		public byte ChangeRow(ulong theRow)
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

		public ulong SizePixelBytes()
		{
			throw new NotImplementedException();
		}

		public ulong SizePixelBytes(CascadeSharp.Image_Format thePixelFormat)
		{
			throw new NotImplementedException();
		}

		public ulong SizeRowBytes()
		{
			throw new NotImplementedException();
		}

		public ulong RowExtraBytes()
		{
			throw new NotImplementedException();
		}

		public ulong MaxRowAligmentBytes()
		{
			throw new NotImplementedException();
		}

		public ulong SizeBytes()
		{
			throw new NotImplementedException();
		}

		public byte RawValue(ulong theRow, ulong theCol)
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

		public byte ChangeRawValue(ulong theRow, ulong theCol)
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}


	}; // class Image_PixMap

}
