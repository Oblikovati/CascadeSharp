//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Aspect;
using CascadeSharp.TKService.Graphic3d;

namespace CascadeSharp.TKV3d.V3d
{
	//---------------------------------------------------------------------
	//  Class  V3d_Viewer
	//---------------------------------------------------------------------
	public  sealed class V3d_Viewer : Standard_Transient
	{

		public V3d_Viewer(Graphic3d_GraphicDriver theDriver)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_Viewer(Graphic3d_GraphicDriver theDriver, string theName, string theDomain, double theViewSize, V3d_TypeOfOrientation theViewProj, Quantity_Color theViewBackground, V3d_TypeOfVisualization theV_isualization, Graphic3d_TypeOfShadingModel theShadingModel, bool theComputedMode, bool theDefaultComputedMode)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_Viewer(Graphic3d_GraphicDriver theDriver, string theName, string theDomain, double theViewSize, V3d_TypeOfOrientation theViewProj, Quantity_Color theViewBackground, V3d_TypeOfVisualization theV_isualization, Graphic3d_TypeOfShadingModel theShadingModel, bool theComputedMode)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_Viewer(Graphic3d_GraphicDriver theDriver, string theName, string theDomain, double theViewSize, V3d_TypeOfOrientation theViewProj, Quantity_Color theViewBackground, V3d_TypeOfVisualization theV_isualization, Graphic3d_TypeOfShadingModel theShadingModel)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_Viewer(Graphic3d_GraphicDriver theDriver, string theName, string theDomain, double theViewSize, V3d_TypeOfOrientation theViewProj, Quantity_Color theViewBackground, V3d_TypeOfVisualization theV_isualization)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_Viewer(Graphic3d_GraphicDriver theDriver, string theName, string theDomain, double theViewSize, V3d_TypeOfOrientation theViewProj, Quantity_Color theViewBackground)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_Viewer(Graphic3d_GraphicDriver theDriver, string theName, string theDomain, double theViewSize, V3d_TypeOfOrientation theViewProj)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_Viewer(Graphic3d_GraphicDriver theDriver, string theName, string theDomain, double theViewSize)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_Viewer(Graphic3d_GraphicDriver theDriver, string theName, string theDomain)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_Viewer(Graphic3d_GraphicDriver theDriver, string theName)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_Viewer(V3d_Viewer parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_Viewer()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IfMoreViews()
		{
			throw new NotImplementedException();
		}

		public V3d_View CreateView()
		{
			throw new NotImplementedException();
		}

		public void SetViewOn()
		{
			throw new NotImplementedException();
		}

		public void SetViewOn(V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void SetViewOff()
		{
			throw new NotImplementedException();
		}

		public void SetViewOff(V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

		public void Redraw()
		{
			throw new NotImplementedException();
		}

		public void RedrawImmediate()
		{
			throw new NotImplementedException();
		}

		public void Invalidate()
		{
			throw new NotImplementedException();
		}

		public void Remove()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_GraphicDriver Driver()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_StructureManager StructureManager()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_RenderingParams DefaultRenderingParams()
		{
			throw new NotImplementedException();
		}

		public void SetDefaultRenderingParams(Graphic3d_RenderingParams theParams)
		{
			throw new NotImplementedException();
		}

		public void SetDefaultBackgroundColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public Aspect_GradientBackground GetGradientBackground()
		{
			throw new NotImplementedException();
		}

		public void SetDefaultBgGradientColors(Quantity_Color theColor1, Quantity_Color theColor2, Aspect_GradientFillMethod theFillStyle)
		{
			throw new NotImplementedException();
		}

		public void SetDefaultBgGradientColors(Quantity_Color theColor1, Quantity_Color theColor2)
		{
			throw new NotImplementedException();
		}

		public double DefaultViewSize()
		{
			throw new NotImplementedException();
		}

		public void SetDefaultViewSize(double theSize)
		{
			throw new NotImplementedException();
		}

		public V3d_TypeOfOrientation DefaultViewProj()
		{
			throw new NotImplementedException();
		}

		public void SetDefaultViewProj(V3d_TypeOfOrientation theOrientation)
		{
			throw new NotImplementedException();
		}

		public V3d_TypeOfVisualization DefaultVisualization()
		{
			throw new NotImplementedException();
		}

		public void SetDefaultVisualization(V3d_TypeOfVisualization theType)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_TypeOfShadingModel DefaultShadingModel()
		{
			throw new NotImplementedException();
		}

		public void SetDefaultShadingModel(Graphic3d_TypeOfShadingModel theType)
		{
			throw new NotImplementedException();
		}

		public V3d_TypeOfView DefaultTypeOfView()
		{
			throw new NotImplementedException();
		}

		public void SetDefaultTypeOfView(V3d_TypeOfView theType)
		{
			throw new NotImplementedException();
		}

		public Quantity_Color DefaultBackgroundColor()
		{
			throw new NotImplementedException();
		}

		public void DefaultBgGradientColors(Quantity_Color theColor1, Quantity_Color theColor2)
		{
			throw new NotImplementedException();
		}

		public void GetAllZLayers(TColStd_SequenceOfInteger theLayerSeq)
		{
			throw new NotImplementedException();
		}

		public bool AddZLayer(ref int theLayerId, Graphic3d_ZLayerSettings theSettings)
		{
			throw new NotImplementedException();
		}

		public bool AddZLayer(ref int theLayerId)
		{
			throw new NotImplementedException();
		}

		public bool InsertLayerBefore(ref int theNewLayerId, Graphic3d_ZLayerSettings theSettings, int theLayerAfter)
		{
			throw new NotImplementedException();
		}

		public bool InsertLayerAfter(ref int theNewLayerId, Graphic3d_ZLayerSettings theSettings, int theLayerBefore)
		{
			throw new NotImplementedException();
		}

		public bool RemoveZLayer(int theLayerId)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_ZLayerSettings ZLayerSettings(int theLayerId)
		{
			throw new NotImplementedException();
		}

		public void SetZLayerSettings(int theLayerId, Graphic3d_ZLayerSettings theSettings)
		{
			throw new NotImplementedException();
		}

		public V3d_ListOfView ActiveViews()
		{
			throw new NotImplementedException();
		}

				public bool LastActiveView()
		{
			throw new NotImplementedException();
		}

		public V3d_ListOfView DefinedViews()
		{
			throw new NotImplementedException();
		}

				public void SetDefaultLights()
		{
			throw new NotImplementedException();
		}

		public void SetLightOn(Graphic3d_CLight theLight)
		{
			throw new NotImplementedException();
		}

		public void SetLightOn()
		{
			throw new NotImplementedException();
		}

		public void SetLightOff(Graphic3d_CLight theLight)
		{
			throw new NotImplementedException();
		}

		public void SetLightOff()
		{
			throw new NotImplementedException();
		}

		public void AddLight(Graphic3d_CLight theLight)
		{
			throw new NotImplementedException();
		}

		public void DelLight(Graphic3d_CLight theLight)
		{
			throw new NotImplementedException();
		}

		public void UpdateLights()
		{
			throw new NotImplementedException();
		}

		public bool IsGlobalLight(Graphic3d_CLight TheLight)
		{
			throw new NotImplementedException();
		}

		public V3d_ListOfLight ActiveLights()
		{
			throw new NotImplementedException();
		}

				public V3d_ListOfLight DefinedLights()
		{
			throw new NotImplementedException();
		}

				public void Erase()
		{
			throw new NotImplementedException();
		}

		public void UnHighlight()
		{
			throw new NotImplementedException();
		}

		public bool ComputedMode()
		{
			throw new NotImplementedException();
		}

		public void SetComputedMode(bool theMode)
		{
			throw new NotImplementedException();
		}

		public bool DefaultComputedMode()
		{
			throw new NotImplementedException();
		}

		public void SetDefaultComputedMode(bool theMode)
		{
			throw new NotImplementedException();
		}

		public gp_Ax3 PrivilegedPlane()
		{
			throw new NotImplementedException();
		}

		public void SetPrivilegedPlane(gp_Ax3 thePlane)
		{
			throw new NotImplementedException();
		}

		public void DisplayPrivilegedPlane(bool theOnOff, double theSize)
		{
			throw new NotImplementedException();
		}

		public void DisplayPrivilegedPlane(bool theOnOff)
		{
			throw new NotImplementedException();
		}

		public void ActivateGrid(Aspect_GridType aGridType, Aspect_GridDrawMode aGridDrawMode)
		{
			throw new NotImplementedException();
		}

		public void DeactivateGrid()
		{
			throw new NotImplementedException();
		}

		public void SetGridEcho(bool showGrid)
		{
			throw new NotImplementedException();
		}

		public void SetGridEcho()
		{
			throw new NotImplementedException();
		}

		public void SetGridEcho(Graphic3d_AspectMarker3d aMarker)
		{
			throw new NotImplementedException();
		}

		public bool GridEcho()
		{
			throw new NotImplementedException();
		}

		public bool IsActive()
		{
			throw new NotImplementedException();
		}

		public Aspect_Grid Grid()
		{
			throw new NotImplementedException();
		}

		public Aspect_GridType GridType()
		{
			throw new NotImplementedException();
		}

		public Aspect_GridDrawMode GridDrawMode()
		{
			throw new NotImplementedException();
		}

		public void RectangularGridValues(ref double XOrigin, ref double YOrigin, ref double XStep, ref double YStep, ref double RotationAngle)
		{
			throw new NotImplementedException();
		}

		public void SetRectangularGridValues(double XOrigin, double YOrigin, double XStep, double YStep, double RotationAngle)
		{
			throw new NotImplementedException();
		}

		public void CircularGridValues(ref double XOrigin, ref double YOrigin, ref double RadiusStep, ref int Div_isionNumber, ref double RotationAngle)
		{
			throw new NotImplementedException();
		}

		public void SetCircularGridValues(double XOrigin, double YOrigin, double RadiusStep, int Div_isionNumber, double RotationAngle)
		{
			throw new NotImplementedException();
		}

		public void CircularGridGraphicValues(ref double Radius, ref double OffSet)
		{
			throw new NotImplementedException();
		}

		public void SetCircularGridGraphicValues(double Radius, double OffSet)
		{
			throw new NotImplementedException();
		}

		public void RectangularGridGraphicValues(ref double XSize, ref double YSize, ref double OffSet)
		{
			throw new NotImplementedException();
		}

		public void SetRectangularGridGraphicValues(double XSize, double YSize, double OffSet)
		{
			throw new NotImplementedException();
		}

				public void HideGridEcho(V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void SetDefaultBackgroundColor(Quantity_TypeOfColor theType, double theV1, double theV2, double theV3)
		{
			throw new NotImplementedException();
		}

		public void DefaultBackgroundColor(Quantity_TypeOfColor theType, ref double theV1, ref double theV2, ref double theV3)
		{
			throw new NotImplementedException();
		}

		public void InitActiveViews()
		{
			throw new NotImplementedException();
		}

		public bool MoreActiveViews()
		{
			throw new NotImplementedException();
		}

		public void NextActiveViews()
		{
			throw new NotImplementedException();
		}

		public V3d_View ActiveView()
		{
			throw new NotImplementedException();
		}

		public void InitDefinedViews()
		{
			throw new NotImplementedException();
		}

		public bool MoreDefinedViews()
		{
			throw new NotImplementedException();
		}

		public void NextDefinedViews()
		{
			throw new NotImplementedException();
		}

		public V3d_View DefinedView()
		{
			throw new NotImplementedException();
		}

		public void InitActiveLights()
		{
			throw new NotImplementedException();
		}

		public bool MoreActiveLights()
		{
			throw new NotImplementedException();
		}

		public void NextActiveLights()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_CLight ActiveLight()
		{
			throw new NotImplementedException();
		}

		public void InitDefinedLights()
		{
			throw new NotImplementedException();
		}

		public bool MoreDefinedLights()
		{
			throw new NotImplementedException();
		}

		public void NextDefinedLights()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_CLight DefinedLight()
		{
			throw new NotImplementedException();
		}

						public Aspect_Background GetBackgroundColor()
		{
			throw new NotImplementedException();
		}

		public void AddView(V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void DelView(V3d_View theView)
		{
			throw new NotImplementedException();
		}


	}; // class V3d_Viewer

}
