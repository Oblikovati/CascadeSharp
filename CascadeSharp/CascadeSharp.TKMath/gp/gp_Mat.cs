//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.gp
{
	//---------------------------------------------------------------------
	//  Class  gp_Mat
	//---------------------------------------------------------------------
	public  sealed class gp_Mat
	{

		public gp_Mat()
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Mat(double a11, double a12, double a13, double a21, double a22, double a23, double a31, double a32, double a33)
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Mat(gp_XYZ Col1, gp_XYZ Col2, gp_XYZ Col3)
			: base()
		{
			throw new NotImplementedException();
		}

		public gp_Mat(gp_Mat parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetCol(int Col, gp_XYZ Value)
		{
			throw new NotImplementedException();
		}

		public void SetCols(gp_XYZ Col1, gp_XYZ Col2, gp_XYZ Col3)
		{
			throw new NotImplementedException();
		}

		public void SetCross(gp_XYZ Ref)
		{
			throw new NotImplementedException();
		}

		public void SetDiagonal(double X1, double X2, double X3)
		{
			throw new NotImplementedException();
		}

		public void SetDot(gp_XYZ Ref)
		{
			throw new NotImplementedException();
		}

		public void SetIdentity()
		{
			throw new NotImplementedException();
		}

		public void SetRotation(gp_XYZ Ax_is, double Ang)
		{
			throw new NotImplementedException();
		}

		public void SetRow(int Row, gp_XYZ Value)
		{
			throw new NotImplementedException();
		}

		public void SetRows(gp_XYZ Row1, gp_XYZ Row2, gp_XYZ Row3)
		{
			throw new NotImplementedException();
		}

		public void SetScale(double S)
		{
			throw new NotImplementedException();
		}

		public void SetValue(int Row, int Col, double Value)
		{
			throw new NotImplementedException();
		}

		public gp_XYZ Column(int Col)
		{
			throw new NotImplementedException();
		}

		public double Determinant()
		{
			throw new NotImplementedException();
		}

		public gp_XYZ Diagonal()
		{
			throw new NotImplementedException();
		}

		public gp_XYZ Row(int Row)
		{
			throw new NotImplementedException();
		}

		public double Value(int Row, int Col)
		{
			throw new NotImplementedException();
		}

		public double ChangeValue(int Row, int Col)
		{
			throw new NotImplementedException();
		}

		public bool IsSingular()
		{
			throw new NotImplementedException();
		}

		public void Add(gp_Mat Other)
		{
			throw new NotImplementedException();
		}

		public gp_Mat Added(gp_Mat Other)
		{
			throw new NotImplementedException();
		}

		public void Divide(double Scalar)
		{
			throw new NotImplementedException();
		}

		public gp_Mat Divided(double Scalar)
		{
			throw new NotImplementedException();
		}

		public void Invert()
		{
			throw new NotImplementedException();
		}

		public gp_Mat Inverted()
		{
			throw new NotImplementedException();
		}

		public gp_Mat Multiplied(gp_Mat Other)
		{
			throw new NotImplementedException();
		}

		public void Multiply(gp_Mat Other)
		{
			throw new NotImplementedException();
		}

		public void PreMultiply(gp_Mat Other)
		{
			throw new NotImplementedException();
		}

		public gp_Mat Multiplied(double Scalar)
		{
			throw new NotImplementedException();
		}

		public void Multiply(double Scalar)
		{
			throw new NotImplementedException();
		}

		public void Power(int N)
		{
			throw new NotImplementedException();
		}

		public gp_Mat Powered(int N)
		{
			throw new NotImplementedException();
		}

		public void Subtract(gp_Mat Other)
		{
			throw new NotImplementedException();
		}

		public gp_Mat Subtracted(gp_Mat Other)
		{
			throw new NotImplementedException();
		}

		public void Transpose()
		{
			throw new NotImplementedException();
		}

		public gp_Mat Transposed()
		{
			throw new NotImplementedException();
		}

				
	}; // class gp_Mat

}
