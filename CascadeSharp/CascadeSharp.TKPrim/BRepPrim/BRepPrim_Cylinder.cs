//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKPrim.BRepPrim
{
    //---------------------------------------------------------------------
    //  Class  BRepPrim_Cylinder
    //---------------------------------------------------------------------
    public sealed class BRepPrim_Cylinder : BRepPrim_Revolution
    {
        public BRepPrim_Cylinder(gp_Ax2 Position, double Radius, double Height)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Cylinder(double Radius)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Cylinder(gp_Pnt Center, double Radius)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Cylinder(gp_Ax2 Axes, double Radius)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Cylinder(double R, double H)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Cylinder(gp_Pnt Center, double R, double H)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Cylinder(BRepPrim_Cylinder parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Cylinder()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face MakeEmptyLateralFace()
        {
            throw new NotImplementedException();
        }

        public void SetMeridian()
        {
            throw new NotImplementedException();
        }
    }; // class BRepPrim_Cylinder
}