//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKTopAlgo.BRepBuilderAPI
{
    //---------------------------------------------------------------------
    //  Class  BRepBuilderAPI_MakeShape
    //---------------------------------------------------------------------
    public class BRepBuilderAPI_MakeShape : BRepBuilderAPI_Command
    {
        public BRepBuilderAPI_MakeShape()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepBuilderAPI_MakeShape(BRepBuilderAPI_MakeShape parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Build()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Generated(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Modified(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool IsDeleted(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }
    }; // class BRepBuilderAPI_MakeShape
}