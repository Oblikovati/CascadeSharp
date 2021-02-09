//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  gp_Trsf
	//---------------------------------------------------------------------
	public  sealed class gp_Trsf
	{

		public gp_Trsf()
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Trsf(gp_Trsf2d T)
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Trsf(gp_Trsf parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetMirror(gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void SetMirror(gp_Ax1 A1)
		{
			throw new NotImplementedException();
		}

		public void SetMirror(gp_Ax2 A2)
		{
			throw new NotImplementedException();
		}

		public void SetRotation(gp_Ax1 A1, double Ang)
		{
			throw new NotImplementedException();
		}

		public void SetRotation(gp_Quaternion R)
		{
			throw new NotImplementedException();
		}

		public void SetRotationPart(gp_Quaternion R)
		{
			throw new NotImplementedException();
		}

		public void SetScale(gp_Pnt P, double S)
		{
			throw new NotImplementedException();
		}

		public void SetDisplacement(gp_Ax3 FromSystem1, gp_Ax3 ToSystem2)
		{
			throw new NotImplementedException();
		}

		public void SetTransformation(gp_Ax3 FromSystem1, gp_Ax3 ToSystem2)
		{
			throw new NotImplementedException();
		}

		public void SetTransformation(gp_Ax3 ToSystem)
		{
			throw new NotImplementedException();
		}

		public void SetTransformation(gp_Quaternion R, gp_Vec T)
		{
			throw new NotImplementedException();
		}

		public void SetTranslation(gp_Vec V)
		{
			throw new NotImplementedException();
		}

		public void SetTranslation(gp_Pnt P1, gp_Pnt P2)
		{
			throw new NotImplementedException();
		}

		public void SetTranslationPart(gp_Vec V)
		{
			throw new NotImplementedException();
		}

		public void SetScaleFactor(double S)
		{
			throw new NotImplementedException();
		}

		public void SetForm(CascadeSharp.gp_TrsfForm P)
		{
			throw new NotImplementedException();
		}

		public void SetValues(double a11, double a12, double a13, double a14, double a21, double a22, double a23, double a24, double a31, double a32, double a33, double a34)
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

		public gp_XYZ TranslationPart()
		{
			throw new NotImplementedException();
		}

		public bool GetRotation(gp_XYZ theAx_is, ref double theAngle)
		{
			throw new NotImplementedException();
		}

		public gp_Quaternion GetRotation()
		{
			throw new NotImplementedException();
		}

		public gp_Mat VectorialPart()
		{
			throw new NotImplementedException();
		}

		public gp_Mat HVectorialPart()
		{
			throw new NotImplementedException();
		}

		public double Value(int Row, int Col)
		{
			throw new NotImplementedException();
		}

		public void Invert()
		{
			throw new NotImplementedException();
		}

		public gp_Trsf Inverted()
		{
			throw new NotImplementedException();
		}

		public gp_Trsf Multiplied(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public void Multiply(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public void PreMultiply(gp_Trsf T)
		{
			throw new NotImplementedException();
		}

		public void Power(int N)
		{
			throw new NotImplementedException();
		}

		public gp_Trsf Powered(int N)
		{
			throw new NotImplementedException();
		}

		public void Transforms(ref double X, ref double Y, ref double Z)
		{
			throw new NotImplementedException();
		}

		public void Transforms(gp_XYZ Coord)
		{
			throw new NotImplementedException();
		}

								public void Orthogonalize()
		{
			throw new NotImplementedException();
		}


	}; // class gp_Trsf

}
