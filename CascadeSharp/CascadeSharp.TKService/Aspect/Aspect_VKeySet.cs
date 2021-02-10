//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKService.Aspect
{
	//---------------------------------------------------------------------
	//  Class  Aspect_VKeySet
	//---------------------------------------------------------------------
	public  sealed class Aspect_VKeySet : Standard_Transient
	{

		public Aspect_VKeySet()
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public uint Modifiers()
		{
			throw new NotImplementedException();
		}

		public double DownTime(uint theKey)
		{
			throw new NotImplementedException();
		}

		public double TimeUp(uint theKey)
		{
			throw new NotImplementedException();
		}

		public bool IsFreeKey(uint theKey)
		{
			throw new NotImplementedException();
		}

		public bool IsKeyDown(uint theKey)
		{
			throw new NotImplementedException();
		}

				public void Reset()
		{
			throw new NotImplementedException();
		}

		public void KeyDown(uint theKey, double theTime, double thePressure)
		{
			throw new NotImplementedException();
		}

		public void KeyDown(uint theKey, double theTime)
		{
			throw new NotImplementedException();
		}

		public void KeyUp(uint theKey, double theTime)
		{
			throw new NotImplementedException();
		}

		public void KeyFromAxis(uint theNegative, uint thePositive, double theTime, double thePressure)
		{
			throw new NotImplementedException();
		}

		public bool HoldDuration(uint theKey, double theTime, ref double theDuration)
		{
			throw new NotImplementedException();
		}

		public bool HoldDuration(uint theKey, double theTime, ref double theDuration, ref double thePressure)
		{
			throw new NotImplementedException();
		}


		//---------------------------------------------------------------------
		//  Enum  KeyStatus
		//---------------------------------------------------------------------
		public		enum KeyStatus
		{
			KeyStatus_Free = 0,
			KeyStatus_Pressed = 1,
			KeyStatus_Released = 2
		} // enum  class KeyStatus

	}; // class Aspect_VKeySet

}
