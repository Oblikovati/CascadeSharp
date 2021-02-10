//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKG3d.GProp
{
    //---------------------------------------------------------------------
    //  Class  GProp_PGProps
    //---------------------------------------------------------------------
    public sealed class GProp_PGProps : GProp_GProps
    {
        public GProp_PGProps()
            : base()
        {
            throw new NotImplementedException();
        }

        public GProp_PGProps(TColgp_Array1OfPnt Pnts)
            : base()
        {
            throw new NotImplementedException();
        }

        public GProp_PGProps(TColgp_Array2OfPnt Pnts)
            : base()
        {
            throw new NotImplementedException();
        }

        public GProp_PGProps(TColgp_Array1OfPnt Pnts, TColStd_Array1OfReal Density)
            : base()
        {
            throw new NotImplementedException();
        }

        public GProp_PGProps(TColgp_Array2OfPnt Pnts, TColStd_Array2OfReal Density)
            : base()
        {
            throw new NotImplementedException();
        }

        public GProp_PGProps(GProp_PGProps parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void AddPoint(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void AddPoint(gp_Pnt P, double Density)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Barycentre(TColgp_Array1OfPnt Pnts)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Barycentre(TColgp_Array2OfPnt Pnts)
        {
            throw new NotImplementedException();
        }

        public void Barycentre(TColgp_Array1OfPnt Pnts, TColStd_Array1OfReal Density, ref double Mass, gp_Pnt G)
        {
            throw new NotImplementedException();
        }

        public void Barycentre(TColgp_Array2OfPnt Pnts, TColStd_Array2OfReal Density, ref double Mass, gp_Pnt G)
        {
            throw new NotImplementedException();
        }
    }; // class GProp_PGProps
}