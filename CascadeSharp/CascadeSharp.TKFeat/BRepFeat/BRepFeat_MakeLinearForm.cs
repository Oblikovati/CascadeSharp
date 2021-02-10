//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKFeat.BRepFeat
{
    //---------------------------------------------------------------------
    //  Class  BRepFeat_MakeLinearForm
    //---------------------------------------------------------------------
    public sealed class BRepFeat_MakeLinearForm : BRepFeat_RibSlot
    {
        public BRepFeat_MakeLinearForm()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFeat_MakeLinearForm(TopoDS_Shape Sbase, TopoDS_Wire W, Geom_Plane P, gp_Vec Direction,
            gp_Vec Direction1, int Fuse, bool Modify)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepFeat_MakeLinearForm(BRepFeat_MakeLinearForm parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Shape Sbase, TopoDS_Wire W, Geom_Plane P, gp_Vec Direction, gp_Vec Direction1, int Fuse,
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

        public void TransformShapeFU(int flag)
        {
            throw new NotImplementedException();
        }

        public bool Propagate(TopTools_ListOfShape L, TopoDS_Face F, gp_Pnt FPoint, gp_Pnt LPoint, ref bool falseside)
        {
            throw new NotImplementedException();
        }
    }; // class BRepFeat_MakeLinearForm
}