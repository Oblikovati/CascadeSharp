//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TColGeom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKFeat.BRepFeat
{
	//---------------------------------------------------------------------
	//  Class  BRepFeat_MakePrism
	//---------------------------------------------------------------------
	public  sealed class BRepFeat_MakePrism : BRepFeat_Form
	{

		public BRepFeat_MakePrism()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFeat_MakePrism(TopoDS_Shape Sbase, TopoDS_Shape Pbase, TopoDS_Face Skface, gp_Dir Direction, int Fuse, bool Modify)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFeat_MakePrism(BRepFeat_MakePrism parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape Sbase, TopoDS_Shape Pbase, TopoDS_Face Skface, gp_Dir Direction, int Fuse, bool Modify)
		{
			throw new NotImplementedException();
		}

		public void Add(TopoDS_Edge E, TopoDS_Face OnFace)
		{
			throw new NotImplementedException();
		}

		public void Perform(double Length)
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

		public void PerformUntilHeight(TopoDS_Shape Until, double Length)
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


	}; // class BRepFeat_MakePrism

}
