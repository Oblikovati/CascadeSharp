//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  IntPolyh_MaillageAffinage
	//---------------------------------------------------------------------
	public  sealed class IntPolyh_MaillageAffinage
	{

		public IntPolyh_MaillageAffinage(Adaptor3d_HSurface S1, int NbSU1, int NbSV1, Adaptor3d_HSurface S2, int NbSU2, int NbSV2, int PRINT)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPolyh_MaillageAffinage(Adaptor3d_HSurface S1, Adaptor3d_HSurface S2, int PRINT)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPolyh_MaillageAffinage(IntPolyh_MaillageAffinage parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPolyh_MaillageAffinage()
		{
			throw new NotImplementedException();
		}

		public void MakeSampling(int SurfID, TColStd_Array1OfReal theUPars, TColStd_Array1OfReal theVPars)
		{
			throw new NotImplementedException();
		}

		public void FillArrayOfPnt(int SurfID)
		{
			throw new NotImplementedException();
		}

		public void FillArrayOfPnt(int SurfID, bool _isShiftFwd)
		{
			throw new NotImplementedException();
		}

		public void FillArrayOfPnt(int SurfID, TColStd_Array1OfReal Upars, TColStd_Array1OfReal Vpars, double theDeflTol)
		{
			throw new NotImplementedException();
		}

		public void FillArrayOfPnt(int SurfID, TColStd_Array1OfReal Upars, TColStd_Array1OfReal Vpars)
		{
			throw new NotImplementedException();
		}

		public void FillArrayOfPnt(int SurfID, bool _isShiftFwd, TColStd_Array1OfReal Upars, TColStd_Array1OfReal Vpars, double theDeflTol)
		{
			throw new NotImplementedException();
		}

		public void FillArrayOfPnt(int SurfID, bool _isShiftFwd, TColStd_Array1OfReal Upars, TColStd_Array1OfReal Vpars)
		{
			throw new NotImplementedException();
		}

				public void CommonBox()
		{
			throw new NotImplementedException();
		}

		public void CommonBox(Bnd_Box B1, Bnd_Box B2, ref double xMin, ref double yMin, ref double zMin, ref double xMax, ref double yMax, ref double zMax)
		{
			throw new NotImplementedException();
		}

		public void FillArrayOfEdges(int SurfID)
		{
			throw new NotImplementedException();
		}

		public void FillArrayOfTriangles(int SurfID)
		{
			throw new NotImplementedException();
		}

		public void CommonPartRefinement()
		{
			throw new NotImplementedException();
		}

		public void LocalSurfaceRefinement(int SurfId)
		{
			throw new NotImplementedException();
		}

		public void ComputeDeflections(int SurfID)
		{
			throw new NotImplementedException();
		}

		public void TrianglesDeflectionsRefinementBSB()
		{
			throw new NotImplementedException();
		}

		public int TriContact(IntPolyh_Point P1, IntPolyh_Point P2, IntPolyh_Point P3, IntPolyh_Point Q1, IntPolyh_Point Q2, IntPolyh_Point Q3, ref double Angle)
		{
			throw new NotImplementedException();
		}

		public int TriangleEdgeContact(int TriSurfID, int EdgeIndice, IntPolyh_Triangle Tri1, IntPolyh_Triangle Tri2, IntPolyh_Point P1, IntPolyh_Point P2, IntPolyh_Point P3, IntPolyh_Point C1, IntPolyh_Point C2, IntPolyh_Point C3, IntPolyh_Point Pe1, IntPolyh_Point Pe2, IntPolyh_Point E, IntPolyh_Point N, IntPolyh_StartPoint SP1, IntPolyh_StartPoint SP2)
		{
			throw new NotImplementedException();
		}

		public int StartingPointsResearch(int T1, int T2, IntPolyh_StartPoint SP1, IntPolyh_StartPoint SP2)
		{
			throw new NotImplementedException();
		}

		public int NextStartingPointsResearch(int T1, int T2, IntPolyh_StartPoint SPInit, IntPolyh_StartPoint SPNext)
		{
			throw new NotImplementedException();
		}

		public int TriangleCompare()
		{
			throw new NotImplementedException();
		}

														public int GetFinTE(int SurfID)
		{
			throw new NotImplementedException();
		}

		public int GetFinTT(int SurfID)
		{
			throw new NotImplementedException();
		}

		public Bnd_Box GetBox(int SurfID)
		{
			throw new NotImplementedException();
		}

		public IntPolyh_ListOfCouples GetCouples()
		{
			throw new NotImplementedException();
		}

		public void SetEnlargeZone(bool EnlargeZone)
		{
			throw new NotImplementedException();
		}

		public bool GetEnlargeZone()
		{
			throw new NotImplementedException();
		}

		public double GetMinDeflection(int SurfID)
		{
			throw new NotImplementedException();
		}

		public double GetMaxDeflection(int SurfID)
		{
			throw new NotImplementedException();
		}


	}; // class IntPolyh_MaillageAffinage

}
