//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Geom_Transformation
	//---------------------------------------------------------------------
	public  sealed class Geom_Transformation : Standard_Transient
	{

		public Geom_Transformation()
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Transformation(gp_Trsf T)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Transformation(Geom_Transformation parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void SetMirror(gp_Pnt thePnt)
		{
			throw new NotImplementedException();
		}

		public void SetMirror(gp_Ax1 theA1)
		{
			throw new NotImplementedException();
		}

		public void SetMirror(gp_Ax2 theA2)
		{
			throw new NotImplementedException();
		}

		public void SetRotation(gp_Ax1 theA1, double theAng)
		{
			throw new NotImplementedException();
		}

		public void SetScale(gp_Pnt thePnt, double theScale)
		{
			throw new NotImplementedException();
		}

		public void SetTransformation(gp_Ax3 theFromSystem1, gp_Ax3 theToSystem2)
		{
			throw new NotImplementedException();
		}

		public void SetTransformation(gp_Ax3 theToSystem)
		{
			throw new NotImplementedException();
		}

		public void SetTranslation(gp_Vec theVec)
		{
			throw new NotImplementedException();
		}

		public void SetTranslation(gp_Pnt P1, gp_Pnt P2)
		{
			throw new NotImplementedException();
		}

		public void SetTrsf(gp_Trsf theTrsf)
		{
			throw new NotImplementedException();
		}

		public bool IsNegative()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.gp_TrsfForm Form()
		{
			throw new NotImplementedException();
		}

		public double ScaleFactor()
		{
			throw new NotImplementedException();
		}

		public gp_Trsf Trsf()
		{
			throw new NotImplementedException();
		}

		public double Value(int theRow, int theCol)
		{
			throw new NotImplementedException();
		}

		public void Invert()
		{
			throw new NotImplementedException();
		}

		public Geom_Transformation Inverted()
		{
			throw new NotImplementedException();
		}

		public Geom_Transformation Multiplied(Geom_Transformation Other)
		{
			throw new NotImplementedException();
		}

		public void Multiply(Geom_Transformation theOther)
		{
			throw new NotImplementedException();
		}

		public void Power(int N)
		{
			throw new NotImplementedException();
		}

		public Geom_Transformation Powered(int N)
		{
			throw new NotImplementedException();
		}

		public void PreMultiply(Geom_Transformation Other)
		{
			throw new NotImplementedException();
		}

		public void Transforms(ref double theX, ref double theY, ref double theZ)
		{
			throw new NotImplementedException();
		}

		public Geom_Transformation Copy()
		{
			throw new NotImplementedException();
		}

				
	}; // class Geom_Transformation

}
