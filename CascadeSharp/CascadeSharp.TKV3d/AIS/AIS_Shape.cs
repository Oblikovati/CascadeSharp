//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.Prs3d;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_Shape
    //---------------------------------------------------------------------
    public class AIS_Shape : AIS_InteractiveObject
    {
        public AIS_Shape(TopoDS_Shape shap)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_Shape(AIS_Shape parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_Shape()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public int Signature()
        {
            throw new NotImplementedException();
        }

        public AIS_KindOfInteractive Type()
        {
            throw new NotImplementedException();
        }

        public bool AcceptShapeDecomposition()
        {
            throw new NotImplementedException();
        }

        public bool AcceptDisplayMode(int theMode)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape()
        {
            throw new NotImplementedException();
        }

        public void SetShape(TopoDS_Shape theShape)
        {
            throw new NotImplementedException();
        }

        public void Set(TopoDS_Shape theShape)
        {
            throw new NotImplementedException();
        }

        public bool SetOwnDeviationCoefficient()
        {
            throw new NotImplementedException();
        }

        public bool SetOwnDeviationAngle()
        {
            throw new NotImplementedException();
        }

        public void SetOwnDeviationCoefficient(double aCoefficient)
        {
            throw new NotImplementedException();
        }

        public void SetAngleAndDeviation(double anAngle)
        {
            throw new NotImplementedException();
        }

        public double UserAngle()
        {
            throw new NotImplementedException();
        }

        public void SetOwnDeviationAngle(double anAngle)
        {
            throw new NotImplementedException();
        }

        public bool OwnDeviationCoefficient(ref double aCoefficient, ref double aPreviousCoefficient)
        {
            throw new NotImplementedException();
        }

        public bool OwnDeviationAngle(ref double anAngle, ref double aPreviousAngle)
        {
            throw new NotImplementedException();
        }

        public void SetTypeOfHLR(Prs3d_TypeOfHLR theTypeOfHLR)
        {
            throw new NotImplementedException();
        }

        public Prs3d_TypeOfHLR TypeOfHLR()
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

        public void SetWidth(double aValue)
        {
            throw new NotImplementedException();
        }

        public void UnsetWidth()
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

        public Bnd_Box BoundingBox()
        {
            throw new NotImplementedException();
        }

        public void Color(Quantity_Color aColor)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_NameOfMaterial Material()
        {
            throw new NotImplementedException();
        }

        public double Transparency()
        {
            throw new NotImplementedException();
        }

        public TopAbs_ShapeEnum SelectionType(int theSelMode)
        {
            throw new NotImplementedException();
        }

        public int SelectionMode(TopAbs_ShapeEnum theShapeType)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d TextureRepeatUV()
        {
            throw new NotImplementedException();
        }

        public void SetTextureRepeatUV(gp_Pnt2d theRepeatUV)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d TextureOriginUV()
        {
            throw new NotImplementedException();
        }

        public void SetTextureOriginUV(gp_Pnt2d theOriginUV)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d TextureScaleUV()
        {
            throw new NotImplementedException();
        }

        public void SetTextureScaleUV(gp_Pnt2d theScaleUV)
        {
            throw new NotImplementedException();
        }

        public void computeHLR(Graphic3d_Camera theProjector, TopLoc_Datum3D theTrsf, Graphic3d_Structure thePrs)
        {
            throw new NotImplementedException();
        }

        public void ComputeSelection(SelectMgr_Selection theSelection, int theMode)
        {
            throw new NotImplementedException();
        }

        public bool setColor(Prs3d_Drawer theDrawer, Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public bool setWidth(Prs3d_Drawer theDrawer, double theWidth)
        {
            throw new NotImplementedException();
        }

        public void setTransparency(Prs3d_Drawer theDrawer, double theValue)
        {
            throw new NotImplementedException();
        }

        public void setMaterial(Prs3d_Drawer theDrawer, Graphic3d_MaterialAspect theMaterial, bool theToKeepColor,
            bool theToKeepTransp)
        {
            throw new NotImplementedException();
        }

        public void replaceWithNewOwnAspects()
        {
            throw new NotImplementedException();
        }

        public void computeHlrPresentation(Graphic3d_Camera theProjector, Graphic3d_Structure thePrs,
            TopoDS_Shape theShape, Prs3d_Drawer theDrawer)
        {
            throw new NotImplementedException();
        }
    }; // class AIS_Shape
}