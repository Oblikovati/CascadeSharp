//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Adaptor3d
{
    //---------------------------------------------------------------------
    //  Class  Adaptor3d_HVertex
    //---------------------------------------------------------------------
    public class Adaptor3d_HVertex : Standard_Transient
    {
        public Adaptor3d_HVertex()
            : base()
        {
            throw new NotImplementedException();
        }

        public Adaptor3d_HVertex(gp_Pnt2d P, TopAbs_Orientation Ori, double Resolution)
            : base()
        {
            throw new NotImplementedException();
        }

        public Adaptor3d_HVertex(Adaptor3d_HVertex parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d Value()
        {
            throw new NotImplementedException();
        }

        public double Parameter(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public double Resolution(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public TopAbs_Orientation Orientation()
        {
            throw new NotImplementedException();
        }

        public bool IsSame(Adaptor3d_HVertex Other)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Adaptor3d_HVertex
}