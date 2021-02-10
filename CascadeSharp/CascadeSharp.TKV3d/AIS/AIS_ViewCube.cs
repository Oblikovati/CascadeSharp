//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.Prs3d;
using CascadeSharp.TKV3d.SelectMgr;
using CascadeSharp.TKV3d.V3d;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_ViewCube
    //---------------------------------------------------------------------
    public class AIS_ViewCube : AIS_InteractiveObject
    {
        public AIS_ViewCube()
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_ViewCube(AIS_ViewCube parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public bool IsBoxSide(V3d_TypeOfOrientation theOrient)
        {
            throw new NotImplementedException();
        }

        public bool IsBoxEdge(V3d_TypeOfOrientation theOrient)
        {
            throw new NotImplementedException();
        }

        public bool IsBoxCorner(V3d_TypeOfOrientation theOrient)
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

        public bool ToAutoStartAnimation()
        {
            throw new NotImplementedException();
        }

        public void SetAutoStartAnimation(bool theToEnable)
        {
            throw new NotImplementedException();
        }

        public bool IsFixedAnimationLoop()
        {
            throw new NotImplementedException();
        }

        public void SetFixedAnimationLoop(bool theToEnable)
        {
            throw new NotImplementedException();
        }

        public void ResetStyles()
        {
            throw new NotImplementedException();
        }

        public void setDefaultAttributes()
        {
            throw new NotImplementedException();
        }

        public void setDefaultHighlightAttributes()
        {
            throw new NotImplementedException();
        }

        public double Size()
        {
            throw new NotImplementedException();
        }

        public void SetSize(double theValue, bool theToAdaptAnother)
        {
            throw new NotImplementedException();
        }

        public void SetSize(double theValue)
        {
            throw new NotImplementedException();
        }

        public double BoxFacetExtension()
        {
            throw new NotImplementedException();
        }

        public void SetBoxFacetExtension(double theValue)
        {
            throw new NotImplementedException();
        }

        public double AxesPadding()
        {
            throw new NotImplementedException();
        }

        public void SetAxesPadding(double theValue)
        {
            throw new NotImplementedException();
        }

        public double BoxEdgeGap()
        {
            throw new NotImplementedException();
        }

        public void SetBoxEdgeGap(double theValue)
        {
            throw new NotImplementedException();
        }

        public double BoxEdgeMinSize()
        {
            throw new NotImplementedException();
        }

        public void SetBoxEdgeMinSize(double theValue)
        {
            throw new NotImplementedException();
        }

        public double BoxCornerMinSize()
        {
            throw new NotImplementedException();
        }

        public void SetBoxCornerMinSize(double theValue)
        {
            throw new NotImplementedException();
        }

        public double RoundRadius()
        {
            throw new NotImplementedException();
        }

        public void SetRoundRadius(double theValue)
        {
            throw new NotImplementedException();
        }

        public double AxesRadius()
        {
            throw new NotImplementedException();
        }

        public void SetAxesRadius(double theRadius)
        {
            throw new NotImplementedException();
        }

        public double AxesConeRadius()
        {
            throw new NotImplementedException();
        }

        public void SetAxesConeRadius(double theRadius)
        {
            throw new NotImplementedException();
        }

        public double AxesSphereRadius()
        {
            throw new NotImplementedException();
        }

        public void SetAxesSphereRadius(double theRadius)
        {
            throw new NotImplementedException();
        }

        public bool ToDrawAxes()
        {
            throw new NotImplementedException();
        }

        public void SetDrawAxes(bool theValue)
        {
            throw new NotImplementedException();
        }

        public bool ToDrawEdges()
        {
            throw new NotImplementedException();
        }

        public void SetDrawEdges(bool theValue)
        {
            throw new NotImplementedException();
        }

        public bool ToDrawVertices()
        {
            throw new NotImplementedException();
        }

        public void SetDrawVertices(bool theValue)
        {
            throw new NotImplementedException();
        }

        public bool IsYup()
        {
            throw new NotImplementedException();
        }

        public void SetYup(bool theIsYup, bool theToUpdateLabels)
        {
            throw new NotImplementedException();
        }

        public void SetYup(bool theIsYup)
        {
            throw new NotImplementedException();
        }

        public Prs3d_ShadingAspect BoxSideStyle()
        {
            throw new NotImplementedException();
        }

        public Prs3d_ShadingAspect BoxEdgeStyle()
        {
            throw new NotImplementedException();
        }

        public Prs3d_ShadingAspect BoxCornerStyle()
        {
            throw new NotImplementedException();
        }

        public Quantity_Color BoxColor()
        {
            throw new NotImplementedException();
        }

        public void SetBoxColor(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public double BoxTransparency()
        {
            throw new NotImplementedException();
        }

        public void SetBoxTransparency(double theValue)
        {
            throw new NotImplementedException();
        }

        public Quantity_Color InnerColor()
        {
            throw new NotImplementedException();
        }

        public void SetInnerColor(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString BoxSideLabel(V3d_TypeOfOrientation theSide)
        {
            throw new NotImplementedException();
        }

        public void SetBoxSideLabel(V3d_TypeOfOrientation theSide, TCollection_AsciiString theLabel)
        {
            throw new NotImplementedException();
        }

        public Quantity_Color TextColor()
        {
            throw new NotImplementedException();
        }

        public void SetTextColor(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString Font()
        {
            throw new NotImplementedException();
        }

        public void SetFont(TCollection_AsciiString theFont)
        {
            throw new NotImplementedException();
        }

        public double FontHeight()
        {
            throw new NotImplementedException();
        }

        public void SetFontHeight(double theValue)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString AxisLabel(Prs3d_DatumParts theAx_is)
        {
            throw new NotImplementedException();
        }

        public void SetAxesLabels(TCollection_AsciiString theX, TCollection_AsciiString theY,
            TCollection_AsciiString theZ)
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

        public void SetTransparency(double theValue)
        {
            throw new NotImplementedException();
        }

        public void UnsetTransparency()
        {
            throw new NotImplementedException();
        }

        public void SetMaterial(Graphic3d_MaterialAspect theMat)
        {
            throw new NotImplementedException();
        }

        public void UnsetMaterial()
        {
            throw new NotImplementedException();
        }

        public double Duration()
        {
            throw new NotImplementedException();
        }

        public void SetDuration(double theValue)
        {
            throw new NotImplementedException();
        }

        public bool ToResetCameraUp()
        {
            throw new NotImplementedException();
        }

        public void SetResetCamera(bool theToReset)
        {
            throw new NotImplementedException();
        }

        public bool ToFitSelected()
        {
            throw new NotImplementedException();
        }

        public void SetFitSelected(bool theToFitSelected)
        {
            throw new NotImplementedException();
        }

        public bool HasAnimation()
        {
            throw new NotImplementedException();
        }

        public void StartAnimation(AIS_ViewCubeOwner theOwner)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAnimation(bool theToUpdate)
        {
            throw new NotImplementedException();
        }

        public void HandleClick(AIS_ViewCubeOwner theOwner)
        {
            throw new NotImplementedException();
        }

        public bool updateAnimation()
        {
            throw new NotImplementedException();
        }

        public void viewFitAll(V3d_View theView, Graphic3d_Camera theCamera)
        {
            throw new NotImplementedException();
        }

        public void onAfterAnimation()
        {
            throw new NotImplementedException();
        }

        public void onAnimationFinished()
        {
            throw new NotImplementedException();
        }

        public bool AcceptDisplayMode(int theMode)
        {
            throw new NotImplementedException();
        }

        public SelectMgr_EntityOwner GlobalSelOwner()
        {
            throw new NotImplementedException();
        }

        public void ComputeSelection(SelectMgr_Selection theSelection, int theMode)
        {
            throw new NotImplementedException();
        }

        public bool IsAutoHilight()
        {
            throw new NotImplementedException();
        }

        public void ClearSelected()
        {
            throw new NotImplementedException();
        }

        public void UnsetAttributes()
        {
            throw new NotImplementedException();
        }

        public void UnsetHilightAttributes()
        {
            throw new NotImplementedException();
        }

        public void createBoxPartTriangles(Graphic3d_ArrayOfTriangles theTr_is, ref int theNbNodes, ref int theNbTr_is,
            V3d_TypeOfOrientation theDir)
        {
            throw new NotImplementedException();
        }

        public void createBoxSideTriangles(Graphic3d_ArrayOfTriangles theTr_is, ref int theNbNodes, ref int theNbTr_is,
            V3d_TypeOfOrientation theDir)
        {
            throw new NotImplementedException();
        }

        public void createBoxEdgeTriangles(Graphic3d_ArrayOfTriangles theTr_is, ref int theNbNodes, ref int theNbTr_is,
            V3d_TypeOfOrientation theDir)
        {
            throw new NotImplementedException();
        }

        public void createBoxCornerTriangles(Graphic3d_ArrayOfTriangles theTr_is, ref int theNbNodes,
            ref int theNbTr_is, V3d_TypeOfOrientation theDir)
        {
            throw new NotImplementedException();
        }

        public void createRoundRectangleTriangles(Graphic3d_ArrayOfTriangles theTr_is, ref int theNbNodes,
            ref int theNbTr_is, gp_XY theSize, double theRadius, gp_Trsf theTrsf)
        {
            throw new NotImplementedException();
        }
    }; // class AIS_ViewCube
}