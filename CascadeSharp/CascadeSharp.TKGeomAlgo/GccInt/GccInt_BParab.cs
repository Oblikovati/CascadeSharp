//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GccInt
{
    //---------------------------------------------------------------------
    //  Class  GccInt_BParab
    //---------------------------------------------------------------------
    public sealed class GccInt_BParab : GccInt_Bisec
    {
        public GccInt_BParab(gp_Parab2d Parab)
            : base()
        {
            throw new NotImplementedException();
        }

        public GccInt_BParab(GccInt_BParab parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GccInt_BParab()
        {
            throw new NotImplementedException();
        }

        public gp_Parab2d Parabola()
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
    }; // class GccInt_BParab
}