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
    //  Class  BRepPrim_Sphere
    //---------------------------------------------------------------------
    public sealed class BRepPrim_Sphere : BRepPrim_Revolution
    {
        public BRepPrim_Sphere(double Radius)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Sphere(gp_Pnt Center, double Radius)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Sphere(gp_Ax2 Axes, double Radius)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Sphere(BRepPrim_Sphere parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_Sphere()
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
    }; // class BRepPrim_Sphere
}