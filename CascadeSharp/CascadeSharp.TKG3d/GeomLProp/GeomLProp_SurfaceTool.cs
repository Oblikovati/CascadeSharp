//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.GeomLProp
{
	//---------------------------------------------------------------------
	//  Class  GeomLProp_SurfaceTool
	//---------------------------------------------------------------------
	public  sealed class GeomLProp_SurfaceTool
	{

		public GeomLProp_SurfaceTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomLProp_SurfaceTool(GeomLProp_SurfaceTool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Value(Geom_Surface S, double U, double V, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void D1(Geom_Surface S, double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V)
		{
			throw new NotImplementedException();
		}

		public void D2(Geom_Surface S, double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec DUV)
		{
			throw new NotImplementedException();
		}

		public gp_Vec DN(Geom_Surface S, double U, double V, int IU, int IV)
		{
			throw new NotImplementedException();
		}

		public int Continuity(Geom_Surface S)
		{
			throw new NotImplementedException();
		}

		public void Bounds(Geom_Surface S, ref double U1, ref double V1, ref double U2, ref double V2)
		{
			throw new NotImplementedException();
		}


	}; // class GeomLProp_SurfaceTool

}
