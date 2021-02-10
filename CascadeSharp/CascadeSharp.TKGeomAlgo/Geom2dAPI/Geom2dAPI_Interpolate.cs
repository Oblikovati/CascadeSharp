//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomAlgo.Geom2dAPI
{
    //---------------------------------------------------------------------
    //  Class  Geom2dAPI_Interpolate
    //---------------------------------------------------------------------
    public sealed class Geom2dAPI_Interpolate
    {
        public Geom2dAPI_Interpolate(TColgp_HArray1OfPnt2d Points, bool PeriodicFlag, double Tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dAPI_Interpolate(TColgp_HArray1OfPnt2d Points, TColStd_HArray1OfReal Parameters, bool PeriodicFlag,
            double Tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dAPI_Interpolate(Geom2dAPI_Interpolate parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dAPI_Interpolate()
        {
            throw new NotImplementedException();
        }

        public void Load(gp_Vec2d InitialTangent, gp_Vec2d FinalTangent, bool Scale)
        {
            throw new NotImplementedException();
        }

        public void Load(gp_Vec2d InitialTangent, gp_Vec2d FinalTangent)
        {
            throw new NotImplementedException();
        }

        public void Load(TColgp_Array1OfVec2d Tangents, TColStd_HArray1OfBoolean TangentFlags, bool Scale)
        {
            throw new NotImplementedException();
        }

        public void Load(TColgp_Array1OfVec2d Tangents, TColStd_HArray1OfBoolean TangentFlags)
        {
            throw new NotImplementedException();
        }

        public void ClearTangents()
        {
            throw new NotImplementedException();
        }

        public void Perform()
        {
            throw new NotImplementedException();
        }

        public Geom2d_BSplineCurve Curve()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public void PerformNonPeriodic()
        {
            throw new NotImplementedException();
        }

        public void PerformPeriodic()
        {
            throw new NotImplementedException();
        }
    }; // class Geom2dAPI_Interpolate
}