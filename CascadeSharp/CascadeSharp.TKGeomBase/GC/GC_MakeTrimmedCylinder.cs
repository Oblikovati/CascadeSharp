//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomBase.GC
{
    //---------------------------------------------------------------------
    //  Class  GC_MakeTrimmedCylinder
    //---------------------------------------------------------------------
    public sealed class GC_MakeTrimmedCylinder : GC_Root
    {
        public GC_MakeTrimmedCylinder(gp_Pnt P1, gp_Pnt P2, gp_Pnt P3)
            : base()
        {
            throw new NotImplementedException();
        }

        public GC_MakeTrimmedCylinder(gp_Circ Circ, double Height)
            : base()
        {
            throw new NotImplementedException();
        }

        public GC_MakeTrimmedCylinder(gp_Ax1 A1, double Radius, double Height)
            : base()
        {
            throw new NotImplementedException();
        }

        public GC_MakeTrimmedCylinder(GC_MakeTrimmedCylinder parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GC_MakeTrimmedCylinder()
        {
            throw new NotImplementedException();
        }

        public Geom_RectangularTrimmedSurface Value()
        {
            throw new NotImplementedException();
        }
    }; // class GC_MakeTrimmedCylinder
}