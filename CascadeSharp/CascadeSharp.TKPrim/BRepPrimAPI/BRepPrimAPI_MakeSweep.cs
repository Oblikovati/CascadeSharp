//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKPrim.BRepPrimAPI
{
    //---------------------------------------------------------------------
    //  Class  BRepPrimAPI_MakeSweep
    //---------------------------------------------------------------------
    public abstract class BRepPrimAPI_MakeSweep : BRepBuilderAPI_MakeShape
    {
        public BRepPrimAPI_MakeSweep(BRepPrimAPI_MakeSweep parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public BRepPrimAPI_MakeSweep()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public TopoDS_Shape FirstShape()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape LastShape()
        {
            throw new NotImplementedException();
        }
    }; // class BRepPrimAPI_MakeSweep
}