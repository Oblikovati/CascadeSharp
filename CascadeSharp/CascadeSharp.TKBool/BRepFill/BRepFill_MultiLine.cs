//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKGeomBase.AppCont;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBool.BRepFill
{
    //---------------------------------------------------------------------
    //  Class  BRepFill_MultiLine
    //---------------------------------------------------------------------
    public sealed class BRepFill_MultiLine : AppCont_Function
    {
        public BRepFill_MultiLine()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_MultiLine(TopoDS_Face Face1, TopoDS_Face Face2, TopoDS_Edge Edge1, TopoDS_Edge Edge2, bool Inv1,
            bool Inv2, Geom2d_Curve B_issec)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_MultiLine(BRepFill_MultiLine parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool IsParticularCase()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity()
        {
            throw new NotImplementedException();
        }

        public void Curves(Geom_Curve Curve, Geom2d_Curve PCurve1, Geom2d_Curve PCurve2)
        {
            throw new NotImplementedException();
        }

        public double FirstParameter()
        {
            throw new NotImplementedException();
        }

        public double LastParameter()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Value(double U)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d ValueOnF1(double U)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d ValueOnF2(double U)
        {
            throw new NotImplementedException();
        }

        public void Value3dOnF1OnF2(double U, gp_Pnt P3d, gp_Pnt2d PF1, gp_Pnt2d PF2)
        {
            throw new NotImplementedException();
        }
    }; // class BRepFill_MultiLine
}