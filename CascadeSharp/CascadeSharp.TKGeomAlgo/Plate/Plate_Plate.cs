//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Plate_Plate
	//---------------------------------------------------------------------
	public  sealed class Plate_Plate
	{

		public Plate_Plate()
			: base()
		{
			throw new NotImplementedException();
		}

		public Plate_Plate(Plate_Plate Ref)
			: base()
		{
			throw new NotImplementedException();
		}

		public Plate_Plate Copy(Plate_Plate Ref)
		{
			throw new NotImplementedException();
		}

		public void Load(Plate_PinpointConstraint PConst)
		{
			throw new NotImplementedException();
		}

		public void Load(Plate_LinearXYZConstraint LXYZConst)
		{
			throw new NotImplementedException();
		}

		public void Load(Plate_LinearScalarConstraint LScalarConst)
		{
			throw new NotImplementedException();
		}

		public void Load(Plate_GlobalTranslationConstraint GTConst)
		{
			throw new NotImplementedException();
		}

		public void Load(Plate_LineConstraint LConst)
		{
			throw new NotImplementedException();
		}

		public void Load(Plate_PlaneConstraint PConst)
		{
			throw new NotImplementedException();
		}

		public void Load(Plate_SampledCurveConstraint SCConst)
		{
			throw new NotImplementedException();
		}

		public void Load(Plate_GtoCConstraint GtoCConst)
		{
			throw new NotImplementedException();
		}

		public void Load(Plate_FreeGtoCConstraint FGtoCConst)
		{
			throw new NotImplementedException();
		}

		public void SolveTI(int ord, double an_isotropie, Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public void SolveTI(int ord, double an_isotropie)
		{
			throw new NotImplementedException();
		}

		public void SolveTI(int ord)
		{
			throw new NotImplementedException();
		}

		public void SolveTI()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public void destroy()
		{
			throw new NotImplementedException();
		}

		public void Init()
		{
			throw new NotImplementedException();
		}

		public gp_XYZ Evaluate(gp_XY point2d)
		{
			throw new NotImplementedException();
		}

		public gp_XYZ EvaluateDerivative(gp_XY point2d, int iu, int iv)
		{
			throw new NotImplementedException();
		}

		public void CoefPol(TColgp_HArray2OfXYZ Coefs)
		{
			throw new NotImplementedException();
		}

		public void SetPolynomialPartOnly(bool PPOnly)
		{
			throw new NotImplementedException();
		}

		public void SetPolynomialPartOnly()
		{
			throw new NotImplementedException();
		}

		public int Continuity()
		{
			throw new NotImplementedException();
		}

		public void UVBox(ref double UMin, ref double UMax, ref double VMin, ref double VMax)
		{
			throw new NotImplementedException();
		}

		public void UVConstraints(TColgp_SequenceOfXY Seq)
		{
			throw new NotImplementedException();
		}

		public double SolEm(gp_XY point2d, int iu, int iv)
		{
			throw new NotImplementedException();
		}

		public double Polm(gp_XY point2d, int iu, int iv, int idu, int idv)
		{
			throw new NotImplementedException();
		}

		public int Deru(int index)
		{
			throw new NotImplementedException();
		}

		public int Derv(int index)
		{
			throw new NotImplementedException();
		}

		public gp_XYZ Solution(int index)
		{
			throw new NotImplementedException();
		}

		public gp_XY Points(int index)
		{
			throw new NotImplementedException();
		}

		public void SolveTI1(int IterationNumber, Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public void SolveTI1(int IterationNumber)
		{
			throw new NotImplementedException();
		}

		public void SolveTI2(int IterationNumber, Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public void SolveTI2(int IterationNumber)
		{
			throw new NotImplementedException();
		}

		public void SolveTI3(int IterationNumber, Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public void SolveTI3(int IterationNumber)
		{
			throw new NotImplementedException();
		}

		public void fillXYZmatrix(math_Matrix mat, int i0, int j0, int ncc1, int ncc2)
		{
			throw new NotImplementedException();
		}


	}; // class Plate_Plate

}
