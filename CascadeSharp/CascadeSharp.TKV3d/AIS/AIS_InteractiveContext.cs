//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;
using CascadeSharp.TKMath.TopLoc;
using CascadeSharp.TKService.Aspect;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.Prs3d;
using CascadeSharp.TKV3d.SelectMgr;
using CascadeSharp.TKV3d.V3d;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_InteractiveContext
    //---------------------------------------------------------------------
    public sealed class AIS_InteractiveContext : Standard_Transient
    {
        public AIS_InteractiveContext(V3d_Viewer MainViewer)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveContext(AIS_InteractiveContext parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveContext()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public AIS_DisplayStatus DisplayStatus(AIS_InteractiveObject anIobj)
        {
            throw new NotImplementedException();
        }

        public void Status(AIS_InteractiveObject anObj, TCollection_ExtendedString astatus)
        {
            throw new NotImplementedException();
        }

        public bool IsDisplayed(AIS_InteractiveObject anIobj)
        {
            throw new NotImplementedException();
        }

        public bool IsDisplayed(AIS_InteractiveObject aniobj, int aMode)
        {
            throw new NotImplementedException();
        }

        public void SetAutoActivateSelection(bool theIsAuto)
        {
            throw new NotImplementedException();
        }

        public bool GetAutoActivateSelection()
        {
            throw new NotImplementedException();
        }

        public void Display(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void Display(AIS_InteractiveObject theIObj, int theD_ispMode, int theSelectionMode,
            bool theToUpdateViewer, AIS_DisplayStatus theD_ispStatus)
        {
            throw new NotImplementedException();
        }

        public void Display(AIS_InteractiveObject theIObj, int theD_ispMode, int theSelectionMode,
            bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void Load(AIS_InteractiveObject theObj, int theSelectionMode)
        {
            throw new NotImplementedException();
        }

        public void Load(AIS_InteractiveObject theObj)
        {
            throw new NotImplementedException();
        }

        public void Display(AIS_InteractiveObject theIObj, int theD_ispMode, int theSelectionMode,
            bool theToUpdateViewer, bool theToAllowDecomposition, AIS_DisplayStatus theD_ispStatus)
        {
            throw new NotImplementedException();
        }

        public void Display(AIS_InteractiveObject theIObj, int theD_ispMode, int theSelectionMode,
            bool theToUpdateViewer, bool theToAllowDecomposition)
        {
            throw new NotImplementedException();
        }

        public void Load(AIS_InteractiveObject theObj, int theSelectionMode, bool parameter1)
        {
            throw new NotImplementedException();
        }

        public void Erase(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void EraseAll(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void DisplayAll(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void EraseSelected(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void DisplaySelected(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void ClearPrs(AIS_InteractiveObject theIObj, int theMode, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void Remove(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void RemoveAll(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void Redisplay(AIS_InteractiveObject theIObj, bool theToUpdateViewer, bool theAllModes)
        {
            throw new NotImplementedException();
        }

        public void Redisplay(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void Redisplay(AIS_KindOfInteractive theTypeOfObject, int theSignature, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void RecomputePrsOnly(AIS_InteractiveObject theIObj, bool theToUpdateViewer, bool theAllModes)
        {
            throw new NotImplementedException();
        }

        public void RecomputePrsOnly(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void RecomputeSelectionOnly(AIS_InteractiveObject anIObj)
        {
            throw new NotImplementedException();
        }

        public void Update(AIS_InteractiveObject theIObj, bool theUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public Prs3d_Drawer HighlightStyle(Prs3d_TypeOfHighlight theStyleType)
        {
            throw new NotImplementedException();
        }

        public void SetHighlightStyle(Prs3d_TypeOfHighlight theStyleType, Prs3d_Drawer theStyle)
        {
            throw new NotImplementedException();
        }

        public Prs3d_Drawer HighlightStyle()
        {
            throw new NotImplementedException();
        }

        public void SetHighlightStyle(Prs3d_Drawer theStyle)
        {
            throw new NotImplementedException();
        }

        public Prs3d_Drawer SelectionStyle()
        {
            throw new NotImplementedException();
        }

        public void SetSelectionStyle(Prs3d_Drawer theStyle)
        {
            throw new NotImplementedException();
        }

        public bool HighlightStyle(AIS_InteractiveObject theObj, Prs3d_Drawer theStyle)
        {
            throw new NotImplementedException();
        }

        public bool HighlightStyle(SelectMgr_EntityOwner theOwner, Prs3d_Drawer theStyle)
        {
            throw new NotImplementedException();
        }

        public bool IsHilighted(AIS_InteractiveObject theObj)
        {
            throw new NotImplementedException();
        }

        public bool IsHilighted(SelectMgr_EntityOwner theOwner)
        {
            throw new NotImplementedException();
        }

        public void Hilight(AIS_InteractiveObject theObj, bool theIsToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void HilightWithColor(AIS_InteractiveObject theObj, Prs3d_Drawer theStyle, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void Unhilight(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public int DisplayPriority(AIS_InteractiveObject theIObj)
        {
            throw new NotImplementedException();
        }

        public void SetDisplayPriority(AIS_InteractiveObject theIObj, int thePriority)
        {
            throw new NotImplementedException();
        }

        public int GetZLayer(AIS_InteractiveObject theIObj)
        {
            throw new NotImplementedException();
        }

        public void SetZLayer(AIS_InteractiveObject theIObj, int theLayerId)
        {
            throw new NotImplementedException();
        }

        public void SetViewAffinity(AIS_InteractiveObject theIObj, V3d_View theView, bool theIsV_isible)
        {
            throw new NotImplementedException();
        }

        public int DisplayMode()
        {
            throw new NotImplementedException();
        }

        public void SetDisplayMode(int theMode, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void SetDisplayMode(AIS_InteractiveObject theIObj, int theMode, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void UnsetDisplayMode(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void SetLocation(AIS_InteractiveObject theObject, TopLoc_Location theLocation)
        {
            throw new NotImplementedException();
        }

        public void ResetLocation(AIS_InteractiveObject theObject)
        {
            throw new NotImplementedException();
        }

        public bool HasLocation(AIS_InteractiveObject theObject)
        {
            throw new NotImplementedException();
        }

        public TopLoc_Location Location(AIS_InteractiveObject theObject)
        {
            throw new NotImplementedException();
        }

        public void SetTransformPersistence(AIS_InteractiveObject theObject, Graphic3d_TransformPers theTrsfPers)
        {
            throw new NotImplementedException();
        }

        public void SetTransformPersistence(AIS_InteractiveObject theObj, ref Graphic3d_TransModeFlags theFlag,
            gp_Pnt thePoint)
        {
            throw new NotImplementedException();
        }

        public void SetTransformPersistence(AIS_InteractiveObject theObj, ref Graphic3d_TransModeFlags theFlag)
        {
            throw new NotImplementedException();
        }

        public void SetPixelTolerance(int thePrec_ision)
        {
            throw new NotImplementedException();
        }

        public void SetPixelTolerance()
        {
            throw new NotImplementedException();
        }

        public int PixelTolerance()
        {
            throw new NotImplementedException();
        }

        public void SetSelectionSensitivity(AIS_InteractiveObject theObject, int theMode, int theNewSensitivity)
        {
            throw new NotImplementedException();
        }

        public V3d_View LastActiveView()
        {
            throw new NotImplementedException();
        }

        public AIS_StatusOfDetection MoveTo(int theXPix, int theYPix, V3d_View theView, bool theToRedrawOnUpdate)
        {
            throw new NotImplementedException();
        }

        public bool ClearDetected(bool theToRedrawImmediate)
        {
            throw new NotImplementedException();
        }

        public bool ClearDetected()
        {
            throw new NotImplementedException();
        }

        public bool HasDetected()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_EntityOwner DetectedOwner()
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveObject DetectedInteractive()
        {
            throw new NotImplementedException();
        }

        public bool HasDetectedShape()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape DetectedShape()
        {
            throw new NotImplementedException();
        }

        public bool HasNextDetected()
        {
            throw new NotImplementedException();
        }

        public int HilightNextDetected(V3d_View theView, bool theToRedrawImmediate)
        {
            throw new NotImplementedException();
        }

        public int HilightNextDetected(V3d_View theView)
        {
            throw new NotImplementedException();
        }

        public int HilightPreviousDetected(V3d_View theView, bool theToRedrawImmediate)
        {
            throw new NotImplementedException();
        }

        public int HilightPreviousDetected(V3d_View theView)
        {
            throw new NotImplementedException();
        }

        public void InitDetected()
        {
            throw new NotImplementedException();
        }

        public bool MoreDetected()
        {
            throw new NotImplementedException();
        }

        public void NextDetected()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_EntityOwner DetectedCurrentOwner()
        {
            throw new NotImplementedException();
        }

        public void SetSelectedAspect(Prs3d_BasicAspect theAspect, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public AIS_StatusOfPick AddSelect(SelectMgr_EntityOwner theObject)
        {
            throw new NotImplementedException();
        }

        public AIS_StatusOfPick AddSelect(AIS_InteractiveObject theObject)
        {
            throw new NotImplementedException();
        }

        public AIS_StatusOfPick Select(int theXPMin, int theYPMin, int theXPMax, int theYPMax, V3d_View theView,
            bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public AIS_StatusOfPick Select(TColgp_Array1OfPnt2d thePolyline, V3d_View theView, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public AIS_StatusOfPick Select(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public AIS_StatusOfPick ShiftSelect(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public AIS_StatusOfPick ShiftSelect(TColgp_Array1OfPnt2d thePolyline, V3d_View theView, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public AIS_StatusOfPick ShiftSelect(int theXPMin, int theYPMin, int theXPMax, int theYPMax, V3d_View theView,
            bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public Bnd_Box BoundingBoxOfSelection()
        {
            throw new NotImplementedException();
        }

        public void FitSelected(V3d_View theView, double theMargin, bool theToUpdate)
        {
            throw new NotImplementedException();
        }

        public void FitSelected(V3d_View theView)
        {
            throw new NotImplementedException();
        }

        public bool ToHilightSelected()
        {
            throw new NotImplementedException();
        }

        public void SetToHilightSelected(bool toHilight)
        {
            throw new NotImplementedException();
        }

        public bool AutomaticHilight()
        {
            throw new NotImplementedException();
        }

        public void SetAutomaticHilight(bool theStatus)
        {
            throw new NotImplementedException();
        }

        public void SetSelected(SelectMgr_EntityOwner theOwners, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void SetSelected(AIS_InteractiveObject theObject, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void AddOrRemoveSelected(AIS_InteractiveObject theObject, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public bool SetSelectedState(SelectMgr_EntityOwner theOwner, bool theIsSelected)
        {
            throw new NotImplementedException();
        }

        public void HilightSelected(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void UnhilightSelected(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void UpdateSelected(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void ClearSelected(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void AddOrRemoveSelected(SelectMgr_EntityOwner theOwner, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public bool IsSelected(SelectMgr_EntityOwner theOwner)
        {
            throw new NotImplementedException();
        }

        public bool IsSelected(AIS_InteractiveObject theObj)
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveObject FirstSelectedObject()
        {
            throw new NotImplementedException();
        }

        public int NbSelected()
        {
            throw new NotImplementedException();
        }

        public void InitSelected()
        {
            throw new NotImplementedException();
        }

        public bool MoreSelected()
        {
            throw new NotImplementedException();
        }

        public void NextSelected()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_EntityOwner SelectedOwner()
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveObject SelectedInteractive()
        {
            throw new NotImplementedException();
        }

        public bool HasSelectedShape()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape SelectedShape()
        {
            throw new NotImplementedException();
        }

        public bool HasApplicative()
        {
            throw new NotImplementedException();
        }

        public Standard_Transient Applicative()
        {
            throw new NotImplementedException();
        }

        public bool BeginImmediateDraw()
        {
            throw new NotImplementedException();
        }

        public bool ImmediateAdd(AIS_InteractiveObject theObj, int theMode)
        {
            throw new NotImplementedException();
        }

        public bool ImmediateAdd(AIS_InteractiveObject theObj)
        {
            throw new NotImplementedException();
        }

        public bool EndImmediateDraw(V3d_View theView)
        {
            throw new NotImplementedException();
        }

        public bool EndImmediateDraw()
        {
            throw new NotImplementedException();
        }

        public bool IsImmediateModeOn()
        {
            throw new NotImplementedException();
        }

        public void RedrawImmediate(V3d_Viewer theViewer)
        {
            throw new NotImplementedException();
        }

        public void SetSelectionModeActive(AIS_InteractiveObject theObj, int theMode, bool theToActivate,
            AIS_SelectionModesConcurrency theConcurrency, bool theIsForce)
        {
            throw new NotImplementedException();
        }

        public void SetSelectionModeActive(AIS_InteractiveObject theObj, int theMode, bool theToActivate,
            AIS_SelectionModesConcurrency theConcurrency)
        {
            throw new NotImplementedException();
        }

        public void SetSelectionModeActive(AIS_InteractiveObject theObj, int theMode, bool theToActivate)
        {
            throw new NotImplementedException();
        }

        public void Activate(AIS_InteractiveObject theObj, int theMode, bool theIsForce)
        {
            throw new NotImplementedException();
        }

        public void Activate(AIS_InteractiveObject theObj, int theMode)
        {
            throw new NotImplementedException();
        }

        public void Activate(AIS_InteractiveObject theObj)
        {
            throw new NotImplementedException();
        }

        public void Activate(int theMode, bool theIsForce)
        {
            throw new NotImplementedException();
        }

        public void Activate(int theMode)
        {
            throw new NotImplementedException();
        }

        public void Deactivate(AIS_InteractiveObject theObj)
        {
            throw new NotImplementedException();
        }

        public void Deactivate(AIS_InteractiveObject theObj, int theMode)
        {
            throw new NotImplementedException();
        }

        public void Deactivate(int theMode)
        {
            throw new NotImplementedException();
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }

        public void ActivatedModes(AIS_InteractiveObject anIobj, TColStd_ListOfInteger theL_ist)
        {
            throw new NotImplementedException();
        }

        public SelectMgr_FilterType FilterType()
        {
            throw new NotImplementedException();
        }

        public void SetFilterType(SelectMgr_FilterType theFilterType)
        {
            throw new NotImplementedException();
        }

        public SelectMgr_ListOfFilter Filters()
        {
            throw new NotImplementedException();
        }

        public void AddFilter(SelectMgr_Filter theFilter)
        {
            throw new NotImplementedException();
        }

        public void RemoveFilter(SelectMgr_Filter theFilter)
        {
            throw new NotImplementedException();
        }

        public void RemoveFilters()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_PickingStrategy PickingStrategy()
        {
            throw new NotImplementedException();
        }

        public void SetPickingStrategy(SelectMgr_PickingStrategy theStrategy)
        {
            throw new NotImplementedException();
        }

        public Prs3d_Drawer DefaultDrawer()
        {
            throw new NotImplementedException();
        }

        public V3d_Viewer CurrentViewer()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_SelectionManager SelectionManager()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_ViewerSelector3d MainSelector()
        {
            throw new NotImplementedException();
        }

        public void UpdateCurrentViewer()
        {
            throw new NotImplementedException();
        }

        public void DisplayedObjects(AIS_ListOfInteractive aL_istOfIO)
        {
            throw new NotImplementedException();
        }

        public void DisplayedObjects(AIS_KindOfInteractive theWhichKind, int theWhichSignature,
            AIS_ListOfInteractive theL_istOfIO)
        {
            throw new NotImplementedException();
        }

        public void ErasedObjects(AIS_ListOfInteractive theL_istOfIO)
        {
            throw new NotImplementedException();
        }

        public void ErasedObjects(AIS_KindOfInteractive theWhichKind, int theWhichSignature,
            AIS_ListOfInteractive theL_istOfIO)
        {
            throw new NotImplementedException();
        }

        public void ObjectsByDisplayStatus(AIS_DisplayStatus theStatus, AIS_ListOfInteractive theL_istOfIO)
        {
            throw new NotImplementedException();
        }

        public void ObjectsByDisplayStatus(AIS_KindOfInteractive WhichKind, int WhichSignature,
            AIS_DisplayStatus theStatus, AIS_ListOfInteractive theL_istOfIO)
        {
            throw new NotImplementedException();
        }

        public void ObjectsInside(AIS_ListOfInteractive aL_istOfIO, AIS_KindOfInteractive WhichKind, int WhichSignature)
        {
            throw new NotImplementedException();
        }

        public void ObjectsInside(AIS_ListOfInteractive aL_istOfIO, AIS_KindOfInteractive WhichKind)
        {
            throw new NotImplementedException();
        }

        public void ObjectsInside(AIS_ListOfInteractive aL_istOfIO)
        {
            throw new NotImplementedException();
        }

        public void RebuildSelectionStructs()
        {
            throw new NotImplementedException();
        }

        public void Disconnect(AIS_InteractiveObject theAssembly, AIS_InteractiveObject theObjToD_isconnect)
        {
            throw new NotImplementedException();
        }

        public void Disconnect(AIS_InteractiveObject theAssembly)
        {
            throw new NotImplementedException();
        }

        public void ObjectsForView(AIS_ListOfInteractive theL_istOfIO, V3d_View theView, bool theIsV_isibleInView,
            AIS_DisplayStatus theStatus)
        {
            throw new NotImplementedException();
        }

        public void ObjectsForView(AIS_ListOfInteractive theL_istOfIO, V3d_View theView, bool theIsV_isibleInView)
        {
            throw new NotImplementedException();
        }

        public int PurgeDisplay()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt GravityPoint(V3d_View theView)
        {
            throw new NotImplementedException();
        }

        public void DisplayActiveSensitive(V3d_View aView)
        {
            throw new NotImplementedException();
        }

        public void ClearActiveSensitive(V3d_View aView)
        {
            throw new NotImplementedException();
        }

        public void DisplayActiveSensitive(AIS_InteractiveObject anObject, V3d_View aView)
        {
            throw new NotImplementedException();
        }

        public void SetLocalAttributes(AIS_InteractiveObject theIObj, Prs3d_Drawer theDrawer, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void UnsetLocalAttributes(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void SetCurrentFacingModel(AIS_InteractiveObject aniobj, Aspect_TypeOfFacingModel aModel)
        {
            throw new NotImplementedException();
        }

        public void SetCurrentFacingModel(AIS_InteractiveObject aniobj)
        {
            throw new NotImplementedException();
        }

        public bool HasColor(AIS_InteractiveObject aniobj)
        {
            throw new NotImplementedException();
        }

        public void Color(AIS_InteractiveObject aniobj, Quantity_Color acolor)
        {
            throw new NotImplementedException();
        }

        public void SetColor(AIS_InteractiveObject theIObj, Quantity_Color theColor, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void UnsetColor(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public double Width(AIS_InteractiveObject aniobj)
        {
            throw new NotImplementedException();
        }

        public void SetWidth(AIS_InteractiveObject theIObj, double theValue, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void UnsetWidth(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void SetMaterial(AIS_InteractiveObject theIObj, Graphic3d_MaterialAspect theMaterial,
            bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void UnsetMaterial(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void SetTransparency(AIS_InteractiveObject theIObj, double theValue, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void UnsetTransparency(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void SetPolygonOffsets(AIS_InteractiveObject theIObj, int theMode, float theFactor, float theUnits,
            bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public bool HasPolygonOffsets(AIS_InteractiveObject anObj)
        {
            throw new NotImplementedException();
        }

        public void PolygonOffsets(AIS_InteractiveObject anObj, ref int aMode, ref float aFactor, ref float aUnits)
        {
            throw new NotImplementedException();
        }

        public void SetTrihedronSize(double theSize, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public double TrihedronSize()
        {
            throw new NotImplementedException();
        }

        public void SetPlaneSize(double theSizeX, double theSizeY, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void SetPlaneSize(double theSize, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public bool PlaneSize(ref double XSize, ref double YSize)
        {
            throw new NotImplementedException();
        }

        public void SetDeviationCoefficient(AIS_InteractiveObject theIObj, double theCoefficient,
            bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void SetDeviationAngle(AIS_InteractiveObject theIObj, double theAngle, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void SetAngleAndDeviation(AIS_InteractiveObject theIObj, double theAngle, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void SetDeviationCoefficient(double theCoefficient)
        {
            throw new NotImplementedException();
        }

        public double DeviationCoefficient()
        {
            throw new NotImplementedException();
        }

        public void SetDeviationAngle(double anAngle)
        {
            throw new NotImplementedException();
        }

        public double DeviationAngle()
        {
            throw new NotImplementedException();
        }

        public Prs3d_LineAspect HiddenLineAspect()
        {
            throw new NotImplementedException();
        }

        public void SetHiddenLineAspect(Prs3d_LineAspect anAspect)
        {
            throw new NotImplementedException();
        }

        public bool DrawHiddenLine()
        {
            throw new NotImplementedException();
        }

        public void EnableDrawHiddenLine()
        {
            throw new NotImplementedException();
        }

        public void DisableDrawHiddenLine()
        {
            throw new NotImplementedException();
        }

        public void SetIsoNumber(int NbIsos, AIS_TypeOfIso WhichIsos)
        {
            throw new NotImplementedException();
        }

        public void SetIsoNumber(int NbIsos)
        {
            throw new NotImplementedException();
        }

        public int IsoNumber(AIS_TypeOfIso WhichIsos)
        {
            throw new NotImplementedException();
        }

        public int IsoNumber()
        {
            throw new NotImplementedException();
        }

        public void IsoOnPlane(bool SwitchOn)
        {
            throw new NotImplementedException();
        }

        public bool IsoOnPlane()
        {
            throw new NotImplementedException();
        }

        public void IsoOnTriangulation(bool theIsEnabled, AIS_InteractiveObject theObject)
        {
            throw new NotImplementedException();
        }

        public void IsoOnTriangulation(bool theToSwitchOn)
        {
            throw new NotImplementedException();
        }

        public bool IsoOnTriangulation()
        {
            throw new NotImplementedException();
        }

        public void SetCurrentObject(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void AddOrRemoveCurrentObject(AIS_InteractiveObject theObj, bool theIsToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCurrent()
        {
            throw new NotImplementedException();
        }

        public bool IsCurrent(AIS_InteractiveObject theObject)
        {
            throw new NotImplementedException();
        }

        public void InitCurrent()
        {
            throw new NotImplementedException();
        }

        public bool MoreCurrent()
        {
            throw new NotImplementedException();
        }

        public void NextCurrent()
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveObject Current()
        {
            throw new NotImplementedException();
        }

        public int NbCurrents()
        {
            throw new NotImplementedException();
        }

        public void HilightCurrents(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void UnhilightCurrents(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void ClearCurrents(bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape DetectedCurrentShape()
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveObject DetectedCurrentObject()
        {
            throw new NotImplementedException();
        }

        public Quantity_Color SubIntensityColor()
        {
            throw new NotImplementedException();
        }

        public void SetSubIntensityColor(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public void SubIntensityOn(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void SubIntensityOff(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public AIS_Selection Selection()
        {
            throw new NotImplementedException();
        }

        public void SetSelection(AIS_Selection theSelection)
        {
            throw new NotImplementedException();
        }

        public void GetDefModes(AIS_InteractiveObject anIobj, ref int Dmode, ref int HiMod, ref int SelMode)
        {
            throw new NotImplementedException();
        }

        public void EraseGlobal(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void ClearGlobal(AIS_InteractiveObject theIObj, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void ClearGlobalPrs(AIS_InteractiveObject theObj, int theMode, bool theToUpdateViewer)
        {
            throw new NotImplementedException();
        }

        public void InitAttributes()
        {
            throw new NotImplementedException();
        }

        public int PurgeViewer(V3d_Viewer Vwr)
        {
            throw new NotImplementedException();
        }

        public void unselectOwners(AIS_InteractiveObject theObject)
        {
            throw new NotImplementedException();
        }

        public void highlightWithColor(SelectMgr_EntityOwner theOwner, V3d_Viewer theViewer)
        {
            throw new NotImplementedException();
        }

        public void highlightWithColor(SelectMgr_EntityOwner theOwner)
        {
            throw new NotImplementedException();
        }

        public void highlightSelected(SelectMgr_EntityOwner theOwner)
        {
            throw new NotImplementedException();
        }

        public void highlightOwners(AIS_NListOfEntityOwner theOwners)
        {
            throw new NotImplementedException();
        }

        public void highlightGlobal(AIS_InteractiveObject theObj, Prs3d_Drawer theStyle, int theD_ispMode)
        {
            throw new NotImplementedException();
        }

        public void unhighlightSelected(bool theIsToHilightSubIntensity)
        {
            throw new NotImplementedException();
        }

        public void unhighlightSelected()
        {
            throw new NotImplementedException();
        }

        public void unhighlightOwners(AIS_NListOfEntityOwner theOwners, bool theIsToHilightSubIntensity)
        {
            throw new NotImplementedException();
        }

        public void unhighlightOwners(AIS_NListOfEntityOwner theOwners)
        {
            throw new NotImplementedException();
        }

        public void unhighlightGlobal(AIS_InteractiveObject theObj)
        {
            throw new NotImplementedException();
        }

        public void turnOnSubintensity(AIS_InteractiveObject theObject, int theD_ispMode, bool theIsD_isplayedOnly)
        {
            throw new NotImplementedException();
        }

        public void turnOnSubintensity(AIS_InteractiveObject theObject, int theD_ispMode)
        {
            throw new NotImplementedException();
        }

        public void turnOnSubintensity(AIS_InteractiveObject theObject)
        {
            throw new NotImplementedException();
        }

        public void turnOnSubintensity()
        {
            throw new NotImplementedException();
        }

        public void highlightWithSubintensity(AIS_InteractiveObject theObject, int theMode)
        {
            throw new NotImplementedException();
        }

        public void highlightWithSubintensity(SelectMgr_EntityOwner theOwner, int theMode)
        {
            throw new NotImplementedException();
        }

        public Prs3d_Drawer getHiStyle(AIS_InteractiveObject theObj, SelectMgr_EntityOwner theOwner)
        {
            throw new NotImplementedException();
        }

        public bool isSlowHiStyle(SelectMgr_EntityOwner theOwner, V3d_Viewer theViewer)
        {
            throw new NotImplementedException();
        }

        public Prs3d_Drawer getSelStyle(AIS_InteractiveObject theObj, SelectMgr_EntityOwner theOwner)
        {
            throw new NotImplementedException();
        }

        public void setContextToObject(AIS_InteractiveObject theObj)
        {
            throw new NotImplementedException();
        }

        public int getHilightMode(AIS_InteractiveObject theObj, Prs3d_Drawer theStyle, int theD_ispMode)
        {
            throw new NotImplementedException();
        }

        public void clearDynamicHighlight()
        {
            throw new NotImplementedException();
        }

        public void setObjectStatus(AIS_InteractiveObject theIObj, AIS_DisplayStatus theStatus, int theD_ispyMode,
            int theSelectionMode)
        {
            throw new NotImplementedException();
        }
    }; // class AIS_InteractiveContext
}