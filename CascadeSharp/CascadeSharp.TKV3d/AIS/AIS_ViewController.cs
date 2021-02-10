//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Aspect;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKService.WNT;
using CascadeSharp.TKV3d.V3d;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_ViewController
	//---------------------------------------------------------------------
	public  sealed class AIS_ViewController
	{

		public AIS_ViewController()
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_ViewInputBuffer InputBuffer(AIS_ViewInputBufferType theType)
		{
			throw new NotImplementedException();
		}

		public AIS_ViewInputBuffer ChangeInputBuffer(AIS_ViewInputBufferType theType)
		{
			throw new NotImplementedException();
		}

		public AIS_AnimationCamera ViewAnimation()
		{
			throw new NotImplementedException();
		}

		public void SetViewAnimation(AIS_AnimationCamera theAnimation)
		{
			throw new NotImplementedException();
		}

		public void AbortViewAnimation()
		{
			throw new NotImplementedException();
		}

		public AIS_RotationMode RotationMode()
		{
			throw new NotImplementedException();
		}

		public void SetRotationMode(AIS_RotationMode theMode)
		{
			throw new NotImplementedException();
		}

		public AIS_NavigationMode NavigationMode()
		{
			throw new NotImplementedException();
		}

		public void SetNavigationMode(AIS_NavigationMode theMode)
		{
			throw new NotImplementedException();
		}

		public float MouseAcceleration()
		{
			throw new NotImplementedException();
		}

		public void SetMouseAcceleration(float theRatio)
		{
			throw new NotImplementedException();
		}

		public float OrbitAcceleration()
		{
			throw new NotImplementedException();
		}

		public void SetOrbitAcceleration(float theRatio)
		{
			throw new NotImplementedException();
		}

		public bool ToShowPanAnchorPoint()
		{
			throw new NotImplementedException();
		}

		public void SetShowPanAnchorPoint(bool theToShow)
		{
			throw new NotImplementedException();
		}

		public bool ToShowRotateCenter()
		{
			throw new NotImplementedException();
		}

		public void SetShowRotateCenter(bool theToShow)
		{
			throw new NotImplementedException();
		}

		public bool ToLockOrbitZUp()
		{
			throw new NotImplementedException();
		}

		public void SetLockOrbitZUp(bool theToForceUp)
		{
			throw new NotImplementedException();
		}

		public bool ToAllowTouchZRotation()
		{
			throw new NotImplementedException();
		}

		public void SetAllowTouchZRotation(bool theToEnable)
		{
			throw new NotImplementedException();
		}

		public bool ToAllowRotation()
		{
			throw new NotImplementedException();
		}

		public void SetAllowRotation(bool theToEnable)
		{
			throw new NotImplementedException();
		}

		public bool ToAllowPanning()
		{
			throw new NotImplementedException();
		}

		public void SetAllowPanning(bool theToEnable)
		{
			throw new NotImplementedException();
		}

		public bool ToAllowZooming()
		{
			throw new NotImplementedException();
		}

		public void SetAllowZooming(bool theToEnable)
		{
			throw new NotImplementedException();
		}

		public bool ToAllowZFocus()
		{
			throw new NotImplementedException();
		}

		public void SetAllowZFocus(bool theToEnable)
		{
			throw new NotImplementedException();
		}

		public bool ToAllowHighlight()
		{
			throw new NotImplementedException();
		}

		public void SetAllowHighlight(bool theToEnable)
		{
			throw new NotImplementedException();
		}

		public bool ToAllowDragging()
		{
			throw new NotImplementedException();
		}

		public void SetAllowDragging(bool theToEnable)
		{
			throw new NotImplementedException();
		}

		public bool ToStickToRayOnZoom()
		{
			throw new NotImplementedException();
		}

		public void SetStickToRayOnZoom(bool theToEnable)
		{
			throw new NotImplementedException();
		}

		public bool ToStickToRayOnRotation()
		{
			throw new NotImplementedException();
		}

		public void SetStickToRayOnRotation(bool theToEnable)
		{
			throw new NotImplementedException();
		}

		public bool ToInvertPitch()
		{
			throw new NotImplementedException();
		}

		public void SetInvertPitch(bool theToInvert)
		{
			throw new NotImplementedException();
		}

		public float WalkSpeedAbsolute()
		{
			throw new NotImplementedException();
		}

		public void SetWalkSpeedAbsolute(float theSpeed)
		{
			throw new NotImplementedException();
		}

		public float WalkSpeedRelative()
		{
			throw new NotImplementedException();
		}

		public void SetWalkSpeedRelative(float theFactor)
		{
			throw new NotImplementedException();
		}

		public float ThrustSpeed()
		{
			throw new NotImplementedException();
		}

		public void SetThrustSpeed(float theSpeed)
		{
			throw new NotImplementedException();
		}

		public bool HasPreviousMoveTo()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Vec2i PreviousMoveTo()
		{
			throw new NotImplementedException();
		}

		public void ResetPreviousMoveTo()
		{
			throw new NotImplementedException();
		}

		public bool ToDisplayXRAuxDevices()
		{
			throw new NotImplementedException();
		}

		public void SetDisplayXRAuxDevices(bool theToD_isplay)
		{
			throw new NotImplementedException();
		}

		public bool ToDisplayXRHands()
		{
			throw new NotImplementedException();
		}

		public void SetDisplayXRHands(bool theToD_isplay)
		{
			throw new NotImplementedException();
		}

		public Aspect_VKeySet Keys()
		{
			throw new NotImplementedException();
		}

		public Aspect_VKeySet ChangeKeys()
		{
			throw new NotImplementedException();
		}

		public void KeyDown(uint theKey, double theTime, double thePressure)
		{
			throw new NotImplementedException();
		}

		public void KeyDown(uint theKey, double theTime)
		{
			throw new NotImplementedException();
		}

		public void KeyUp(uint theKey, double theTime)
		{
			throw new NotImplementedException();
		}

		public void KeyFromAxis(uint theNegative, uint thePositive, double theTime, double thePressure)
		{
			throw new NotImplementedException();
		}

		public AIS_WalkDelta FetchNavigationKeys(double theCrouchRatio, double theRunRatio)
		{
			throw new NotImplementedException();
		}

						public double MouseDoubleClickInterval()
		{
			throw new NotImplementedException();
		}

		public void SetMouseDoubleClickInterval(double theSeconds)
		{
			throw new NotImplementedException();
		}

		public void SelectInViewer(Graphic3d_Vec2i thePnt, bool theIsXOR)
		{
			throw new NotImplementedException();
		}

		public void SelectInViewer(Graphic3d_Vec2i thePnt)
		{
			throw new NotImplementedException();
		}

						public void UpdateRubberBand(Graphic3d_Vec2i thePntFrom, Graphic3d_Vec2i thePntTo, bool theIsXOR)
		{
			throw new NotImplementedException();
		}

		public void UpdateRubberBand(Graphic3d_Vec2i thePntFrom, Graphic3d_Vec2i thePntTo)
		{
			throw new NotImplementedException();
		}

		public void UpdatePolySelection(Graphic3d_Vec2i thePnt, bool theToAppend)
		{
			throw new NotImplementedException();
		}

		public bool UpdateZoom(Aspect_ScrollDelta theDelta)
		{
			throw new NotImplementedException();
		}

		public bool UpdateZRotation(double theAngle)
		{
			throw new NotImplementedException();
		}

		public bool UpdateMouseScroll(Aspect_ScrollDelta theDelta)
		{
			throw new NotImplementedException();
		}

		public bool UpdateMouseButtons(Graphic3d_Vec2i thePoint, uint theButtons, uint theModifiers, bool theIsEmulated)
		{
			throw new NotImplementedException();
		}

		public bool UpdateMousePosition(Graphic3d_Vec2i thePoint, uint theButtons, uint theModifiers, bool theIsEmulated)
		{
			throw new NotImplementedException();
		}

		public bool PressMouseButton(Graphic3d_Vec2i thePoint, uint theButton, uint theModifiers, bool theIsEmulated)
		{
			throw new NotImplementedException();
		}

		public bool ReleaseMouseButton(Graphic3d_Vec2i thePoint, uint theButton, uint theModifiers, bool theIsEmulated)
		{
			throw new NotImplementedException();
		}

		public bool UpdateMouseClick(Graphic3d_Vec2i thePoint, uint theButton, uint theModifiers, bool theIsDoubleClick)
		{
			throw new NotImplementedException();
		}

		public uint PressedMouseButtons()
		{
			throw new NotImplementedException();
		}

		public uint LastMouseFlags()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Vec2i LastMousePosition()
		{
			throw new NotImplementedException();
		}

		public float TouchToleranceScale()
		{
			throw new NotImplementedException();
		}

		public void SetTouchToleranceScale(float theTolerance)
		{
			throw new NotImplementedException();
		}

		public bool HasTouchPoints()
		{
			throw new NotImplementedException();
		}

		public void AddTouchPoint(ulong theId, Graphic3d_Vec2d thePnt, bool theClearBefore)
		{
			throw new NotImplementedException();
		}

		public void AddTouchPoint(ulong theId, Graphic3d_Vec2d thePnt)
		{
			throw new NotImplementedException();
		}

		public bool RemoveTouchPoint(ulong theId, bool theClearSelectPnts)
		{
			throw new NotImplementedException();
		}

		public bool RemoveTouchPoint(ulong theId)
		{
			throw new NotImplementedException();
		}

		public void UpdateTouchPoint(ulong theId, Graphic3d_Vec2d thePnt)
		{
			throw new NotImplementedException();
		}

		public float Get3dMouseTranslationScale()
		{
			throw new NotImplementedException();
		}

		public void Set3dMouseTranslationScale(float theScale)
		{
			throw new NotImplementedException();
		}

		public float Get3dMouseRotationScale()
		{
			throw new NotImplementedException();
		}

		public void Set3dMouseRotationScale(float theScale)
		{
			throw new NotImplementedException();
		}

		public bool To3dMousePreciseInput()
		{
			throw new NotImplementedException();
		}

		public void Set3dMousePreciseInput(bool theIsQuadric)
		{
			throw new NotImplementedException();
		}

										public bool Update3dMouse(WNT_HIDSpaceMouse theEvent)
		{
			throw new NotImplementedException();
		}

		public bool update3dMouseTranslation(WNT_HIDSpaceMouse theEvent)
		{
			throw new NotImplementedException();
		}

		public bool update3dMouseRotation(WNT_HIDSpaceMouse theEvent)
		{
			throw new NotImplementedException();
		}

		public bool update3dMouseKeys(WNT_HIDSpaceMouse theEvent)
		{
			throw new NotImplementedException();
		}

		public double EventTime()
		{
			throw new NotImplementedException();
		}

		public void ResetViewInput()
		{
			throw new NotImplementedException();
		}

		public void UpdateViewOrientation(V3d_TypeOfOrientation theOrientation, bool theToFitAll)
		{
			throw new NotImplementedException();
		}

		public void FlushViewEvents(AIS_InteractiveContext theCtx, V3d_View theView, bool theToHandle)
		{
			throw new NotImplementedException();
		}

		public void FlushViewEvents(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void HandleViewEvents(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void OnSelectionChanged(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void OnObjectDragged(AIS_InteractiveContext theCtx, V3d_View theView, AIS_DragAction theAction)
		{
			throw new NotImplementedException();
		}

		public bool PickPoint(gp_Pnt thePnt, AIS_InteractiveContext theCtx, V3d_View theView, Graphic3d_Vec2i theCursor, bool theToStickToPickRay)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt GravityPoint(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void FitAllAuto(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void handleViewOrientationKeys(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public AIS_WalkDelta handleNavigationKeys(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void handleCameraActions(AIS_InteractiveContext theCtx, V3d_View theView, AIS_WalkDelta theWalk)
		{
			throw new NotImplementedException();
		}

		public void handleMoveTo(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public bool toAskNextFrame()
		{
			throw new NotImplementedException();
		}

		public void setAskNextFrame(bool theToDraw)
		{
			throw new NotImplementedException();
		}

		public void setAskNextFrame()
		{
			throw new NotImplementedException();
		}

		public bool hasPanningAnchorPoint()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt panningAnchorPoint()
		{
			throw new NotImplementedException();
		}

		public void setPanningAnchorPoint(gp_Pnt thePnt)
		{
			throw new NotImplementedException();
		}

		public void handlePanning(V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void handleZRotate(V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public double MinZoomDistance()
		{
			throw new NotImplementedException();
		}

		public void SetMinZoomDistance(double theD_ist)
		{
			throw new NotImplementedException();
		}

		public void handleZoom(V3d_View theView, Aspect_ScrollDelta theParams, gp_Pnt thePnt)
		{
			throw new NotImplementedException();
		}

		public void handleZFocusScroll(V3d_View theView, Aspect_ScrollDelta theParams)
		{
			throw new NotImplementedException();
		}

		public void handleOrbitRotation(V3d_View theView, gp_Pnt thePnt, bool theToLockZUp)
		{
			throw new NotImplementedException();
		}

		public void handleViewRotation(V3d_View theView, double theYawExtra, double thePitchExtra, double theRoll, bool theToRestartOnIncrement)
		{
			throw new NotImplementedException();
		}

		public void handleViewRedraw(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void handleXRInput(AIS_InteractiveContext theCtx, V3d_View theView, AIS_WalkDelta theWalk)
		{
			throw new NotImplementedException();
		}

		public void handleXRTurnPad(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void handleXRTeleport(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void handleXRPicking(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void handleXRHighlight(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void handleXRPresentations(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public int handleXRMoveTo(AIS_InteractiveContext theCtx, V3d_View theView, gp_Trsf thePose, bool theToHighlight)
		{
			throw new NotImplementedException();
		}

		public void flushBuffers(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void flushGestures(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void updateEventsTime(ref double thePrevTime, ref double theCurrTime)
		{
			throw new NotImplementedException();
		}

		public void handleSelectionPick(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void handleDynamicHighlight(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void handleSelectionPoly(AIS_InteractiveContext theCtx, V3d_View theView)
		{
			throw new NotImplementedException();
		}

		public void contextLazyMoveTo(AIS_InteractiveContext theCtx, V3d_View theView, Graphic3d_Vec2i thePnt)
		{
			throw new NotImplementedException();
		}


	}; // class AIS_ViewController

}
