//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  IntPatch_ALineToWLine
	//---------------------------------------------------------------------
	public  sealed class IntPatch_ALineToWLine
	{

		public IntPatch_ALineToWLine(Adaptor3d_HSurface theS1, Adaptor3d_HSurface theS2, int theNbPoints)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_ALineToWLine(Adaptor3d_HSurface theS1, Adaptor3d_HSurface theS2)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_ALineToWLine(IntPatch_ALineToWLine parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_ALineToWLine()
		{
			throw new NotImplementedException();
		}

		public void SetTolOpenDomain(double aT)
		{
			throw new NotImplementedException();
		}

		public double TolOpenDomain()
		{
			throw new NotImplementedException();
		}

		public void SetTolTransition(double aT)
		{
			throw new NotImplementedException();
		}

		public double TolTransition()
		{
			throw new NotImplementedException();
		}

		public void SetTol3D(double aT)
		{
			throw new NotImplementedException();
		}

		public double Tol3D()
		{
			throw new NotImplementedException();
		}

		public void MakeWLine(IntPatch_ALine aline, IntPatch_SequenceOfLine theLines)
		{
			throw new NotImplementedException();
		}

		public void MakeWLine(IntPatch_ALine aline, double paraminf, double _paramsup, IntPatch_SequenceOfLine theLines)
		{
			throw new NotImplementedException();
		}

		public bool StepComputing(IntPatch_ALine theALine, IntSurf_PntOn2S thePOn2S, double theLastParOfAline, double theCurParam, double theTgMagnitude, double theStepMin, double theStepMax, double theMaxDeflection, ref double theStep)
		{
			throw new NotImplementedException();
		}

		public int CheckDeflection(gp_XYZ theMidPt, double theMaxDeflection)
		{
			throw new NotImplementedException();
		}

		public double GetSectionRadius(gp_Pnt thePnt3d)
		{
			throw new NotImplementedException();
		}


	}; // class IntPatch_ALineToWLine

}
