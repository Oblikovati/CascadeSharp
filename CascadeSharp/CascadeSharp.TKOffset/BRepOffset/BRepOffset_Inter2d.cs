//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.BRepAlgo;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKOffset.BRepOffset
{
    //---------------------------------------------------------------------
    //  Class  BRepOffset_Inter2d
    //---------------------------------------------------------------------
    public sealed class BRepOffset_Inter2d
    {
        public BRepOffset_Inter2d()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffset_Inter2d(BRepOffset_Inter2d parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Compute(BRepAlgo_AsDes AsDes, TopoDS_Face F, TopTools_IndexedMapOfShape NewEdges, double Tol,
            TopTools_IndexedDataMapOfShapeListOfShape theDMVV)
        {
            throw new NotImplementedException();
        }

        public bool ConnexIntByInt(TopoDS_Face FI, BRepOffset_Offset OFI, TopTools_DataMapOfShapeShape MES,
            TopTools_DataMapOfShapeShape Build, BRepAlgo_AsDes AsDes2d, double Offset, double Tol,
            BRepOffset_Analyse Analyse, TopTools_IndexedMapOfShape FacesWithVerts,
            TopTools_IndexedDataMapOfShapeListOfShape theDMVV)
        {
            throw new NotImplementedException();
        }

        public void ConnexIntByIntInVert(TopoDS_Face FI, BRepOffset_Offset OFI, TopTools_DataMapOfShapeShape MES,
            TopTools_DataMapOfShapeShape Build, BRepAlgo_AsDes AsDes, BRepAlgo_AsDes AsDes2d, double Tol,
            BRepOffset_Analyse Analyse, TopTools_IndexedDataMapOfShapeListOfShape theDMVV)
        {
            throw new NotImplementedException();
        }

        public bool FuseVertices(TopTools_IndexedDataMapOfShapeListOfShape theDMVV, BRepAlgo_AsDes theAsDes)
        {
            throw new NotImplementedException();
        }

        public bool ExtentEdge(TopoDS_Edge E, TopoDS_Edge NE, double theOffset)
        {
            throw new NotImplementedException();
        }
    }; // class BRepOffset_Inter2d
}