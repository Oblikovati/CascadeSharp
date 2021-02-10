//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2dAdaptor;
using CascadeSharp.TKGeomAlgo.GccEnt;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.Geom2dGcc
{
    //---------------------------------------------------------------------
    //  Class  Geom2dGcc_Lin2d2Tan
    //---------------------------------------------------------------------
    public sealed class Geom2dGcc_Lin2d2Tan
    {
        public Geom2dGcc_Lin2d2Tan(Geom2dGcc_QualifiedCurve Qualified1, Geom2dGcc_QualifiedCurve Qualified2,
            double Tolang)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_Lin2d2Tan(Geom2dGcc_QualifiedCurve Qualified1, gp_Pnt2d ThePoint, double Tolang)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_Lin2d2Tan(Geom2dGcc_QualifiedCurve Qualified1, Geom2dGcc_QualifiedCurve Qualified2,
            double Tolang, double Param1, double Param2)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_Lin2d2Tan(Geom2dGcc_QualifiedCurve Qualified1, gp_Pnt2d ThePoint, double Tolang, double Param1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_Lin2d2Tan(Geom2dGcc_Lin2d2Tan parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_Lin2d2Tan()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public int NbSolutions()
        {
            throw new NotImplementedException();
        }

        public gp_Lin2d ThisSolution(int Index)
        {
            throw new NotImplementedException();
        }

        public void WhichQualifier(int Index, ref GccEnt_Position Qualif1, ref GccEnt_Position Qualif2)
        {
            throw new NotImplementedException();
        }

        public void Tangency1(int Index, ref double ParSol, ref double ParArg, gp_Pnt2d PntSol)
        {
            throw new NotImplementedException();
        }

        public void Tangency2(int Index, ref double ParSol, ref double ParArg, gp_Pnt2d PntSol)
        {
            throw new NotImplementedException();
        }

        public bool Add(int theIndex, Geom2dGcc_Lin2d2TanIter theLin, double theTol, Geom2dAdaptor_Curve theC1,
            Geom2dAdaptor_Curve theC2)
        {
            throw new NotImplementedException();
        }
    }; // class Geom2dGcc_Lin2d2Tan
}