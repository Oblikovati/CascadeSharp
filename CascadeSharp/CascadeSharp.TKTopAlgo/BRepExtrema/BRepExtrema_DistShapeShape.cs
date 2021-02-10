//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepExtrema_DistShapeShape
	//---------------------------------------------------------------------
	public  sealed class BRepExtrema_DistShapeShape
	{

		public BRepExtrema_DistShapeShape()
			: base()
		{
			throw new NotImplementedException();
		}

						public BRepExtrema_DistShapeShape(TopoDS_Shape Shape1, TopoDS_Shape Shape2)
			: base()
		{
			throw new NotImplementedException();
		}

						public BRepExtrema_DistShapeShape(TopoDS_Shape Shape1, TopoDS_Shape Shape2, double theDeflection)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepExtrema_DistShapeShape(BRepExtrema_DistShapeShape parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetDeflection(double theDeflection)
		{
			throw new NotImplementedException();
		}

		public void LoadS1(TopoDS_Shape Shape1)
		{
			throw new NotImplementedException();
		}

		public void LoadS2(TopoDS_Shape Shape1)
		{
			throw new NotImplementedException();
		}

		public bool Perform()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public int NbSolution()
		{
			throw new NotImplementedException();
		}

		public double Value()
		{
			throw new NotImplementedException();
		}

		public bool InnerSolution()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt PointOnShape1(int N)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt PointOnShape2(int N)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.BRepExtrema_SupportType SupportTypeShape1(int N)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.BRepExtrema_SupportType SupportTypeShape2(int N)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape SupportOnShape1(int N)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape SupportOnShape2(int N)
		{
			throw new NotImplementedException();
		}

		public void ParOnEdgeS1(int N, ref double t)
		{
			throw new NotImplementedException();
		}

		public void ParOnEdgeS2(int N, ref double t)
		{
			throw new NotImplementedException();
		}

		public void ParOnFaceS1(int N, ref double u, ref double v)
		{
			throw new NotImplementedException();
		}

		public void ParOnFaceS2(int N, ref double u, ref double v)
		{
			throw new NotImplementedException();
		}

								public void DistanceMapMap(TopTools_IndexedMapOfShape Map1, TopTools_IndexedMapOfShape Map2, Bnd_SeqOfBox LBox1, Bnd_SeqOfBox LBox2)
		{
			throw new NotImplementedException();
		}


	}; // class BRepExtrema_DistShapeShape

}
