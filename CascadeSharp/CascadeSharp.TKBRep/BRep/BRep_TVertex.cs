//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBRep.BRep
{
    //---------------------------------------------------------------------
    //  Class  BRep_TVertex
    //---------------------------------------------------------------------
    public sealed class BRep_TVertex : TopoDS_TVertex
    {
        public BRep_TVertex()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRep_TVertex(BRep_TVertex parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public double Tolerance()
        {
            throw new NotImplementedException();
        }

        public void Tolerance(double T)
        {
            throw new NotImplementedException();
        }

        public void UpdateTolerance(double T)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Pnt()
        {
            throw new NotImplementedException();
        }

        public void Pnt(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public BRep_ListOfPointRepresentation Points()
        {
            throw new NotImplementedException();
        }

        public BRep_ListOfPointRepresentation ChangePoints()
        {
            throw new NotImplementedException();
        }

        public override TopoDS_TShape EmptyCopy()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class BRep_TVertex
}