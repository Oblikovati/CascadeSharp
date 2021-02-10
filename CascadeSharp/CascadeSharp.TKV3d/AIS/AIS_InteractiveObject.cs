//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  AIS_InteractiveObject
	//---------------------------------------------------------------------
	public  abstract class AIS_InteractiveObject : CascadeSharp.SelectMgr_SelectableObject
	{

				public AIS_InteractiveObject(AIS_InteractiveObject parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public AIS_InteractiveObject()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public CascadeSharp.AIS_KindOfInteractive Type()
		{
			throw new NotImplementedException();
		}

		public int Signature()
		{
			throw new NotImplementedException();
		}

		public void Redisplay(bool AllModes)
		{
			throw new NotImplementedException();
		}

		public void Redisplay()
		{
			throw new NotImplementedException();
		}

		public bool HasInteractiveContext()
		{
			throw new NotImplementedException();
		}

		public AIS_InteractiveContext InteractiveContext()
		{
			throw new NotImplementedException();
		}

		public void SetContext(AIS_InteractiveContext aCtx)
		{
			throw new NotImplementedException();
		}

		public bool HasOwner()
		{
			throw new NotImplementedException();
		}

		public Standard_Transient GetOwner()
		{
			throw new NotImplementedException();
		}

		public void SetOwner(Standard_Transient theApplicativeEntity)
		{
			throw new NotImplementedException();
		}

		public void ClearOwner()
		{
			throw new NotImplementedException();
		}

		public bool ProcessDragging(AIS_InteractiveContext theCtx, V3d_View theView, SelectMgr_EntityOwner theOwner, Graphic3d_Vec2i theDragFrom, Graphic3d_Vec2i theDragTo, CascadeSharp.AIS_DragAction theAction)
		{
			throw new NotImplementedException();
		}

		public AIS_InteractiveContext GetContext()
		{
			throw new NotImplementedException();
		}

		public bool HasPresentation()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Structure Presentation()
		{
			throw new NotImplementedException();
		}

		public void SetAspect(Prs3d_BasicAspect anAspect)
		{
			throw new NotImplementedException();
		}

				
	}; // class AIS_InteractiveObject

}
