//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepTool_TOOL
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepTool_TOOL
	{

		public TopOpeBRepTool_TOOL()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepTool_TOOL(TopOpeBRepTool_TOOL parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public int OriinSor(TopoDS_Shape sub, TopoDS_Shape S, bool checkclo)
		{
			throw new NotImplementedException();
		}

		public int OriinSor(TopoDS_Shape sub, TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public int OriinSorclosed(TopoDS_Shape sub, TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public bool ClosedE(TopoDS_Edge E, TopoDS_Vertex vclo)
		{
			throw new NotImplementedException();
		}

		public bool ClosedS(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool IsClosingE(TopoDS_Edge E, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool IsClosingE(TopoDS_Edge E, TopoDS_Shape W, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void Vertices(TopoDS_Edge E, TopTools_Array1OfShape Vces)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex Vertex(int Iv, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public double ParE(int Iv, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public int OnBoundary(double par, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d UVF(double par, TopOpeBRepTool_C2DF C2DF)
		{
			throw new NotImplementedException();
		}

		public bool ParISO(gp_Pnt2d p2d, TopoDS_Edge e, TopoDS_Face f, ref double pare)
		{
			throw new NotImplementedException();
		}

		public bool ParE2d(gp_Pnt2d p2d, TopoDS_Edge e, TopoDS_Face f, ref double par, ref double d_ist)
		{
			throw new NotImplementedException();
		}

		public bool Getduv(TopoDS_Face f, gp_Pnt2d uv, gp_Vec dir, double factor, gp_Dir2d duv)
		{
			throw new NotImplementedException();
		}

		public bool uvApp(TopoDS_Face f, TopoDS_Edge e, double par, double eps, gp_Pnt2d uvapp)
		{
			throw new NotImplementedException();
		}

		public double TolUV(TopoDS_Face F, double tol3d)
		{
			throw new NotImplementedException();
		}

		public double TolP(TopoDS_Edge E, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public double minDUV(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool outUVbounds(gp_Pnt2d uv, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void stuvF(gp_Pnt2d uv, TopoDS_Face F, ref int onU, ref int onV)
		{
			throw new NotImplementedException();
		}

		public bool TggeomE(double par, BRepAdaptor_Curve BC, gp_Vec Tg)
		{
			throw new NotImplementedException();
		}

		public bool TggeomE(double par, TopoDS_Edge E, gp_Vec Tg)
		{
			throw new NotImplementedException();
		}

		public bool TgINSIDE(TopoDS_Vertex v, TopoDS_Edge E, gp_Vec Tg, ref int OvinE)
		{
			throw new NotImplementedException();
		}

		public gp_Vec2d Tg2d(int iv, TopoDS_Edge E, TopOpeBRepTool_C2DF C2DF)
		{
			throw new NotImplementedException();
		}

		public gp_Vec2d Tg2dApp(int iv, TopoDS_Edge E, TopOpeBRepTool_C2DF C2DF, double factor)
		{
			throw new NotImplementedException();
		}

		public gp_Vec2d tryTg2dApp(int iv, TopoDS_Edge E, TopOpeBRepTool_C2DF C2DF, double factor)
		{
			throw new NotImplementedException();
		}

		public bool XX(gp_Pnt2d uv, TopoDS_Face f, double par, TopoDS_Edge e, gp_Dir xx)
		{
			throw new NotImplementedException();
		}

		public bool Nt(gp_Pnt2d uv, TopoDS_Face f, gp_Dir normt)
		{
			throw new NotImplementedException();
		}

		public bool NggeomF(gp_Pnt2d uv, TopoDS_Face F, gp_Vec ng)
		{
			throw new NotImplementedException();
		}

		public bool NgApp(double par, TopoDS_Edge E, TopoDS_Face F, double tola, gp_Dir ngApp)
		{
			throw new NotImplementedException();
		}

		public bool tryNgApp(double par, TopoDS_Edge E, TopoDS_Face F, double tola, gp_Dir ng)
		{
			throw new NotImplementedException();
		}

		public int tryOriEinF(double par, TopoDS_Edge E, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool IsQuad(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public bool IsQuad(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool CurvE(TopoDS_Edge E, double par, gp_Dir tg0, ref double Curv)
		{
			throw new NotImplementedException();
		}

		public bool CurvF(TopoDS_Face F, gp_Pnt2d uv, gp_Dir tg0, ref double Curv, ref bool direct)
		{
			throw new NotImplementedException();
		}

		public bool UVISO(Geom2d_Curve PC, ref bool _isou, ref bool _isov, gp_Dir2d d2d, gp_Pnt2d o2d)
		{
			throw new NotImplementedException();
		}

		public bool UVISO(TopOpeBRepTool_C2DF C2DF, ref bool _isou, ref bool _isov, gp_Dir2d d2d, gp_Pnt2d o2d)
		{
			throw new NotImplementedException();
		}

		public bool UVISO(TopoDS_Edge E, TopoDS_Face F, ref bool _isou, ref bool _isov, gp_Dir2d d2d, gp_Pnt2d o2d)
		{
			throw new NotImplementedException();
		}

		public bool IsonCLO(Geom2d_Curve PC, bool onU, double xfirst, double xperiod, double xtol)
		{
			throw new NotImplementedException();
		}

		public bool IsonCLO(TopOpeBRepTool_C2DF C2DF, bool onU, double xfirst, double xperiod, double xtol)
		{
			throw new NotImplementedException();
		}

		public void TrslUV(gp_Vec2d t2d, TopOpeBRepTool_C2DF C2DF)
		{
			throw new NotImplementedException();
		}

		public bool TrslUVModifE(gp_Vec2d t2d, TopoDS_Face F, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public double Matter(gp_Vec d1, gp_Vec d2, gp_Vec _ref)
		{
			throw new NotImplementedException();
		}

		public double Matter(gp_Vec2d d1, gp_Vec2d d2)
		{
			throw new NotImplementedException();
		}

		public bool Matter(gp_Dir xx1, gp_Dir nt1, gp_Dir xx2, gp_Dir nt2, double tola, ref double Ang)
		{
			throw new NotImplementedException();
		}

		public bool Matter(TopoDS_Face f1, TopoDS_Face f2, TopoDS_Edge e, double pare, double tola, ref double Ang)
		{
			throw new NotImplementedException();
		}

		public bool MatterKPtg(TopoDS_Face f1, TopoDS_Face f2, TopoDS_Edge e, ref double Ang)
		{
			throw new NotImplementedException();
		}

		public bool Getstp3dF(gp_Pnt p, TopoDS_Face f, gp_Pnt2d uv,  ref CascadeSharp.TopAbs_State st)
		{
			throw new NotImplementedException();
		}

		public bool SplitE(TopoDS_Edge Eanc, TopTools_ListOfShape Splits)
		{
			throw new NotImplementedException();
		}

		public void MkShell(TopTools_ListOfShape lF, TopoDS_Shape She)
		{
			throw new NotImplementedException();
		}

		public bool Remove(TopTools_ListOfShape loS, TopoDS_Shape toremove)
		{
			throw new NotImplementedException();
		}

		public bool WireToFace(TopoDS_Face F_ref, TopTools_DataMapOfShapeListOfShape mapWlow, TopTools_ListOfShape lFs)
		{
			throw new NotImplementedException();
		}

		public bool EdgeONFace(double par, TopoDS_Edge ed, gp_Pnt2d uv, TopoDS_Face fa, ref bool _isonfa)
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRepTool_TOOL

}
