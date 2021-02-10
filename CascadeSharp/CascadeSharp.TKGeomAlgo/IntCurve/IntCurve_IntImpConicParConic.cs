//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  IntCurve_IntImpConicParConic
	//---------------------------------------------------------------------
	public  sealed class IntCurve_IntImpConicParConic : CascadeSharp.IntRes2d_Intersection
	{

		public IntCurve_IntImpConicParConic()
			: base()
		{
			throw new NotImplementedException();
		}

		public IntCurve_IntImpConicParConic(IntCurve_IConicTool ITool, IntRes2d_Domain Dom1, IntCurve_PConic PCurve, IntRes2d_Domain Dom2, double TolConf, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntCurve_IntImpConicParConic(IntCurve_IntImpConicParConic parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Perform(IntCurve_IConicTool ITool, IntRes2d_Domain Dom1, IntCurve_PConic PCurve, IntRes2d_Domain Dom2, double TolConf, double Tol)
		{
			throw new NotImplementedException();
		}

		public double FindU(double parameter, gp_Pnt2d point, IntCurve_PConic TheParCurev, IntCurve_IConicTool TheImpTool)
		{
			throw new NotImplementedException();
		}

		public double FindV(double parameter, gp_Pnt2d point, IntCurve_IConicTool TheImpTool, IntCurve_PConic ParCurve, IntRes2d_Domain TheParCurveDomain, double V0, double V1, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void And_Domaine_Objet1_Intersections(IntCurve_IConicTool TheImpTool, IntCurve_PConic TheParCurve, IntRes2d_Domain TheImpCurveDomain, IntRes2d_Domain TheParCurveDomain, ref int NbResultats, TColStd_Array1OfReal Inter2_And_Domain2, TColStd_Array1OfReal Inter1, TColStd_Array1OfReal Resultat1, TColStd_Array1OfReal Resultat2, double EpsNul)
		{
			throw new NotImplementedException();
		}


	}; // class IntCurve_IntImpConicParConic

}
