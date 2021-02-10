//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKGeomAlgo.IntSurf;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
    //---------------------------------------------------------------------
    //  Class  IntPatch_WLine
    //---------------------------------------------------------------------
    public sealed class IntPatch_WLine : IntPatch_PointLine
    {
        public IntPatch_WLine(IntSurf_LineOn2S Line, bool Tang, IntSurf_TypeTrans Trans1, IntSurf_TypeTrans Trans2)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_WLine(IntSurf_LineOn2S Line, bool Tang, IntSurf_Situation Situ1, IntSurf_Situation Situ2)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_WLine(IntSurf_LineOn2S Line, bool Tang)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_WLine(IntPatch_WLine parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_WLine()
        {
            throw new NotImplementedException();
        }

        public void AddVertex(IntPatch_Point Pnt, bool theIsPrepend)
        {
            throw new NotImplementedException();
        }

        public void AddVertex(IntPatch_Point Pnt)
        {
            throw new NotImplementedException();
        }

        public void SetPoint(int Index, IntPatch_Point Pnt)
        {
            throw new NotImplementedException();
        }

        public void Replace(int Index, IntPatch_Point Pnt)
        {
            throw new NotImplementedException();
        }

        public void SetFirstPoint(int IndFirst)
        {
            throw new NotImplementedException();
        }

        public void SetLastPoint(int IndLast)
        {
            throw new NotImplementedException();
        }

        public int NbPnts()
        {
            throw new NotImplementedException();
        }

        public IntSurf_PntOn2S Point(int Index)
        {
            throw new NotImplementedException();
        }

        public bool HasFirstPoint()
        {
            throw new NotImplementedException();
        }

        public bool HasLastPoint()
        {
            throw new NotImplementedException();
        }

        public IntPatch_Point FirstPoint()
        {
            throw new NotImplementedException();
        }

        public IntPatch_Point LastPoint()
        {
            throw new NotImplementedException();
        }

        public IntPatch_Point FirstPoint(ref int Indfirst)
        {
            throw new NotImplementedException();
        }

        public IntPatch_Point LastPoint(ref int Indlast)
        {
            throw new NotImplementedException();
        }

        public int NbVertex()
        {
            throw new NotImplementedException();
        }

        public IntPatch_Point Vertex(int Index)
        {
            throw new NotImplementedException();
        }

        public IntPatch_Point ChangeVertex(int Index)
        {
            throw new NotImplementedException();
        }

        public void ComputeVertexParameters(double Tol)
        {
            throw new NotImplementedException();
        }

        public IntSurf_LineOn2S Curve()
        {
            throw new NotImplementedException();
        }

        public bool IsOutSurf1Box(gp_Pnt2d theP)
        {
            throw new NotImplementedException();
        }

        public bool IsOutSurf2Box(gp_Pnt2d theP)
        {
            throw new NotImplementedException();
        }

        public bool IsOutBox(gp_Pnt theP)
        {
            throw new NotImplementedException();
        }

        public void SetPeriod(double pu1, double pv1, double pu2, double pv2)
        {
            throw new NotImplementedException();
        }

        public double U1Period()
        {
            throw new NotImplementedException();
        }

        public double V1Period()
        {
            throw new NotImplementedException();
        }

        public double U2Period()
        {
            throw new NotImplementedException();
        }

        public double V2Period()
        {
            throw new NotImplementedException();
        }

        public void SetArcOnS1(Adaptor2d_HCurve2d A)
        {
            throw new NotImplementedException();
        }

        public bool HasArcOnS1()
        {
            throw new NotImplementedException();
        }

        public Adaptor2d_HCurve2d GetArcOnS1()
        {
            throw new NotImplementedException();
        }

        public void SetArcOnS2(Adaptor2d_HCurve2d A)
        {
            throw new NotImplementedException();
        }

        public bool HasArcOnS2()
        {
            throw new NotImplementedException();
        }

        public Adaptor2d_HCurve2d GetArcOnS2()
        {
            throw new NotImplementedException();
        }

        public void ClearVertexes()
        {
            throw new NotImplementedException();
        }

        public void RemoveVertex(int theIndex)
        {
            throw new NotImplementedException();
        }

        public void InsertVertexBefore(int theIndex, IntPatch_Point thePnt)
        {
            throw new NotImplementedException();
        }

        public void Dump(int theMode)
        {
            throw new NotImplementedException();
        }

        public void EnablePurging(bool theIsEnabled)
        {
            throw new NotImplementedException();
        }

        public bool IsPurgingAllowed()
        {
            throw new NotImplementedException();
        }

        public IntPatch_WLType GetCreatingWay()
        {
            throw new NotImplementedException();
        }

        public void SetCreatingWayInfo(IntPatch_WLType theAlgo)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }


        //---------------------------------------------------------------------
        //  Enum  IntPatch_WLType
        //---------------------------------------------------------------------
        public enum IntPatch_WLType
        {
            IntPatch_WLUnknown = 0,
            IntPatch_WLImpImp = 1,
            IntPatch_WLImpPrm = 2,
            IntPatch_WLPrmPrm = 3
        } // enum  class IntPatch_WLType
    }; // class IntPatch_WLine
}