//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_CameraFrustum
	//---------------------------------------------------------------------
	public  sealed class AIS_CameraFrustum : AIS_InteractiveObject
	{

		public AIS_CameraFrustum()
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_CameraFrustum(AIS_CameraFrustum parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void SetCameraFrustum(Graphic3d_Camera theCamera)
		{
			throw new NotImplementedException();
		}

		public void SetColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void UnsetColor()
		{
			throw new NotImplementedException();
		}

		public void UnsetTransparency()
		{
			throw new NotImplementedException();
		}

		public bool AcceptDisplayMode(int theMode)
		{
			throw new NotImplementedException();
		}

				public void ComputeSelection(SelectMgr_Selection theSelection, int theMode)
		{
			throw new NotImplementedException();
		}

		public void fillTriangles()
		{
			throw new NotImplementedException();
		}

		public void fillBorders()
		{
			throw new NotImplementedException();
		}


		//---------------------------------------------------------------------
		//  Enum  SelectionMode
		//---------------------------------------------------------------------
		public		enum SelectionMode
		{
			SelectionMode_Edges = 0,
			SelectionMode_Volume = 1
		} // enum  class SelectionMode

	}; // class AIS_CameraFrustum

}
