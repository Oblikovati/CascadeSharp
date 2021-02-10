//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKFillet.ChFiDS;

namespace CascadeSharp.TKOffset.BRepOffset
{
    //---------------------------------------------------------------------
    //  Class  BRepOffset_Analyse
    //---------------------------------------------------------------------
    public sealed class BRepOffset_Analyse
    {
        public BRepOffset_Analyse()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffset_Analyse(TopoDS_Shape theS, double theAngle)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffset_Analyse(BRepOffset_Analyse parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Shape theS, double theAngle)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public BRepOffset_ListOfInterval Type(TopoDS_Edge theE)
        {
            throw new NotImplementedException();
        }

        public void Edges(TopoDS_Vertex theV, ChFiDS_TypeOfConcavity theType, TopTools_ListOfShape theL)
        {
            throw new NotImplementedException();
        }

        public void Edges(TopoDS_Face theF, ChFiDS_TypeOfConcavity theType, TopTools_ListOfShape theL)
        {
            throw new NotImplementedException();
        }

        public void TangentEdges(TopoDS_Edge theEdge, TopoDS_Vertex theVertex, TopTools_ListOfShape theEdges)
        {
            throw new NotImplementedException();
        }

        public bool HasAncestor(TopoDS_Shape theS)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Ancestors(TopoDS_Shape theS)
        {
            throw new NotImplementedException();
        }

        public void Explode(TopTools_ListOfShape theL, ChFiDS_TypeOfConcavity theType)
        {
            throw new NotImplementedException();
        }

        public void Explode(TopTools_ListOfShape theL, ChFiDS_TypeOfConcavity theType1, ChFiDS_TypeOfConcavity theType2)
        {
            throw new NotImplementedException();
        }

        public void AddFaces(TopoDS_Face theFace, TopoDS_Compound theCo, TopTools_MapOfShape theMap,
            ChFiDS_TypeOfConcavity theType)
        {
            throw new NotImplementedException();
        }

        public void AddFaces(TopoDS_Face theFace, TopoDS_Compound theCo, TopTools_MapOfShape theMap,
            ChFiDS_TypeOfConcavity theType1, ChFiDS_TypeOfConcavity theType2)
        {
            throw new NotImplementedException();
        }

        public void SetOffsetValue(double theOffset)
        {
            throw new NotImplementedException();
        }

        public void SetFaceOffsetMap(TopTools_DataMapOfShapeReal theMap)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape NewFaces()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Generated(TopoDS_Shape theS)
        {
            throw new NotImplementedException();
        }

        public bool HasGenerated(TopoDS_Shape theS)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Edge EdgeReplacement(TopoDS_Face theFace, TopoDS_Edge theEdge)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Descendants(TopoDS_Shape theS, bool theUpdate)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Descendants(TopoDS_Shape theS)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void TreatTangentFaces(TopTools_ListOfShape theEdges)
        {
            throw new NotImplementedException();
        }
    }; // class BRepOffset_Analyse
}