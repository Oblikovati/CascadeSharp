//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GccInt
{
    //---------------------------------------------------------------------
    //  Class  GccInt_BHyper
    //---------------------------------------------------------------------
    public sealed class GccInt_BHyper : GccInt_Bisec
    {
        public GccInt_BHyper(gp_Hypr2d Hyper)
            : base()
        {
            throw new NotImplementedException();
        }

        public GccInt_BHyper(GccInt_BHyper parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GccInt_BHyper()
        {
            throw new NotImplementedException();
        }

        public gp_Hypr2d Hyperbola()
        {
            throw new NotImplementedException();
        }

        public GccInt_IType ArcType()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class GccInt_BHyper
}