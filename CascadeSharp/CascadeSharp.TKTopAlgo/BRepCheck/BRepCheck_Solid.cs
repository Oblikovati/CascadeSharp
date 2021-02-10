//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;

namespace CascadeSharp.TKTopAlgo.BRepCheck
{
    //---------------------------------------------------------------------
    //  Class  BRepCheck_Solid
    //---------------------------------------------------------------------
    public sealed class BRepCheck_Solid : BRepCheck_Result
    {
        public BRepCheck_Solid(TopoDS_Solid theS)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Solid(BRepCheck_Solid parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Solid()
        {
            throw new NotImplementedException();
        }

        public void InContext(TopoDS_Shape theContextShape)
        {
            throw new NotImplementedException();
        }

        public void Minimum()
        {
            throw new NotImplementedException();
        }

        public void Blind()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class BRepCheck_Solid
}