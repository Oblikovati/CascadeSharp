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
	//  Class  GccAna_Lin2dTanPar
	//---------------------------------------------------------------------
	public  sealed class GccAna_Lin2dTanPar
	{

		public GccAna_Lin2dTanPar(gp_Pnt2d ThePoint, gp_Lin2d Lin1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GccAna_Lin2dTanPar(GccEnt_QualifiedCirc Qualified1, gp_Lin2d Lin1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GccAna_Lin2dTanPar(GccAna_Lin2dTanPar parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GccAna_Lin2dTanPar()
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

		public void WhichQualifier(int Index,  ref GccEnt_Position Qualif1)
		{
			throw new NotImplementedException();
		}

		public void Tangency1(int Index, ref double ParSol, ref double ParArg, gp_Pnt2d Pnt)
		{
			throw new NotImplementedException();
		}


	}; // class GccAna_Lin2dTanPar

}
