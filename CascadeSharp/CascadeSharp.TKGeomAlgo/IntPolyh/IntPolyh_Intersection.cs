//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  IntPolyh_Intersection
	//---------------------------------------------------------------------
	public  sealed class IntPolyh_Intersection
	{

		public IntPolyh_Intersection(Adaptor3d_HSurface theS1, Adaptor3d_HSurface theS2)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPolyh_Intersection(Adaptor3d_HSurface theS1, int theNbSU1, int theNbSV1, Adaptor3d_HSurface theS2, int theNbSU2, int theNbSV2)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPolyh_Intersection(Adaptor3d_HSurface theS1, TColStd_Array1OfReal theUPars1, TColStd_Array1OfReal theVPars1, Adaptor3d_HSurface theS2, TColStd_Array1OfReal theUPars2, TColStd_Array1OfReal theVPars2)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPolyh_Intersection(IntPolyh_Intersection parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public IntPolyh_Intersection()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public int NbSectionLines()
		{
			throw new NotImplementedException();
		}

		public int NbPointsInLine(int IndexLine)
		{
			throw new NotImplementedException();
		}

		public int NbTangentZones()
		{
			throw new NotImplementedException();
		}

		public int NbPointsInTangentZone(int parameter1)
		{
			throw new NotImplementedException();
		}

		public void GetLinePoint(int IndexLine, int IndexPoint, ref double x, ref double y, ref double z, ref double u1, ref double v1, ref double u2, ref double v2, ref double incidence)
		{
			throw new NotImplementedException();
		}

		public void GetTangentZonePoint(int IndexLine, int IndexPoint, ref double x, ref double y, ref double z, ref double u1, ref double v1, ref double u2, ref double v2)
		{
			throw new NotImplementedException();
		}

		public void Perform()
		{
			throw new NotImplementedException();
		}

		public void Perform(TColStd_Array1OfReal theUPars1, TColStd_Array1OfReal theVPars1, TColStd_Array1OfReal theUPars2, TColStd_Array1OfReal theVPars2)
		{
			throw new NotImplementedException();
		}

		public bool PerformStd(TColStd_Array1OfReal theUPars1, TColStd_Array1OfReal theVPars1, TColStd_Array1OfReal theUPars2, TColStd_Array1OfReal theVPars2, double theDeflTol1, double theDeflTol2, IntPolyh_MaillageAffinage theMaillageS, ref int theNbCouples)
		{
			throw new NotImplementedException();
		}

		public bool PerformAdv(TColStd_Array1OfReal theUPars1, TColStd_Array1OfReal theVPars1, TColStd_Array1OfReal theUPars2, TColStd_Array1OfReal theVPars2, double theDeflTol1, double theDeflTol2, IntPolyh_MaillageAffinage theMaillageFF, IntPolyh_MaillageAffinage theMaillageFR, IntPolyh_MaillageAffinage theMaillageRF, IntPolyh_MaillageAffinage theMaillageRR, ref int theNbCouples)
		{
			throw new NotImplementedException();
		}

		public bool PerformMaillage(TColStd_Array1OfReal theUPars1, TColStd_Array1OfReal theVPars1, TColStd_Array1OfReal theUPars2, TColStd_Array1OfReal theVPars2, double theDeflTol1, double theDeflTol2, IntPolyh_MaillageAffinage theMaillage)
		{
			throw new NotImplementedException();
		}

				public void MergeCouples(IntPolyh_ListOfCouples theArrayFF, IntPolyh_ListOfCouples theArrayFR, IntPolyh_ListOfCouples theArrayRF, IntPolyh_ListOfCouples theArrayRR)
		{
			throw new NotImplementedException();
		}


	}; // class IntPolyh_Intersection

}
