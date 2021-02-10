//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.BRepFill;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKGeomAlgo.Law;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKPrim.BRepPrimAPI;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKOffset.BRepOffsetAPI
{
    //---------------------------------------------------------------------
    //  Class  BRepOffsetAPI_MakePipeShell
    //---------------------------------------------------------------------
    public sealed class BRepOffsetAPI_MakePipeShell : BRepPrimAPI_MakeSweep
    {
        public BRepOffsetAPI_MakePipeShell(TopoDS_Wire Spine)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakePipeShell(BRepOffsetAPI_MakePipeShell parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakePipeShell()
        {
            throw new NotImplementedException();
        }

        public void SetMode(bool IsFrenet)
        {
            throw new NotImplementedException();
        }

        public void SetMode()
        {
            throw new NotImplementedException();
        }

        public void SetDiscreteMode()
        {
            throw new NotImplementedException();
        }

        public void SetMode(gp_Ax2 Axe)
        {
            throw new NotImplementedException();
        }

        public void SetMode(gp_Dir BiNormal)
        {
            throw new NotImplementedException();
        }

        public bool SetMode(TopoDS_Shape SpineSupport)
        {
            throw new NotImplementedException();
        }

        public void SetMode(TopoDS_Wire AuxiliarySpine, bool CurvilinearEquivalence, BRepFill_TypeOfContact KeepContact)
        {
            throw new NotImplementedException();
        }

        public void SetMode(TopoDS_Wire AuxiliarySpine, bool CurvilinearEquivalence)
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Shape Profile, bool WithContact, bool WithCorrection)
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Shape Profile, bool WithContact)
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Shape Profile)
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Shape Profile, TopoDS_Vertex Location, bool WithContact, bool WithCorrection)
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Shape Profile, TopoDS_Vertex Location, bool WithContact)
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Shape Profile, TopoDS_Vertex Location)
        {
            throw new NotImplementedException();
        }

        public void SetLaw(TopoDS_Shape Profile, Law_Function L, bool WithContact, bool WithCorrection)
        {
            throw new NotImplementedException();
        }

        public void SetLaw(TopoDS_Shape Profile, Law_Function L, bool WithContact)
        {
            throw new NotImplementedException();
        }

        public void SetLaw(TopoDS_Shape Profile, Law_Function L)
        {
            throw new NotImplementedException();
        }

        public void SetLaw(TopoDS_Shape Profile, Law_Function L, TopoDS_Vertex Location, bool WithContact,
            bool WithCorrection)
        {
            throw new NotImplementedException();
        }

        public void SetLaw(TopoDS_Shape Profile, Law_Function L, TopoDS_Vertex Location, bool WithContact)
        {
            throw new NotImplementedException();
        }

        public void SetLaw(TopoDS_Shape Profile, Law_Function L, TopoDS_Vertex Location)
        {
            throw new NotImplementedException();
        }

        public void Delete(TopoDS_Shape Profile)
        {
            throw new NotImplementedException();
        }

        public bool IsReady()
        {
            throw new NotImplementedException();
        }

        public BRepBuilderAPI_PipeError GetStatus()
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(double Tol3d, double BoundTol, double TolAngular)
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(double Tol3d, double BoundTol)
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(double Tol3d)
        {
            throw new NotImplementedException();
        }

        public void SetTolerance()
        {
            throw new NotImplementedException();
        }

        public void SetMaxDegree(int NewMaxDegree)
        {
            throw new NotImplementedException();
        }

        public void SetMaxSegments(int NewMaxSegments)
        {
            throw new NotImplementedException();
        }

        public void SetForceApproxC1(bool ForceApproxC1)
        {
            throw new NotImplementedException();
        }

        public void SetTransitionMode(BRepBuilderAPI_TransitionMode Mode)
        {
            throw new NotImplementedException();
        }

        public void SetTransitionMode()
        {
            throw new NotImplementedException();
        }

        public void Simulate(int NumberOfSection, TopTools_ListOfShape Result)
        {
            throw new NotImplementedException();
        }

        public void Build()
        {
            throw new NotImplementedException();
        }

        public bool MakeSolid()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape FirstShape()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape LastShape()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Generated(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public double ErrorOnSurface()
        {
            throw new NotImplementedException();
        }

        public void Profiles(TopTools_ListOfShape theProfiles)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Wire Spine()
        {
            throw new NotImplementedException();
        }
    }; // class BRepOffsetAPI_MakePipeShell
}