//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKGeomAlgo.IntCurveSurface;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.BRepClass3d
{
    //---------------------------------------------------------------------
    //  Class  BRepClass3d_Intersector3d
    //---------------------------------------------------------------------
    public sealed class BRepClass3d_Intersector3d
    {
        public BRepClass3d_Intersector3d()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepClass3d_Intersector3d(BRepClass3d_Intersector3d parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Perform(gp_Lin L, double Prm, double Tol, TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public bool HasAPoint()
        {
            throw new NotImplementedException();
        }

        public double UParameter()
        {
            throw new NotImplementedException();
        }

        public double VParameter()
        {
            throw new NotImplementedException();
        }

        public double WParameter()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Pnt()
        {
            throw new NotImplementedException();
        }

        public IntCurveSurface_TransitionOnCurve Transition()
        {
            throw new NotImplementedException();
        }

        public TopAbs_State State()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face Face()
        {
            throw new NotImplementedException();
        }
    }; // class BRepClass3d_Intersector3d
}