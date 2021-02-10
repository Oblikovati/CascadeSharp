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
    //  Class  GccAna_Circ2dTanCen
    //---------------------------------------------------------------------
    public sealed class GccAna_Circ2dTanCen
    {
        public GccAna_Circ2dTanCen(GccEnt_QualifiedCirc Qualified1, gp_Pnt2d Pcenter, double Tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public GccAna_Circ2dTanCen(gp_Lin2d Linetan, gp_Pnt2d Pcenter)
            : base()
        {
            throw new NotImplementedException();
        }

        public GccAna_Circ2dTanCen(gp_Pnt2d Point1, gp_Pnt2d Pcenter)
            : base()
        {
            throw new NotImplementedException();
        }

        public GccAna_Circ2dTanCen(GccAna_Circ2dTanCen parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GccAna_Circ2dTanCen()
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

        public gp_Circ2d ThisSolution(int Index)
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

        public bool IsTheSame1(int Index)
        {
            throw new NotImplementedException();
        }
    }; // class GccAna_Circ2dTanCen
}