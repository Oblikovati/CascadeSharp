//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;
using CascadeSharp.TKService.Image;
using CascadeSharp.TKV3d.StdSelect;
using CascadeSharp.TKV3d.V3d;

namespace CascadeSharp.TKV3d.SelectMgr
{
	//---------------------------------------------------------------------
	//  Class  SelectMgr_ViewerSelector3d
	//---------------------------------------------------------------------
	public  sealed class SelectMgr_ViewerSelector3d : SelectMgr_ViewerSelector
	{

		public SelectMgr_ViewerSelector3d()
			: base()
		{
			throw new NotImplementedException();
		}

		public SelectMgr_ViewerSelector3d(SelectMgr_ViewerSelector3d parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Pick(int theXPix, int theYPix, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void Pick(int theXPMin, int theYPMin, int theXPMax, int theYPMax, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void Pick(TColgp_Array1OfPnt2d thePolyline, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public bool ToPixMap(Image_PixMap theImage, V3d_View theView, StdSelect_TypeOfSelectionImage theType, int thePickedIndex)
		{
			throw new NotImplementedException();
		}

		public bool ToPixMap(Image_PixMap theImage, V3d_View theView, StdSelect_TypeOfSelectionImage theType)
		{
			throw new NotImplementedException();
		}

		public void DisplaySensitive(V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void ClearSensitive(V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void DisplaySensitive(SelectMgr_Selection theSel, gp_Trsf theTrsf, V3d_View theView, bool theToClearOthers)
		{
			throw new NotImplementedException();
		}

		public void DisplaySensitive(SelectMgr_Selection theSel, gp_Trsf theTrsf, V3d_View theView)
		{
			throw new NotImplementedException();
		}

						public void updateZLayers(V3d_View theView)
		{
			throw new NotImplementedException();
		}


	}; // class SelectMgr_ViewerSelector3d

}
