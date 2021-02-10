//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.SelectMgr;
using CascadeSharp.TKV3d.StdSelect;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_ColoredShape
    //---------------------------------------------------------------------
    public sealed class AIS_ColoredShape : AIS_Shape
    {
        public AIS_ColoredShape(TopoDS_Shape theShape)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_ColoredShape(AIS_Shape theShape)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_ColoredShape(AIS_ColoredShape parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_ColoredShape()
        {
            throw new NotImplementedException();
        }

        public AIS_ColoredDrawer CustomAspects(TopoDS_Shape theShape)
        {
            throw new NotImplementedException();
        }

        public void ClearCustomAspects()
        {
            throw new NotImplementedException();
        }

        public void UnsetCustomAspects(TopoDS_Shape theShape, bool theToUnreg_ister)
        {
            throw new NotImplementedException();
        }

        public void UnsetCustomAspects(TopoDS_Shape theShape)
        {
            throw new NotImplementedException();
        }

        public void SetCustomColor(TopoDS_Shape theShape, Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public void SetCustomTransparency(TopoDS_Shape theShape, double theTransparency)
        {
            throw new NotImplementedException();
        }

        public void SetCustomWidth(TopoDS_Shape theShape, double theLineWidth)
        {
            throw new NotImplementedException();
        }

        public AIS_DataMapOfShapeDrawer CustomAspectsMap()
        {
            throw new NotImplementedException();
        }

        public AIS_DataMapOfShapeDrawer ChangeCustomAspectsMap()
        {
            throw new NotImplementedException();
        }

        public void SetColor(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public void SetWidth(double theLineWidth)
        {
            throw new NotImplementedException();
        }

        public void SetTransparency(double theValue)
        {
            throw new NotImplementedException();
        }

        public void SetMaterial(Graphic3d_MaterialAspect theAspect)
        {
            throw new NotImplementedException();
        }

        public void UnsetTransparency()
        {
            throw new NotImplementedException();
        }

        public void UnsetWidth()
        {
            throw new NotImplementedException();
        }

        public void ComputeSelection(SelectMgr_Selection theSelection, int theMode)
        {
            throw new NotImplementedException();
        }

        public void fillSubshapeDrawerMap(AIS_DataMapOfShapeDrawer theSubshapeDrawerMap)
        {
            throw new NotImplementedException();
        }

        public bool isShapeEntirelyVisible()
        {
            throw new NotImplementedException();
        }

        public void bindSubShapes(AIS_DataMapOfShapeDrawer theShapeDrawerMap, TopoDS_Shape theKeyShape,
            AIS_ColoredDrawer theDrawer)
        {
            throw new NotImplementedException();
        }

        public void computeSubshapeSelection(AIS_ColoredDrawer theParentDrawer,
            AIS_DataMapOfShapeDrawer theShapeDrawerMap, TopoDS_Shape theShape, StdSelect_BRepOwner theOwner,
            SelectMgr_Selection theSelection, TopAbs_ShapeEnum theTypOfSel, int thePriority, double theDeflection,
            double theDeflAngle)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class AIS_ColoredShape
}