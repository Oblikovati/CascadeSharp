//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomBase.AppParCurves
{
    //---------------------------------------------------------------------
    //  Class  AppParCurves_MultiBSpCurve
    //---------------------------------------------------------------------
    public sealed class AppParCurves_MultiBSpCurve : AppParCurves_MultiCurve
    {
        public AppParCurves_MultiBSpCurve()
            : base()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_MultiBSpCurve(int NbPol)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_MultiBSpCurve(AppParCurves_Array1OfMultiPoint tabMU, TColStd_Array1OfReal Knots,
            TColStd_Array1OfInteger Mults)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_MultiBSpCurve(AppParCurves_MultiCurve SC, TColStd_Array1OfReal Knots,
            TColStd_Array1OfInteger Mults)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_MultiBSpCurve(AppParCurves_MultiBSpCurve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void SetKnots(TColStd_Array1OfReal theKnots)
        {
            throw new NotImplementedException();
        }

        public void SetMultiplicities(TColStd_Array1OfInteger theMults)
        {
            throw new NotImplementedException();
        }

        public TColStd_Array1OfReal Knots()
        {
            throw new NotImplementedException();
        }

        public TColStd_Array1OfInteger Multiplicities()
        {
            throw new NotImplementedException();
        }

        public int Degree()
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
    }; // class AppParCurves_MultiBSpCurve
}