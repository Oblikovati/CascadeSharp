//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.BRepClass3d
{
    //---------------------------------------------------------------------
    //  Class  BRepClass3d_SClassifier
    //---------------------------------------------------------------------
    public class BRepClass3d_SClassifier
    {
        public BRepClass3d_SClassifier()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepClass3d_SClassifier(BRepClass3d_SolidExplorer S, gp_Pnt P, double Tol)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepClass3d_SClassifier(BRepClass3d_SClassifier parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Perform(BRepClass3d_SolidExplorer S, gp_Pnt P, double Tol)
        {
            throw new NotImplementedException();
        }

        public void PerformInfinitePoint(BRepClass3d_SolidExplorer S, double Tol)
        {
            throw new NotImplementedException();
        }

        public bool Rejected()
        {
            throw new NotImplementedException();
        }

        public TopAbs_State State()
        {
            throw new NotImplementedException();
        }

        public bool IsOnAFace()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face Face()
        {
            throw new NotImplementedException();
        }

        public void ForceIn()
        {
            throw new NotImplementedException();
        }

        public void ForceOut()
        {
            throw new NotImplementedException();
        }
    }; // class BRepClass3d_SClassifier
}