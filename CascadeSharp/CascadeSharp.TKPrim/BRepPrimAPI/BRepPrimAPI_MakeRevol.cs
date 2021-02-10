//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKPrim.BRepSweep;

namespace CascadeSharp.TKPrim.BRepPrimAPI
{
    //---------------------------------------------------------------------
    //  Class  BRepPrimAPI_MakeRevol
    //---------------------------------------------------------------------
    public sealed class BRepPrimAPI_MakeRevol : BRepPrimAPI_MakeSweep
    {
        public BRepPrimAPI_MakeRevol(TopoDS_Shape S, gp_Ax1 A, double D, bool Copy)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrimAPI_MakeRevol(TopoDS_Shape S, gp_Ax1 A, double D)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrimAPI_MakeRevol(TopoDS_Shape S, gp_Ax1 A, bool Copy)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrimAPI_MakeRevol(TopoDS_Shape S, gp_Ax1 A)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrimAPI_MakeRevol(BRepPrimAPI_MakeRevol parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepPrimAPI_MakeRevol()
        {
            throw new NotImplementedException();
        }

        public BRepSweep_Revol Revol()
        {
            throw new NotImplementedException();
        }

        public void Build()
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

        public bool IsDeleted(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape FirstShape(TopoDS_Shape theShape)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape LastShape(TopoDS_Shape theShape)
        {
            throw new NotImplementedException();
        }

        public bool HasDegenerated()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Degenerated()
        {
            throw new NotImplementedException();
        }

        public bool CheckValidity(TopoDS_Shape theShape, gp_Ax1 theA)
        {
            throw new NotImplementedException();
        }
    }; // class BRepPrimAPI_MakeRevol
}