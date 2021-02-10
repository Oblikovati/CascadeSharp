//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKService.Aspect
{
    //---------------------------------------------------------------------
    //  Class  Aspect_NeutralWindow
    //---------------------------------------------------------------------
    public sealed class Aspect_NeutralWindow : Aspect_Window
    {
        public Aspect_NeutralWindow()
            : base()
        {
            throw new NotImplementedException();
        }

        public Aspect_NeutralWindow(Aspect_NeutralWindow parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
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

        public bool SetNativeHandle(IntPtr theWindow)
        {
            throw new NotImplementedException();
        }

        public bool SetNativeHandles(IntPtr theWindow, IntPtr theParentWindow, IntPtr theFbConfig)
        {
            throw new NotImplementedException();
        }

        public bool IsMapped()
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

        public double Ratio()
        {
            throw new NotImplementedException();
        }

        public void Position(ref int theX1, ref int theY1, ref int theX2, ref int theY2)
        {
            throw new NotImplementedException();
        }

        public bool SetPosition(int theX1, int theY1)
        {
            throw new NotImplementedException();
        }

        public bool SetPosition(int theX1, int theY1, int theX2, int theY2)
        {
            throw new NotImplementedException();
        }

        public void Size(ref int theWidth, ref int theHeight)
        {
            throw new NotImplementedException();
        }

        public bool SetSize(int theWidth, int theHeight)
        {
            throw new NotImplementedException();
        }
    }; // class Aspect_NeutralWindow
}