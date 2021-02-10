//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
    //---------------------------------------------------------------------
    //  Class  GeomFill_Sweep
    //---------------------------------------------------------------------
    public sealed class GeomFill_Sweep
    {
        public GeomFill_Sweep(GeomFill_LocationLaw Location, bool WithKpart)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_Sweep(GeomFill_LocationLaw Location)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_Sweep(GeomFill_Sweep parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_Sweep()
        {
            throw new NotImplementedException();
        }

        public void SetDomain(double First, double Last, double SectionFirst, double SectionLast)
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(double Tol3d, double BoundTol, double Tol2d, double TolAngular)
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(double Tol3d, double BoundTol, double Tol2d)
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(double Tol3d, double BoundTol)
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(double Tol3d)
        {
            throw new NotImplementedException();
        }

        public void SetForceApproxC1(bool ForceApproxC1)
        {
            throw new NotImplementedException();
        }

        public bool ExchangeUV()
        {
            throw new NotImplementedException();
        }

        public bool UReversed()
        {
            throw new NotImplementedException();
        }

        public bool VReversed()
        {
            throw new NotImplementedException();
        }

        public void Build(GeomFill_SectionLaw Section, GeomFill_ApproxStyle Methode, GeomAbs_Shape Continuity,
            int Degmax, int Segmax)
        {
            throw new NotImplementedException();
        }

        public void Build(GeomFill_SectionLaw Section, GeomFill_ApproxStyle Methode, GeomAbs_Shape Continuity,
            int Degmax)
        {
            throw new NotImplementedException();
        }

        public void Build(GeomFill_SectionLaw Section, GeomFill_ApproxStyle Methode, GeomAbs_Shape Continuity)
        {
            throw new NotImplementedException();
        }

        public void Build(GeomFill_SectionLaw Section, GeomFill_ApproxStyle Methode)
        {
            throw new NotImplementedException();
        }

        public void Build(GeomFill_SectionLaw Section)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public double ErrorOnSurface()
        {
            throw new NotImplementedException();
        }

        public void ErrorOnRestriction(bool IsFirst, ref double UError, ref double VError)
        {
            throw new NotImplementedException();
        }

        public void ErrorOnTrace(int IndexOfTrace, ref double UError, ref double VError)
        {
            throw new NotImplementedException();
        }

        public Geom_Surface Surface()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve Restriction(bool IsFirst)
        {
            throw new NotImplementedException();
        }

        public int NumberOfTrace()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve Trace(int IndexOfTrace)
        {
            throw new NotImplementedException();
        }

        public bool Build2d(GeomAbs_Shape Continuity, int Degmax, int Segmax)
        {
            throw new NotImplementedException();
        }

        public bool BuildAll(GeomAbs_Shape Continuity, int Degmax, int Segmax)
        {
            throw new NotImplementedException();
        }

        public bool BuildProduct(GeomAbs_Shape Continuity, int Degmax, int Segmax)
        {
            throw new NotImplementedException();
        }

        public bool BuildKPart()
        {
            throw new NotImplementedException();
        }
    }; // class GeomFill_Sweep
}