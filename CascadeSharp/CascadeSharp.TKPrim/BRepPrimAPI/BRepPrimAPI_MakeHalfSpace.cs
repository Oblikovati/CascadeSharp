//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKPrim.BRepPrimAPI
{
    //---------------------------------------------------------------------
    //  Class  BRepPrimAPI_MakeHalfSpace
    //---------------------------------------------------------------------
    public sealed class BRepPrimAPI_MakeHalfSpace : BRepBuilderAPI_MakeShape
    {
        public BRepPrimAPI_MakeHalfSpace(TopoDS_Face Face, gp_Pnt RefPnt)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrimAPI_MakeHalfSpace(TopoDS_Shell Shell, gp_Pnt RefPnt)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrimAPI_MakeHalfSpace(BRepPrimAPI_MakeHalfSpace parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrimAPI_MakeHalfSpace()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Solid Solid()
        {
            throw new NotImplementedException();
        }
    }; // class BRepPrimAPI_MakeHalfSpace
}