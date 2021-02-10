//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKGeomAlgo.GeomFill;

namespace CascadeSharp.TKBool.BRepFill
{
    //---------------------------------------------------------------------
    //  Class  BRepFill_DraftLaw
    //---------------------------------------------------------------------
    public sealed class BRepFill_DraftLaw : BRepFill_Edge3DLaw
    {
        public BRepFill_DraftLaw(TopoDS_Wire Path, GeomFill_LocationDraft Law)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_DraftLaw(BRepFill_DraftLaw parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_DraftLaw()
        {
            throw new NotImplementedException();
        }

        public void CleanLaw(double TolAngular)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class BRepFill_DraftLaw
}