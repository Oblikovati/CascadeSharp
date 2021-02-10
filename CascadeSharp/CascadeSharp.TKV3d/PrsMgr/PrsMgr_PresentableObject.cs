//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  PrsMgr_PresentableObject
	//---------------------------------------------------------------------
	public  abstract class PrsMgr_PresentableObject : Standard_Transient
	{

				public PrsMgr_PresentableObject(PrsMgr_PresentableObject parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public PrsMgr_PresentableObject()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

								public int ZLayer()
		{
			throw new NotImplementedException();
		}

		public void SetZLayer(int theLayerId)
		{
			throw new NotImplementedException();
		}

		public bool IsMutable()
		{
			throw new NotImplementedException();
		}

		public void SetMutable(bool theIsMutable)
		{
			throw new NotImplementedException();
		}

		public bool HasDisplayMode()
		{
			throw new NotImplementedException();
		}

		public int DisplayMode()
		{
			throw new NotImplementedException();
		}

		public void SetDisplayMode(int theMode)
		{
			throw new NotImplementedException();
		}

		public void UnsetDisplayMode()
		{
			throw new NotImplementedException();
		}

		public bool HasHilightMode()
		{
			throw new NotImplementedException();
		}

		public int HilightMode()
		{
			throw new NotImplementedException();
		}

		public void SetHilightMode(int theMode)
		{
			throw new NotImplementedException();
		}

		public void UnsetHilightMode()
		{
			throw new NotImplementedException();
		}

		public bool AcceptDisplayMode(int theMode)
		{
			throw new NotImplementedException();
		}

		public int DefaultDisplayMode()
		{
			throw new NotImplementedException();
		}

		public bool ToBeUpdated(bool theToIncludeHidden)
		{
			throw new NotImplementedException();
		}

		public bool ToBeUpdated()
		{
			throw new NotImplementedException();
		}

		public void SetToUpdate(int theMode)
		{
			throw new NotImplementedException();
		}

		public void SetToUpdate()
		{
			throw new NotImplementedException();
		}

		public bool IsInfinite()
		{
			throw new NotImplementedException();
		}

		public void SetInfiniteState(bool theFlag)
		{
			throw new NotImplementedException();
		}

		public void SetInfiniteState()
		{
			throw new NotImplementedException();
		}

						public Prs3d_Drawer Attributes()
		{
			throw new NotImplementedException();
		}

		public void SetAttributes(Prs3d_Drawer theDrawer)
		{
			throw new NotImplementedException();
		}

		public Prs3d_Drawer HilightAttributes()
		{
			throw new NotImplementedException();
		}

		public void SetHilightAttributes(Prs3d_Drawer theDrawer)
		{
			throw new NotImplementedException();
		}

		public Prs3d_Drawer DynamicHilightAttributes()
		{
			throw new NotImplementedException();
		}

		public void SetDynamicHilightAttributes(Prs3d_Drawer theDrawer)
		{
			throw new NotImplementedException();
		}

		public void UnsetHilightAttributes()
		{
			throw new NotImplementedException();
		}

		public void SynchronizeAspects()
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

		public TopLoc_Datum3D LocalTransformationGeom()
		{
			throw new NotImplementedException();
		}

		public void SetLocalTransformation(gp_Trsf theTrsf)
		{
			throw new NotImplementedException();
		}

		public void SetLocalTransformation(TopLoc_Datum3D theTrsf)
		{
			throw new NotImplementedException();
		}

		public bool HasTransformation()
		{
			throw new NotImplementedException();
		}

		public TopLoc_Datum3D TransformationGeom()
		{
			throw new NotImplementedException();
		}

		public gp_Trsf LocalTransformation()
		{
			throw new NotImplementedException();
		}

		public gp_Trsf Transformation()
		{
			throw new NotImplementedException();
		}

		public gp_GTrsf InversedTransformation()
		{
			throw new NotImplementedException();
		}

		public TopLoc_Datum3D CombinedParentTransformation()
		{
			throw new NotImplementedException();
		}

		public void ResetTransformation()
		{
			throw new NotImplementedException();
		}

		public void UpdateTransformation()
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

		public void AddClipPlane(Graphic3d_ClipPlane thePlane)
		{
			throw new NotImplementedException();
		}

		public void RemoveClipPlane(Graphic3d_ClipPlane thePlane)
		{
			throw new NotImplementedException();
		}

		public PrsMgr_PresentableObject Parent()
		{
			throw new NotImplementedException();
		}

				public void AddChild(PrsMgr_PresentableObject theObject)
		{
			throw new NotImplementedException();
		}

		public void AddChildWithCurrentTransformation(PrsMgr_PresentableObject theObject)
		{
			throw new NotImplementedException();
		}

		public void RemoveChild(PrsMgr_PresentableObject theObject)
		{
			throw new NotImplementedException();
		}

		public void RemoveChildWithRestoreTransformation(PrsMgr_PresentableObject theObject)
		{
			throw new NotImplementedException();
		}

		public bool HasOwnPresentations()
		{
			throw new NotImplementedException();
		}

		public void BoundingBox(Bnd_Box theBndBox)
		{
			throw new NotImplementedException();
		}

						public void computeHLR(Graphic3d_Camera theProjector, TopLoc_Datum3D theTrsf, Graphic3d_Structure thePrs)
		{
			throw new NotImplementedException();
		}

		public bool UpdatePresentations(bool theToIncludeHidden)
		{
			throw new NotImplementedException();
		}

		public bool UpdatePresentations()
		{
			throw new NotImplementedException();
		}

		public void UpdateClipping()
		{
			throw new NotImplementedException();
		}

		public void SetCombinedParentTransform(TopLoc_Datum3D theTrsf)
		{
			throw new NotImplementedException();
		}

		public void setLocalTransformation(TopLoc_Datum3D theTransformation)
		{
			throw new NotImplementedException();
		}

		public gp_Trsf getIdentityTrsf()
		{
			throw new NotImplementedException();
		}

		public void recomputeComputed()
		{
			throw new NotImplementedException();
		}

		public void replaceAspects(Graphic3d_MapOfAspectsToAspects theMap)
		{
			throw new NotImplementedException();
		}

		public void SetIsoOnTriangulation(bool theIsEnabled)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Aspect_TypeOfFacingModel CurrentFacingModel()
		{
			throw new NotImplementedException();
		}

		public void SetCurrentFacingModel(CascadeSharp.Aspect_TypeOfFacingModel theModel)
		{
			throw new NotImplementedException();
		}

		public void SetCurrentFacingModel()
		{
			throw new NotImplementedException();
		}

		public bool HasColor()
		{
			throw new NotImplementedException();
		}

		public void Color(Quantity_Color theColor)
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

		public bool HasWidth()
		{
			throw new NotImplementedException();
		}

		public double Width()
		{
			throw new NotImplementedException();
		}

		public void SetWidth(double theWidth)
		{
			throw new NotImplementedException();
		}

		public void UnsetWidth()
		{
			throw new NotImplementedException();
		}

		public bool HasMaterial()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Graphic3d_NameOfMaterial Material()
		{
			throw new NotImplementedException();
		}

		public void SetMaterial(Graphic3d_MaterialAspect aName)
		{
			throw new NotImplementedException();
		}

		public void UnsetMaterial()
		{
			throw new NotImplementedException();
		}

		public bool IsTransparent()
		{
			throw new NotImplementedException();
		}

		public double Transparency()
		{
			throw new NotImplementedException();
		}

		public void SetTransparency(double aValue)
		{
			throw new NotImplementedException();
		}

		public void SetTransparency()
		{
			throw new NotImplementedException();
		}

		public void UnsetTransparency()
		{
			throw new NotImplementedException();
		}

		public bool HasPolygonOffsets()
		{
			throw new NotImplementedException();
		}

		public void PolygonOffsets(ref int aMode, ref float aFactor, ref float aUnits)
		{
			throw new NotImplementedException();
		}

		public void SetPolygonOffsets(int aMode, float aFactor, float aUnits)
		{
			throw new NotImplementedException();
		}

		public void SetPolygonOffsets(int aMode, float aFactor)
		{
			throw new NotImplementedException();
		}

		public void SetPolygonOffsets(int aMode)
		{
			throw new NotImplementedException();
		}

		public void UnsetAttributes()
		{
			throw new NotImplementedException();
		}

						public void ToBeUpdated(TColStd_ListOfInteger L_istOfMode)
		{
			throw new NotImplementedException();
		}

		public void SetTransformPersistence(CascadeSharp.Graphic3d_TransModeFlags theMode, gp_Pnt thePoint)
		{
			throw new NotImplementedException();
		}

		public void SetTransformPersistence(CascadeSharp.Graphic3d_TransModeFlags theMode)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Graphic3d_TransModeFlags GetTransformPersistenceMode()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt GetTransformPersistencePoint()
		{
			throw new NotImplementedException();
		}

		public bool ToPropagateVisualState()
		{
			throw new NotImplementedException();
		}

		public void SetPropagateVisualState(bool theFlag)
		{
			throw new NotImplementedException();
		}

		public void Update(bool theToIncludeHidden)
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

		public void Update(int theMode, bool theToClearOther)
		{
			throw new NotImplementedException();
		}


	}; // class PrsMgr_PresentableObject

}
