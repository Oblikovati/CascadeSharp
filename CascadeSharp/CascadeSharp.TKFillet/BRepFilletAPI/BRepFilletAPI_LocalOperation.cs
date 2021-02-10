//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKFillet.ChFiDS;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKFillet.BRepFilletAPI
{
    //---------------------------------------------------------------------
    //  Class  BRepFilletAPI_LocalOperation
    //---------------------------------------------------------------------
    public abstract class BRepFilletAPI_LocalOperation : BRepBuilderAPI_MakeShape
    {
        public BRepFilletAPI_LocalOperation(BRepFilletAPI_LocalOperation parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public BRepFilletAPI_LocalOperation()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void Add(TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public void ResetContour(int IC)
        {
            throw new NotImplementedException();
        }

        public int NbContours()
        {
            throw new NotImplementedException();
        }

        public int Contour(TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public int NbEdges(int I)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge Edge(int I, int J)
        {
            throw new NotImplementedException();
        }

        public void Remove(TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public double Length(int IC)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex FirstVertex(int IC)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex LastVertex(int IC)
        {
            throw new NotImplementedException();
        }

        public double Abscissa(int IC, TopoDS_Vertex V)
        {
            throw new NotImplementedException();
        }

        public double RelativeAbscissa(int IC, TopoDS_Vertex V)
        {
            throw new NotImplementedException();
        }

        public bool ClosedAndTangent(int IC)
        {
            throw new NotImplementedException();
        }

        public bool Closed(int IC)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Simulate(int IC)
        {
            throw new NotImplementedException();
        }

        public int NbSurf(int IC)
        {
            throw new NotImplementedException();
        }

        public ChFiDS_SecHArray1 Sect(int IC, int IS)
        {
            throw new NotImplementedException();
        }
    }; // class BRepFilletAPI_LocalOperation
}