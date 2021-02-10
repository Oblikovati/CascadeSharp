//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomFill
	//---------------------------------------------------------------------
	public  sealed class GeomFill
	{

		public GeomFill()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill(GeomFill parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Surface(Geom_Curve Curve1, Geom_Curve Curve2)
		{
			throw new NotImplementedException();
		}

		public void GetCircle(CascadeSharp.Convert_ParameterisationType TConv, gp_Vec ns1, gp_Vec ns2, gp_Vec nplan, gp_Pnt pt1, gp_Pnt pt2, double Rayon, gp_Pnt Center, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weigths)
		{
			throw new NotImplementedException();
		}

		public bool GetCircle(CascadeSharp.Convert_ParameterisationType TConv, gp_Vec ns1, gp_Vec ns2, gp_Vec dn1w, gp_Vec dn2w, gp_Vec nplan, gp_Vec dnplan, gp_Pnt pts1, gp_Pnt pts2, gp_Vec tang1, gp_Vec tang2, double Rayon, double DRayon, gp_Pnt Center, gp_Vec DCenter, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColStd_Array1OfReal Weigths, TColStd_Array1OfReal DWeigths)
		{
			throw new NotImplementedException();
		}

		public bool GetCircle(CascadeSharp.Convert_ParameterisationType TConv, gp_Vec ns1, gp_Vec ns2, gp_Vec dn1w, gp_Vec dn2w, gp_Vec d2n1w, gp_Vec d2n2w, gp_Vec nplan, gp_Vec dnplan, gp_Vec d2nplan, gp_Pnt pts1, gp_Pnt pts2, gp_Vec tang1, gp_Vec tang2, gp_Vec Dtang1, gp_Vec Dtang2, double Rayon, double DRayon, double D2Rayon, gp_Pnt Center, gp_Vec DCenter, gp_Vec D2Center, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColgp_Array1OfVec D2Poles, TColStd_Array1OfReal Weigths, TColStd_Array1OfReal DWeigths, TColStd_Array1OfReal D2Weigths)
		{
			throw new NotImplementedException();
		}

		public void GetShape(double MaxAng, ref int NbPoles, ref int NbKnots, ref int Degree,  ref CascadeSharp.Convert_ParameterisationType TypeConv)
		{
			throw new NotImplementedException();
		}

		public void Knots(CascadeSharp.Convert_ParameterisationType TypeConv, TColStd_Array1OfReal TKnots)
		{
			throw new NotImplementedException();
		}

		public void Mults(CascadeSharp.Convert_ParameterisationType TypeConv, TColStd_Array1OfInteger TMults)
		{
			throw new NotImplementedException();
		}

		public void GetMinimalWeights(CascadeSharp.Convert_ParameterisationType TConv, double AngleMin, double AngleMax, TColStd_Array1OfReal Weigths)
		{
			throw new NotImplementedException();
		}

		public double GetTolerance(CascadeSharp.Convert_ParameterisationType TConv, double AngleMin, double Radius, double AngularTol, double SpatialTol)
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill

}
