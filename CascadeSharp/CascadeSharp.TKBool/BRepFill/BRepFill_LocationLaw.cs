//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_LocationLaw
	//---------------------------------------------------------------------
	public  class BRepFill_LocationLaw : Standard_Transient
	{

		public BRepFill_LocationLaw(BRepFill_LocationLaw parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_LocationLaw()
			: base()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomFill_PipeError GetStatus()
		{
			throw new NotImplementedException();
		}

		public void TransformInG0Law()
		{
			throw new NotImplementedException();
		}

		public void TransformInCompatibleLaw(double AngularTolerance)
		{
			throw new NotImplementedException();
		}

		public void DeleteTransform()
		{
			throw new NotImplementedException();
		}

		public int NbHoles(double Tol)
		{
			throw new NotImplementedException();
		}

		public int NbHoles()
		{
			throw new NotImplementedException();
		}

		public void Holes(TColStd_Array1OfInteger Interval)
		{
			throw new NotImplementedException();
		}

		public int NbLaw()
		{
			throw new NotImplementedException();
		}

		public GeomFill_LocationLaw Law(int Index)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire Wire()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge Edge(int Index)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex Vertex(int Index)
		{
			throw new NotImplementedException();
		}

		public void PerformVertex(int Index, TopoDS_Vertex InputVertex, double TolMin, TopoDS_Vertex OutputVertex, int Location)
		{
			throw new NotImplementedException();
		}

		public void PerformVertex(int Index, TopoDS_Vertex InputVertex, double TolMin, TopoDS_Vertex OutputVertex)
		{
			throw new NotImplementedException();
		}

		public void CurvilinearBounds(int Index, ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public bool IsClosed()
		{
			throw new NotImplementedException();
		}

		public int IsG1(int Index, double SpatialTolerance, double AngularTolerance)
		{
			throw new NotImplementedException();
		}

		public int IsG1(int Index, double SpatialTolerance)
		{
			throw new NotImplementedException();
		}

		public int IsG1(int Index)
		{
			throw new NotImplementedException();
		}

		public void D0(double Absc_issa, TopoDS_Shape Section)
		{
			throw new NotImplementedException();
		}

		public void Parameter(double Absc_issa, ref int Index, ref double Param)
		{
			throw new NotImplementedException();
		}

		public double Abscissa(int Index, double Param)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Init(TopoDS_Wire Path)
		{
			throw new NotImplementedException();
		}

		public void TangentIsMain()
		{
			throw new NotImplementedException();
		}

		public void NormalIsMain()
		{
			throw new NotImplementedException();
		}

		public void BiNormalIsMain()
		{
			throw new NotImplementedException();
		}


	}; // class BRepFill_LocationLaw

}
