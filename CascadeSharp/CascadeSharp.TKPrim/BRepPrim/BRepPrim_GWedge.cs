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
    //  Class  BRepPrim_GWedge
    //---------------------------------------------------------------------
    public class BRepPrim_GWedge
    {
        public BRepPrim_GWedge()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_GWedge(BRepPrim_Builder B, gp_Ax2 Axes, double dx, double dy, double dz)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_GWedge(BRepPrim_Builder B, gp_Ax2 Axes, double dx, double dy, double dz, double ltx)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_GWedge(BRepPrim_Builder B, gp_Ax2 Axes, double xmin, double ymin, double zmin, double z2min,
            double x2min, double xmax, double ymax, double zmax, double z2max, double x2max)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrim_GWedge(BRepPrim_GWedge parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public gp_Ax2 Axes()
        {
            throw new NotImplementedException();
        }

        public double GetXMin()
        {
            throw new NotImplementedException();
        }

        public double GetYMin()
        {
            throw new NotImplementedException();
        }

        public double GetZMin()
        {
            throw new NotImplementedException();
        }

        public double GetZ2Min()
        {
            throw new NotImplementedException();
        }

        public double GetX2Min()
        {
            throw new NotImplementedException();
        }

        public double GetXMax()
        {
            throw new NotImplementedException();
        }

        public double GetYMax()
        {
            throw new NotImplementedException();
        }

        public double GetZMax()
        {
            throw new NotImplementedException();
        }

        public double GetZ2Max()
        {
            throw new NotImplementedException();
        }

        public double GetX2Max()
        {
            throw new NotImplementedException();
        }

        public void Open(BRepPrim_Direction d1)
        {
            throw new NotImplementedException();
        }

        public void Close(BRepPrim_Direction d1)
        {
            throw new NotImplementedException();
        }

        public bool IsInfinite(BRepPrim_Direction d1)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shell Shell()
        {
            throw new NotImplementedException();
        }

        public bool HasFace(BRepPrim_Direction d1)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face Face(BRepPrim_Direction d1)
        {
            throw new NotImplementedException();
        }

        public gp_Pln Plane(BRepPrim_Direction d1)
        {
            throw new NotImplementedException();
        }

        public bool HasWire(BRepPrim_Direction d1)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Wire Wire(BRepPrim_Direction d1)
        {
            throw new NotImplementedException();
        }

        public bool HasEdge(BRepPrim_Direction d1, BRepPrim_Direction d2)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge Edge(BRepPrim_Direction d1, BRepPrim_Direction d2)
        {
            throw new NotImplementedException();
        }

        public gp_Lin Line(BRepPrim_Direction d1, BRepPrim_Direction d2)
        {
            throw new NotImplementedException();
        }

        public bool HasVertex(BRepPrim_Direction d1, BRepPrim_Direction d2, BRepPrim_Direction d3)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex Vertex(BRepPrim_Direction d1, BRepPrim_Direction d2, BRepPrim_Direction d3)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Point(BRepPrim_Direction d1, BRepPrim_Direction d2, BRepPrim_Direction d3)
        {
            throw new NotImplementedException();
        }

        public bool IsDegeneratedShape()
        {
            throw new NotImplementedException();
        }
    }; // class BRepPrim_GWedge
}