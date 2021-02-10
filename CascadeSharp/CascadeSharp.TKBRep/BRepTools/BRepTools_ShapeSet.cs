//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRep;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.BRepTools
{
    //---------------------------------------------------------------------
    //  Class  BRepTools_ShapeSet
    //---------------------------------------------------------------------
    public sealed class BRepTools_ShapeSet : TopTools_ShapeSet
    {
        public BRepTools_ShapeSet(bool _isWithTriangles)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepTools_ShapeSet(BRep_Builder B, bool _isWithTriangles)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepTools_ShapeSet(BRep_Builder B)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepTools_ShapeSet(BRepTools_ShapeSet parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepTools_ShapeSet()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void AddGeometry(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void AddShapes(TopoDS_Shape S1, TopoDS_Shape S2)
        {
            throw new NotImplementedException();
        }

        public void Check(TopAbs_ShapeEnum T, TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }
    }; // class BRepTools_ShapeSet
}