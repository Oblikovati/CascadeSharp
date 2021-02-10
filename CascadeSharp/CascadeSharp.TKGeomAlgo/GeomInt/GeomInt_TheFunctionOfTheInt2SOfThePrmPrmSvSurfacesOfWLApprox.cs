//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomInt_TheFunctionOfTheInt2SOfThePrmPrmSvSurfacesOfWLApprox
	//---------------------------------------------------------------------
	public  sealed class GeomInt_TheFunctionOfTheInt2SOfThePrmPrmSvSurfacesOfWLApprox : CascadeSharp.math_FunctionSetWithDerivatives
	{

		public GeomInt_TheFunctionOfTheInt2SOfThePrmPrmSvSurfacesOfWLApprox(Adaptor3d_HSurface S1, Adaptor3d_HSurface S2)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_TheFunctionOfTheInt2SOfThePrmPrmSvSurfacesOfWLApprox(GeomInt_TheFunctionOfTheInt2SOfThePrmPrmSvSurfacesOfWLApprox parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_TheFunctionOfTheInt2SOfThePrmPrmSvSurfacesOfWLApprox()
		{
			throw new NotImplementedException();
		}

		public int NbVariables()
		{
			throw new NotImplementedException();
		}

		public int NbEquations()
		{
			throw new NotImplementedException();
		}

		public bool Value(math_Vector X, math_Vector F)
		{
			throw new NotImplementedException();
		}

		public bool Derivatives(math_Vector X, math_Matrix D)
		{
			throw new NotImplementedException();
		}

		public bool Values(math_Vector X, math_Vector F, math_Matrix D)
		{
			throw new NotImplementedException();
		}

		public void ComputeParameters(CascadeSharp.IntImp_ConstIsoparametric ChoixIso, TColStd_Array1OfReal Param, math_Vector UVap, math_Vector BornInf, math_Vector BornSup, math_Vector Tolerance)
		{
			throw new NotImplementedException();
		}

		public double Root()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Point()
		{
			throw new NotImplementedException();
		}

		public bool IsTangent(math_Vector UVap, TColStd_Array1OfReal Param,  ref CascadeSharp.IntImp_ConstIsoparametric BestChoix)
		{
			throw new NotImplementedException();
		}

		public gp_Dir Direction()
		{
			throw new NotImplementedException();
		}

		public gp_Dir2d DirectionOnS1()
		{
			throw new NotImplementedException();
		}

		public gp_Dir2d DirectionOnS2()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurface AuxillarSurface1()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurface AuxillarSurface2()
		{
			throw new NotImplementedException();
		}


	}; // class GeomInt_TheFunctionOfTheInt2SOfThePrmPrmSvSurfacesOfWLApprox

}
