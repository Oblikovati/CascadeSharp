//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
    //---------------------------------------------------------------------
    //  Class  GeomFill_DegeneratedBound
    //---------------------------------------------------------------------
    public sealed class GeomFill_DegeneratedBound : GeomFill_Boundary
    {
        public GeomFill_DegeneratedBound(gp_Pnt Point, double First, double Last, double Tol3d, double Tolang)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_DegeneratedBound(GeomFill_DegeneratedBound parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_DegeneratedBound()
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
    }; // class GeomFill_DegeneratedBound
}