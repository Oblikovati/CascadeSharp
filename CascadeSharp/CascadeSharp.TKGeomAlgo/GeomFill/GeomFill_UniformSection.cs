//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
    //---------------------------------------------------------------------
    //  Class  GeomFill_UniformSection
    //---------------------------------------------------------------------
    public sealed class GeomFill_UniformSection : GeomFill_SectionLaw
    {
        public GeomFill_UniformSection(Geom_Curve C, double FirstParameter, double LastParameter)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_UniformSection(Geom_Curve C, double FirstParameter)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_UniformSection(Geom_Curve C)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_UniformSection(GeomFill_UniformSection parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_UniformSection()
        {
            throw new NotImplementedException();
        }

        public bool D0(double Param, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weigths)
        {
            throw new NotImplementedException();
        }

        public bool D1(double Param, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColStd_Array1OfReal Weigths,
            TColStd_Array1OfReal DWeigths)
        {
            throw new NotImplementedException();
        }

        public bool D2(double Param, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColgp_Array1OfVec D2Poles,
            TColStd_Array1OfReal Weigths, TColStd_Array1OfReal DWeigths, TColStd_Array1OfReal D2Weigths)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface BSplineSurface()
        {
            throw new NotImplementedException();
        }

        public void SectionShape(ref int NbPoles, ref int NbKnots, ref int Degree)
        {
            throw new NotImplementedException();
        }

        public void Knots(TColStd_Array1OfReal TKnots)
        {
            throw new NotImplementedException();
        }

        public void Mults(TColStd_Array1OfInteger TMults)
        {
            throw new NotImplementedException();
        }

        public bool IsRational()
        {
            throw new NotImplementedException();
        }

        public bool IsUPeriodic()
        {
            throw new NotImplementedException();
        }

        public bool IsVPeriodic()
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

        public void SetInterval(double First, double Last)
        {
            throw new NotImplementedException();
        }

        public void GetInterval(ref double First, ref double Last)
        {
            throw new NotImplementedException();
        }

        public void GetDomain(ref double First, ref double Last)
        {
            throw new NotImplementedException();
        }

        public void GetTolerance(double BoundTol, double SurfTol, double AngleTol, TColStd_Array1OfReal Tol3d)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt BarycentreOfSurf()
        {
            throw new NotImplementedException();
        }

        public double MaximalSection()
        {
            throw new NotImplementedException();
        }

        public void GetMinimalWeight(TColStd_Array1OfReal Weigths)
        {
            throw new NotImplementedException();
        }

        public bool IsConstant(ref double Error)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve ConstantSection()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class GeomFill_UniformSection
}