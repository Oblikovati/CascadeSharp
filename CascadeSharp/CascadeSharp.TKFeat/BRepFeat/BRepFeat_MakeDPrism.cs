//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepFeat_MakeDPrism
	//---------------------------------------------------------------------
	public  sealed class BRepFeat_MakeDPrism : CascadeSharp.BRepFeat_Form
	{

		public BRepFeat_MakeDPrism(TopoDS_Shape Sbase, TopoDS_Face Pbase, TopoDS_Face Skface, double Angle, int Fuse, bool Modify)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFeat_MakeDPrism()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFeat_MakeDPrism(BRepFeat_MakeDPrism parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape Sbase, TopoDS_Face Pbase, TopoDS_Face Skface, double Angle, int Fuse, bool Modify)
		{
			throw new NotImplementedException();
		}

		public void Add(TopoDS_Edge E, TopoDS_Face OnFace)
		{
			throw new NotImplementedException();
		}

		public void Perform(double Height)
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Shape Until)
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Shape From, TopoDS_Shape Until)
		{
			throw new NotImplementedException();
		}

		public void PerformUntilEnd()
		{
			throw new NotImplementedException();
		}

		public void PerformFromEnd(TopoDS_Shape FUntil)
		{
			throw new NotImplementedException();
		}

		public void PerformThruAll()
		{
			throw new NotImplementedException();
		}

		public void PerformUntilHeight(TopoDS_Shape Until, double Height)
		{
			throw new NotImplementedException();
		}

		public void Curves(TColGeom_SequenceOfCurve S)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve BarycCurve()
		{
			throw new NotImplementedException();
		}

		public void BossEdges(int sig)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape TopEdges()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape LatEdges()
		{
			throw new NotImplementedException();
		}


	}; // class BRepFeat_MakeDPrism

}
