//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Aspect_RectangularGrid
	//---------------------------------------------------------------------
	public  abstract class Aspect_RectangularGrid : CascadeSharp.Aspect_Grid
	{

		public Aspect_RectangularGrid(double aXStep, double aYStep, double anXOrigin, double anYOrigin, double aFirstAngle, double aSecondAngle, double aRotationAngle)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_RectangularGrid(double aXStep, double aYStep, double anXOrigin, double anYOrigin, double aFirstAngle, double aSecondAngle)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_RectangularGrid(double aXStep, double aYStep, double anXOrigin, double anYOrigin, double aFirstAngle)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_RectangularGrid(double aXStep, double aYStep, double anXOrigin, double anYOrigin)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_RectangularGrid(double aXStep, double aYStep, double anXOrigin)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_RectangularGrid(double aXStep, double aYStep)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_RectangularGrid(Aspect_RectangularGrid parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_RectangularGrid()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void SetXStep(double aStep)
		{
			throw new NotImplementedException();
		}

		public void SetYStep(double aStep)
		{
			throw new NotImplementedException();
		}

		public void SetAngle(double anAngle1, double anAngle2)
		{
			throw new NotImplementedException();
		}

		public void SetGridValues(double XOrigin, double YOrigin, double XStep, double YStep, double RotationAngle)
		{
			throw new NotImplementedException();
		}

		public void Compute(double X, double Y, ref double gridX, ref double gridY)
		{
			throw new NotImplementedException();
		}

		public double XStep()
		{
			throw new NotImplementedException();
		}

		public double YStep()
		{
			throw new NotImplementedException();
		}

		public double FirstAngle()
		{
			throw new NotImplementedException();
		}

		public double SecondAngle()
		{
			throw new NotImplementedException();
		}

		public void Init()
		{
			throw new NotImplementedException();
		}

						public bool CheckAngle(double alpha, double beta)
		{
			throw new NotImplementedException();
		}


	}; // class Aspect_RectangularGrid

}
