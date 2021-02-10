//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_TEdge
    //---------------------------------------------------------------------
    public abstract class TopoDS_TEdge : TopoDS_TShape
    {
        public TopoDS_TEdge()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public TopoDS_TEdge(TopoDS_TEdge parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public TopAbs_ShapeEnum ShapeType()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class TopoDS_TEdge
}