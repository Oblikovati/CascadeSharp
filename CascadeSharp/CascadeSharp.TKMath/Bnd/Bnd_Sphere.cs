//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Bnd_Sphere
	//---------------------------------------------------------------------
	public  sealed class Bnd_Sphere
	{

		public Bnd_Sphere()
			: base()
		{
			throw new NotImplementedException();
		}

		public Bnd_Sphere(gp_XYZ theCntr, double theRad, int theU, int theV)
			: base()
		{
			throw new NotImplementedException();
		}

		public Bnd_Sphere(Bnd_Sphere parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public int U()
		{
			throw new NotImplementedException();
		}

		public int V()
		{
			throw new NotImplementedException();
		}

		public bool IsValid()
		{
			throw new NotImplementedException();
		}

		public void SetValid(bool _isValid)
		{
			throw new NotImplementedException();
		}

		public gp_XYZ Center()
		{
			throw new NotImplementedException();
		}

		public double Radius()
		{
			throw new NotImplementedException();
		}

		public void Distances(gp_XYZ theXYZ, ref double theMin, ref double theMax)
		{
			throw new NotImplementedException();
		}

		public void SquareDistances(gp_XYZ theXYZ, ref double theMin, ref double theMax)
		{
			throw new NotImplementedException();
		}

		public bool Project(gp_XYZ theNode, gp_XYZ theProjNode, ref double theD_ist, ref bool theInside)
		{
			throw new NotImplementedException();
		}

		public double Distance(gp_XYZ theNode)
		{
			throw new NotImplementedException();
		}

		public double SquareDistance(gp_XYZ theNode)
		{
			throw new NotImplementedException();
		}

		public void Add(Bnd_Sphere theOther)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(Bnd_Sphere theOther)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(gp_XYZ thePnt, ref double theMaxD_ist)
		{
			throw new NotImplementedException();
		}

		public double SquareExtent()
		{
			throw new NotImplementedException();
		}


	}; // class Bnd_Sphere

}
