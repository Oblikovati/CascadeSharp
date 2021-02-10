//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Geom;

namespace CascadeSharp.TKGeomBase.GeomLib
{
    //---------------------------------------------------------------------
    //  Class  GeomLib_CheckBSplineCurve
    //---------------------------------------------------------------------
    public sealed class GeomLib_CheckBSplineCurve
    {
        public GeomLib_CheckBSplineCurve(Geom_BSplineCurve Curve, double Tolerance, double AngularTolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomLib_CheckBSplineCurve(GeomLib_CheckBSplineCurve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomLib_CheckBSplineCurve()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public void NeedTangentFix(ref bool FirstFlag, ref bool SecondFlag)
        {
            throw new NotImplementedException();
        }

        public void FixTangent(bool FirstFlag, bool LastFlag)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve FixedTangent(bool FirstFlag, bool LastFlag)
        {
            throw new NotImplementedException();
        }

        public void FixTangentOnCurve(Geom_BSplineCurve theCurve, bool FirstFlag, bool LastFlag)
        {
            throw new NotImplementedException();
        }
    }; // class GeomLib_CheckBSplineCurve
}