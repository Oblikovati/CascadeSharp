//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKGeomAlgo.GccAna;
using CascadeSharp.TKGeomAlgo.GccEnt;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.Geom2dGcc
{
	//---------------------------------------------------------------------
	//  Class  Geom2dGcc_Circ2d3Tan
	//---------------------------------------------------------------------
	public  sealed class Geom2dGcc_Circ2d3Tan
	{

		public Geom2dGcc_Circ2d3Tan(Geom2dGcc_QualifiedCurve Qualified1, Geom2dGcc_QualifiedCurve Qualified2, Geom2dGcc_QualifiedCurve Qualified3, double Tolerance, double Param1, double Param2, double Param3)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dGcc_Circ2d3Tan(Geom2dGcc_QualifiedCurve Qualified1, Geom2dGcc_QualifiedCurve Qualified2, Geom2d_Point Point, double Tolerance, double Param1, double Param2)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dGcc_Circ2d3Tan(Geom2dGcc_QualifiedCurve Qualified1, Geom2d_Point Point1, Geom2d_Point Point2, double Tolerance, double Param1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dGcc_Circ2d3Tan(Geom2d_Point Point1, Geom2d_Point Point2, Geom2d_Point Point3, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dGcc_Circ2d3Tan(Geom2dGcc_Circ2d3Tan parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dGcc_Circ2d3Tan()
		{
			throw new NotImplementedException();
		}

		public void Results(GccAna_Circ2d3Tan Circ, int Rank1, int Rank2, int Rank3)
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

		public void WhichQualifier(int Index,  ref GccEnt_Position Qualif1,  ref GccEnt_Position Qualif2,  ref GccEnt_Position Qualif3)
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

		public void Tangency3(int Index, ref double ParSol, ref double ParArg, gp_Pnt2d PntSol)
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

		public bool IsTheSame3(int Index)
		{
			throw new NotImplementedException();
		}


	}; // class Geom2dGcc_Circ2d3Tan

}
