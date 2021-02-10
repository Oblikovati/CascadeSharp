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
    //  Class  BRepFill_ACRLaw
    //---------------------------------------------------------------------
    public sealed class BRepFill_ACRLaw : BRepFill_LocationLaw
    {
        public BRepFill_ACRLaw(TopoDS_Wire Path, GeomFill_LocationGuide Law)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_ACRLaw(BRepFill_ACRLaw parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_ACRLaw()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class BRepFill_ACRLaw
}