//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKService.Graphic3d
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_CLight
	//---------------------------------------------------------------------
	public  class Graphic3d_CLight : Standard_Transient
	{

		public Graphic3d_CLight(Graphic3d_TypeOfLightSource theType)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_CLight(Graphic3d_CLight parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_CLight()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public Graphic3d_TypeOfLightSource Type()
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString Name()
		{
			throw new NotImplementedException();
		}

		public void SetName(TCollection_AsciiString theName)
		{
			throw new NotImplementedException();
		}

		public Quantity_Color Color()
		{
			throw new NotImplementedException();
		}

		public void SetColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public bool IsEnabled()
		{
			throw new NotImplementedException();
		}

		public void SetEnabled(bool theIsOn)
		{
			throw new NotImplementedException();
		}

		public bool IsHeadlight()
		{
			throw new NotImplementedException();
		}

		public bool Headlight()
		{
			throw new NotImplementedException();
		}

		public void SetHeadlight(bool theValue)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Position()
		{
			throw new NotImplementedException();
		}

		public void SetPosition(gp_Pnt thePosition)
		{
			throw new NotImplementedException();
		}

		public void Position(ref double theX, ref double theY, ref double theZ)
		{
			throw new NotImplementedException();
		}

		public void SetPosition(double theX, double theY, double theZ)
		{
			throw new NotImplementedException();
		}

		public float ConstAttenuation()
		{
			throw new NotImplementedException();
		}

		public float LinearAttenuation()
		{
			throw new NotImplementedException();
		}

		public void Attenuation(ref double theConstAttenuation, ref double theLinearAttenuation)
		{
			throw new NotImplementedException();
		}

		public void SetAttenuation(float theConstAttenuation, float theLinearAttenuation)
		{
			throw new NotImplementedException();
		}

		public gp_Dir Direction()
		{
			throw new NotImplementedException();
		}

		public void SetDirection(gp_Dir theDir)
		{
			throw new NotImplementedException();
		}

		public void Direction(ref double theVx, ref double theVy, ref double theVz)
		{
			throw new NotImplementedException();
		}

		public void SetDirection(double theVx, double theVy, double theVz)
		{
			throw new NotImplementedException();
		}

		public float Angle()
		{
			throw new NotImplementedException();
		}

		public void SetAngle(float theAngle)
		{
			throw new NotImplementedException();
		}

		public float Concentration()
		{
			throw new NotImplementedException();
		}

		public void SetConcentration(float theConcentration)
		{
			throw new NotImplementedException();
		}

		public float Intensity()
		{
			throw new NotImplementedException();
		}

		public void SetIntensity(float theValue)
		{
			throw new NotImplementedException();
		}

		public float Smoothness()
		{
			throw new NotImplementedException();
		}

		public void SetSmoothRadius(float theValue)
		{
			throw new NotImplementedException();
		}

		public void SetSmoothAngle(float theValue)
		{
			throw new NotImplementedException();
		}

		public float Range()
		{
			throw new NotImplementedException();
		}

		public void SetRange(float theValue)
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString GetId()
		{
			throw new NotImplementedException();
		}

								public ulong Revision()
		{
			throw new NotImplementedException();
		}

						public float changeConstAttenuation()
		{
			throw new NotImplementedException();
		}

		public float changeLinearAttenuation()
		{
			throw new NotImplementedException();
		}

		public float changeAngle()
		{
			throw new NotImplementedException();
		}

		public float changeConcentration()
		{
			throw new NotImplementedException();
		}

		public void makeId()
		{
			throw new NotImplementedException();
		}

		public void updateRevisionIf(bool theIsModified)
		{
			throw new NotImplementedException();
		}


	}; // class Graphic3d_CLight

}
