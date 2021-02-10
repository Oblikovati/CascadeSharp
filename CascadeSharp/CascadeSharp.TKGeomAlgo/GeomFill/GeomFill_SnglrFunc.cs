//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
    //---------------------------------------------------------------------
    //  Class  GeomFill_SnglrFunc
    //---------------------------------------------------------------------
    public sealed class GeomFill_SnglrFunc : Adaptor3d_Curve
    {
        public GeomFill_SnglrFunc(Adaptor3d_HCurve HC)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_SnglrFunc(GeomFill_SnglrFunc parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_SnglrFunc()
        {
            throw new NotImplementedException();
        }

        public void SetRatio(double Ratio)
        {
            throw new NotImplementedException();
        }

        public double FirstParameter()
        {
            throw new NotImplementedException();
        }

        public double LastParameter()
        {
            throw new NotImplementedException();
        }

        public int NbIntervals(GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public void Intervals(TColStd_Array1OfReal T, GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Value(double U)
        {
            throw new NotImplementedException();
        }

        public bool IsPeriodic()
        {
            throw new NotImplementedException();
        }

        public double Period()
        {
            throw new NotImplementedException();
        }

        public void D0(double U, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, gp_Pnt P, gp_Vec V)
        {
            throw new NotImplementedException();
        }

        public void D2(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2)
        {
            throw new NotImplementedException();
        }

        public void D3(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2, gp_Vec V3)
        {
            throw new NotImplementedException();
        }

        public gp_Vec DN(double U, int N)
        {
            throw new NotImplementedException();
        }

        public double Resolution(double R3d)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_CurveType GetGeomType()
        {
            throw new NotImplementedException();
        }
    }; // class GeomFill_SnglrFunc
}