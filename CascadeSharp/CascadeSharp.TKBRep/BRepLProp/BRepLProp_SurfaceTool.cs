//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepAdaptor;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBRep.BRepLProp
{
	//---------------------------------------------------------------------
	//  Class  BRepLProp_SurfaceTool
	//---------------------------------------------------------------------
	public  sealed class BRepLProp_SurfaceTool
	{

		public BRepLProp_SurfaceTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepLProp_SurfaceTool(BRepLProp_SurfaceTool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Value(BRepAdaptor_Surface S, double U, double V, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void D1(BRepAdaptor_Surface S, double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V)
		{
			throw new NotImplementedException();
		}

		public void D2(BRepAdaptor_Surface S, double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec DUV)
		{
			throw new NotImplementedException();
		}

		public gp_Vec DN(BRepAdaptor_Surface S, double U, double V, int IU, int IV)
		{
			throw new NotImplementedException();
		}

		public int Continuity(BRepAdaptor_Surface S)
		{
			throw new NotImplementedException();
		}

		public void Bounds(BRepAdaptor_Surface S, ref double U1, ref double V1, ref double U2, ref double V2)
		{
			throw new NotImplementedException();
		}


	}; // class BRepLProp_SurfaceTool

}
