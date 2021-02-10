//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBO.BRepAlgoAPI;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKFeat.LocOpe;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TColGeom;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKFeat.BRepFeat
{
    //---------------------------------------------------------------------
    //  Class  BRepFeat_Form
    //---------------------------------------------------------------------
    public abstract class BRepFeat_Form : BRepBuilderAPI_MakeShape
    {
        public BRepFeat_Form()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public BRepFeat_Form(BRepFeat_Form parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public TopTools_ListOfShape Modified(TopoDS_Shape F)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Generated(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool IsDeleted(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape FirstShape()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape LastShape()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape NewEdges()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape TgtEdges()
        {
            throw new NotImplementedException();
        }

        public void BasisShapeValid()
        {
            throw new NotImplementedException();
        }

        public void GeneratedShapeValid()
        {
            throw new NotImplementedException();
        }

        public void ShapeFromValid()
        {
            throw new NotImplementedException();
        }

        public void ShapeUntilValid()
        {
            throw new NotImplementedException();
        }

        public void GluedFacesValid()
        {
            throw new NotImplementedException();
        }

        public void SketchFaceValid()
        {
            throw new NotImplementedException();
        }

        public void PerfSelectionValid()
        {
            throw new NotImplementedException();
        }

        public void Curves(TColGeom_SequenceOfCurve S)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve BarycCurve()
        {
            throw new NotImplementedException();
        }

        public BRepFeat_StatusError CurrentStatusError()
        {
            throw new NotImplementedException();
        }

        public void GlobalPerform()
        {
            throw new NotImplementedException();
        }

        public void UpdateDescendants(LocOpe_Gluer G)
        {
            throw new NotImplementedException();
        }

        public void UpdateDescendants(BRepAlgoAPI_BooleanOperation aBOP, TopoDS_Shape SResult, bool SkipFace)
        {
            throw new NotImplementedException();
        }

        public void UpdateDescendants(BRepAlgoAPI_BooleanOperation aBOP, TopoDS_Shape SResult)
        {
            throw new NotImplementedException();
        }

        public bool TransformShapeFU(int flag)
        {
            throw new NotImplementedException();
        }
    }; // class BRepFeat_Form
}