//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;

namespace CascadeSharp.TKTopAlgo.BRepCheck
{
    //---------------------------------------------------------------------
    //  Class  BRepCheck_Wire
    //---------------------------------------------------------------------
    public sealed class BRepCheck_Wire : BRepCheck_Result
    {
        public BRepCheck_Wire(TopoDS_Wire W)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Wire(BRepCheck_Wire parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Wire()
        {
            throw new NotImplementedException();
        }

        public void InContext(TopoDS_Shape ContextShape)
        {
            throw new NotImplementedException();
        }

        public void Minimum()
        {
            throw new NotImplementedException();
        }

        public void Blind()
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Status Closed(bool Update)
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Status Closed()
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Status Closed2d(TopoDS_Face F, bool Update)
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Status Closed2d(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Status Orientation(TopoDS_Face F, bool Update)
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Status Orientation(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Status SelfIntersect(TopoDS_Face F, TopoDS_Edge E1, TopoDS_Edge E2, bool Update)
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Status SelfIntersect(TopoDS_Face F, TopoDS_Edge E1, TopoDS_Edge E2)
        {
            throw new NotImplementedException();
        }

        public bool GeometricControls()
        {
            throw new NotImplementedException();
        }

        public void GeometricControls(bool B)
        {
            throw new NotImplementedException();
        }

        public void SetStatus(BRepCheck_Status theStatus)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class BRepCheck_Wire
}