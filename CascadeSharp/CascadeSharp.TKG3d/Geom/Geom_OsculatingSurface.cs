//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Geom_OsculatingSurface
	//---------------------------------------------------------------------
	public  sealed class Geom_OsculatingSurface : Standard_Transient
	{

		public Geom_OsculatingSurface()
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_OsculatingSurface(Geom_Surface BS, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_OsculatingSurface(Geom_OsculatingSurface parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Surface BS, double Tol)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface BasisSurface()
		{
			throw new NotImplementedException();
		}

		public double Tolerance()
		{
			throw new NotImplementedException();
		}

		public bool UOscSurf(double U, double V, ref bool t, Geom_BSplineSurface L)
		{
			throw new NotImplementedException();
		}

		public bool VOscSurf(double U, double V, ref bool t, Geom_BSplineSurface L)
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool BuildOsculatingSurface(double Param, int UKnot, int VKnot, Geom_BSplineSurface BS, Geom_BSplineSurface L)
		{
			throw new NotImplementedException();
		}

		public bool IsQPunctual(Geom_Surface S, double Param, CascadeSharp.GeomAbs_IsoType IT, double TolMin, double TolMax)
		{
			throw new NotImplementedException();
		}

		public bool HasOscSurf()
		{
			throw new NotImplementedException();
		}

		public bool IsAlongU()
		{
			throw new NotImplementedException();
		}

		public bool IsAlongV()
		{
			throw new NotImplementedException();
		}

		public void ClearOsculFlags()
		{
			throw new NotImplementedException();
		}

		public Geom_SequenceOfBSplineSurface GetSeqOfL1()
		{
			throw new NotImplementedException();
		}

		public Geom_SequenceOfBSplineSurface GetSeqOfL2()
		{
			throw new NotImplementedException();
		}


	}; // class Geom_OsculatingSurface

}
