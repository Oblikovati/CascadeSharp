//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.TopOpeBRepDS;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBool.TopOpeBRep
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRep_FaceEdgeIntersector
    //---------------------------------------------------------------------
    public sealed class TopOpeBRep_FaceEdgeIntersector
    {
        public TopOpeBRep_FaceEdgeIntersector()
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRep_FaceEdgeIntersector(TopOpeBRep_FaceEdgeIntersector parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Shape F, TopoDS_Shape E)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape(int Index)
        {
            throw new NotImplementedException();
        }

        public void ForceTolerance(double tol)
        {
            throw new NotImplementedException();
        }

        public double Tolerance()
        {
            throw new NotImplementedException();
        }

        public int NbPoints()
        {
            throw new NotImplementedException();
        }

        public void InitPoint()
        {
            throw new NotImplementedException();
        }

        public bool MorePoint()
        {
            throw new NotImplementedException();
        }

        public void NextPoint()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Value()
        {
            throw new NotImplementedException();
        }

        public double Parameter()
        {
            throw new NotImplementedException();
        }

        public void UVPoint(gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public TopAbs_State State()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_Transition Transition(int Index, TopAbs_Orientation FaceOrientation)
        {
            throw new NotImplementedException();
        }

        public bool IsVertex(TopoDS_Shape S, gp_Pnt P, double Tol, TopoDS_Vertex V)
        {
            throw new NotImplementedException();
        }

        public bool IsVertex(int I, TopoDS_Vertex V)
        {
            throw new NotImplementedException();
        }

        public int Index()
        {
            throw new NotImplementedException();
        }

        public void ResetIntersection()
        {
            throw new NotImplementedException();
        }

        public void ShapeTolerances(TopoDS_Shape S1, TopoDS_Shape S2)
        {
            throw new NotImplementedException();
        }

        public double ToleranceMax(TopoDS_Shape S, TopAbs_ShapeEnum T)
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRep_FaceEdgeIntersector
}