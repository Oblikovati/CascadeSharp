//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GccInt
{
    //---------------------------------------------------------------------
    //  Class  GccInt_Bisec
    //---------------------------------------------------------------------
    public abstract class GccInt_Bisec : Standard_Transient
    {
        public GccInt_Bisec(GccInt_Bisec parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public GccInt_Bisec()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public GccInt_IType ArcType()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d Point()
        {
            throw new NotImplementedException();
        }

        public gp_Lin2d Line()
        {
            throw new NotImplementedException();
        }

        public gp_Circ2d Circle()
        {
            throw new NotImplementedException();
        }

        public gp_Hypr2d Hyperbola()
        {
            throw new NotImplementedException();
        }

        public gp_Parab2d Parabola()
        {
            throw new NotImplementedException();
        }

        public gp_Elips2d Ellipse()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class GccInt_Bisec
}