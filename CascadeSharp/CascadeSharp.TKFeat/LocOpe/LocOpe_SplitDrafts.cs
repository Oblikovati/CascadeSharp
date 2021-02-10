//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKFeat.LocOpe
{
    //---------------------------------------------------------------------
    //  Class  LocOpe_SplitDrafts
    //---------------------------------------------------------------------
    public sealed class LocOpe_SplitDrafts
    {
        public LocOpe_SplitDrafts()
            : base()
        {
            throw new NotImplementedException();
        }

        public LocOpe_SplitDrafts(TopoDS_Shape S)
            : base()
        {
            throw new NotImplementedException();
        }

        public LocOpe_SplitDrafts(LocOpe_SplitDrafts parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Face F, TopoDS_Wire W, gp_Dir Extractg, gp_Pln NPlg, double Angleg, gp_Dir Extractd,
            gp_Pln NPld, double Angled, bool ModifyLeft, bool ModifyRight)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Face F, TopoDS_Wire W, gp_Dir Extractg, gp_Pln NPlg, double Angleg, gp_Dir Extractd,
            gp_Pln NPld, double Angled, bool ModifyLeft)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Face F, TopoDS_Wire W, gp_Dir Extractg, gp_Pln NPlg, double Angleg, gp_Dir Extractd,
            gp_Pln NPld, double Angled)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Face F, TopoDS_Wire W, gp_Dir Extract, gp_Pln NPl, double Angle)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape OriginalShape()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape ShapesFromShape(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }
    }; // class LocOpe_SplitDrafts
}