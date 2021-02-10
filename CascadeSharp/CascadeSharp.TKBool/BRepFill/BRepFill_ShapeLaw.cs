//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKGeomAlgo.GeomFill;
using CascadeSharp.TKGeomAlgo.Law;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKBool.BRepFill
{
    //---------------------------------------------------------------------
    //  Class  BRepFill_ShapeLaw
    //---------------------------------------------------------------------
    public sealed class BRepFill_ShapeLaw : BRepFill_SectionLaw
    {
        public BRepFill_ShapeLaw(TopoDS_Vertex V, bool Build)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_ShapeLaw(TopoDS_Vertex V)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_ShapeLaw(TopoDS_Wire W, bool Build)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_ShapeLaw(TopoDS_Wire W)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_ShapeLaw(TopoDS_Wire W, Law_Function L, bool Build)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_ShapeLaw(TopoDS_Wire W, Law_Function L)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_ShapeLaw(BRepFill_ShapeLaw parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_ShapeLaw()
        {
            throw new NotImplementedException();
        }

        public bool IsVertex()
        {
            throw new NotImplementedException();
        }

        public bool IsConstant()
        {
            throw new NotImplementedException();
        }

        public GeomFill_SectionLaw ConcatenedLaw()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity(int Index, double TolAngular)
        {
            throw new NotImplementedException();
        }

        public double VertexTol(int Index, double Param)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex Vertex(int Index, double Param)
        {
            throw new NotImplementedException();
        }

        public void D0(double Param, TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge Edge(int Index)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void Init(bool B)
        {
            throw new NotImplementedException();
        }
    }; // class BRepFill_ShapeLaw
}