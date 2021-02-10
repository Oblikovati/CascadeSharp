//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepFeat
	//---------------------------------------------------------------------
	public  sealed class BRepFeat
	{

		public BRepFeat()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFeat(BRepFeat parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SampleEdges(TopoDS_Shape S, TColgp_SequenceOfPnt Pt)
		{
			throw new NotImplementedException();
		}

		public void Barycenter(TopoDS_Shape S, gp_Pnt Pt)
		{
			throw new NotImplementedException();
		}

		public double ParametricBarycenter(TopoDS_Shape S, Geom_Curve C)
		{
			throw new NotImplementedException();
		}

		public void ParametricMinMax(TopoDS_Shape S, Geom_Curve C, ref double prmin, ref double prmax, ref double prbmin, ref double prbmax, ref bool flag, bool Ori)
		{
			throw new NotImplementedException();
		}

		public void ParametricMinMax(TopoDS_Shape S, Geom_Curve C, ref double prmin, ref double prmax, ref double prbmin, ref double prbmax, ref bool flag)
		{
			throw new NotImplementedException();
		}

		public bool IsInside(TopoDS_Face F1, TopoDS_Face F2)
		{
			throw new NotImplementedException();
		}

		public bool IsInOut(BRepTopAdaptor_FClass2d FC, Geom2dAdaptor_Curve AC)
		{
			throw new NotImplementedException();
		}

		public void FaceUntil(TopoDS_Shape S, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Solid Tool(TopoDS_Shape SRef, TopoDS_Face Fac, CascadeSharp.TopAbs_Orientation Orf)
		{
			throw new NotImplementedException();
		}

		
	}; // class BRepFeat

}
