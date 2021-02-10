//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKBool.TopOpeBRepTool
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRepTool_CurveTool
    //---------------------------------------------------------------------
    public sealed class TopOpeBRepTool_CurveTool
    {
        public TopOpeBRepTool_CurveTool()
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_CurveTool(TopOpeBRepTool_OutCurveType OCT)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_CurveTool(TopOpeBRepTool_GeomTool GT)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_CurveTool(TopOpeBRepTool_CurveTool parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_GeomTool ChangeGeomTool()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_GeomTool GetGeomTool()
        {
            throw new NotImplementedException();
        }

        public void SetGeomTool(TopOpeBRepTool_GeomTool GT)
        {
            throw new NotImplementedException();
        }

        public bool MakeCurves(double min, double max, Geom_Curve C3D, Geom2d_Curve PC1, Geom2d_Curve PC2,
            TopoDS_Shape S1, TopoDS_Shape S2, Geom_Curve C3DN, Geom2d_Curve PC1N, Geom2d_Curve PC2N, ref double Tol3d,
            ref double Tol2d)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve MakeBSpline1fromPnt(TColgp_Array1OfPnt P)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve MakeBSpline1fromPnt2d(TColgp_Array1OfPnt2d P)
        {
            throw new NotImplementedException();
        }

        public bool IsProjectable(TopoDS_Shape S, Geom_Curve C)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve MakePCurveOnFace(TopoDS_Shape S, Geom_Curve C, ref double TolReached2d, double first,
            double last)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve MakePCurveOnFace(TopoDS_Shape S, Geom_Curve C, ref double TolReached2d, double first)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve MakePCurveOnFace(TopoDS_Shape S, Geom_Curve C, ref double TolReached2d)
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRepTool_CurveTool
}