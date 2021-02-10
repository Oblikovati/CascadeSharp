//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepAdaptor;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBO.IntTools
{
    //---------------------------------------------------------------------
    //  Class  IntTools
    //---------------------------------------------------------------------
    public sealed class IntTools
    {
        public IntTools()
            : base()
        {
            throw new NotImplementedException();
        }

        public IntTools(IntTools parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public double Length(TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public void RemoveIdenticalRoots(IntTools_SequenceOfRoots aSeq, double anEpsT)
        {
            throw new NotImplementedException();
        }

        public void SortRoots(IntTools_SequenceOfRoots aSeq, double anEpsT)
        {
            throw new NotImplementedException();
        }

        public void FindRootStates(IntTools_SequenceOfRoots aSeq, double anEpsNull)
        {
            throw new NotImplementedException();
        }

        public int Parameter(gp_Pnt P, Geom_Curve Curve, ref double aParm)
        {
            throw new NotImplementedException();
        }

        public int GetRadius(BRepAdaptor_Curve C, double t1, double t3, ref double R)
        {
            throw new NotImplementedException();
        }

        public int PrepareArgs(BRepAdaptor_Curve C, double tMax, double tMin, int D_iscret, double Deflect,
            IntTools_CArray1OfReal anArgs)
        {
            throw new NotImplementedException();
        }
    }; // class IntTools
}