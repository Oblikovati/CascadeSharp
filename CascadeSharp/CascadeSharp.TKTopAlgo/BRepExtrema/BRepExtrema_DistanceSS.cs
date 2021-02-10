//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKMath.Bnd;

namespace CascadeSharp.TKTopAlgo.BRepExtrema
{
    //---------------------------------------------------------------------
    //  Class  BRepExtrema_DistanceSS
    //---------------------------------------------------------------------
    public sealed class BRepExtrema_DistanceSS
    {
        public BRepExtrema_DistanceSS(TopoDS_Shape S1, TopoDS_Shape S2, Bnd_Box B1, Bnd_Box B2, double DstRef)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_DistanceSS(TopoDS_Shape S1, TopoDS_Shape S2, Bnd_Box B1, Bnd_Box B2, double DstRef,
            double aDeflection)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_DistanceSS(BRepExtrema_DistanceSS parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_DistanceSS()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public double DistValue()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_SeqOfSolution Seq1Value()
        {
            throw new NotImplementedException();
        }

        public BRepExtrema_SeqOfSolution Seq2Value()
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Shape S1, TopoDS_Shape S2, Bnd_Box B1, Bnd_Box B2)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Vertex S1, TopoDS_Vertex S2)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Vertex S1, TopoDS_Edge S2, Bnd_Box B1, Bnd_Box B2)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Vertex S1, TopoDS_Face S2, Bnd_Box B1, Bnd_Box B2)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Edge S1, TopoDS_Vertex S2, Bnd_Box B1, Bnd_Box B2)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Edge S1, TopoDS_Edge S2, Bnd_Box B1, Bnd_Box B2)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Edge S1, TopoDS_Face S2, Bnd_Box B1, Bnd_Box B2)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Face S1, TopoDS_Vertex S2, Bnd_Box B1, Bnd_Box B2)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Face S1, TopoDS_Edge S2, Bnd_Box B1, Bnd_Box B2)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Face S1, TopoDS_Face S2, Bnd_Box B1, Bnd_Box B2)
        {
            throw new NotImplementedException();
        }
    }; // class BRepExtrema_DistanceSS
}