//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKShHealing.ShapeAnalysis
{
    //---------------------------------------------------------------------
    //  Class  ShapeAnalysis_Curve
    //---------------------------------------------------------------------
    public sealed class ShapeAnalysis_Curve
    {
        public ShapeAnalysis_Curve()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_Curve(ShapeAnalysis_Curve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public double Project(Geom_Curve C3D, gp_Pnt P3D, double preci, gp_Pnt proj, ref double param,
            bool AdjustToEnds)
        {
            throw new NotImplementedException();
        }

        public double Project(Geom_Curve C3D, gp_Pnt P3D, double preci, gp_Pnt proj, ref double param)
        {
            throw new NotImplementedException();
        }

        public double Project(Adaptor3d_Curve C3D, gp_Pnt P3D, double preci, gp_Pnt proj, ref double param,
            bool AdjustToEnds)
        {
            throw new NotImplementedException();
        }

        public double Project(Adaptor3d_Curve C3D, gp_Pnt P3D, double preci, gp_Pnt proj, ref double param)
        {
            throw new NotImplementedException();
        }

        public double Project(Geom_Curve C3D, gp_Pnt P3D, double preci, gp_Pnt proj, ref double param, double cf,
            double cl, bool AdjustToEnds)
        {
            throw new NotImplementedException();
        }

        public double Project(Geom_Curve C3D, gp_Pnt P3D, double preci, gp_Pnt proj, ref double param, double cf,
            double cl)
        {
            throw new NotImplementedException();
        }

        public double ProjectAct(Adaptor3d_Curve C3D, gp_Pnt P3D, double preci, gp_Pnt proj, ref double param)
        {
            throw new NotImplementedException();
        }

        public double NextProject(double paramPrev, Geom_Curve C3D, gp_Pnt P3D, double preci, gp_Pnt proj,
            ref double param, double cf, double cl, bool AdjustToEnds)
        {
            throw new NotImplementedException();
        }

        public double NextProject(double paramPrev, Geom_Curve C3D, gp_Pnt P3D, double preci, gp_Pnt proj,
            ref double param, double cf, double cl)
        {
            throw new NotImplementedException();
        }

        public double NextProject(double paramPrev, Adaptor3d_Curve C3D, gp_Pnt P3D, double preci, gp_Pnt proj,
            ref double param)
        {
            throw new NotImplementedException();
        }

        public bool ValidateRange(Geom_Curve Crv, ref double First, ref double Last, double prec)
        {
            throw new NotImplementedException();
        }

        public void FillBndBox(Geom2d_Curve C2d, double First, double Last, int NPoints, bool Exact, Bnd_Box2d Box)
        {
            throw new NotImplementedException();
        }

        public int SelectForwardSeam(Geom2d_Curve C1, Geom2d_Curve C2)
        {
            throw new NotImplementedException();
        }

        public bool IsPlanar(TColgp_Array1OfPnt pnts, gp_XYZ Normal, double preci)
        {
            throw new NotImplementedException();
        }

        public bool IsPlanar(TColgp_Array1OfPnt pnts, gp_XYZ Normal)
        {
            throw new NotImplementedException();
        }

        public bool IsPlanar(Geom_Curve curve, gp_XYZ Normal, double preci)
        {
            throw new NotImplementedException();
        }

        public bool IsPlanar(Geom_Curve curve, gp_XYZ Normal)
        {
            throw new NotImplementedException();
        }

        public bool GetSamplePoints(Geom2d_Curve curve, double first, double last, TColgp_SequenceOfPnt2d seq)
        {
            throw new NotImplementedException();
        }

        public bool GetSamplePoints(Geom_Curve curve, double first, double last, TColgp_SequenceOfPnt seq)
        {
            throw new NotImplementedException();
        }

        public bool IsClosed(Geom_Curve curve, double preci)
        {
            throw new NotImplementedException();
        }

        public bool IsClosed(Geom_Curve curve)
        {
            throw new NotImplementedException();
        }

        public bool IsPeriodic(Geom_Curve curve)
        {
            throw new NotImplementedException();
        }

        public bool IsPeriodic(Geom2d_Curve curve)
        {
            throw new NotImplementedException();
        }
    }; // class ShapeAnalysis_Curve
}