//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKTopAlgo.Bisector;
using CascadeSharp.TKTopAlgo.MAT;

namespace CascadeSharp.TKTopAlgo.MAT2d
{
    //---------------------------------------------------------------------
    //  Class  MAT2d_Tool2d
    //---------------------------------------------------------------------
    public sealed class MAT2d_Tool2d
    {
        public MAT2d_Tool2d()
            : base()
        {
            throw new NotImplementedException();
        }

        public MAT2d_Tool2d(MAT2d_Tool2d parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Sense(MAT_Side aside)
        {
            throw new NotImplementedException();
        }

        public void SetJoinType(GeomAbs_JoinType aJoinType)
        {
            throw new NotImplementedException();
        }

        public void InitItems(MAT2d_Circuit aCircuit)
        {
            throw new NotImplementedException();
        }

        public int NumberOfItems()
        {
            throw new NotImplementedException();
        }

        public double ToleranceOfConfusion()
        {
            throw new NotImplementedException();
        }

        public int FirstPoint(int anitem, ref double d_ist)
        {
            throw new NotImplementedException();
        }

        public int TangentBefore(int anitem, bool IsOpenResult)
        {
            throw new NotImplementedException();
        }

        public int TangentAfter(int anitem, bool IsOpenResult)
        {
            throw new NotImplementedException();
        }

        public int Tangent(int b_isector)
        {
            throw new NotImplementedException();
        }

        public void CreateBisector(MAT_Bisector ab_isector)
        {
            throw new NotImplementedException();
        }

        public bool TrimBisector(MAT_Bisector ab_isector)
        {
            throw new NotImplementedException();
        }

        public bool TrimBisector(MAT_Bisector ab_isector, int apoint)
        {
            throw new NotImplementedException();
        }

        public double IntersectBisector(MAT_Bisector b_isectorone, MAT_Bisector b_isectortwo, ref int intpnt)
        {
            throw new NotImplementedException();
        }

        public double Distance(MAT_Bisector ab_isector, double param1, double param2)
        {
            throw new NotImplementedException();
        }

        public void Dump(int b_isector, int erease)
        {
            throw new NotImplementedException();
        }

        public Bisector_Bisec GeomBis(int Index)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Geometry GeomElt(int Index)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d GeomPnt(int Index)
        {
            throw new NotImplementedException();
        }

        public gp_Vec2d GeomVec(int Index)
        {
            throw new NotImplementedException();
        }

        public MAT2d_Circuit Circuit()
        {
            throw new NotImplementedException();
        }

        public void BisecFusion(int Index1, int Index2)
        {
            throw new NotImplementedException();
        }

        public Bisector_Bisec ChangeGeomBis(int Index)
        {
            throw new NotImplementedException();
        }

        public bool IsSameDistance(MAT_Bisector b_isectorone, MAT_Bisector b_isectortwo, gp_Pnt2d apoint,
            ref double ad_istance)
        {
            throw new NotImplementedException();
        }

        public bool Projection(int IndexElt, gp_Pnt2d Point, ref double D_istance)
        {
            throw new NotImplementedException();
        }

        public void TrimBisec(Bisector_Bisec B_is, int IndexEdge, bool OnLine, int StartOrEnd)
        {
            throw new NotImplementedException();
        }
    }; // class MAT2d_Tool2d
}