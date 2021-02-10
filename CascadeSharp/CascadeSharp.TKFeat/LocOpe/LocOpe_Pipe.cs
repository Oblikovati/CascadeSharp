//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TColGeom;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKFeat.LocOpe
{
    //---------------------------------------------------------------------
    //  Class  LocOpe_Pipe
    //---------------------------------------------------------------------
    public sealed class LocOpe_Pipe
    {
        public LocOpe_Pipe(TopoDS_Wire Spine, TopoDS_Shape Profile)
            : base()
        {
            throw new NotImplementedException();
        }

        public LocOpe_Pipe(LocOpe_Pipe parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public LocOpe_Pipe()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Spine()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Profile()
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

        public TopoDS_Shape Shape()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Shapes(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public TColGeom_SequenceOfCurve Curves(TColgp_SequenceOfPnt Spt)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve BarycCurve()
        {
            throw new NotImplementedException();
        }
    }; // class LocOpe_Pipe
}