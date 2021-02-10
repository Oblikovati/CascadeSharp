//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBO.BOPAlgo;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKBO.BRepAlgoAPI
{
    //---------------------------------------------------------------------
    //  Class  BRepAlgoAPI_BooleanOperation
    //---------------------------------------------------------------------
    public class BRepAlgoAPI_BooleanOperation : BRepAlgoAPI_BuilderAlgo
    {
        public BRepAlgoAPI_BooleanOperation()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepAlgoAPI_BooleanOperation(TopoDS_Shape theS1, TopoDS_Shape theS2, BOPAlgo_Operation theOperation)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepAlgoAPI_BooleanOperation(BRepAlgoAPI_BooleanOperation parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape1()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape2()
        {
            throw new NotImplementedException();
        }

        public void SetTools(TopTools_ListOfShape theLS)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Tools()
        {
            throw new NotImplementedException();
        }

        public void SetOperation(BOPAlgo_Operation theBOP)
        {
            throw new NotImplementedException();
        }

        public BOPAlgo_Operation Operation()
        {
            throw new NotImplementedException();
        }

        public void Build()
        {
            throw new NotImplementedException();
        }
    }; // class BRepAlgoAPI_BooleanOperation
}