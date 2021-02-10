//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  V3d_View
	//---------------------------------------------------------------------
	public  sealed class V3d_View : Standard_Transient
	{

		public V3d_View(V3d_Viewer theViewer, CascadeSharp.V3d_TypeOfView theType)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_View(V3d_Viewer theViewer)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_View(V3d_Viewer theViewer, V3d_View theView)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_View(V3d_View parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_View()
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

		public void SetMagnify(Aspect_Window theWindow, V3d_View thePreviousView, int theX1, int theY1, int theX2, int theY2)
		{
			throw new NotImplementedException();
		}

		public void Remove()
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

		public bool IsInvalidated()
		{
			throw new NotImplementedException();
		}

		public bool IsInvalidatedImmediate()
		{
			throw new NotImplementedException();
		}

		public void InvalidateImmediate()
		{
			throw new NotImplementedException();
		}

		public void MustBeResized()
		{
			throw new NotImplementedException();
		}

		public void DoMapping()
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			throw new NotImplementedException();
		}

		public void UpdateLights()
		{
			throw new NotImplementedException();
		}

		public void SetAutoZFitMode(bool theIsOn, double theScaleFactor)
		{
			throw new NotImplementedException();
		}

		public void SetAutoZFitMode(bool theIsOn)
		{
			throw new NotImplementedException();
		}

		public bool AutoZFitMode()
		{
			throw new NotImplementedException();
		}

		public double AutoZFitScaleFactor()
		{
			throw new NotImplementedException();
		}

		public void AutoZFit()
		{
			throw new NotImplementedException();
		}

		public void ZFitAll(double theScaleFactor)
		{
			throw new NotImplementedException();
		}

		public void ZFitAll()
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundColor(CascadeSharp.Quantity_TypeOfColor theType, double theV1, double theV2, double theV3)
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void SetBgGradientColors(Quantity_Color theColor1, Quantity_Color theColor2, CascadeSharp.Aspect_GradientFillMethod theFillStyle, bool theToUpdate)
		{
			throw new NotImplementedException();
		}

		public void SetBgGradientColors(Quantity_Color theColor1, Quantity_Color theColor2, CascadeSharp.Aspect_GradientFillMethod theFillStyle)
		{
			throw new NotImplementedException();
		}

		public void SetBgGradientColors(Quantity_Color theColor1, Quantity_Color theColor2)
		{
			throw new NotImplementedException();
		}

		public void SetBgGradientStyle(CascadeSharp.Aspect_GradientFillMethod theMethod, bool theToUpdate)
		{
			throw new NotImplementedException();
		}

		public void SetBgGradientStyle(CascadeSharp.Aspect_GradientFillMethod theMethod)
		{
			throw new NotImplementedException();
		}

		public void SetBgGradientStyle()
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundImage(string theFileName, CascadeSharp.Aspect_FillMethod theFillStyle, bool theToUpdate)
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundImage(string theFileName, CascadeSharp.Aspect_FillMethod theFillStyle)
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundImage(string theFileName)
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundImage(Graphic3d_Texture2D theTexture, CascadeSharp.Aspect_FillMethod theFillStyle, bool theToUpdate)
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundImage(Graphic3d_Texture2D theTexture, CascadeSharp.Aspect_FillMethod theFillStyle)
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundImage(Graphic3d_Texture2D theTexture)
		{
			throw new NotImplementedException();
		}

		public void SetBgImageStyle(CascadeSharp.Aspect_FillMethod theFillStyle, bool theToUpdate)
		{
			throw new NotImplementedException();
		}

		public void SetBgImageStyle(CascadeSharp.Aspect_FillMethod theFillStyle)
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundCubeMap(Graphic3d_CubeMap theCubeMap, bool theToUpdatePBREnv, bool theToUpdate)
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundCubeMap(Graphic3d_CubeMap theCubeMap, bool theToUpdatePBREnv)
		{
			throw new NotImplementedException();
		}

		public void SetBackgroundCubeMap(Graphic3d_CubeMap theCubeMap)
		{
			throw new NotImplementedException();
		}

		public void GeneratePBREnvironment(bool theToUpdate)
		{
			throw new NotImplementedException();
		}

		public void GeneratePBREnvironment()
		{
			throw new NotImplementedException();
		}

		public void ClearPBREnvironment(bool theToUpdate)
		{
			throw new NotImplementedException();
		}

		public void ClearPBREnvironment()
		{
			throw new NotImplementedException();
		}

		public void SetAxis(double X, double Y, double Z, double Vx, double Vy, double Vz)
		{
			throw new NotImplementedException();
		}

		public void SetShadingModel(CascadeSharp.Graphic3d_TypeOfShadingModel theShadingModel)
		{
			throw new NotImplementedException();
		}

		public void SetTextureEnv(Graphic3d_TextureEnv theTexture)
		{
			throw new NotImplementedException();
		}

		public void SetVisualization(CascadeSharp.V3d_TypeOfVisualization theType)
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

		public bool IsActiveLight(Graphic3d_CLight theLight)
		{
			throw new NotImplementedException();
		}

		public bool SetImmediateUpdate(bool theImmediateUpdate)
		{
			throw new NotImplementedException();
		}

		public void ZBufferTriedronSetup(Quantity_Color theXColor, Quantity_Color theYColor, Quantity_Color theZColor, double theSizeRatio, double theAx_isDiametr, int theNbFacettes)
		{
			throw new NotImplementedException();
		}

		public void ZBufferTriedronSetup(Quantity_Color theXColor, Quantity_Color theYColor, Quantity_Color theZColor, double theSizeRatio, double theAx_isDiametr)
		{
			throw new NotImplementedException();
		}

		public void ZBufferTriedronSetup(Quantity_Color theXColor, Quantity_Color theYColor, Quantity_Color theZColor, double theSizeRatio)
		{
			throw new NotImplementedException();
		}

		public void ZBufferTriedronSetup(Quantity_Color theXColor, Quantity_Color theYColor, Quantity_Color theZColor)
		{
			throw new NotImplementedException();
		}

		public void ZBufferTriedronSetup(Quantity_Color theXColor, Quantity_Color theYColor)
		{
			throw new NotImplementedException();
		}

		public void ZBufferTriedronSetup(Quantity_Color theXColor)
		{
			throw new NotImplementedException();
		}

		public void ZBufferTriedronSetup()
		{
			throw new NotImplementedException();
		}

		public void TriedronDisplay(CascadeSharp.Aspect_TypeOfTriedronPosition thePosition, Quantity_Color theColor, double theScale, CascadeSharp.V3d_TypeOfVisualization theMode)
		{
			throw new NotImplementedException();
		}

		public void TriedronDisplay(CascadeSharp.Aspect_TypeOfTriedronPosition thePosition, Quantity_Color theColor, double theScale)
		{
			throw new NotImplementedException();
		}

		public void TriedronDisplay(CascadeSharp.Aspect_TypeOfTriedronPosition thePosition, Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void TriedronDisplay(CascadeSharp.Aspect_TypeOfTriedronPosition thePosition)
		{
			throw new NotImplementedException();
		}

		public void TriedronDisplay()
		{
			throw new NotImplementedException();
		}

		public void TriedronErase()
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

		public void SetFront()
		{
			throw new NotImplementedException();
		}

		public void Rotate(double Ax, double Ay, double Az, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Rotate(double Ax, double Ay, double Az)
		{
			throw new NotImplementedException();
		}

		public void Rotate(double Ax, double Ay, double Az, double X, double Y, double Z, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Rotate(double Ax, double Ay, double Az, double X, double Y, double Z)
		{
			throw new NotImplementedException();
		}

		public void Rotate(CascadeSharp.V3d_TypeOfAxe Axe, double Angle, double X, double Y, double Z, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Rotate(CascadeSharp.V3d_TypeOfAxe Axe, double Angle, double X, double Y, double Z)
		{
			throw new NotImplementedException();
		}

		public void Rotate(CascadeSharp.V3d_TypeOfAxe Axe, double Angle, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Rotate(CascadeSharp.V3d_TypeOfAxe Axe, double Angle)
		{
			throw new NotImplementedException();
		}

		public void Rotate(double Angle, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Rotate(double Angle)
		{
			throw new NotImplementedException();
		}

		public void Move(double Dx, double Dy, double Dz, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Move(double Dx, double Dy, double Dz)
		{
			throw new NotImplementedException();
		}

		public void Move(CascadeSharp.V3d_TypeOfAxe Axe, double Length, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Move(CascadeSharp.V3d_TypeOfAxe Axe, double Length)
		{
			throw new NotImplementedException();
		}

		public void Move(double Length, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Move(double Length)
		{
			throw new NotImplementedException();
		}

		public void Translate(double Dx, double Dy, double Dz, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Translate(double Dx, double Dy, double Dz)
		{
			throw new NotImplementedException();
		}

		public void Translate(CascadeSharp.V3d_TypeOfAxe Axe, double Length, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Translate(CascadeSharp.V3d_TypeOfAxe Axe, double Length)
		{
			throw new NotImplementedException();
		}

		public void Translate(double Length, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Translate(double Length)
		{
			throw new NotImplementedException();
		}

		public void Place(int theXp, int theYp, double theZoomFactor)
		{
			throw new NotImplementedException();
		}

		public void Place(int theXp, int theYp)
		{
			throw new NotImplementedException();
		}

		public void Turn(double Ax, double Ay, double Az, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Turn(double Ax, double Ay, double Az)
		{
			throw new NotImplementedException();
		}

		public void Turn(CascadeSharp.V3d_TypeOfAxe Axe, double Angle, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Turn(CascadeSharp.V3d_TypeOfAxe Axe, double Angle)
		{
			throw new NotImplementedException();
		}

		public void Turn(double Angle, bool Start)
		{
			throw new NotImplementedException();
		}

		public void Turn(double Angle)
		{
			throw new NotImplementedException();
		}

		public void SetTwist(double Angle)
		{
			throw new NotImplementedException();
		}

		public void SetEye(double X, double Y, double Z)
		{
			throw new NotImplementedException();
		}

		public void SetDepth(double Depth)
		{
			throw new NotImplementedException();
		}

		public void SetProj(double Vx, double Vy, double Vz)
		{
			throw new NotImplementedException();
		}

		public void SetProj(CascadeSharp.V3d_TypeOfOrientation theOrientation, bool theIsYup)
		{
			throw new NotImplementedException();
		}

		public void SetProj(CascadeSharp.V3d_TypeOfOrientation theOrientation)
		{
			throw new NotImplementedException();
		}

		public void SetAt(double X, double Y, double Z)
		{
			throw new NotImplementedException();
		}

		public void SetUp(double Vx, double Vy, double Vz)
		{
			throw new NotImplementedException();
		}

		public void SetUp(CascadeSharp.V3d_TypeOfOrientation Orientation)
		{
			throw new NotImplementedException();
		}

		public void SetViewOrientationDefault()
		{
			throw new NotImplementedException();
		}

		public void ResetViewOrientation()
		{
			throw new NotImplementedException();
		}

		public void Panning(double theDXv, double theDYv, double theZoomFactor, bool theToStart)
		{
			throw new NotImplementedException();
		}

		public void Panning(double theDXv, double theDYv, double theZoomFactor)
		{
			throw new NotImplementedException();
		}

		public void Panning(double theDXv, double theDYv)
		{
			throw new NotImplementedException();
		}

		public void SetCenter(int theXp, int theYp)
		{
			throw new NotImplementedException();
		}

		public void SetSize(double theSize)
		{
			throw new NotImplementedException();
		}

		public void SetZSize(double SetZSize)
		{
			throw new NotImplementedException();
		}

		public void SetZoom(double Coef, bool Start)
		{
			throw new NotImplementedException();
		}

		public void SetZoom(double Coef)
		{
			throw new NotImplementedException();
		}

		public void SetScale(double Coef)
		{
			throw new NotImplementedException();
		}

		public void SetAxialScale(double Sx, double Sy, double Sz)
		{
			throw new NotImplementedException();
		}

		public void FitAll(double theMargin, bool theToUpdate)
		{
			throw new NotImplementedException();
		}

		public void FitAll(double theMargin)
		{
			throw new NotImplementedException();
		}

		public void FitAll()
		{
			throw new NotImplementedException();
		}

		public void FitAll(Bnd_Box theBox, double theMargin, bool theToUpdate)
		{
			throw new NotImplementedException();
		}

		public void FitAll(Bnd_Box theBox, double theMargin)
		{
			throw new NotImplementedException();
		}

		public void FitAll(Bnd_Box theBox)
		{
			throw new NotImplementedException();
		}

		public void DepthFitAll(double Aspect, double Margin)
		{
			throw new NotImplementedException();
		}

		public void DepthFitAll(double Aspect)
		{
			throw new NotImplementedException();
		}

		public void DepthFitAll()
		{
			throw new NotImplementedException();
		}

		public void FitAll(double theMinXv, double theMinYv, double theMaxXv, double theMaxYv)
		{
			throw new NotImplementedException();
		}

		public void WindowFit(int theMinXp, int theMinYp, int theMaxXp, int theMaxYp)
		{
			throw new NotImplementedException();
		}

		public void SetViewMappingDefault()
		{
			throw new NotImplementedException();
		}

		public void ResetViewMapping()
		{
			throw new NotImplementedException();
		}

		public void Reset(bool theToUpdate)
		{
			throw new NotImplementedException();
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}

		public double Convert(int Vp)
		{
			throw new NotImplementedException();
		}

		public void Convert(int Xp, int Yp, ref double Xv, ref double Yv)
		{
			throw new NotImplementedException();
		}

		public int Convert(double Vv)
		{
			throw new NotImplementedException();
		}

		public void Convert(double Xv, double Yv, ref int Xp, ref int Yp)
		{
			throw new NotImplementedException();
		}

		public void Convert(int Xp, int Yp, ref double X, ref double Y, ref double Z)
		{
			throw new NotImplementedException();
		}

		public void ConvertWithProj(int Xp, int Yp, ref double X, ref double Y, ref double Z, ref double Vx, ref double Vy, ref double Vz)
		{
			throw new NotImplementedException();
		}

		public void ConvertToGrid(int Xp, int Yp, ref double Xg, ref double Yg, ref double Zg)
		{
			throw new NotImplementedException();
		}

		public void ConvertToGrid(double X, double Y, double Z, ref double Xg, ref double Yg, ref double Zg)
		{
			throw new NotImplementedException();
		}

		public void Convert(double X, double Y, double Z, ref int Xp, ref int Yp)
		{
			throw new NotImplementedException();
		}

		public void Project(double theX, double theY, double theZ, ref double theXp, ref double theYp)
		{
			throw new NotImplementedException();
		}

		public void Project(double theX, double theY, double theZ, ref double theXp, ref double theYp, ref double theZp)
		{
			throw new NotImplementedException();
		}

		public void BackgroundColor(CascadeSharp.Quantity_TypeOfColor Type, ref double V1, ref double V2, ref double V3)
		{
			throw new NotImplementedException();
		}

		public Quantity_Color BackgroundColor()
		{
			throw new NotImplementedException();
		}

		public void GradientBackgroundColors(Quantity_Color theColor1, Quantity_Color theColor2)
		{
			throw new NotImplementedException();
		}

		public Aspect_GradientBackground GradientBackground()
		{
			throw new NotImplementedException();
		}

		public double Scale()
		{
			throw new NotImplementedException();
		}

		public void AxialScale(ref double Sx, ref double Sy, ref double Sz)
		{
			throw new NotImplementedException();
		}

		public void Size(ref double Width, ref double Height)
		{
			throw new NotImplementedException();
		}

		public double ZSize()
		{
			throw new NotImplementedException();
		}

		public void Eye(ref double X, ref double Y, ref double Z)
		{
			throw new NotImplementedException();
		}

		public void FocalReferencePoint(ref double X, ref double Y, ref double Z)
		{
			throw new NotImplementedException();
		}

		public void ProjReferenceAxe(int Xpix, int Ypix, ref double XP, ref double YP, ref double ZP, ref double VX, ref double VY, ref double VZ)
		{
			throw new NotImplementedException();
		}

		public double Depth()
		{
			throw new NotImplementedException();
		}

		public void Proj(ref double Vx, ref double Vy, ref double Vz)
		{
			throw new NotImplementedException();
		}

		public void At(ref double X, ref double Y, ref double Z)
		{
			throw new NotImplementedException();
		}

		public void Up(ref double Vx, ref double Vy, ref double Vz)
		{
			throw new NotImplementedException();
		}

		public double Twist()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Graphic3d_TypeOfShadingModel ShadingModel()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_TextureEnv TextureEnv()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.V3d_TypeOfVisualization Visualization()
		{
			throw new NotImplementedException();
		}

		public V3d_ListOfLight ActiveLights()
		{
			throw new NotImplementedException();
		}

				public int LightLimit()
		{
			throw new NotImplementedException();
		}

		public V3d_Viewer Viewer()
		{
			throw new NotImplementedException();
		}

		public bool IfWindow()
		{
			throw new NotImplementedException();
		}

		public Aspect_Window Window()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.V3d_TypeOfView Type()
		{
			throw new NotImplementedException();
		}

		public void Pan(int theDXp, int theDYp, double theZoomFactor, bool theToStart)
		{
			throw new NotImplementedException();
		}

		public void Pan(int theDXp, int theDYp, double theZoomFactor)
		{
			throw new NotImplementedException();
		}

		public void Pan(int theDXp, int theDYp)
		{
			throw new NotImplementedException();
		}

		public void Zoom(int theXp1, int theYp1, int theXp2, int theYp2)
		{
			throw new NotImplementedException();
		}

		public void StartZoomAtPoint(int theXp, int theYp)
		{
			throw new NotImplementedException();
		}

		public void ZoomAtPoint(int theMouseStartX, int theMouseStartY, int theMouseEndX, int theMouseEndY)
		{
			throw new NotImplementedException();
		}

		public void AxialScale(int Dx, int Dy, CascadeSharp.V3d_TypeOfAxe Ax_is)
		{
			throw new NotImplementedException();
		}

		public void StartRotation(int X, int Y, double zRotationThreshold)
		{
			throw new NotImplementedException();
		}

		public void StartRotation(int X, int Y)
		{
			throw new NotImplementedException();
		}

		public void Rotation(int X, int Y)
		{
			throw new NotImplementedException();
		}

		public void SetFocale(double Focale)
		{
			throw new NotImplementedException();
		}

		public double Focale()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_CView View()
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

		public void WindowFitAll(int Xmin, int Ymin, int Xmax, int Ymax)
		{
			throw new NotImplementedException();
		}

		public bool FitMinMax(Graphic3d_Camera theCamera, Bnd_Box theBox, double theMargin, double theResolution, bool theToEnlargeIfLine)
		{
			throw new NotImplementedException();
		}

		public bool FitMinMax(Graphic3d_Camera theCamera, Bnd_Box theBox, double theMargin, double theResolution)
		{
			throw new NotImplementedException();
		}

		public bool FitMinMax(Graphic3d_Camera theCamera, Bnd_Box theBox, double theMargin)
		{
			throw new NotImplementedException();
		}

		public void SetGrid(gp_Ax3 aPlane, Aspect_Grid aGrid)
		{
			throw new NotImplementedException();
		}

		public void SetGridActivity(bool aFlag)
		{
			throw new NotImplementedException();
		}

		public bool Dump(string theFile,  ref CascadeSharp.Graphic3d_BufferType theBufferType)
		{
			throw new NotImplementedException();
		}

		public bool Dump(string theFile)
		{
			throw new NotImplementedException();
		}

		public bool ToPixMap(Image_PixMap theImage, V3d_ImageDumpOptions theParams)
		{
			throw new NotImplementedException();
		}

		public bool ToPixMap(Image_PixMap theImage, int theWidth, int theHeight,  ref CascadeSharp.Graphic3d_BufferType theBufferType, bool theToAdjustAspect, CascadeSharp.V3d_StereoDumpOptions theStereoOptions)
		{
			throw new NotImplementedException();
		}

		public bool ToPixMap(Image_PixMap theImage, int theWidth, int theHeight,  ref CascadeSharp.Graphic3d_BufferType theBufferType, bool theToAdjustAspect)
		{
			throw new NotImplementedException();
		}

		public bool ToPixMap(Image_PixMap theImage, int theWidth, int theHeight,  ref CascadeSharp.Graphic3d_BufferType theBufferType)
		{
			throw new NotImplementedException();
		}

		public bool ToPixMap(Image_PixMap theImage, int theWidth, int theHeight)
		{
			throw new NotImplementedException();
		}

		public void SetBackFacingModel(CascadeSharp.V3d_TypeOfBackfacingModel theModel)
		{
			throw new NotImplementedException();
		}

		public void SetBackFacingModel()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.V3d_TypeOfBackfacingModel BackFacingModel()
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

		public void SetClipPlanes(Graphic3d_SequenceOfHClipPlane thePlanes)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_SequenceOfHClipPlane ClipPlanes()
		{
			throw new NotImplementedException();
		}

		public int PlaneLimit()
		{
			throw new NotImplementedException();
		}

		public void SetCamera(Graphic3d_Camera theCamera)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Camera Camera()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Camera DefaultCamera()
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

		public bool IsCullingEnabled()
		{
			throw new NotImplementedException();
		}

		public void SetFrustumCulling(bool theMode)
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

		public gp_Pnt GravityPoint()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IfMoreLights()
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

		public void ImmediateUpdate()
		{
			throw new NotImplementedException();
		}

		public void Scale(Graphic3d_Camera theCamera, double theSizeXv, double theSizeYv)
		{
			throw new NotImplementedException();
		}

		public void Translate(Graphic3d_Camera theCamera, double theDXv, double theDYv)
		{
			throw new NotImplementedException();
		}

		public void SetRatio()
		{
			throw new NotImplementedException();
		}

		public bool screenAxis(gp_Dir theVpn, gp_Dir theVup, gp_Vec theXaxe, gp_Vec theYaxe, gp_Vec theZaxe)
		{
			throw new NotImplementedException();
		}

				public int MinMax(ref double Umin, ref double Vmin, ref double Umax, ref double Vmax)
		{
			throw new NotImplementedException();
		}

		public int MinMax(ref double Xmin, ref double Ymin, ref double Zmin, ref double Xmax, ref double Ymax, ref double Zmax)
		{
			throw new NotImplementedException();
		}

		public void Init()
		{
			throw new NotImplementedException();
		}

		
	}; // class V3d_View

}
