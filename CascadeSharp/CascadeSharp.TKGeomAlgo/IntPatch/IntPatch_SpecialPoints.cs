//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKGeomAlgo.IntSurf;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
	//---------------------------------------------------------------------
	//  Class  IntPatch_SpecialPoints
	//---------------------------------------------------------------------
	public  sealed class IntPatch_SpecialPoints
	{

		public IntPatch_SpecialPoints()
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPatch_SpecialPoints(IntPatch_SpecialPoints parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public bool AddCrossUVIsoPoint(Adaptor3d_HSurface theQSurf, Adaptor3d_HSurface thePSurf, IntSurf_PntOn2S theRefPt, double theTol3d, IntSurf_PntOn2S theAddedPoint, bool theIsReversed)
		{
			throw new NotImplementedException();
		}

		public bool AddCrossUVIsoPoint(Adaptor3d_HSurface theQSurf, Adaptor3d_HSurface thePSurf, IntSurf_PntOn2S theRefPt, double theTol3d, IntSurf_PntOn2S theAddedPoint)
		{
			throw new NotImplementedException();
		}

		public bool AddPointOnUorVIso(Adaptor3d_HSurface theQSurf, Adaptor3d_HSurface thePSurf, IntSurf_PntOn2S theRefPt, bool theIsU, double theIsoParameter, math_Vector theToler, math_Vector theInitPoint, math_Vector theInfBound, math_Vector theSupBound, IntSurf_PntOn2S theAddedPoint, bool theIsReversed)
		{
			throw new NotImplementedException();
		}

		public bool AddPointOnUorVIso(Adaptor3d_HSurface theQSurf, Adaptor3d_HSurface thePSurf, IntSurf_PntOn2S theRefPt, bool theIsU, double theIsoParameter, math_Vector theToler, math_Vector theInitPoint, math_Vector theInfBound, math_Vector theSupBound, IntSurf_PntOn2S theAddedPoint)
		{
			throw new NotImplementedException();
		}

		public bool AddSingularPole(Adaptor3d_HSurface theQSurf, Adaptor3d_HSurface thePSurf, IntSurf_PntOn2S thePtIso, IntPatch_Point theVertex, IntSurf_PntOn2S theAddedPoint, bool theIsReversed, bool theIsReqRefCheck)
		{
			throw new NotImplementedException();
		}

		public bool AddSingularPole(Adaptor3d_HSurface theQSurf, Adaptor3d_HSurface thePSurf, IntSurf_PntOn2S thePtIso, IntPatch_Point theVertex, IntSurf_PntOn2S theAddedPoint, bool theIsReversed)
		{
			throw new NotImplementedException();
		}

		public bool AddSingularPole(Adaptor3d_HSurface theQSurf, Adaptor3d_HSurface thePSurf, IntSurf_PntOn2S thePtIso, IntPatch_Point theVertex, IntSurf_PntOn2S theAddedPoint)
		{
			throw new NotImplementedException();
		}

		public bool ContinueAfterSpecialPoint(Adaptor3d_HSurface theQSurf, Adaptor3d_HSurface thePSurf, IntSurf_PntOn2S theRefPt, IntPatch_SpecPntType theSPType, double theTol2D, IntSurf_PntOn2S theNewPoint, bool theIsReversed)
		{
			throw new NotImplementedException();
		}

		public bool ContinueAfterSpecialPoint(Adaptor3d_HSurface theQSurf, Adaptor3d_HSurface thePSurf, IntSurf_PntOn2S theRefPt, IntPatch_SpecPntType theSPType, double theTol2D, IntSurf_PntOn2S theNewPoint)
		{
			throw new NotImplementedException();
		}

		public void AdjustPointAndVertex(IntSurf_PntOn2S theRefPoint, double theArrPeriods, IntSurf_PntOn2S theNewPoint, IntPatch_Point theVertex)
		{
			throw new NotImplementedException();
		}

		public void AdjustPointAndVertex(IntSurf_PntOn2S theRefPoint, double theArrPeriods, IntSurf_PntOn2S theNewPoint)
		{
			throw new NotImplementedException();
		}

		public bool ProcessSphere(IntSurf_PntOn2S thePtIso, gp_Vec theDUofPSurf, gp_Vec theDVofPSurf, bool theIsReversed, double theVquad, ref double theUquad, ref bool theIsIsoChoosen)
		{
			throw new NotImplementedException();
		}

		public bool ProcessCone(IntSurf_PntOn2S thePtIso, gp_Vec theDUofPSurf, gp_Vec theDVofPSurf, gp_Cone theCone, bool theIsReversed, ref double theUquad, ref bool theIsIsoChoosen)
		{
			throw new NotImplementedException();
		}

		public int GetTangentToIntLineForCone(double theConeSemiAngle, gp_XYZ thePlnNormal, gp_XYZ theResult)
		{
			throw new NotImplementedException();
		}


	}; // class IntPatch_SpecialPoints

}
