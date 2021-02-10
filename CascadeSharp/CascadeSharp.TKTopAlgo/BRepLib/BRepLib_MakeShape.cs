//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKTopAlgo.BRepLib
{
    //---------------------------------------------------------------------
    //  Class  BRepLib_MakeShape
    //---------------------------------------------------------------------
    public class BRepLib_MakeShape : BRepLib_Command
    {
        public BRepLib_MakeShape()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepLib_MakeShape(BRepLib_MakeShape parameter1)
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

        public BRepLib_ShapeModification FaceStatus(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public bool HasDescendants(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape DescendantFaces(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public int NbSurfaces()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape NewFaces(int I)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape FacesFromEdges(TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }
    }; // class BRepLib_MakeShape
}