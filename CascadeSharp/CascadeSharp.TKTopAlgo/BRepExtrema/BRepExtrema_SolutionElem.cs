//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.BRepExtrema
{
    //---------------------------------------------------------------------
    //  Class  BRepExtrema_SolutionElem
    //---------------------------------------------------------------------
    public sealed class BRepExtrema_SolutionElem
    {
        public BRepExtrema_SolutionElem()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_SolutionElem(double theD_ist, gp_Pnt thePoint, BRepExtrema_SupportType theSolType,
            TopoDS_Vertex theVertex)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_SolutionElem(double theD_ist, gp_Pnt thePoint, BRepExtrema_SupportType theSolType,
            TopoDS_Edge theEdge, double theParam)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_SolutionElem(double theD_ist, gp_Pnt thePoint, BRepExtrema_SupportType theSolType,
            TopoDS_Face theFace, double theU, double theV)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_SolutionElem(BRepExtrema_SolutionElem parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public double Dist()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Point()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_SupportType SupportKind()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex Vertex()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge Edge()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face Face()
        {
            throw new NotImplementedException();
        }

        public void EdgeParameter(ref double theParam)
        {
            throw new NotImplementedException();
        }

        public void FaceParameter(ref double theU, ref double theV)
        {
            throw new NotImplementedException();
        }
    }; // class BRepExtrema_SolutionElem
}