//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKGeomAlgo.IntCurve;
using CascadeSharp.TKGeomAlgo.IntRes2d;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.Geom2dInt
{
	//---------------------------------------------------------------------
	//  Class  Geom2dInt_TheIntersectorOfTheIntConicCurveOfGInter
	//---------------------------------------------------------------------
	public  sealed class Geom2dInt_TheIntersectorOfTheIntConicCurveOfGInter : IntRes2d_Intersection
	{

		public Geom2dInt_TheIntersectorOfTheIntConicCurveOfGInter()
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dInt_TheIntersectorOfTheIntConicCurveOfGInter(IntCurve_IConicTool ITool, IntRes2d_Domain Dom1, Adaptor2d_Curve2d PCurve, IntRes2d_Domain Dom2, double TolConf, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dInt_TheIntersectorOfTheIntConicCurveOfGInter(Geom2dInt_TheIntersectorOfTheIntConicCurveOfGInter parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Perform(IntCurve_IConicTool ITool, IntRes2d_Domain Dom1, Adaptor2d_Curve2d PCurve, IntRes2d_Domain Dom2, double TolConf, double Tol)
		{
			throw new NotImplementedException();
		}

		public double FindU(double parameter, gp_Pnt2d point, Adaptor2d_Curve2d TheParCurev, IntCurve_IConicTool IntCurve_IConicTool)
		{
			throw new NotImplementedException();
		}

		public double FindV(double parameter, gp_Pnt2d point, IntCurve_IConicTool IntCurve_IConicTool, Adaptor2d_Curve2d ParCurve, IntRes2d_Domain TheParCurveDomain, double V0, double V1, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void And_Domaine_Objet1_Intersections(IntCurve_IConicTool IntCurve_IConicTool, Adaptor2d_Curve2d TheParCurve, IntRes2d_Domain TheImpCurveDomain, IntRes2d_Domain TheParCurveDomain, ref int NbResultats, TColStd_Array1OfReal Inter2_And_Domain2, TColStd_Array1OfReal Inter1, TColStd_Array1OfReal Resultat1, TColStd_Array1OfReal Resultat2, double EpsNul)
		{
			throw new NotImplementedException();
		}


	}; // class Geom2dInt_TheIntersectorOfTheIntConicCurveOfGInter

}
