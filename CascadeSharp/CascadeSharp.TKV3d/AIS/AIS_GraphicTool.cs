//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKService.Aspect;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.Prs3d;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_GraphicTool
	//---------------------------------------------------------------------
	public  sealed class AIS_GraphicTool
	{

		public AIS_GraphicTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_GraphicTool(AIS_GraphicTool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Quantity_NameOfColor GetLineColor(Prs3d_Drawer aDrawer, AIS_TypeOfAttribute TheTypeOfAttributes)
		{
			throw new NotImplementedException();
		}

		public void GetLineColor(Prs3d_Drawer aDrawer, AIS_TypeOfAttribute TheTypeOfAttributes, Quantity_Color TheLineColor)
		{
			throw new NotImplementedException();
		}

		public double GetLineWidth(Prs3d_Drawer aDrawer, AIS_TypeOfAttribute TheTypeOfAttributes)
		{
			throw new NotImplementedException();
		}

		public Aspect_TypeOfLine GetLineType(Prs3d_Drawer aDrawer, AIS_TypeOfAttribute TheTypeOfAttributes)
		{
			throw new NotImplementedException();
		}

		public void GetLineAtt(Prs3d_Drawer aDrawer, AIS_TypeOfAttribute TheTypeOfAttributes,  ref Quantity_NameOfColor aCol, ref double aWidth,  ref Aspect_TypeOfLine aTyp)
		{
			throw new NotImplementedException();
		}

		public Quantity_NameOfColor GetInteriorColor(Prs3d_Drawer aDrawer)
		{
			throw new NotImplementedException();
		}

		public void GetInteriorColor(Prs3d_Drawer aDrawer, Quantity_Color aColor)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_MaterialAspect GetMaterial(Prs3d_Drawer aDrawer)
		{
			throw new NotImplementedException();
		}


	}; // class AIS_GraphicTool

}
