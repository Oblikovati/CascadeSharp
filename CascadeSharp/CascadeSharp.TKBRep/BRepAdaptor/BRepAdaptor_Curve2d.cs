//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2dAdaptor;

namespace CascadeSharp.TKBRep.BRepAdaptor
{
    //---------------------------------------------------------------------
    //  Class  BRepAdaptor_Curve2d
    //---------------------------------------------------------------------
    public sealed class BRepAdaptor_Curve2d : Geom2dAdaptor_Curve
    {
        public BRepAdaptor_Curve2d()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepAdaptor_Curve2d(TopoDS_Edge E, TopoDS_Face F)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepAdaptor_Curve2d(BRepAdaptor_Curve2d parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Initialize(TopoDS_Edge E, TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge Edge()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face Face()
        {
            throw new NotImplementedException();
        }
    }; // class BRepAdaptor_Curve2d
}