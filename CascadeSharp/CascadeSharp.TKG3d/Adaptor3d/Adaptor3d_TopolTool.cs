//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Adaptor3d
{
	//---------------------------------------------------------------------
	//  Class  Adaptor3d_TopolTool
	//---------------------------------------------------------------------
	public  class Adaptor3d_TopolTool : Standard_Transient
	{

		public Adaptor3d_TopolTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_TopolTool(Adaptor3d_HSurface Surface)
			: base()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_TopolTool(Adaptor3d_TopolTool parameter1)
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

		public TopAbs_State Classify(gp_Pnt2d P, double Tol, bool ReacdreOnPeriodic)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State Classify(gp_Pnt2d P, double Tol)
		{
			throw new NotImplementedException();
		}

		public bool IsThePointOn(gp_Pnt2d P, double Tol, bool ReacdreOnPeriodic)
		{
			throw new NotImplementedException();
		}

		public bool IsThePointOn(gp_Pnt2d P, double Tol)
		{
			throw new NotImplementedException();
		}

		public TopAbs_Orientation Orientation(Adaptor2d_HCurve2d C)
		{
			throw new NotImplementedException();
		}

		public TopAbs_Orientation Orientation(Adaptor3d_HVertex V)
		{
			throw new NotImplementedException();
		}

		public bool Identical(Adaptor3d_HVertex V1, Adaptor3d_HVertex V2)
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

		public void UParameters(TColStd_Array1OfReal theArray)
		{
			throw new NotImplementedException();
		}

		public void VParameters(TColStd_Array1OfReal theArray)
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

		public IntPtr Edge()
		{
			throw new NotImplementedException();
		}

		public void SamplePnts(double theDefl, int theNUmin, int theNVmin)
		{
			throw new NotImplementedException();
		}

		public void BSplSamplePnts(double theDefl, int theNUmin, int theNVmin)
		{
			throw new NotImplementedException();
		}

		public bool IsUniformSampling()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Adaptor3d_TopolTool

}
