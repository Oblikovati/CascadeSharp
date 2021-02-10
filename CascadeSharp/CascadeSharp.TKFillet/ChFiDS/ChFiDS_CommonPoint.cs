//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKFillet.ChFiDS
{
    //---------------------------------------------------------------------
    //  Class  ChFiDS_CommonPoint
    //---------------------------------------------------------------------
    public sealed class ChFiDS_CommonPoint
    {
        public ChFiDS_CommonPoint()
            : base()
        {
            throw new NotImplementedException();
        }

        public ChFiDS_CommonPoint(ChFiDS_CommonPoint parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void SetVertex(TopoDS_Vertex theVertex)
        {
            throw new NotImplementedException();
        }

        public void SetArc(double Tol, TopoDS_Edge A, double Param, TopAbs_Orientation TArc)
        {
            throw new NotImplementedException();
        }

        public void SetParameter(double Param)
        {
            throw new NotImplementedException();
        }

        public void SetPoint(gp_Pnt thePoint)
        {
            throw new NotImplementedException();
        }

        public void SetVector(gp_Vec theVector)
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(double Tol)
        {
            throw new NotImplementedException();
        }

        public double Tolerance()
        {
            throw new NotImplementedException();
        }

        public bool IsVertex()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Vertex Vertex()
        {
            throw new NotImplementedException();
        }

        public bool IsOnArc()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge Arc()
        {
            throw new NotImplementedException();
        }

        public TopAbs_Orientation TransitionOnArc()
        {
            throw new NotImplementedException();
        }

        public double ParameterOnArc()
        {
            throw new NotImplementedException();
        }

        public double Parameter()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Point()
        {
            throw new NotImplementedException();
        }

        public bool HasVector()
        {
            throw new NotImplementedException();
        }

        public gp_Vec Vector()
        {
            throw new NotImplementedException();
        }
    }; // class ChFiDS_CommonPoint
}