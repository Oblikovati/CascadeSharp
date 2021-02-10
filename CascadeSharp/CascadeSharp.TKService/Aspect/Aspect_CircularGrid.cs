//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Aspect_CircularGrid
	//---------------------------------------------------------------------
	public  abstract class Aspect_CircularGrid : CascadeSharp.Aspect_Grid
	{

		public Aspect_CircularGrid(double aRadiusStep, int aDiv_isionNumber, double XOrigin, double anYOrigin, double aRotationAngle)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_CircularGrid(double aRadiusStep, int aDiv_isionNumber, double XOrigin, double anYOrigin)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_CircularGrid(double aRadiusStep, int aDiv_isionNumber, double XOrigin)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_CircularGrid(double aRadiusStep, int aDiv_isionNumber)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_CircularGrid(Aspect_CircularGrid parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_CircularGrid()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void SetRadiusStep(double aStep)
		{
			throw new NotImplementedException();
		}

		public void SetDivisionNumber(int aNumber)
		{
			throw new NotImplementedException();
		}

		public void SetGridValues(double XOrigin, double YOrigin, double RadiusStep, int Div_isionNumber, double RotationAngle)
		{
			throw new NotImplementedException();
		}

		public void Compute(double X, double Y, ref double gridX, ref double gridY)
		{
			throw new NotImplementedException();
		}

		public double RadiusStep()
		{
			throw new NotImplementedException();
		}

		public int DivisionNumber()
		{
			throw new NotImplementedException();
		}

		public void Init()
		{
			throw new NotImplementedException();
		}

				
	}; // class Aspect_CircularGrid

}
