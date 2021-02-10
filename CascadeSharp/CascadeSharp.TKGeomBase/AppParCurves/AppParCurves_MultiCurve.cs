//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomBase.AppParCurves
{
	//---------------------------------------------------------------------
	//  Class  AppParCurves_MultiCurve
	//---------------------------------------------------------------------
	public  class AppParCurves_MultiCurve
	{

		public AppParCurves_MultiCurve()
			: base()
		{
			throw new NotImplementedException();
		}

		public AppParCurves_MultiCurve(int NbPol)
			: base()
		{
			throw new NotImplementedException();
		}

		public AppParCurves_MultiCurve(AppParCurves_Array1OfMultiPoint tabMU)
			: base()
		{
			throw new NotImplementedException();
		}

		public AppParCurves_MultiCurve(AppParCurves_MultiCurve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetNbPoles(int nbPoles)
		{
			throw new NotImplementedException();
		}

		public void SetValue(int Index, AppParCurves_MultiPoint MPoint)
		{
			throw new NotImplementedException();
		}

		public int NbCurves()
		{
			throw new NotImplementedException();
		}

		public int NbPoles()
		{
			throw new NotImplementedException();
		}

		public int Degree()
		{
			throw new NotImplementedException();
		}

		public int Dimension(int CuIndex)
		{
			throw new NotImplementedException();
		}

		public void Curve(int CuIndex, TColgp_Array1OfPnt TabPnt)
		{
			throw new NotImplementedException();
		}

		public void Curve(int CuIndex, TColgp_Array1OfPnt2d TabPnt)
		{
			throw new NotImplementedException();
		}

		public AppParCurves_MultiPoint Value(int Index)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Pole(int CuIndex, int Nieme)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d Pole2d(int CuIndex, int Nieme)
		{
			throw new NotImplementedException();
		}

		public void Transform(int CuIndex, double x, double dx, double y, double dy, double z, double dz)
		{
			throw new NotImplementedException();
		}

		public void Transform2d(int CuIndex, double x, double dx, double y, double dy)
		{
			throw new NotImplementedException();
		}

		public void Value(int CuIndex, double U, gp_Pnt Pt)
		{
			throw new NotImplementedException();
		}

		public void Value(int CuIndex, double U, gp_Pnt2d Pt)
		{
			throw new NotImplementedException();
		}

		public void D1(int CuIndex, double U, gp_Pnt Pt, gp_Vec V1)
		{
			throw new NotImplementedException();
		}

		public void D1(int CuIndex, double U, gp_Pnt2d Pt, gp_Vec2d V1)
		{
			throw new NotImplementedException();
		}

		public void D2(int CuIndex, double U, gp_Pnt Pt, gp_Vec V1, gp_Vec V2)
		{
			throw new NotImplementedException();
		}

		public void D2(int CuIndex, double U, gp_Pnt2d Pt, gp_Vec2d V1, gp_Vec2d V2)
		{
			throw new NotImplementedException();
		}

		
	}; // class AppParCurves_MultiCurve

}
