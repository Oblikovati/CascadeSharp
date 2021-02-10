//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TColGeom;

namespace CascadeSharp.TKFeat.BRepFeat
{
    //---------------------------------------------------------------------
    //  Class  BRepFeat_MakePipe
    //---------------------------------------------------------------------
    public sealed class BRepFeat_MakePipe : BRepFeat_Form
    {
        public BRepFeat_MakePipe()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFeat_MakePipe(TopoDS_Shape Sbase, TopoDS_Shape Pbase, TopoDS_Face Skface, TopoDS_Wire Spine,
            int Fuse, bool Modify)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFeat_MakePipe(BRepFeat_MakePipe parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Shape Sbase, TopoDS_Shape Pbase, TopoDS_Face Skface, TopoDS_Wire Spine, int Fuse,
            bool Modify)
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Edge E, TopoDS_Face OnFace)
        {
            throw new NotImplementedException();
        }

        public void Perform()
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Shape Until)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Shape From, TopoDS_Shape Until)
        {
            throw new NotImplementedException();
        }

        public void Curves(TColGeom_SequenceOfCurve S)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve BarycCurve()
        {
            throw new NotImplementedException();
        }
    }; // class BRepFeat_MakePipe
}