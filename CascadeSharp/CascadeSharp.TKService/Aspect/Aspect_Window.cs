//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKService.Aspect
{
	//---------------------------------------------------------------------
	//  Class  Aspect_Window
	//---------------------------------------------------------------------
	public  abstract class Aspect_Window : Standard_Transient
	{

		public Aspect_Window()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_Window(Aspect_Window parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void SetBackground(Aspect_Background ABack)
		{
			throw new NotImplementedException();
		}

		public void SetBackground(Quantity_Color color)
		{
			throw new NotImplementedException();
		}

		public void SetBackground(Aspect_GradientBackground ABackground)
		{
			throw new NotImplementedException();
		}

		public void SetBackground(Quantity_Color theFirstColor, Quantity_Color theSecondColor, Aspect_GradientFillMethod theFillMethod)
		{
			throw new NotImplementedException();
		}

		public void Map()
		{
			throw new NotImplementedException();
		}

		public void Unmap()
		{
			throw new NotImplementedException();
		}

		public Aspect_TypeOfResize DoResize()
		{
			throw new NotImplementedException();
		}

		public bool DoMapping()
		{
			throw new NotImplementedException();
		}

		public Aspect_Background Background()
		{
			throw new NotImplementedException();
		}

		public Aspect_FillMethod BackgroundFillMethod()
		{
			throw new NotImplementedException();
		}

		public Aspect_GradientBackground GradientBackground()
		{
			throw new NotImplementedException();
		}

		public bool IsMapped()
		{
			throw new NotImplementedException();
		}

		public bool IsVirtual()
		{
			throw new NotImplementedException();
		}

		public void SetVirtual(bool theVirtual)
		{
			throw new NotImplementedException();
		}

		public double Ratio()
		{
			throw new NotImplementedException();
		}

		public void Position(ref int X1, ref int Y1, ref int X2, ref int Y2)
		{
			throw new NotImplementedException();
		}

		public void Size(ref int Width, ref int Height)
		{
			throw new NotImplementedException();
		}

		public IntPtr NativeHandle()
		{
			throw new NotImplementedException();
		}

		public IntPtr NativeParentHandle()
		{
			throw new NotImplementedException();
		}

		public IntPtr NativeFBConfig()
		{
			throw new NotImplementedException();
		}

		public void SetTitle(TCollection_AsciiString theTitle)
		{
			throw new NotImplementedException();
		}

		public void InvalidateContent(Aspect_DisplayConnection theD_isp)
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Aspect_Window

}
