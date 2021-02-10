//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKOffset.BRepOffsetAPI
{
    //---------------------------------------------------------------------
    //  Class  BRepOffsetAPI_MakeDraft
    //---------------------------------------------------------------------
    public sealed class BRepOffsetAPI_MakeDraft : BRepBuilderAPI_MakeShape
    {
        public BRepOffsetAPI_MakeDraft(TopoDS_Shape Shape, gp_Dir Dir, double Angle)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakeDraft(BRepOffsetAPI_MakeDraft parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffsetAPI_MakeDraft()
        {
            throw new NotImplementedException();
        }

        public void SetOptions(BRepBuilderAPI_TransitionMode Style, double AngleMin, double AngleMax)
        {
            throw new NotImplementedException();
        }

        public void SetOptions(BRepBuilderAPI_TransitionMode Style, double AngleMin)
        {
            throw new NotImplementedException();
        }

        public void SetOptions(BRepBuilderAPI_TransitionMode Style)
        {
            throw new NotImplementedException();
        }

        public void SetOptions()
        {
            throw new NotImplementedException();
        }

        public void SetDraft(bool IsInternal)
        {
            throw new NotImplementedException();
        }

        public void SetDraft()
        {
            throw new NotImplementedException();
        }

        public void Perform(double LengthMax)
        {
            throw new NotImplementedException();
        }

        public void Perform(Geom_Surface Surface, bool KeepInsideSurface)
        {
            throw new NotImplementedException();
        }

        public void Perform(Geom_Surface Surface)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Shape StopShape, bool KeepOutSide)
        {
            throw new NotImplementedException();
        }

        public void Perform(TopoDS_Shape StopShape)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shell Shell()
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Generated(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }
    }; // class BRepOffsetAPI_MakeDraft
}