//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepTopAdaptor_TopolTool
	//---------------------------------------------------------------------
	public  sealed class BRepTopAdaptor_TopolTool : CascadeSharp.Adaptor3d_TopolTool
	{

		public BRepTopAdaptor_TopolTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepTopAdaptor_TopolTool(Adaptor3d_HSurface Surface)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepTopAdaptor_TopolTool(BRepTopAdaptor_TopolTool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Initialize()
		{
			throw new NotImplementedException();
		}

		public void Initialize(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public void Initialize(Adaptor2d_HCurve2d Curve)
		{
			throw new NotImplementedException();
		}

		public void Init()
		{
			throw new NotImplementedException();
		}

		public bool More()
		{
			throw new NotImplementedException();
		}

		public Adaptor2d_HCurve2d Value()
		{
			throw new NotImplementedException();
		}

		public void Next()
		{
			throw new NotImplementedException();
		}

		public IntPtr Edge()
		{
			throw new NotImplementedException();
		}

		public void InitVertexIterator()
		{
			throw new NotImplementedException();
		}

		public bool MoreVertex()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HVertex Vertex()
		{
			throw new NotImplementedException();
		}

		public void NextVertex()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_State Classify(gp_Pnt2d P2d, double Tol, bool RecadreOnPeriodic)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_State Classify(gp_Pnt2d P2d, double Tol)
		{
			throw new NotImplementedException();
		}

		public bool IsThePointOn(gp_Pnt2d P2d, double Tol, bool RecadreOnPeriodic)
		{
			throw new NotImplementedException();
		}

		public bool IsThePointOn(gp_Pnt2d P2d, double Tol)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_Orientation Orientation(Adaptor2d_HCurve2d C)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_Orientation Orientation(Adaptor3d_HVertex C)
		{
			throw new NotImplementedException();
		}

		public void Destroy()
		{
			throw new NotImplementedException();
		}

		public bool Has3d()
		{
			throw new NotImplementedException();
		}

		public double Tol3d(Adaptor2d_HCurve2d C)
		{
			throw new NotImplementedException();
		}

		public double Tol3d(Adaptor3d_HVertex V)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Pnt(Adaptor3d_HVertex V)
		{
			throw new NotImplementedException();
		}

		public void ComputeSamplePoints()
		{
			throw new NotImplementedException();
		}

		public int NbSamplesU()
		{
			throw new NotImplementedException();
		}

		public int NbSamplesV()
		{
			throw new NotImplementedException();
		}

		public int NbSamples()
		{
			throw new NotImplementedException();
		}

		public void SamplePoint(int Index, gp_Pnt2d P2d, gp_Pnt P3d)
		{
			throw new NotImplementedException();
		}

		public bool DomainIsInfinite()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRepTopAdaptor_TopolTool

}
