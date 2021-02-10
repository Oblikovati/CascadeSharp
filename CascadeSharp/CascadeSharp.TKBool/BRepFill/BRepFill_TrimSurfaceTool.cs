//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKBool.BRepFill
{
    //---------------------------------------------------------------------
    //  Class  BRepFill_TrimSurfaceTool
    //---------------------------------------------------------------------
    public sealed class BRepFill_TrimSurfaceTool
    {
        public BRepFill_TrimSurfaceTool(Geom2d_Curve B_is, TopoDS_Face Face1, TopoDS_Face Face2, TopoDS_Edge Edge1,
            TopoDS_Edge Edge2, bool Inv1, bool Inv2)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_TrimSurfaceTool(BRepFill_TrimSurfaceTool parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_TrimSurfaceTool()
        {
            throw new NotImplementedException();
        }

        public void IntersectWith(TopoDS_Edge EdgeOnF1, TopoDS_Edge EdgeOnF2, TColgp_SequenceOfPnt Points)
        {
            throw new NotImplementedException();
        }

        public bool IsOnFace(gp_Pnt2d Point)
        {
            throw new NotImplementedException();
        }

        public double ProjOn(gp_Pnt2d Point, TopoDS_Edge Edge)
        {
            throw new NotImplementedException();
        }

        public void Project(double U1, double U2, Geom_Curve Curve, Geom2d_Curve PCurve1, Geom2d_Curve PCurve2,
            ref GeomAbs_Shape myCont)
        {
            throw new NotImplementedException();
        }
    }; // class BRepFill_TrimSurfaceTool
}