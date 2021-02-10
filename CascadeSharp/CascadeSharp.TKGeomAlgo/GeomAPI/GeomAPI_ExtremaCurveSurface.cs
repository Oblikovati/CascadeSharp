//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GeomAPI
{
	//---------------------------------------------------------------------
	//  Class  GeomAPI_ExtremaCurveSurface
	//---------------------------------------------------------------------
	public  sealed class GeomAPI_ExtremaCurveSurface
	{

		public GeomAPI_ExtremaCurveSurface()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAPI_ExtremaCurveSurface(Geom_Curve Curve, Geom_Surface Surface)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAPI_ExtremaCurveSurface(Geom_Curve Curve, Geom_Surface Surface, double Wmin, double Wmax, double Umin, double Umax, double Vmin, double Vmax)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAPI_ExtremaCurveSurface(GeomAPI_ExtremaCurveSurface parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Curve Curve, Geom_Surface Surface)
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Curve Curve, Geom_Surface Surface, double Wmin, double Wmax, double Umin, double Umax, double Vmin, double Vmax)
		{
			throw new NotImplementedException();
		}

		public int NbExtrema()
		{
			throw new NotImplementedException();
		}

		public void Points(int Index, gp_Pnt P1, gp_Pnt P2)
		{
			throw new NotImplementedException();
		}

		public void Parameters(int Index, ref double W, ref double U, ref double V)
		{
			throw new NotImplementedException();
		}

		public double Distance(int Index)
		{
			throw new NotImplementedException();
		}

		public void NearestPoints(gp_Pnt PC, gp_Pnt PS)
		{
			throw new NotImplementedException();
		}

		public void LowerDistanceParameters(ref double W, ref double U, ref double V)
		{
			throw new NotImplementedException();
		}

		public double LowerDistance()
		{
			throw new NotImplementedException();
		}

		
	}; // class GeomAPI_ExtremaCurveSurface

}
