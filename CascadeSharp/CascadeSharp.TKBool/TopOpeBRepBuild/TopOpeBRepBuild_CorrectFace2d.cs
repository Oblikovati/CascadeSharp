//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBool.TopOpeBRepBuild
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRepBuild_CorrectFace2d
    //---------------------------------------------------------------------
    public sealed class TopOpeBRepBuild_CorrectFace2d
    {
        public TopOpeBRepBuild_CorrectFace2d()
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepBuild_CorrectFace2d(TopoDS_Face aFace, TopTools_IndexedMapOfOrientedShape anAvoidMap,
            TopTools_IndexedDataMapOfShapeShape aMap)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepBuild_CorrectFace2d(TopOpeBRepBuild_CorrectFace2d parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face Face()
        {
            throw new NotImplementedException();
        }

        public void Perform()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public int ErrorStatus()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face CorrectedFace()
        {
            throw new NotImplementedException();
        }

        public void SetMapOfTrans2dInfo(TopTools_IndexedDataMapOfShapeShape aMap)
        {
            throw new NotImplementedException();
        }

        public TopTools_IndexedDataMapOfShapeShape MapOfTrans2dInfo()
        {
            throw new NotImplementedException();
        }

        public void GetP2dFL(TopoDS_Face aFace, TopoDS_Edge anEdge, gp_Pnt2d P2dF, gp_Pnt2d P2dL)
        {
            throw new NotImplementedException();
        }

        public void CheckList(TopoDS_Face aFace, TopTools_ListOfShape aHeadL_ist)
        {
            throw new NotImplementedException();
        }

        public void CheckFace()
        {
            throw new NotImplementedException();
        }

        public int MakeRightWire()
        {
            throw new NotImplementedException();
        }

        public void MakeHeadList(TopoDS_Shape aFirstEdge, TopTools_ListOfShape aHeadL_ist)
        {
            throw new NotImplementedException();
        }

        public void TranslateCurve2d(TopoDS_Edge anEdge, TopoDS_Face aFace, gp_Vec2d aTranslateVec,
            Geom2d_Curve aCurve2d)
        {
            throw new NotImplementedException();
        }

        public int OuterWire(TopoDS_Wire anOuterWire)
        {
            throw new NotImplementedException();
        }

        public void BndBoxWire(TopoDS_Wire aWire, Bnd_Box2d aB2d)
        {
            throw new NotImplementedException();
        }

        public void MoveWire2d(TopoDS_Wire aWire, gp_Vec2d aTrV)
        {
            throw new NotImplementedException();
        }

        public void MoveWires2d(TopoDS_Wire aWire)
        {
            throw new NotImplementedException();
        }

        public void UpdateEdge(TopoDS_Edge E, Geom2d_Curve C, TopoDS_Face F, double Tol)
        {
            throw new NotImplementedException();
        }

        public void UpdateEdge(TopoDS_Edge E, Geom2d_Curve C1, Geom2d_Curve C2, TopoDS_Face F, double Tol)
        {
            throw new NotImplementedException();
        }

        public void BuildCopyData(TopoDS_Face F, TopTools_IndexedMapOfOrientedShape anAvoidMap, TopoDS_Face aCopyFace,
            TopTools_IndexedMapOfOrientedShape aCopyAvoidMap, bool aNeedToUsePMap)
        {
            throw new NotImplementedException();
        }

        public int ConnectWire(TopoDS_Face aCopyFace, TopTools_IndexedMapOfOrientedShape aCopyAvoidMap,
            bool aTryToConnectFlag)
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRepBuild_CorrectFace2d
}