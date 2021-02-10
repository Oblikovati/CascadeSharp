//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.GeomAdaptor;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKShHealing.ShapeAnalysis
{
    //---------------------------------------------------------------------
    //  Class  ShapeAnalysis_Surface
    //---------------------------------------------------------------------
    public sealed class ShapeAnalysis_Surface : Standard_Transient
    {
        public ShapeAnalysis_Surface(Geom_Surface S)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_Surface(ShapeAnalysis_Surface parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_Surface()
        {
            throw new NotImplementedException();
        }

        public void Init(Geom_Surface S)
        {
            throw new NotImplementedException();
        }

        public void Init(ShapeAnalysis_Surface other)
        {
            throw new NotImplementedException();
        }

        public void SetDomain(double U1, double U2, double V1, double V2)
        {
            throw new NotImplementedException();
        }

        public Geom_Surface Surface()
        {
            throw new NotImplementedException();
        }

        public GeomAdaptor_HSurface Adaptor3d()
        {
            throw new NotImplementedException();
        }

        public GeomAdaptor_HSurface TrueAdaptor3d()
        {
            throw new NotImplementedException();
        }

        public double Gap()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Value(double u, double v)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Value(gp_Pnt2d p2d)
        {
            throw new NotImplementedException();
        }

        public bool HasSingularities(double preci)
        {
            throw new NotImplementedException();
        }

        public int NbSingularities(double preci)
        {
            throw new NotImplementedException();
        }

        public bool Singularity(int num, ref double preci, gp_Pnt P3d, gp_Pnt2d firstP2d, gp_Pnt2d lastP2d,
            ref double firstpar, ref double lastpar, ref bool u_isodeg)
        {
            throw new NotImplementedException();
        }

        public bool IsDegenerated(gp_Pnt P3d, double preci)
        {
            throw new NotImplementedException();
        }

        public bool DegeneratedValues(gp_Pnt P3d, double preci, gp_Pnt2d firstP2d, gp_Pnt2d lastP2d,
            ref double firstpar, ref double lastpar, bool forward)
        {
            throw new NotImplementedException();
        }

        public bool DegeneratedValues(gp_Pnt P3d, double preci, gp_Pnt2d firstP2d, gp_Pnt2d lastP2d,
            ref double firstpar, ref double lastpar)
        {
            throw new NotImplementedException();
        }

        public bool ProjectDegenerated(gp_Pnt P3d, double preci, gp_Pnt2d neighbour, gp_Pnt2d result)
        {
            throw new NotImplementedException();
        }

        public bool ProjectDegenerated(int nbrPnt, TColgp_SequenceOfPnt points, TColgp_SequenceOfPnt2d pnt2d,
            double preci, bool direct)
        {
            throw new NotImplementedException();
        }

        public bool IsDegenerated(gp_Pnt2d p2d1, gp_Pnt2d p2d2, double tol, double ratio)
        {
            throw new NotImplementedException();
        }

        public void Bounds(ref double ufirst, ref double ulast, ref double vfirst, ref double vlast)
        {
            throw new NotImplementedException();
        }

        public void ComputeBoundIsos()
        {
            throw new NotImplementedException();
        }

        public Geom_Curve UIso(double U)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve VIso(double V)
        {
            throw new NotImplementedException();
        }

        public bool IsUClosed(double preci)
        {
            throw new NotImplementedException();
        }

        public bool IsUClosed()
        {
            throw new NotImplementedException();
        }

        public bool IsVClosed(double preci)
        {
            throw new NotImplementedException();
        }

        public bool IsVClosed()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d ValueOfUV(gp_Pnt P3D, double preci)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d NextValueOfUV(gp_Pnt2d p2dPrev, gp_Pnt P3D, double preci, double maxpreci)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d NextValueOfUV(gp_Pnt2d p2dPrev, gp_Pnt P3D, double preci)
        {
            throw new NotImplementedException();
        }

        public double UVFromIso(gp_Pnt P3D, double preci, ref double U, ref double V)
        {
            throw new NotImplementedException();
        }

        public double UCloseVal()
        {
            throw new NotImplementedException();
        }

        public double VCloseVal()
        {
            throw new NotImplementedException();
        }

        public Bnd_Box GetBoxUF()
        {
            throw new NotImplementedException();
        }

        public Bnd_Box GetBoxUL()
        {
            throw new NotImplementedException();
        }

        public Bnd_Box GetBoxVF()
        {
            throw new NotImplementedException();
        }

        public Bnd_Box GetBoxVL()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void ComputeSingularities()
        {
            throw new NotImplementedException();
        }

        public void ComputeBoxes()
        {
            throw new NotImplementedException();
        }

        public int SurfaceNewton(gp_Pnt2d p2dPrev, gp_Pnt P3D, double preci, gp_Pnt2d sol)
        {
            throw new NotImplementedException();
        }

        public void SortSingularities()
        {
            throw new NotImplementedException();
        }
    }; // class ShapeAnalysis_Surface
}