//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.BRepLib
{
    //---------------------------------------------------------------------
    //  Class  BRepLib_MakeFace
    //---------------------------------------------------------------------
    public sealed class BRepLib_MakeFace : BRepLib_MakeShape
    {
        public BRepLib_MakeFace()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(TopoDS_Face F)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Pln P)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Cylinder C)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Cone C)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Sphere S)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Torus C)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(Geom_Surface S, double TolDegen)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Pln P, double UMin, double UMax, double VMin, double VMax)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Cylinder C, double UMin, double UMax, double VMin, double VMax)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Cone C, double UMin, double UMax, double VMin, double VMax)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Sphere S, double UMin, double UMax, double VMin, double VMax)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Torus C, double UMin, double UMax, double VMin, double VMax)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(Geom_Surface S, double UMin, double UMax, double VMin, double VMax, double TolDegen)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(TopoDS_Wire W, bool OnlyPlane)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(TopoDS_Wire W)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Pln P, TopoDS_Wire W, bool Inside)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Pln P, TopoDS_Wire W)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Cylinder C, TopoDS_Wire W, bool Inside)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Cylinder C, TopoDS_Wire W)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Cone C, TopoDS_Wire W, bool Inside)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Cone C, TopoDS_Wire W)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Sphere S, TopoDS_Wire W, bool Inside)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Sphere S, TopoDS_Wire W)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Torus C, TopoDS_Wire W, bool Inside)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(gp_Torus C, TopoDS_Wire W)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(Geom_Surface S, TopoDS_Wire W, bool Inside)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(Geom_Surface S, TopoDS_Wire W)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(TopoDS_Face F, TopoDS_Wire W)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeFace(BRepLib_MakeFace parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public void Init(Geom_Surface S, bool Bound, double TolDegen)
        {
            throw new NotImplementedException();
        }

        public void Init(Geom_Surface S, double UMin, double UMax, double VMin, double VMax, double TolDegen)
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Wire W)
        {
            throw new NotImplementedException();
        }

        public BRepLib_FaceError Error()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face Face()
        {
            throw new NotImplementedException();
        }

        public bool IsDegenerated(Geom_Curve theCurve, double theMaxTol, ref double theActTol)
        {
            throw new NotImplementedException();
        }

        public void CheckInside()
        {
            throw new NotImplementedException();
        }
    }; // class BRepLib_MakeFace
}