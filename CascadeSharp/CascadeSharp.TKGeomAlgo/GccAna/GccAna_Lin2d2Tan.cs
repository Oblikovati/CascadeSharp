//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GccAna_Lin2d2Tan
	//---------------------------------------------------------------------
	public  sealed class GccAna_Lin2d2Tan
	{

		public GccAna_Lin2d2Tan(gp_Pnt2d ThePoint1, gp_Pnt2d ThePoint2, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public GccAna_Lin2d2Tan(GccEnt_QualifiedCirc Qualified1, gp_Pnt2d ThePoint, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public GccAna_Lin2d2Tan(GccEnt_QualifiedCirc Qualified1, GccEnt_QualifiedCirc Qualified2, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public GccAna_Lin2d2Tan(GccAna_Lin2d2Tan parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GccAna_Lin2d2Tan()
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

		public void WhichQualifier(int Index,  ref CascadeSharp.GccEnt_Position Qualif1,  ref CascadeSharp.GccEnt_Position Qualif2)
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


	}; // class GccAna_Lin2d2Tan

}
