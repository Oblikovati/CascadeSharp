//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.BRepFill;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKOffset.BRepOffsetAPI
{
    //---------------------------------------------------------------------
    //  Class  BRepOffsetAPI_MakeEvolved
    //---------------------------------------------------------------------
    public sealed class BRepOffsetAPI_MakeEvolved : BRepBuilderAPI_MakeShape
    {
        public BRepOffsetAPI_MakeEvolved()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakeEvolved(TopoDS_Shape theSpine, TopoDS_Wire theProfile, GeomAbs_JoinType theJoinType,
            bool theIsAxeProf, bool theIsSolid, bool theIsProfOnSpine, double theTol, bool theIsVolume,
            bool theRunInParallel)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakeEvolved(TopoDS_Shape theSpine, TopoDS_Wire theProfile, GeomAbs_JoinType theJoinType,
            bool theIsAxeProf, bool theIsSolid, bool theIsProfOnSpine, double theTol, bool theIsVolume)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakeEvolved(TopoDS_Shape theSpine, TopoDS_Wire theProfile, GeomAbs_JoinType theJoinType,
            bool theIsAxeProf, bool theIsSolid, bool theIsProfOnSpine, double theTol)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakeEvolved(TopoDS_Shape theSpine, TopoDS_Wire theProfile, GeomAbs_JoinType theJoinType,
            bool theIsAxeProf, bool theIsSolid, bool theIsProfOnSpine)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakeEvolved(TopoDS_Shape theSpine, TopoDS_Wire theProfile, GeomAbs_JoinType theJoinType,
            bool theIsAxeProf, bool theIsSolid)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakeEvolved(TopoDS_Shape theSpine, TopoDS_Wire theProfile, GeomAbs_JoinType theJoinType,
            bool theIsAxeProf)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakeEvolved(TopoDS_Shape theSpine, TopoDS_Wire theProfile, GeomAbs_JoinType theJoinType)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakeEvolved(TopoDS_Shape theSpine, TopoDS_Wire theProfile)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakeEvolved(BRepOffsetAPI_MakeEvolved parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFill_Evolved Evolved()
        {
            throw new NotImplementedException();
        }

        public void Build()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape GeneratedShapes(TopoDS_Shape SpineShape, TopoDS_Shape ProfShape)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Top()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Bottom()
        {
            throw new NotImplementedException();
        }
    }; // class BRepOffsetAPI_MakeEvolved
}