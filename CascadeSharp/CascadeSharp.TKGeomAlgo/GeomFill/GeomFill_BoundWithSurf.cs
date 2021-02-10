//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
    //---------------------------------------------------------------------
    //  Class  GeomFill_BoundWithSurf
    //---------------------------------------------------------------------
    public sealed class GeomFill_BoundWithSurf : GeomFill_Boundary
    {
        public GeomFill_BoundWithSurf(Adaptor3d_CurveOnSurface CurveOnSurf, double Tol3d, double Tolang)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_BoundWithSurf(GeomFill_BoundWithSurf parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_BoundWithSurf()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Value(double U)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, gp_Pnt P, gp_Vec V)
        {
            throw new NotImplementedException();
        }

        public bool HasNormals()
        {
            throw new NotImplementedException();
        }

        public gp_Vec Norm(double U)
        {
            throw new NotImplementedException();
        }

        public void D1Norm(double U, gp_Vec N, gp_Vec DN)
        {
            throw new NotImplementedException();
        }

        public void Reparametrize(double First, double Last, bool HasDF, bool HasDL, double DF, double DL, bool Rev)
        {
            throw new NotImplementedException();
        }

        public void Bounds(ref double First, ref double Last)
        {
            throw new NotImplementedException();
        }

        public bool IsDegenerated()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class GeomFill_BoundWithSurf
}