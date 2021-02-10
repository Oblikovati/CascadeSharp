//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Image_AlienPixMap
	//---------------------------------------------------------------------
	public  sealed class Image_AlienPixMap : CascadeSharp.Image_PixMap
	{

		public Image_AlienPixMap()
			: base()
		{
			throw new NotImplementedException();
		}

		public Image_AlienPixMap(Image_AlienPixMap parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IsTopDownDefault()
		{
			throw new NotImplementedException();
		}

		public bool Load(TCollection_AsciiString theFileName)
		{
			throw new NotImplementedException();
		}

				public bool Load(byte theData, ulong theLength, TCollection_AsciiString theFileName)
		{
			throw new NotImplementedException();
		}

		public bool Save(TCollection_AsciiString theFileName)
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

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool AdjustGamma(double theGammaCorr)
		{
			throw new NotImplementedException();
		}

		public bool InitWrapper(CascadeSharp.Image_Format thePixelFormat, ref byte theDataPtr, ulong theSizeX, ulong theSizeY, ulong theSizeRowBytes)
		{
			throw new NotImplementedException();
		}

		public bool savePPM(TCollection_AsciiString theFileName)
		{
			throw new NotImplementedException();
		}


	}; // class Image_AlienPixMap

}
