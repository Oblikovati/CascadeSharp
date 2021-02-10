//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Aspect_Grid
	//---------------------------------------------------------------------
	public  abstract class Aspect_Grid : Standard_Transient
	{

		public Aspect_Grid(double theXOrigin, double theYOrigin, double theRotationAngle, Quantity_Color theColor, Quantity_Color theTenthColor)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_Grid(double theXOrigin, double theYOrigin, double theRotationAngle, Quantity_Color theColor)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_Grid(double theXOrigin, double theYOrigin, double theRotationAngle)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_Grid(double theXOrigin, double theYOrigin)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_Grid(double theXOrigin)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_Grid(Aspect_Grid parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Aspect_Grid()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void SetXOrigin(double anOrigin)
		{
			throw new NotImplementedException();
		}

		public void SetYOrigin(double anOrigin)
		{
			throw new NotImplementedException();
		}

		public void SetRotationAngle(double anAngle)
		{
			throw new NotImplementedException();
		}

		public void Rotate(double anAngle)
		{
			throw new NotImplementedException();
		}

		public void Translate(double aDx, double aDy)
		{
			throw new NotImplementedException();
		}

		public void SetColors(Quantity_Color aColor, Quantity_Color aTenthColor)
		{
			throw new NotImplementedException();
		}

		public void Hit(double X, double Y, ref double gridX, ref double gridY)
		{
			throw new NotImplementedException();
		}

		public void Compute(double X, double Y, ref double gridX, ref double gridY)
		{
			throw new NotImplementedException();
		}

		public void Activate()
		{
			throw new NotImplementedException();
		}

		public void Deactivate()
		{
			throw new NotImplementedException();
		}

		public double XOrigin()
		{
			throw new NotImplementedException();
		}

		public double YOrigin()
		{
			throw new NotImplementedException();
		}

		public double RotationAngle()
		{
			throw new NotImplementedException();
		}

		public bool IsActive()
		{
			throw new NotImplementedException();
		}

		public void Colors(Quantity_Color aColor, Quantity_Color aTenthColor)
		{
			throw new NotImplementedException();
		}

		public void SetDrawMode(CascadeSharp.Aspect_GridDrawMode aDrawMode)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.Aspect_GridDrawMode DrawMode()
		{
			throw new NotImplementedException();
		}

		public void Display()
		{
			throw new NotImplementedException();
		}

		public void Erase()
		{
			throw new NotImplementedException();
		}

		public bool IsDisplayed()
		{
			throw new NotImplementedException();
		}

		public void Init()
		{
			throw new NotImplementedException();
		}

						public void UpdateDisplay()
		{
			throw new NotImplementedException();
		}


	}; // class Aspect_Grid

}
