//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKShHealing.ShapeBuild
{
    //---------------------------------------------------------------------
    //  Class  ShapeBuild_Vertex
    //---------------------------------------------------------------------
    public sealed class ShapeBuild_Vertex
    {
        public ShapeBuild_Vertex()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeBuild_Vertex(ShapeBuild_Vertex parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex CombineVertex(TopoDS_Vertex V1, TopoDS_Vertex V2, double tolFactor)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex CombineVertex(TopoDS_Vertex V1, TopoDS_Vertex V2)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex CombineVertex(gp_Pnt pnt1, gp_Pnt pnt2, double tol1, double tol2, double tolFactor)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex CombineVertex(gp_Pnt pnt1, gp_Pnt pnt2, double tol1, double tol2)
        {
            throw new NotImplementedException();
        }
    }; // class ShapeBuild_Vertex
}