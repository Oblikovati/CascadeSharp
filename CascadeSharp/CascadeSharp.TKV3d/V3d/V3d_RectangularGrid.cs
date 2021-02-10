//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKService.Aspect;

namespace CascadeSharp.TKV3d.V3d
{
    //---------------------------------------------------------------------
    //  Class  V3d_RectangularGrid
    //---------------------------------------------------------------------
    public sealed class V3d_RectangularGrid : Aspect_RectangularGrid
    {
        public V3d_RectangularGrid(V3d_Viewer aViewer, Quantity_Color aColor, Quantity_Color aTenthColor)
            : base()
        {
            throw new NotImplementedException();
        }

        public V3d_RectangularGrid(V3d_RectangularGrid parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public V3d_RectangularGrid()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void SetColors(Quantity_Color aColor, Quantity_Color aTenthColor)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Erase()
        {
            throw new NotImplementedException();
        }

        public bool IsDisplayed()
        {
            throw new NotImplementedException();
        }

        public void GraphicValues(ref double XSize, ref double YSize, ref double OffSet)
        {
            throw new NotImplementedException();
        }

        public void SetGraphicValues(double XSize, double YSize, double OffSet)
        {
            throw new NotImplementedException();
        }

        public void UpdateDisplay()
        {
            throw new NotImplementedException();
        }

        public void DefineLines()
        {
            throw new NotImplementedException();
        }

        public void DefinePoints()
        {
            throw new NotImplementedException();
        }
    }; // class V3d_RectangularGrid
}