//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepAdaptor;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBool.TopOpeBRepTool
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepTool_ShapeTool
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepTool_ShapeTool
	{

		public TopOpeBRepTool_ShapeTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepTool_ShapeTool(TopOpeBRepTool_ShapeTool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public double Tolerance(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Pnt(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve BASISCURVE(Geom_Curve C)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve BASISCURVE(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface BASISSURFACE(Geom_Surface S)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface BASISSURFACE(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void UVBOUNDS(Geom_Surface S, ref bool UPeri, ref bool VPeri, ref double Umin, ref double Umax, ref double Vmin, ref double Vmax)
		{
			throw new NotImplementedException();
		}

		public void UVBOUNDS(TopoDS_Face F, ref bool UPeri, ref bool VPeri, ref double Umin, ref double Umax, ref double Vmin, ref double Vmax)
		{
			throw new NotImplementedException();
		}

		public void AdjustOnPeriodic(TopoDS_Shape S, ref double u, ref double v)
		{
			throw new NotImplementedException();
		}

		public bool Closed(TopoDS_Shape S1, TopoDS_Shape S2)
		{
			throw new NotImplementedException();
		}

		public double PeriodizeParameter(double par, TopoDS_Shape EE, TopoDS_Shape FF)
		{
			throw new NotImplementedException();
		}

		public bool ShapesSameOriented(TopoDS_Shape S1, TopoDS_Shape S2)
		{
			throw new NotImplementedException();
		}

		public bool SurfacesSameOriented(BRepAdaptor_Surface S1, BRepAdaptor_Surface S2)
		{
			throw new NotImplementedException();
		}

		public bool FacesSameOriented(TopoDS_Shape F1, TopoDS_Shape F2)
		{
			throw new NotImplementedException();
		}

		public bool CurvesSameOriented(BRepAdaptor_Curve C1, BRepAdaptor_Curve C2)
		{
			throw new NotImplementedException();
		}

		public bool EdgesSameOriented(TopoDS_Shape E1, TopoDS_Shape E2)
		{
			throw new NotImplementedException();
		}

		public double EdgeData(BRepAdaptor_Curve BRAC, double P, gp_Dir T, gp_Dir N, ref double C)
		{
			throw new NotImplementedException();
		}

		public double EdgeData(TopoDS_Shape E, double P, gp_Dir T, gp_Dir N, ref double C)
		{
			throw new NotImplementedException();
		}

		public double Resolution3dU(Geom_Surface SU, double Tol2d)
		{
			throw new NotImplementedException();
		}

		public double Resolution3dV(Geom_Surface SU, double Tol2d)
		{
			throw new NotImplementedException();
		}

		public double Resolution3d(Geom_Surface SU, double Tol2d)
		{
			throw new NotImplementedException();
		}

		public double Resolution3d(TopoDS_Face F, double Tol2d)
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRepTool_ShapeTool

}
