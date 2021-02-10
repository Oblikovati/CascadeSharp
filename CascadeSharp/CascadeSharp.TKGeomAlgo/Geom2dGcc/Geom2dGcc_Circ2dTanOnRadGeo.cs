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
	//  Class  Geom2dGcc_Circ2dTanOnRadGeo
	//---------------------------------------------------------------------
	public  sealed class Geom2dGcc_Circ2dTanOnRadGeo
	{

		public Geom2dGcc_Circ2dTanOnRadGeo(Geom2dGcc_QCurve Qualified1, gp_Lin2d OnLine, double Radius, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dGcc_Circ2dTanOnRadGeo(Geom2dGcc_QCurve Qualified1, gp_Circ2d OnCirc, double Radius, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dGcc_Circ2dTanOnRadGeo(GccEnt_QualifiedCirc Qualified1, Geom2dAdaptor_Curve OnCurv, double Radius, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dGcc_Circ2dTanOnRadGeo(GccEnt_QualifiedLin Qualified1, Geom2dAdaptor_Curve OnCurv, double Radius, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dGcc_Circ2dTanOnRadGeo(Geom2dGcc_QCurve Qualified1, Geom2dAdaptor_Curve OnCurv, double Radius, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dGcc_Circ2dTanOnRadGeo(gp_Pnt2d Point1, Geom2dAdaptor_Curve OnCurv, double Radius, double Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dGcc_Circ2dTanOnRadGeo(Geom2dGcc_Circ2dTanOnRadGeo parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dGcc_Circ2dTanOnRadGeo()
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

		public void WhichQualifier(int Index,  ref GccEnt_Position Qualif1)
		{
			throw new NotImplementedException();
		}

		public void Tangency1(int Index, ref double ParSol, ref double ParArg, gp_Pnt2d PntSol)
		{
			throw new NotImplementedException();
		}

		public void CenterOn3(int Index, ref double ParArg, gp_Pnt2d PntSol)
		{
			throw new NotImplementedException();
		}

		public bool IsTheSame1(int Index)
		{
			throw new NotImplementedException();
		}


	}; // class Geom2dGcc_Circ2dTanOnRadGeo

}
