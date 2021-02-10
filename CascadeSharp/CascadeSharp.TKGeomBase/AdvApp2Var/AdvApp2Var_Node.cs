//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomBase.AdvApp2Var
{
    //---------------------------------------------------------------------
    //  Class  AdvApp2Var_Node
    //---------------------------------------------------------------------
    public sealed class AdvApp2Var_Node : Standard_Transient
    {
        public AdvApp2Var_Node()
            : base()
        {
            throw new NotImplementedException();
        }

        public AdvApp2Var_Node(int iu, int iv)
            : base()
        {
            throw new NotImplementedException();
        }

        public AdvApp2Var_Node(gp_XY UV, int iu, int iv)
            : base()
        {
            throw new NotImplementedException();
        }

        public AdvApp2Var_Node(AdvApp2Var_Node theOther)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public gp_XY Coord()
        {
            throw new NotImplementedException();
        }

        public void SetCoord(double x1, double x2)
        {
            throw new NotImplementedException();
        }

        public int UOrder()
        {
            throw new NotImplementedException();
        }

        public int VOrder()
        {
            throw new NotImplementedException();
        }

        public void SetPoint(int iu, int iv, gp_Pnt Pt)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Point(int iu, int iv)
        {
            throw new NotImplementedException();
        }

        public void SetError(int iu, int iv, double error)
        {
            throw new NotImplementedException();
        }

        public double Error(int iu, int iv)
        {
            throw new NotImplementedException();
        }
    }; // class AdvApp2Var_Node
}