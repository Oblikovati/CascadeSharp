//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKGeomAlgo.GccEnt;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GccAna
{
    //---------------------------------------------------------------------
    //  Class  GccAna_Lin2dTanObl
    //---------------------------------------------------------------------
    public sealed class GccAna_Lin2dTanObl
    {
        public GccAna_Lin2dTanObl(gp_Pnt2d ThePoint, gp_Lin2d TheLine, double TheAngle)
            : base()
        {
            throw new NotImplementedException();
        }

        public GccAna_Lin2dTanObl(GccEnt_QualifiedCirc Qualified1, gp_Lin2d TheLine, double TheAngle)
            : base()
        {
            throw new NotImplementedException();
        }

        public GccAna_Lin2dTanObl(GccAna_Lin2dTanObl parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GccAna_Lin2dTanObl()
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

        public void WhichQualifier(int Index, ref GccEnt_Position Qualif1)
        {
            throw new NotImplementedException();
        }

        public void Tangency1(int Index, ref double ParSol, ref double ParArg, gp_Pnt2d PntSol)
        {
            throw new NotImplementedException();
        }

        public void Intersection2(int Index, ref double ParSol, ref double ParArg, gp_Pnt2d PntSol)
        {
            throw new NotImplementedException();
        }
    }; // class GccAna_Lin2dTanObl
}