//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKernel;
using CascadeSharp.TKGeomAlgo.GeomFill;
using CascadeSharp.TKGeomAlgo.Law;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBool.BRepFill
{
    //---------------------------------------------------------------------
    //  Class  BRepFill_PipeShell
    //---------------------------------------------------------------------
    public sealed class BRepFill_PipeShell : Standard_Transient
    {
        public BRepFill_PipeShell(TopoDS_Wire Spine)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_PipeShell(BRepFill_PipeShell parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_PipeShell()
        {
            throw new NotImplementedException();
        }

        public void Set(bool Frenet)
        {
            throw new NotImplementedException();
        }

        public void Set()
        {
            throw new NotImplementedException();
        }

        public void SetDiscrete()
        {
            throw new NotImplementedException();
        }

        public void Set(gp_Ax2 Axe)
        {
            throw new NotImplementedException();
        }

        public void Set(gp_Dir BiNormal)
        {
            throw new NotImplementedException();
        }

        public bool Set(TopoDS_Shape SpineSupport)
        {
            throw new NotImplementedException();
        }

        public void Set(TopoDS_Wire AuxiliarySpine, bool CurvilinearEquivalence, BRepFill_TypeOfContact KeepContact)
        {
            throw new NotImplementedException();
        }

        public void Set(TopoDS_Wire AuxiliarySpine, bool CurvilinearEquivalence)
        {
            throw new NotImplementedException();
        }

        public void Set(TopoDS_Wire AuxiliarySpine)
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

        public void DeleteProfile(TopoDS_Shape Profile)
        {
            throw new NotImplementedException();
        }

        public bool IsReady()
        {
            throw new NotImplementedException();
        }

        public GeomFill_PipeError GetStatus()
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

        public void SetTransition(BRepFill_TransitionStyle Mode, double Angmin, double Angmax)
        {
            throw new NotImplementedException();
        }

        public void SetTransition(BRepFill_TransitionStyle Mode, double Angmin)
        {
            throw new NotImplementedException();
        }

        public void SetTransition(BRepFill_TransitionStyle Mode)
        {
            throw new NotImplementedException();
        }

        public void SetTransition()
        {
            throw new NotImplementedException();
        }

        public void Simulate(int NumberOfSection, TopTools_ListOfShape Sections)
        {
            throw new NotImplementedException();
        }

        public bool Build()
        {
            throw new NotImplementedException();
        }

        public bool MakeSolid()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape()
        {
            throw new NotImplementedException();
        }

        public double ErrorOnSurface()
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

        public void Profiles(TopTools_ListOfShape theProfiles)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Wire Spine()
        {
            throw new NotImplementedException();
        }

        public void Generated(TopoDS_Shape S, TopTools_ListOfShape L)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void Prepare()
        {
            throw new NotImplementedException();
        }

        public void Place(BRepFill_Section Sec, TopoDS_Wire W, gp_Trsf Trsf, ref double param)
        {
            throw new NotImplementedException();
        }

        public void ResetLoc()
        {
            throw new NotImplementedException();
        }

        public void BuildHistory(BRepFill_Sweep theSweep)
        {
            throw new NotImplementedException();
        }
    }; // class BRepFill_PipeShell
}