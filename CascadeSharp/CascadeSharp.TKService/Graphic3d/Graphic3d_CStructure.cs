//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_CStructure
	//---------------------------------------------------------------------
	public  abstract class Graphic3d_CStructure : Standard_Transient
	{

		public Graphic3d_CStructure(Graphic3d_StructureManager theManager)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_CStructure(Graphic3d_CStructure parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_CStructure()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_GraphicDriver GraphicDriver()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_SequenceOfGroup Groups()
		{
			throw new NotImplementedException();
		}

		public TopLoc_Datum3D Transformation()
		{
			throw new NotImplementedException();
		}

		public void SetTransformation(TopLoc_Datum3D theTrsf)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_TransformPers TransformPersistence()
		{
			throw new NotImplementedException();
		}

		public void SetTransformPersistence(Graphic3d_TransformPers theTrsfPers)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_SequenceOfHClipPlane ClipPlanes()
		{
			throw new NotImplementedException();
		}

		public void SetClipPlanes(Graphic3d_SequenceOfHClipPlane thePlanes)
		{
			throw new NotImplementedException();
		}

						public bool IsVisible()
		{
			throw new NotImplementedException();
		}

		public bool IsVisible(int theViewId)
		{
			throw new NotImplementedException();
		}

		public void SetZLayer(int theLayerIndex)
		{
			throw new NotImplementedException();
		}

		public int ZLayer()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_PresentationAttributes HighlightStyle()
		{
			throw new NotImplementedException();
		}

		public bool IsCulled()
		{
			throw new NotImplementedException();
		}

		public void SetCulled(bool theIsCulled)
		{
			throw new NotImplementedException();
		}

		public void MarkAsNotCulled()
		{
			throw new NotImplementedException();
		}

		public bool BndBoxClipCheck()
		{
			throw new NotImplementedException();
		}

		public void SetBndBoxClipCheck(bool theBndBoxClipCheck)
		{
			throw new NotImplementedException();
		}

		public bool IsAlwaysRendered()
		{
			throw new NotImplementedException();
		}

		public void OnVisibilityChanged()
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void Connect(Graphic3d_CStructure theStructure)
		{
			throw new NotImplementedException();
		}

		public void Disconnect(Graphic3d_CStructure theStructure)
		{
			throw new NotImplementedException();
		}

		public void GraphicHighlight(Graphic3d_PresentationAttributes theStyle)
		{
			throw new NotImplementedException();
		}

		public void GraphicUnhighlight()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_CStructure ShadowLink(Graphic3d_StructureManager theManager)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Group NewGroup(Graphic3d_Structure theStruct)
		{
			throw new NotImplementedException();
		}

		public void RemoveGroup(Graphic3d_Group theGroup)
		{
			throw new NotImplementedException();
		}

		public void updateLayerTransformation()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Graphic3d_CStructure

}
