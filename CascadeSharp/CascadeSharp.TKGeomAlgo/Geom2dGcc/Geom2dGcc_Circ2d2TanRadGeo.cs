//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKGeomAlgo.GccEnt;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.Geom2dGcc
{
    //---------------------------------------------------------------------
    //  Class  Geom2dGcc_Circ2d2TanRadGeo
    //---------------------------------------------------------------------
    public sealed class Geom2dGcc_Circ2d2TanRadGeo
    {
        public Geom2dGcc_Circ2d2TanRadGeo(GccEnt_QualifiedCirc Qualified1, Geom2dGcc_QCurve Qualified2, double Radius,
            double Tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_Circ2d2TanRadGeo(GccEnt_QualifiedLin Qualified1, Geom2dGcc_QCurve Qualified2, double Radius,
            double Tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_Circ2d2TanRadGeo(Geom2dGcc_QCurve Qualified1, Geom2dGcc_QCurve Qualified2, double Radius,
            double Tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_Circ2d2TanRadGeo(Geom2dGcc_QCurve Qualified1, gp_Pnt2d Point2, double Radius, double Tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_Circ2d2TanRadGeo(Geom2dGcc_Circ2d2TanRadGeo parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_Circ2d2TanRadGeo()
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

        public bool IsTheSame1(int Index)
        {
            throw new NotImplementedException();
        }

        public bool IsTheSame2(int Index)
        {
            throw new NotImplementedException();
        }
    }; // class Geom2dGcc_Circ2d2TanRadGeo
}