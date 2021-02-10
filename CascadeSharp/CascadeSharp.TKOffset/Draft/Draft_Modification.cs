//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepTools;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKOffset.Draft
{
    //---------------------------------------------------------------------
    //  Class  Draft_Modification
    //---------------------------------------------------------------------
    public sealed class Draft_Modification : BRepTools_Modification
    {
        public Draft_Modification(TopoDS_Shape S)
            : base()
        {
            throw new NotImplementedException();
        }

        public Draft_Modification(Draft_Modification parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Draft_Modification()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool Add(TopoDS_Face F, gp_Dir Direction, double Angle, gp_Pln NeutralPlane, bool Flag)
        {
            throw new NotImplementedException();
        }

        public bool Add(TopoDS_Face F, gp_Dir Direction, double Angle, gp_Pln NeutralPlane)
        {
            throw new NotImplementedException();
        }

        public void Remove(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public void Perform()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public Draft_ErrorStatus Error()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape ProblematicShape()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape ConnectedFaces(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape ModifiedFaces()
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

        public bool InternalAdd(TopoDS_Face F, gp_Dir Direction, double Angle, gp_Pln NeutralPlane, bool Flag)
        {
            throw new NotImplementedException();
        }

        public bool InternalAdd(TopoDS_Face F, gp_Dir Direction, double Angle, gp_Pln NeutralPlane)
        {
            throw new NotImplementedException();
        }

        public bool Propagate()
        {
            throw new NotImplementedException();
        }

        public Geom_Curve NewCurve(Geom_Curve C, Geom_Surface S, TopAbs_Orientation OriS, gp_Dir Direction,
            double Angle, gp_Pln NeutralPlane, bool Flag)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve NewCurve(Geom_Curve C, Geom_Surface S, TopAbs_Orientation OriS, gp_Dir Direction,
            double Angle, gp_Pln NeutralPlane)
        {
            throw new NotImplementedException();
        }

        public Geom_Surface NewSurface(Geom_Surface S, TopAbs_Orientation OriS, gp_Dir Direction, double Angle,
            gp_Pln NeutralPlane)
        {
            throw new NotImplementedException();
        }
    }; // class Draft_Modification
}