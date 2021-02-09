//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Bnd_Range
	//---------------------------------------------------------------------
	public  sealed class Bnd_Range
	{

		public Bnd_Range()
			: base()
		{
			throw new NotImplementedException();
		}

		public Bnd_Range(double theMin, double theMax)
			: base()
		{
			throw new NotImplementedException();
		}

		public Bnd_Range(Bnd_Range parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Common(Bnd_Range theOther)
		{
			throw new NotImplementedException();
		}

		public bool Union(Bnd_Range theOther)
		{
			throw new NotImplementedException();
		}

						public int IsIntersected(double theVal, double thePeriod)
		{
			throw new NotImplementedException();
		}

		public int IsIntersected(double theVal)
		{
			throw new NotImplementedException();
		}

		public void Add(double theParameter)
		{
			throw new NotImplementedException();
		}

		public void Add(Bnd_Range theRange)
		{
			throw new NotImplementedException();
		}

		public bool GetMin(ref double thePar)
		{
			throw new NotImplementedException();
		}

		public bool GetMax(ref double thePar)
		{
			throw new NotImplementedException();
		}

		public bool GetBounds(ref double theFirstPar, ref double theLastPar)
		{
			throw new NotImplementedException();
		}

		public bool GetIntermediatePoint(double theLambda, ref double theParameter)
		{
			throw new NotImplementedException();
		}

		public double Delta()
		{
			throw new NotImplementedException();
		}

		public bool IsVoid()
		{
			throw new NotImplementedException();
		}

		public void SetVoid()
		{
			throw new NotImplementedException();
		}

		public void Enlarge(double theDelta)
		{
			throw new NotImplementedException();
		}

		public Bnd_Range Shifted(double theVal)
		{
			throw new NotImplementedException();
		}

		public void Shift(double theVal)
		{
			throw new NotImplementedException();
		}

		public void TrimFrom(double theValLower)
		{
			throw new NotImplementedException();
		}

		public void TrimTo(double theValUpper)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(double theValue)
		{
			throw new NotImplementedException();
		}

		public bool IsOut(Bnd_Range theRange)
		{
			throw new NotImplementedException();
		}

				
	}; // class Bnd_Range

}
