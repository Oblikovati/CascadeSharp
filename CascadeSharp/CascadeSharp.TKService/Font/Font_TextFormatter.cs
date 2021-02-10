//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKService.Graphic3d;

namespace CascadeSharp.TKService.Font
{
	//---------------------------------------------------------------------
	//  Class  Font_TextFormatter
	//---------------------------------------------------------------------
	public  sealed class Font_TextFormatter : Standard_Transient
	{

		public Font_TextFormatter()
			: base()
		{
			throw new NotImplementedException();
		}

		public Font_TextFormatter(Font_TextFormatter parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetupAlignment(Graphic3d_HorizontalTextAlignment theAlignX, Graphic3d_VerticalTextAlignment theAlignY)
		{
			throw new NotImplementedException();
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}

				public void Format()
		{
			throw new NotImplementedException();
		}

								public bool GlyphBoundingBox(int theIndex, Font_Rect theBndBox)
		{
			throw new NotImplementedException();
		}

		public float LineHeight(int theIndex)
		{
			throw new NotImplementedException();
		}

		public float LineWidth(int theIndex)
		{
			throw new NotImplementedException();
		}

		public bool IsLFSymbol(int theIndex)
		{
			throw new NotImplementedException();
		}

		public float FirstPosition()
		{
			throw new NotImplementedException();
		}

		public int LinePositionIndex(int theIndex)
		{
			throw new NotImplementedException();
		}

		public int LineIndex(int theIndex)
		{
			throw new NotImplementedException();
		}

		public int TabSize()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_HorizontalTextAlignment HorizontalTextAlignment()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_VerticalTextAlignment VerticalTextAlignment()
		{
			throw new NotImplementedException();
		}

		public void SetWrapping(float theWidth)
		{
			throw new NotImplementedException();
		}

		public bool HasWrapping()
		{
			throw new NotImplementedException();
		}

		public float Wrapping()
		{
			throw new NotImplementedException();
		}

		public float ResultWidth()
		{
			throw new NotImplementedException();
		}

		public float ResultHeight()
		{
			throw new NotImplementedException();
		}

		public float MaximumSymbolWidth()
		{
			throw new NotImplementedException();
		}

		public void BndBox(Font_Rect theBndBox)
		{
			throw new NotImplementedException();
		}

								public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void newLine(int theLastRect, float theMaxLineWidth)
		{
			throw new NotImplementedException();
		}


		//---------------------------------------------------------------------
		//  Enum  IterationFilter
		//---------------------------------------------------------------------
		public		enum IterationFilter
		{
			IterationFilter_None = 0,
			IterationFilter_ExcludeInvisible = 2
		} // enum  class IterationFilter

	}; // class Font_TextFormatter

}
