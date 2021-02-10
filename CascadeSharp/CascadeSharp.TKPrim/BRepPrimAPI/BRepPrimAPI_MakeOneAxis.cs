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
    //  Class  BRepPrimAPI_MakeOneAxis
    //---------------------------------------------------------------------
    public abstract class BRepPrimAPI_MakeOneAxis : BRepBuilderAPI_MakeShape
    {
        public BRepPrimAPI_MakeOneAxis()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public BRepPrimAPI_MakeOneAxis(BRepPrimAPI_MakeOneAxis parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public IntPtr OneAxis()
        {
            throw new NotImplementedException();
        }

        public void Build()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face Face()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shell Shell()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Solid Solid()
        {
            throw new NotImplementedException();
        }
    }; // class BRepPrimAPI_MakeOneAxis
}