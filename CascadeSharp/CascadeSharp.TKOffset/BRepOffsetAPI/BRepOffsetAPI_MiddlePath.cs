//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKOffset.BRepOffsetAPI
{
    //---------------------------------------------------------------------
    //  Class  BRepOffsetAPI_MiddlePath
    //---------------------------------------------------------------------
    public sealed class BRepOffsetAPI_MiddlePath : BRepBuilderAPI_MakeShape
    {
        public BRepOffsetAPI_MiddlePath(TopoDS_Shape aShape, TopoDS_Shape StartShape, TopoDS_Shape EndShape)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MiddlePath(BRepOffsetAPI_MiddlePath parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MiddlePath()
        {
            throw new NotImplementedException();
        }

        public void Build()
        {
            throw new NotImplementedException();
        }
    }; // class BRepOffsetAPI_MiddlePath
}