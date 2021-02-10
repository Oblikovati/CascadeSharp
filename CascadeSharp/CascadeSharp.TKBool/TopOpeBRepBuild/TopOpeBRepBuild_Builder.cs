//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.TopOpeBRepDS;
using CascadeSharp.TKBool.TopOpeBRepTool;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBool.TopOpeBRepBuild
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRepBuild_Builder
    //---------------------------------------------------------------------
    public class TopOpeBRepBuild_Builder
    {
        public TopOpeBRepBuild_Builder(TopOpeBRepDS_BuildTool BT)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepBuild_Builder(TopOpeBRepBuild_Builder parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepBuild_Builder()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_BuildTool ChangeBuildTool()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_BuildTool BuildTool()
        {
            throw new NotImplementedException();
        }

        public void Perform(TopOpeBRepDS_HDataStructure HDS)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopOpeBRepDS_HDataStructure HDS, TopoDS_Shape S1, TopoDS_Shape S2)
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_HDataStructure DataStructure()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void MergeEdges(TopTools_ListOfShape L1, TopAbs_State TB1, TopTools_ListOfShape L2, TopAbs_State TB2,
            bool onA, bool onB, bool onAB)
        {
            throw new NotImplementedException();
        }

        public void MergeEdges(TopTools_ListOfShape L1, TopAbs_State TB1, TopTools_ListOfShape L2, TopAbs_State TB2,
            bool onA, bool onB)
        {
            throw new NotImplementedException();
        }

        public void MergeEdges(TopTools_ListOfShape L1, TopAbs_State TB1, TopTools_ListOfShape L2, TopAbs_State TB2,
            bool onA)
        {
            throw new NotImplementedException();
        }

        public void MergeEdges(TopTools_ListOfShape L1, TopAbs_State TB1, TopTools_ListOfShape L2, TopAbs_State TB2)
        {
            throw new NotImplementedException();
        }

        public void MergeFaces(TopTools_ListOfShape S1, TopAbs_State TB1, TopTools_ListOfShape S2, TopAbs_State TB2,
            bool onA, bool onB, bool onAB)
        {
            throw new NotImplementedException();
        }

        public void MergeFaces(TopTools_ListOfShape S1, TopAbs_State TB1, TopTools_ListOfShape S2, TopAbs_State TB2,
            bool onA, bool onB)
        {
            throw new NotImplementedException();
        }

        public void MergeFaces(TopTools_ListOfShape S1, TopAbs_State TB1, TopTools_ListOfShape S2, TopAbs_State TB2,
            bool onA)
        {
            throw new NotImplementedException();
        }

        public void MergeFaces(TopTools_ListOfShape S1, TopAbs_State TB1, TopTools_ListOfShape S2, TopAbs_State TB2)
        {
            throw new NotImplementedException();
        }

        public void MergeSolids(TopoDS_Shape S1, TopAbs_State TB1, TopoDS_Shape S2, TopAbs_State TB2)
        {
            throw new NotImplementedException();
        }

        public void MergeShapes(TopoDS_Shape S1, TopAbs_State TB1, TopoDS_Shape S2, TopAbs_State TB2)
        {
            throw new NotImplementedException();
        }

        public void End()
        {
            throw new NotImplementedException();
        }

        public bool Classify()
        {
            throw new NotImplementedException();
        }

        public void ChangeClassify(bool B)
        {
            throw new NotImplementedException();
        }

        public void MergeSolid(TopoDS_Shape S, TopAbs_State TB)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape NewVertex(int I)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape NewEdges(int I)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape NewFaces(int I)
        {
            throw new NotImplementedException();
        }

        public bool IsSplit(TopoDS_Shape S, TopAbs_State TB)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Splits(TopoDS_Shape S, TopAbs_State TB)
        {
            throw new NotImplementedException();
        }

        public bool IsMerged(TopoDS_Shape S, TopAbs_State TB)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Merged(TopoDS_Shape S, TopAbs_State TB)
        {
            throw new NotImplementedException();
        }

        public void InitSection()
        {
            throw new NotImplementedException();
        }

        public void SplitSectionEdges()
        {
            throw new NotImplementedException();
        }

        public void SplitSectionEdge(TopoDS_Shape E)
        {
            throw new NotImplementedException();
        }

        public void SectionCurves(TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public void SectionEdges(TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public void FillSecEdgeAncestorMap(int aShapeRank, TopTools_MapOfShape aMapON,
            TopTools_DataMapOfShapeShape anAncMap)
        {
            throw new NotImplementedException();
        }

        public void Section(TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Section()
        {
            throw new NotImplementedException();
        }

        public void BuildVertices(TopOpeBRepDS_HDataStructure DS)
        {
            throw new NotImplementedException();
        }

        public void BuildEdges(TopOpeBRepDS_HDataStructure DS)
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_DataMapOfShapeListOfShapeOn1State MSplit(TopAbs_State s)
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_DataMapOfShapeListOfShapeOn1State ChangeMSplit(TopAbs_State s)
        {
            throw new NotImplementedException();
        }

        public void MakeEdges(TopoDS_Shape E, TopOpeBRepBuild_EdgeBuilder B, TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public void MakeFaces(TopoDS_Shape F, TopOpeBRepBuild_FaceBuilder B, TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public void MakeSolids(TopOpeBRepBuild_SolidBuilder B, TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public void MakeShells(TopOpeBRepBuild_SolidBuilder B, TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape ChangeSplit(TopoDS_Shape S, TopAbs_State TB)
        {
            throw new NotImplementedException();
        }

        public bool Opec12()
        {
            throw new NotImplementedException();
        }

        public bool Opec21()
        {
            throw new NotImplementedException();
        }

        public bool Opecom()
        {
            throw new NotImplementedException();
        }

        public bool Opefus()
        {
            throw new NotImplementedException();
        }

        public TopAbs_State ShapePosition(TopoDS_Shape S, TopTools_ListOfShape LS)
        {
            throw new NotImplementedException();
        }

        public bool KeepShape(TopoDS_Shape S, TopTools_ListOfShape LS, TopAbs_State T)
        {
            throw new NotImplementedException();
        }

        public TopAbs_ShapeEnum TopType(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool Reverse(TopAbs_State T1, TopAbs_State T2)
        {
            throw new NotImplementedException();
        }

        public TopAbs_Orientation Orient(TopAbs_Orientation O, bool R)
        {
            throw new NotImplementedException();
        }

        public void FindSameDomain(TopTools_ListOfShape L1, TopTools_ListOfShape L2)
        {
            throw new NotImplementedException();
        }

        public void FindSameDomainSameOrientation(TopTools_ListOfShape LSO, TopTools_ListOfShape LDO)
        {
            throw new NotImplementedException();
        }

        public void MapShapes(TopoDS_Shape S1, TopoDS_Shape S2)
        {
            throw new NotImplementedException();
        }

        public void ClearMaps()
        {
            throw new NotImplementedException();
        }

        public void FindSameRank(TopTools_ListOfShape L1, int R, TopTools_ListOfShape L2)
        {
            throw new NotImplementedException();
        }

        public int ShapeRank(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool IsShapeOf(TopoDS_Shape S, int I12)
        {
            throw new NotImplementedException();
        }

        public bool Contains(TopoDS_Shape S, TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public int FindIsKPart()
        {
            throw new NotImplementedException();
        }

        public int IsKPart()
        {
            throw new NotImplementedException();
        }

        public void MergeKPart()
        {
            throw new NotImplementedException();
        }

        public void MergeKPart(TopAbs_State TB1, TopAbs_State TB2)
        {
            throw new NotImplementedException();
        }

        public void MergeKPartiskole()
        {
            throw new NotImplementedException();
        }

        public void MergeKPartiskoletge()
        {
            throw new NotImplementedException();
        }

        public void MergeKPartisdisj()
        {
            throw new NotImplementedException();
        }

        public void MergeKPartisfafa()
        {
            throw new NotImplementedException();
        }

        public void MergeKPartissoso()
        {
            throw new NotImplementedException();
        }

        public int KPiskole()
        {
            throw new NotImplementedException();
        }

        public int KPiskoletge()
        {
            throw new NotImplementedException();
        }

        public int KPisdisj()
        {
            throw new NotImplementedException();
        }

        public int KPisfafa()
        {
            throw new NotImplementedException();
        }

        public int KPissoso()
        {
            throw new NotImplementedException();
        }

        public void KPClearMaps()
        {
            throw new NotImplementedException();
        }

        public int KPlhg(TopoDS_Shape S, TopAbs_ShapeEnum T, TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public int KPlhg(TopoDS_Shape S, TopAbs_ShapeEnum T)
        {
            throw new NotImplementedException();
        }

        public int KPlhsd(TopoDS_Shape S, TopAbs_ShapeEnum T, TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public int KPlhsd(TopoDS_Shape S, TopAbs_ShapeEnum T)
        {
            throw new NotImplementedException();
        }

        public TopAbs_State KPclasSS(TopoDS_Shape S1, TopTools_ListOfShape exceptLS1, TopoDS_Shape S2)
        {
            throw new NotImplementedException();
        }

        public TopAbs_State KPclasSS(TopoDS_Shape S1, TopoDS_Shape exceptS1, TopoDS_Shape S2)
        {
            throw new NotImplementedException();
        }

        public TopAbs_State KPclasSS(TopoDS_Shape S1, TopoDS_Shape S2)
        {
            throw new NotImplementedException();
        }

        public bool KPiskolesh(TopoDS_Shape S, TopTools_ListOfShape LS, TopTools_ListOfShape LF)
        {
            throw new NotImplementedException();
        }

        public bool KPiskoletgesh(TopoDS_Shape S, TopTools_ListOfShape LS, TopTools_ListOfShape LF)
        {
            throw new NotImplementedException();
        }

        public void KPSameDomain(TopTools_ListOfShape L1, TopTools_ListOfShape L2)
        {
            throw new NotImplementedException();
        }

        public int KPisdisjsh(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public int KPisfafash(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public int KPissososh(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void KPiskoleanalyse(TopAbs_State FT1, TopAbs_State FT2, TopAbs_State ST1, TopAbs_State ST2, ref int I,
            ref int I1, ref int I2)
        {
            throw new NotImplementedException();
        }

        public void KPiskoletgeanalyse(TopOpeBRepDS_Config Conf, TopAbs_State ST1, TopAbs_State ST2, ref int I)
        {
            throw new NotImplementedException();
        }

        public void KPisdisjanalyse(TopAbs_State ST1, TopAbs_State ST2, ref int I, ref int IC1, ref int IC2)
        {
            throw new NotImplementedException();
        }

        public int KPls(TopoDS_Shape S, TopAbs_ShapeEnum T, TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public int KPls(TopoDS_Shape S, TopAbs_ShapeEnum T)
        {
            throw new NotImplementedException();
        }

        public TopAbs_State KPclassF(TopoDS_Shape F1, TopoDS_Shape F2)
        {
            throw new NotImplementedException();
        }

        public void KPclassFF(TopoDS_Shape F1, TopoDS_Shape F2, ref TopAbs_State T1, ref TopAbs_State T2)
        {
            throw new NotImplementedException();
        }

        public bool KPiskoleFF(TopoDS_Shape F1, TopoDS_Shape F2, ref TopAbs_State T1, ref TopAbs_State T2)
        {
            throw new NotImplementedException();
        }

        public bool KPContains(TopoDS_Shape S, TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape KPmakeface(TopoDS_Shape F1, TopTools_ListOfShape LF2, TopAbs_State T1, TopAbs_State T2,
            bool R1, bool R2)
        {
            throw new NotImplementedException();
        }

        public int KPreturn(int KP)
        {
            throw new NotImplementedException();
        }

        public void SplitEvisoONperiodicF()
        {
            throw new NotImplementedException();
        }

        public void GMergeSolids(TopTools_ListOfShape LSO1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G)
        {
            throw new NotImplementedException();
        }

        public void GFillSolidsSFS(TopTools_ListOfShape LSO1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_ShellFaceSet SFS)
        {
            throw new NotImplementedException();
        }

        public void GFillSolidSFS(TopoDS_Shape SO1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_ShellFaceSet SFS)
        {
            throw new NotImplementedException();
        }

        public void GFillSurfaceTopologySFS(TopoDS_Shape SO1, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_ShellFaceSet SFS)
        {
            throw new NotImplementedException();
        }

        public void GFillSurfaceTopologySFS(TopOpeBRepDS_SurfaceIterator IT, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_ShellFaceSet SFS)
        {
            throw new NotImplementedException();
        }

        public void GFillShellSFS(TopoDS_Shape SH1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_ShellFaceSet SFS)
        {
            throw new NotImplementedException();
        }

        public void GFillFaceSFS(TopoDS_Shape F1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_ShellFaceSet SFS)
        {
            throw new NotImplementedException();
        }

        public void GSplitFaceSFS(TopoDS_Shape F1, TopTools_ListOfShape LSclass, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_ShellFaceSet SFS)
        {
            throw new NotImplementedException();
        }

        public void GMergeFaceSFS(TopoDS_Shape F, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_ShellFaceSet SFS)
        {
            throw new NotImplementedException();
        }

        public void GSplitFace(TopoDS_Shape F, TopOpeBRepBuild_GTopo G, TopTools_ListOfShape LSclass)
        {
            throw new NotImplementedException();
        }

        public void AddONPatchesSFS(TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_ShellFaceSet SFS)
        {
            throw new NotImplementedException();
        }

        public void FillOnPatches(TopTools_ListOfShape anEdgesON, TopoDS_Shape aBaseFace,
            TopTools_IndexedMapOfOrientedShape avoidMap)
        {
            throw new NotImplementedException();
        }

        public void FindFacesTouchingEdge(TopoDS_Shape aFace, TopoDS_Shape anEdge, int aShRank,
            TopTools_ListOfShape aFaces)
        {
            throw new NotImplementedException();
        }

        public void GMergeFaces(TopTools_ListOfShape LF1, TopTools_ListOfShape LF2, TopOpeBRepBuild_GTopo G)
        {
            throw new NotImplementedException();
        }

        public void GFillFacesWES(TopTools_ListOfShape LF1, TopTools_ListOfShape LF2, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_WireEdgeSet WES)
        {
            throw new NotImplementedException();
        }

        public void GFillFacesWESK(TopTools_ListOfShape LF1, TopTools_ListOfShape LF2, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_WireEdgeSet WES, int K)
        {
            throw new NotImplementedException();
        }

        public void GFillFacesWESMakeFaces(TopTools_ListOfShape LF1, TopTools_ListOfShape LF2, TopTools_ListOfShape LSO,
            TopOpeBRepBuild_GTopo G)
        {
            throw new NotImplementedException();
        }

        public void GFillFaceWES(TopoDS_Shape F, TopTools_ListOfShape LF2, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_WireEdgeSet WES)
        {
            throw new NotImplementedException();
        }

        public void GFillCurveTopologyWES(TopoDS_Shape F, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_WireEdgeSet WES)
        {
            throw new NotImplementedException();
        }

        public void GFillCurveTopologyWES(TopOpeBRepDS_CurveIterator IT, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_WireEdgeSet WES)
        {
            throw new NotImplementedException();
        }

        public void GFillONPartsWES(TopoDS_Shape F, TopOpeBRepBuild_GTopo G, TopTools_ListOfShape LSclass,
            TopOpeBRepBuild_WireEdgeSet WES)
        {
            throw new NotImplementedException();
        }

        public void GFillWireWES(TopoDS_Shape W, TopTools_ListOfShape LF2, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_WireEdgeSet WES)
        {
            throw new NotImplementedException();
        }

        public void GFillEdgeWES(TopoDS_Shape E, TopTools_ListOfShape LF2, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_WireEdgeSet WES)
        {
            throw new NotImplementedException();
        }

        public void GSplitEdgeWES(TopoDS_Shape E, TopTools_ListOfShape LF2, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_WireEdgeSet WES)
        {
            throw new NotImplementedException();
        }

        public void GMergeEdgeWES(TopoDS_Shape E, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_WireEdgeSet WES)
        {
            throw new NotImplementedException();
        }

        public void GSplitEdge(TopoDS_Shape E, TopOpeBRepBuild_GTopo G, TopTools_ListOfShape LSclass)
        {
            throw new NotImplementedException();
        }

        public void GMergeEdges(TopTools_ListOfShape LE1, TopTools_ListOfShape LE2, TopOpeBRepBuild_GTopo G)
        {
            throw new NotImplementedException();
        }

        public void GFillEdgesPVS(TopTools_ListOfShape LE1, TopTools_ListOfShape LE2, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_PaveSet PVS)
        {
            throw new NotImplementedException();
        }

        public void GFillEdgePVS(TopoDS_Shape E, TopTools_ListOfShape LE2, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_PaveSet PVS)
        {
            throw new NotImplementedException();
        }

        public void GFillPointTopologyPVS(TopoDS_Shape E, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_PaveSet PVS)
        {
            throw new NotImplementedException();
        }

        public void GFillPointTopologyPVS(TopoDS_Shape E, TopOpeBRepDS_PointIterator IT, TopOpeBRepBuild_GTopo G,
            TopOpeBRepBuild_PaveSet PVS)
        {
            throw new NotImplementedException();
        }

        public bool GParamOnReference(TopoDS_Vertex V, TopoDS_Edge E, ref double P)
        {
            throw new NotImplementedException();
        }

        public bool GKeepShape(TopoDS_Shape S, TopTools_ListOfShape L_ref, TopAbs_State T)
        {
            throw new NotImplementedException();
        }

        public bool GKeepShape1(TopoDS_Shape S, TopTools_ListOfShape L_ref, TopAbs_State T, ref TopAbs_State pos)
        {
            throw new NotImplementedException();
        }

        public void GKeepShapes(TopoDS_Shape S, TopTools_ListOfShape L_ref, TopAbs_State T, TopTools_ListOfShape Lin,
            TopTools_ListOfShape Lou)
        {
            throw new NotImplementedException();
        }

        public void GSFSMakeSolids(TopoDS_Shape SOF, TopOpeBRepBuild_ShellFaceSet SFS, TopTools_ListOfShape LOSO)
        {
            throw new NotImplementedException();
        }

        public void GSOBUMakeSolids(TopoDS_Shape SOF, TopOpeBRepBuild_SolidBuilder SOBU, TopTools_ListOfShape LOSO)
        {
            throw new NotImplementedException();
        }

        public void GWESMakeFaces(TopoDS_Shape FF, TopOpeBRepBuild_WireEdgeSet WES, TopTools_ListOfShape LOF)
        {
            throw new NotImplementedException();
        }

        public void GFABUMakeFaces(TopoDS_Shape FF, TopOpeBRepBuild_FaceBuilder FABU, TopTools_ListOfShape LOF,
            TopTools_DataMapOfShapeInteger MW_isOld)
        {
            throw new NotImplementedException();
        }

        public void RegularizeFaces(TopoDS_Shape FF, TopTools_ListOfShape lnewFace, TopTools_ListOfShape LOF)
        {
            throw new NotImplementedException();
        }

        public void RegularizeFace(TopoDS_Shape FF, TopoDS_Shape newFace, TopTools_ListOfShape LOF)
        {
            throw new NotImplementedException();
        }

        public void RegularizeSolids(TopoDS_Shape SS, TopTools_ListOfShape lnewSolid, TopTools_ListOfShape LOS)
        {
            throw new NotImplementedException();
        }

        public void RegularizeSolid(TopoDS_Shape SS, TopoDS_Shape newSolid, TopTools_ListOfShape LOS)
        {
            throw new NotImplementedException();
        }

        public void GPVSMakeEdges(TopoDS_Shape EF, TopOpeBRepBuild_PaveSet PVS, TopTools_ListOfShape LOE)
        {
            throw new NotImplementedException();
        }

        public void GEDBUMakeEdges(TopoDS_Shape EF, TopOpeBRepBuild_EdgeBuilder EDBU, TopTools_ListOfShape LOE)
        {
            throw new NotImplementedException();
        }

        public bool GToSplit(TopoDS_Shape S, TopAbs_State TB)
        {
            throw new NotImplementedException();
        }

        public bool GToMerge(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool GTakeCommonOfSame(TopOpeBRepBuild_GTopo G)
        {
            throw new NotImplementedException();
        }

        public bool GTakeCommonOfDiff(TopOpeBRepBuild_GTopo G)
        {
            throw new NotImplementedException();
        }

        public void GFindSamDom(TopoDS_Shape S, TopTools_ListOfShape L1, TopTools_ListOfShape L2)
        {
            throw new NotImplementedException();
        }

        public void GFindSamDom(TopTools_ListOfShape L1, TopTools_ListOfShape L2)
        {
            throw new NotImplementedException();
        }

        public void GFindSamDomSODO(TopoDS_Shape S, TopTools_ListOfShape LSO, TopTools_ListOfShape LDO)
        {
            throw new NotImplementedException();
        }

        public void GFindSamDomSODO(TopTools_ListOfShape LSO, TopTools_ListOfShape LDO)
        {
            throw new NotImplementedException();
        }

        public void GMapShapes(TopoDS_Shape S1, TopoDS_Shape S2)
        {
            throw new NotImplementedException();
        }

        public void GClearMaps()
        {
            throw new NotImplementedException();
        }

        public void GFindSameRank(TopTools_ListOfShape L1, int R, TopTools_ListOfShape L2)
        {
            throw new NotImplementedException();
        }

        public int GShapeRank(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool GIsShapeOf(TopoDS_Shape S, int I12)
        {
            throw new NotImplementedException();
        }

        public bool GContains(TopoDS_Shape S, TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public void GCopyList(TopTools_ListOfShape Lin, int i1, int i2, TopTools_ListOfShape Lou)
        {
            throw new NotImplementedException();
        }

        public void GCopyList(TopTools_ListOfShape Lin, TopTools_ListOfShape Lou)
        {
            throw new NotImplementedException();
        }

        public void GdumpLS(TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public void GdumpPNT(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void GdumpORIPARPNT(TopAbs_Orientation o, double p, gp_Pnt Pnt)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHA(TopoDS_Shape S, IntPtr str)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHA(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHAORI(TopoDS_Shape S, IntPtr str)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHAORI(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHAORIGEO(TopoDS_Shape S, IntPtr str)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHAORIGEO(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHASTA(int iS, TopAbs_State T, TCollection_AsciiString a, TCollection_AsciiString b)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHASTA(int iS, TopAbs_State T, TCollection_AsciiString a)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHASTA(int iS, TopAbs_State T)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHASTA(TopoDS_Shape S, TopAbs_State T, TCollection_AsciiString a, TCollection_AsciiString b)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHASTA(TopoDS_Shape S, TopAbs_State T, TCollection_AsciiString a)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHASTA(TopoDS_Shape S, TopAbs_State T)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHASTA(int iS, TopAbs_State T, TopOpeBRepBuild_ShapeSet SS, TCollection_AsciiString a,
            TCollection_AsciiString b, TCollection_AsciiString c)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHASTA(int iS, TopAbs_State T, TopOpeBRepBuild_ShapeSet SS, TCollection_AsciiString a,
            TCollection_AsciiString b)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHASTA(int iS, TopAbs_State T, TopOpeBRepBuild_ShapeSet SS, TCollection_AsciiString a)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHASTA(int iS, TopAbs_State T, TopOpeBRepBuild_ShapeSet SS)
        {
            throw new NotImplementedException();
        }

        public void GdumpEDG(TopoDS_Shape S, IntPtr str)
        {
            throw new NotImplementedException();
        }

        public void GdumpEDG(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void GdumpEDGVER(TopoDS_Shape E, TopoDS_Shape V, IntPtr str)
        {
            throw new NotImplementedException();
        }

        public void GdumpEDGVER(TopoDS_Shape E, TopoDS_Shape V)
        {
            throw new NotImplementedException();
        }

        public void GdumpSAMDOM(TopTools_ListOfShape L, IntPtr str)
        {
            throw new NotImplementedException();
        }

        public void GdumpSAMDOM(TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public void GdumpEXP(TopOpeBRepTool_ShapeExplorer E)
        {
            throw new NotImplementedException();
        }

        public void GdumpSOBU(TopOpeBRepBuild_SolidBuilder SB)
        {
            throw new NotImplementedException();
        }

        public void GdumpFABU(TopOpeBRepBuild_FaceBuilder FB)
        {
            throw new NotImplementedException();
        }

        public void GdumpEDBU(TopOpeBRepBuild_EdgeBuilder EB)
        {
            throw new NotImplementedException();
        }

        public bool GtraceSPS(int iS)
        {
            throw new NotImplementedException();
        }

        public bool GtraceSPS(int iS, int jS)
        {
            throw new NotImplementedException();
        }

        public bool GtraceSPS(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool GtraceSPS(TopoDS_Shape S, ref int IS)
        {
            throw new NotImplementedException();
        }

        public void GdumpSHASETreset()
        {
            throw new NotImplementedException();
        }

        public int GdumpSHASETindex()
        {
            throw new NotImplementedException();
        }

        public void PrintGeo(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void PrintSur(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public void PrintCur(TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public void PrintPnt(TopoDS_Vertex V)
        {
            throw new NotImplementedException();
        }

        public void PrintOri(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString StringState(TopAbs_State S)
        {
            throw new NotImplementedException();
        }

        public bool GcheckNBOUNDS(TopoDS_Shape E)
        {
            throw new NotImplementedException();
        }

        public void BuildEdges(int iC, TopOpeBRepDS_HDataStructure DS)
        {
            throw new NotImplementedException();
        }

        public void BuildFaces(int iS, TopOpeBRepDS_HDataStructure DS)
        {
            throw new NotImplementedException();
        }

        public void BuildFaces(TopOpeBRepDS_HDataStructure DS)
        {
            throw new NotImplementedException();
        }

        public void SplitEdge(TopoDS_Shape E1, TopAbs_State TB1, TopAbs_State TB2)
        {
            throw new NotImplementedException();
        }

        public void SplitEdge1(TopoDS_Shape E1, TopAbs_State TB1, TopAbs_State TB2)
        {
            throw new NotImplementedException();
        }

        public void SplitEdge2(TopoDS_Shape E1, TopAbs_State TB1, TopAbs_State TB2)
        {
            throw new NotImplementedException();
        }

        public void SplitFace(TopoDS_Shape F1, TopAbs_State TB1, TopAbs_State TB2)
        {
            throw new NotImplementedException();
        }

        public void SplitFace1(TopoDS_Shape F1, TopAbs_State TB1, TopAbs_State TB2)
        {
            throw new NotImplementedException();
        }

        public void SplitFace2(TopoDS_Shape F1, TopAbs_State TB1, TopAbs_State TB2)
        {
            throw new NotImplementedException();
        }

        public void SplitSolid(TopoDS_Shape S1, TopAbs_State TB1, TopAbs_State TB2)
        {
            throw new NotImplementedException();
        }

        public void SplitShapes(TopOpeBRepTool_ShapeExplorer Ex, TopAbs_State TB1, TopAbs_State TB2,
            TopOpeBRepBuild_ShapeSet SS, bool RevOri)
        {
            throw new NotImplementedException();
        }

        public void FillFace(TopoDS_Shape F1, TopAbs_State TB1, TopTools_ListOfShape LF2, TopAbs_State TB2,
            TopOpeBRepBuild_WireEdgeSet WES, bool RevOri)
        {
            throw new NotImplementedException();
        }

        public void FillSolid(TopoDS_Shape S1, TopAbs_State TB1, TopTools_ListOfShape LS2, TopAbs_State TB2,
            TopOpeBRepBuild_ShapeSet SS, bool RevOri)
        {
            throw new NotImplementedException();
        }

        public void FillShape(TopoDS_Shape S1, TopAbs_State TB1, TopTools_ListOfShape LS2, TopAbs_State TB2,
            TopOpeBRepBuild_ShapeSet SS, bool RevOri)
        {
            throw new NotImplementedException();
        }

        public void FillVertexSet(TopOpeBRepDS_PointIterator IT, TopAbs_State TB, TopOpeBRepBuild_PaveSet PVS)
        {
            throw new NotImplementedException();
        }

        public void FillVertexSetOnValue(TopOpeBRepDS_PointIterator IT, TopAbs_State TB, TopOpeBRepBuild_PaveSet PVS)
        {
            throw new NotImplementedException();
        }

        public bool ToSplit(TopoDS_Shape S, TopAbs_State TB)
        {
            throw new NotImplementedException();
        }

        public void MarkSplit(TopoDS_Shape S, TopAbs_State TB, bool B)
        {
            throw new NotImplementedException();
        }

        public void MarkSplit(TopoDS_Shape S, TopAbs_State TB)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape ChangeMerged(TopoDS_Shape S, TopAbs_State TB)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape ChangeNewVertex(int I)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape ChangeNewEdges(int I)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape ChangeNewFaces(int I)
        {
            throw new NotImplementedException();
        }

        public void AddIntersectionEdges(TopoDS_Shape F, TopAbs_State TB, bool RevOri, TopOpeBRepBuild_ShapeSet ES)
        {
            throw new NotImplementedException();
        }

        public void UpdateSplitAndMerged(TopTools_DataMapOfIntegerListOfShape mle, TopTools_DataMapOfIntegerShape mre,
            TopTools_DataMapOfShapeShape mlf, TopAbs_State state)
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRepBuild_Builder
}