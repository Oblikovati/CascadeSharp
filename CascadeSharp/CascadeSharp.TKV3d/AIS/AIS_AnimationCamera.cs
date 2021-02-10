//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.V3d;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_AnimationCamera
	//---------------------------------------------------------------------
	public  sealed class AIS_AnimationCamera : AIS_Animation
	{

		public AIS_AnimationCamera(TCollection_AsciiString theAnimationName, V3d_View theView)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_AnimationCamera(AIS_AnimationCamera parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_AnimationCamera()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public V3d_View View()
		{
			throw new NotImplementedException();
		}

		public void SetView(V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Camera CameraStart()
		{
			throw new NotImplementedException();
		}

		public void SetCameraStart(Graphic3d_Camera theCameraStart)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Camera CameraEnd()
		{
			throw new NotImplementedException();
		}

		public void SetCameraEnd(Graphic3d_Camera theCameraEnd)
		{
			throw new NotImplementedException();
		}

		public void update(AIS_AnimationProgress theProgress)
		{
			throw new NotImplementedException();
		}


	}; // class AIS_AnimationCamera

}
