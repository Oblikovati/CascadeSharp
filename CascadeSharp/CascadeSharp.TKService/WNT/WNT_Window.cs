//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKService.Aspect;

namespace CascadeSharp.TKService.WNT
{
	//---------------------------------------------------------------------
	//  Class  WNT_Window
	//---------------------------------------------------------------------
	public  sealed class WNT_Window : Aspect_Window
	{

		public WNT_Window(string theTitle, WNT_WClass theClass, uint theStyle, int thePxLeft, int thePxTop, int thePxWidth, int thePxHeight, Quantity_NameOfColor theBackColor, IntPtr theParent, IntPtr theMenu, IntPtr theClientStruct)
			: base()
		{
			throw new NotImplementedException();
		}

		public WNT_Window(string theTitle, WNT_WClass theClass, uint theStyle, int thePxLeft, int thePxTop, int thePxWidth, int thePxHeight, Quantity_NameOfColor theBackColor, IntPtr theParent, IntPtr theMenu)
			: base()
		{
			throw new NotImplementedException();
		}

		public WNT_Window(string theTitle, WNT_WClass theClass, uint theStyle, int thePxLeft, int thePxTop, int thePxWidth, int thePxHeight, Quantity_NameOfColor theBackColor, IntPtr theParent)
			: base()
		{
			throw new NotImplementedException();
		}

		public WNT_Window(string theTitle, WNT_WClass theClass, uint theStyle, int thePxLeft, int thePxTop, int thePxWidth, int thePxHeight, Quantity_NameOfColor theBackColor)
			: base()
		{
			throw new NotImplementedException();
		}

		public WNT_Window(string theTitle, WNT_WClass theClass, uint theStyle, int thePxLeft, int thePxTop, int thePxWidth, int thePxHeight)
			: base()
		{
			throw new NotImplementedException();
		}

		public WNT_Window(IntPtr aHandle, Quantity_NameOfColor aBackColor)
			: base()
		{
			throw new NotImplementedException();
		}

		public WNT_Window(IntPtr aHandle)
			: base()
		{
			throw new NotImplementedException();
		}

		public WNT_Window(WNT_Window parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public WNT_Window()
		{
			throw new NotImplementedException();
		}

		public uint VirtualKeyFromNative(int theKey)
		{
			throw new NotImplementedException();
		}

						public uint MouseKeyFlagsAsync()
		{
			throw new NotImplementedException();
		}

		public uint MouseButtonsAsync()
		{
			throw new NotImplementedException();
		}

		public void SetCursor(IntPtr aCursor)
		{
			throw new NotImplementedException();
		}

		public void Map()
		{
			throw new NotImplementedException();
		}

		public void Map(int aMapMode)
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

		public void SetPos(int X, int Y, int X1, int Y1)
		{
			throw new NotImplementedException();
		}

		public bool IsMapped()
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

		public IntPtr HWindow()
		{
			throw new NotImplementedException();
		}

		public IntPtr HParentWindow()
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

		public void InvalidateContent()
		{
			throw new NotImplementedException();
		}

		public int RegisterRawInputDevices(uint theRawDeviceMask)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
		//---------------------------------------------------------------------
		//  Enum  RawInputMask
		//---------------------------------------------------------------------
		public		enum RawInputMask
		{
			RawInputMask_Mouse = 1,
			RawInputMask_SpaceMouse = 2
		} // enum  class RawInputMask

	}; // class WNT_Window

}
