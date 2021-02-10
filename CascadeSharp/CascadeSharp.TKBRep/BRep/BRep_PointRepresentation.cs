//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.BRep
{
	//---------------------------------------------------------------------
	//  Class  BRep_PointRepresentation
	//---------------------------------------------------------------------
	public  class BRep_PointRepresentation : Standard_Transient
	{

		public BRep_PointRepresentation(double P, TopLoc_Location L)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRep_PointRepresentation(BRep_PointRepresentation parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRep_PointRepresentation()
		{
			throw new NotImplementedException();
		}

		public bool IsPointOnCurve()
		{
			throw new NotImplementedException();
		}

		public bool IsPointOnCurveOnSurface()
		{
			throw new NotImplementedException();
		}

		public bool IsPointOnSurface()
		{
			throw new NotImplementedException();
		}

		public bool IsPointOnCurve(Geom_Curve C, TopLoc_Location L)
		{
			throw new NotImplementedException();
		}

		public bool IsPointOnCurveOnSurface(Geom2d_Curve PC, Geom_Surface S, TopLoc_Location L)
		{
			throw new NotImplementedException();
		}

		public bool IsPointOnSurface(Geom_Surface S, TopLoc_Location L)
		{
			throw new NotImplementedException();
		}

		public TopLoc_Location Location()
		{
			throw new NotImplementedException();
		}

		public void Location(TopLoc_Location L)
		{
			throw new NotImplementedException();
		}

		public double Parameter()
		{
			throw new NotImplementedException();
		}

		public void Parameter(double P)
		{
			throw new NotImplementedException();
		}

		public double Parameter2()
		{
			throw new NotImplementedException();
		}

		public void Parameter2(double P)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve Curve()
		{
			throw new NotImplementedException();
		}

		public void Curve(Geom_Curve C)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve PCurve()
		{
			throw new NotImplementedException();
		}

		public void PCurve(Geom2d_Curve C)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Surface()
		{
			throw new NotImplementedException();
		}

		public void Surface(Geom_Surface S)
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRep_PointRepresentation

}
