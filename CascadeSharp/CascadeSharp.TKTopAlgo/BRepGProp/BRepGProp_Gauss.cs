//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.BRepGProp
{
	//---------------------------------------------------------------------
	//  Class  BRepGProp_Gauss
	//---------------------------------------------------------------------
	public  sealed class BRepGProp_Gauss
	{

		public BRepGProp_Gauss(BRepGProp_GaussType theType)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepGProp_Gauss(BRepGProp_Gauss parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepGProp_Gauss()
		{
			throw new NotImplementedException();
		}

		public void Compute(BRepGProp_Face theSurface, gp_Pnt theLocation, double theCoeff, bool theIsByPoint, ref double theOutMass, gp_Pnt theOutGravityCenter, gp_Mat theOutInertia)
		{
			throw new NotImplementedException();
		}

		public void Compute(BRepGProp_Face theSurface, gp_Pnt theLocation, ref double theOutMass, gp_Pnt theOutGravityCenter, gp_Mat theOutInertia)
		{
			throw new NotImplementedException();
		}

		public void Compute(BRepGProp_Face theSurface, BRepGProp_Domain theDomain, gp_Pnt theLocation, double theCoeff, bool theIsByPoint, ref double theOutMass, gp_Pnt theOutGravityCenter, gp_Mat theOutInertia)
		{
			throw new NotImplementedException();
		}

		public void Compute(BRepGProp_Face theSurface, BRepGProp_Domain theDomain, gp_Pnt theLocation, ref double theOutMass, gp_Pnt theOutGravityCenter, gp_Mat theOutInertia)
		{
			throw new NotImplementedException();
		}

		public double Compute(BRepGProp_Face theSurface, BRepGProp_Domain theDomain, gp_Pnt theLocation, double theEps, double theCoeff, bool theByPoint, ref double theOutMass, gp_Pnt theOutGravityCenter, gp_Mat theOutInertia)
		{
			throw new NotImplementedException();
		}

		public double Compute(BRepGProp_Face theSurface, BRepGProp_Domain theDomain, gp_Pnt theLocation, double theEps, ref double theOutMass, gp_Pnt theOutGravityCenter, gp_Mat theOutInertia)
		{
			throw new NotImplementedException();
		}

						public void checkBounds(double theU1, double theU2, double theV1, double theV2)
		{
			throw new NotImplementedException();
		}

										public int MaxSubs(int theN, int theCoeff)
		{
			throw new NotImplementedException();
		}

		public int MaxSubs(int theN)
		{
			throw new NotImplementedException();
		}

										
		//---------------------------------------------------------------------
		//  Enum  BRepGProp_GaussType
		//---------------------------------------------------------------------
		public		enum BRepGProp_GaussType
		{
			Vinert = 0,
			Sinert = 1
		} // enum  class BRepGProp_GaussType

	}; // class BRepGProp_Gauss

}
