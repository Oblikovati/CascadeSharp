//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRep_CurveRepresentation
	//---------------------------------------------------------------------
	public  abstract class BRep_CurveRepresentation : Standard_Transient
	{

		public BRep_CurveRepresentation(TopLoc_Location L)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BRep_CurveRepresentation(BRep_CurveRepresentation parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BRep_CurveRepresentation()
		{
			throw new NotImplementedException();
		}

		public bool IsCurve3D()
		{
			throw new NotImplementedException();
		}

		public bool IsCurveOnSurface()
		{
			throw new NotImplementedException();
		}

		public bool IsRegularity()
		{
			throw new NotImplementedException();
		}

		public bool IsCurveOnClosedSurface()
		{
			throw new NotImplementedException();
		}

		public bool IsCurveOnSurface(Geom_Surface S, TopLoc_Location L)
		{
			throw new NotImplementedException();
		}

		public bool IsRegularity(Geom_Surface S1, Geom_Surface S2, TopLoc_Location L1, TopLoc_Location L2)
		{
			throw new NotImplementedException();
		}

		public bool IsPolygon3D()
		{
			throw new NotImplementedException();
		}

		public bool IsPolygonOnTriangulation()
		{
			throw new NotImplementedException();
		}

				public bool IsPolygonOnClosedTriangulation()
		{
			throw new NotImplementedException();
		}

		public bool IsPolygonOnSurface()
		{
			throw new NotImplementedException();
		}

		public bool IsPolygonOnSurface(Geom_Surface S, TopLoc_Location L)
		{
			throw new NotImplementedException();
		}

		public bool IsPolygonOnClosedSurface()
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

		public Geom_Curve Curve3D()
		{
			throw new NotImplementedException();
		}

		public void Curve3D(Geom_Curve C)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Surface()
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

		public Geom2d_Curve PCurve2()
		{
			throw new NotImplementedException();
		}

		public void PCurve2(Geom2d_Curve C)
		{
			throw new NotImplementedException();
		}

																								public Geom_Surface Surface2()
		{
			throw new NotImplementedException();
		}

		public TopLoc_Location Location2()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public void Continuity(CascadeSharp.GeomAbs_Shape C)
		{
			throw new NotImplementedException();
		}

		public BRep_CurveRepresentation Copy()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRep_CurveRepresentation

}
