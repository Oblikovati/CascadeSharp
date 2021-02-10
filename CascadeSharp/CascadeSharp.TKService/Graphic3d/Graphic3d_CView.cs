//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_CView
	//---------------------------------------------------------------------
	public  abstract class Graphic3d_CView : CascadeSharp.Graphic3d_DataStructureManager
	{

		public Graphic3d_CView(Graphic3d_StructureManager theMgr)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_CView(Graphic3d_CView parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_CView()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public int Identification()
		{
			throw new NotImplementedException();
		}

		public void Activate()
		{
			throw new NotImplementedException();
		}

		public void Deactivate()
		{
			throw new NotImplementedException();
		}

		public bool IsActive()
		{
			throw new NotImplementedException();
		}

		public void Remove()
		{
			throw new NotImplementedException();
		}

		public bool IsRemoved()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Camera Camera()
		{
			throw new NotImplementedException();
		}

		public void SetCamera(Graphic3d_Camera theCamera)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Graphic3d_TypeOfShadingModel ShadingModel()
		{
			throw new NotImplementedException();
		}

		public void SetShadingModel(CascadeSharp.Graphic3d_TypeOfShadingModel theModel)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Graphic3d_TypeOfVisualization VisualizationType()
		{
			throw new NotImplementedException();
		}

		public void SetVisualizationType(CascadeSharp.Graphic3d_TypeOfVisualization theType)
		{
			throw new NotImplementedException();
		}

		public void SetComputedMode(bool theMode)
		{
			throw new NotImplementedException();
		}

		public bool ComputedMode()
		{
			throw new NotImplementedException();
		}

		public void ReCompute(Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public void Update(int theLayerId)
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

		public void Compute()
		{
			throw new NotImplementedException();
		}

		public bool ContainsFacet()
		{
			throw new NotImplementedException();
		}

		public bool ContainsFacet(Graphic3d_MapOfStructure theSet)
		{
			throw new NotImplementedException();
		}

		public void DisplayedStructures(Graphic3d_MapOfStructure theStructures)
		{
			throw new NotImplementedException();
		}

		public int NumberOfDisplayedStructures()
		{
			throw new NotImplementedException();
		}

						public bool IsComputed(int theStructId, Graphic3d_Structure theComputedStruct)
		{
			throw new NotImplementedException();
		}

		public Bnd_Box MinMaxValues(bool theToIncludeAuxiliary)
		{
			throw new NotImplementedException();
		}

		public Bnd_Box MinMaxValues()
		{
			throw new NotImplementedException();
		}

		public Bnd_Box MinMaxValues(Graphic3d_MapOfStructure theSet, bool theToIncludeAuxiliary)
		{
			throw new NotImplementedException();
		}

		public Bnd_Box MinMaxValues(Graphic3d_MapOfStructure theSet)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_StructureManager StructureManager()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Graphic3d_TypeOfAnswer acceptDisplay(CascadeSharp.Graphic3d_TypeOfStructure theStructType)
		{
			throw new NotImplementedException();
		}

		public void Clear(Graphic3d_Structure theStructure, bool theWithDestruction)
		{
			throw new NotImplementedException();
		}

		public void Connect(Graphic3d_Structure theMother, Graphic3d_Structure theDaughter)
		{
			throw new NotImplementedException();
		}

		public void Disconnect(Graphic3d_Structure theMother, Graphic3d_Structure theDaughter)
		{
			throw new NotImplementedException();
		}

		public void Display(Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public void Erase(Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public void Highlight(Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public void SetTransform(Graphic3d_Structure theStructure, TopLoc_Datum3D theTrsf)
		{
			throw new NotImplementedException();
		}

		public void UnHighlight(Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public int IsComputed(Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public bool IsDisplayed(Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public void ChangePriority(Graphic3d_Structure theStructure, int theOldPriority, int theNewPriority)
		{
			throw new NotImplementedException();
		}

		public void ChangeZLayer(Graphic3d_Structure theStructure, int theLayerId)
		{
			throw new NotImplementedException();
		}

		public int HaveTheSameOwner(Graphic3d_Structure theStructure)
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

		public bool IsInvalidated()
		{
			throw new NotImplementedException();
		}

		public void Resized()
		{
			throw new NotImplementedException();
		}

		public bool SetImmediateModeDrawToFront(bool theDrawToFrontBuffer)
		{
			throw new NotImplementedException();
		}

		public void SetWindow(Aspect_Window theWindow, IntPtr theContext)
		{
			throw new NotImplementedException();
		}

		public void SetWindow(Aspect_Window theWindow)
		{
			throw new NotImplementedException();
		}

		public Aspect_Window Window()
		{
			throw new NotImplementedException();
		}

		public bool IsDefined()
		{
			throw new NotImplementedException();
		}

		public bool BufferDump(Image_PixMap theImage,  ref CascadeSharp.Graphic3d_BufferType theBufferType)
		{
			throw new NotImplementedException();
		}

		public void InvalidateBVHData(int theLayerId)
		{
			throw new NotImplementedException();
		}

		public void InsertLayerBefore(int theNewLayerId, Graphic3d_ZLayerSettings theSettings, int theLayerAfter)
		{
			throw new NotImplementedException();
		}

		public void InsertLayerAfter(int theNewLayerId, Graphic3d_ZLayerSettings theSettings, int theLayerBefore)
		{
			throw new NotImplementedException();
		}

		public int ZLayerMax()
		{
			throw new NotImplementedException();
		}

						public void InvalidateZLayerBoundingBox(int theLayerId)
		{
			throw new NotImplementedException();
		}

		public void RemoveZLayer(int theLayerId)
		{
			throw new NotImplementedException();
		}

		public void SetZLayerSettings(int theLayerId, Graphic3d_ZLayerSettings theSettings)
		{
			throw new NotImplementedException();
		}

		public double ConsiderZoomPersistenceObjects()
		{
			throw new NotImplementedException();
		}

		public Standard_Transient FBO()
		{
			throw new NotImplementedException();
		}

		public void SetFBO(Standard_Transient theFbo)
		{
			throw new NotImplementedException();
		}

		public Standard_Transient FBOCreate(int theWidth, int theHeight)
		{
			throw new NotImplementedException();
		}

		public void FBORelease(Standard_Transient theFbo)
		{
			throw new NotImplementedException();
		}

		public void FBOGetDimensions(Standard_Transient theFbo, ref int theWidth, ref int theHeight, ref int theWidthMax, ref int theHeightMax)
		{
			throw new NotImplementedException();
		}

		public void FBOChangeViewport(Standard_Transient theFbo, int theWidth, int theHeight)
		{
			throw new NotImplementedException();
		}

		public void CopySettings(Graphic3d_CView theOther)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_RenderingParams RenderingParams()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_RenderingParams ChangeRenderingParams()
		{
			throw new NotImplementedException();
		}

		public Aspect_Background Background()
		{
			throw new NotImplementedException();
		}

		public void SetBackground(Aspect_Background theBackground)
		{
			throw new NotImplementedException();
		}

		public Aspect_GradientBackground GradientBackground()
		{
			throw new NotImplementedException();
		}

		public void SetGradientBackground(Aspect_GradientBackground theBackground)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_TextureMap BackgroundImage()
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundImage(Graphic3d_TextureMap theTextureMap, bool theToUpdatePBREnv)
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundImage(Graphic3d_TextureMap theTextureMap)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Aspect_FillMethod BackgroundImageStyle()
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundImageStyle(CascadeSharp.Aspect_FillMethod theFillStyle)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_CubeMap BackgroundCubeMap()
		{
			throw new NotImplementedException();
		}

		public void GeneratePBREnvironment()
		{
			throw new NotImplementedException();
		}

		public void ClearPBREnvironment()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_TextureEnv TextureEnv()
		{
			throw new NotImplementedException();
		}

		public void SetTextureEnv(Graphic3d_TextureEnv theTextureEnv)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Graphic3d_TypeOfBackfacingModel BackfacingModel()
		{
			throw new NotImplementedException();
		}

		public void SetBackfacingModel(CascadeSharp.Graphic3d_TypeOfBackfacingModel theModel)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_LightSet Lights()
		{
			throw new NotImplementedException();
		}

		public void SetLights(Graphic3d_LightSet theLights)
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

		public void DiagnosticInformation(TColStd_IndexedDataMapOfStringString theDict, CascadeSharp.Graphic3d_DiagnosticInfo theFlags)
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString StatisticInformation()
		{
			throw new NotImplementedException();
		}

		public void StatisticInformation(TColStd_IndexedDataMapOfStringString theDict)
		{
			throw new NotImplementedException();
		}

		public double UnitFactor()
		{
			throw new NotImplementedException();
		}

		public void SetUnitFactor(double theFactor)
		{
			throw new NotImplementedException();
		}

		public Aspect_XRSession XRSession()
		{
			throw new NotImplementedException();
		}

		public void SetXRSession(Aspect_XRSession theSession)
		{
			throw new NotImplementedException();
		}

		public bool IsActiveXR()
		{
			throw new NotImplementedException();
		}

		public bool InitXR()
		{
			throw new NotImplementedException();
		}

		public void ReleaseXR()
		{
			throw new NotImplementedException();
		}

		public void ProcessXRInput()
		{
			throw new NotImplementedException();
		}

		public void SetupXRPosedCamera()
		{
			throw new NotImplementedException();
		}

		public void UnsetXRPosedCamera()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Camera PosedXRCamera()
		{
			throw new NotImplementedException();
		}

		public void SetPosedXRCamera(Graphic3d_Camera theCamera)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Camera BaseXRCamera()
		{
			throw new NotImplementedException();
		}

		public void SetBaseXRCamera(Graphic3d_Camera theCamera)
		{
			throw new NotImplementedException();
		}

		public gp_Trsf PoseXRToWorld(gp_Trsf thePoseXR)
		{
			throw new NotImplementedException();
		}

		public void SynchronizeXRBaseToPosedCamera()
		{
			throw new NotImplementedException();
		}

		public void SynchronizeXRPosedToBaseCamera()
		{
			throw new NotImplementedException();
		}

		public void ComputeXRPosedCameraFromBase(Graphic3d_Camera theCam, gp_Trsf theXRTrsf)
		{
			throw new NotImplementedException();
		}

		public void ComputeXRBaseCameraFromPosed(Graphic3d_Camera theCamPosed, gp_Trsf thePoseTrsf)
		{
			throw new NotImplementedException();
		}

		public void TurnViewXRCamera(gp_Trsf theTrsfTurn)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_GraduatedTrihedron GetGraduatedTrihedron()
		{
			throw new NotImplementedException();
		}

		public void GraduatedTrihedronDisplay(Graphic3d_GraduatedTrihedron theTrihedronData)
		{
			throw new NotImplementedException();
		}

		public void GraduatedTrihedronErase()
		{
			throw new NotImplementedException();
		}

								public void displayStructure(Graphic3d_CStructure theStructure, int thePriority)
		{
			throw new NotImplementedException();
		}

		public void eraseStructure(Graphic3d_CStructure theStructure)
		{
			throw new NotImplementedException();
		}

		public void changeZLayer(Graphic3d_CStructure theCStructure, int theNewLayerId)
		{
			throw new NotImplementedException();
		}

		public void changePriority(Graphic3d_CStructure theCStructure, int theNewPriority)
		{
			throw new NotImplementedException();
		}


	}; // class Graphic3d_CView

}
