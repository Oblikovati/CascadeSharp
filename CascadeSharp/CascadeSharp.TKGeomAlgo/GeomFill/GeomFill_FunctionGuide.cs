//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_FunctionGuide
	//---------------------------------------------------------------------
	public  sealed class GeomFill_FunctionGuide : CascadeSharp.math_FunctionSetWithDerivatives
	{

		public GeomFill_FunctionGuide(GeomFill_SectionLaw S, Adaptor3d_HCurve Guide, double ParamOnLaw)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_FunctionGuide(GeomFill_SectionLaw S, Adaptor3d_HCurve Guide)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_FunctionGuide(GeomFill_FunctionGuide parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_FunctionGuide()
		{
			throw new NotImplementedException();
		}

		public void SetParam(double Param, gp_Pnt Centre, gp_XYZ Dir, gp_XYZ XDir)
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

		public bool DerivT(math_Vector X, gp_XYZ DCentre, gp_XYZ DDir, math_Vector DFDT)
		{
			throw new NotImplementedException();
		}

		public bool Deriv2T(gp_XYZ DCentre, gp_XYZ DDir, math_Vector DFDT, math_Vector D2FT)
		{
			throw new NotImplementedException();
		}

		public void DSDT(double U, double V, gp_XYZ DCentre, gp_XYZ DDir, gp_Vec DSDT)
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill_FunctionGuide

}
