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
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.BRepTools
{
    //---------------------------------------------------------------------
    //  Class  BRepTools_TrsfModification
    //---------------------------------------------------------------------
    public class BRepTools_TrsfModification : BRepTools_Modification
    {
        public BRepTools_TrsfModification(gp_Trsf T)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepTools_TrsfModification(BRepTools_TrsfModification parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepTools_TrsfModification()
        {
            throw new NotImplementedException();
        }

        public gp_Trsf Trsf()
        {
            throw new NotImplementedException();
        }

        public bool NewSurface(TopoDS_Face F, Geom_Surface S, TopLoc_Location L, ref double Tol, ref bool RevWires,
            ref bool RevFace)
        {
            throw new NotImplementedException();
        }

        public bool NewCurve(TopoDS_Edge E, Geom_Curve C, TopLoc_Location L, ref double Tol)
        {
            throw new NotImplementedException();
        }

        public bool NewPoint(TopoDS_Vertex V, gp_Pnt P, ref double Tol)
        {
            throw new NotImplementedException();
        }

        public bool NewCurve2d(TopoDS_Edge E, TopoDS_Face F, TopoDS_Edge NewE, TopoDS_Face NewF, Geom2d_Curve C,
            ref double Tol)
        {
            throw new NotImplementedException();
        }

        public bool NewParameter(TopoDS_Vertex V, TopoDS_Edge E, ref double P, ref double Tol)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity(TopoDS_Edge E, TopoDS_Face F1, TopoDS_Face F2, TopoDS_Edge NewE,
            TopoDS_Face NewF1, TopoDS_Face NewF2)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class BRepTools_TrsfModification
}