//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.Geom;

namespace CascadeSharp.TKOffset.BRepOffset
{
    //---------------------------------------------------------------------
    //  Class  BRepOffset
    //---------------------------------------------------------------------
    public sealed class BRepOffset
    {
        public BRepOffset()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepOffset(BRepOffset parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Surface Surface(Geom_Surface Surface, double Offset, ref BRepOffset_Status theStatus, bool allowC0)
        {
            throw new NotImplementedException();
        }

        public Geom_Surface Surface(Geom_Surface Surface, double Offset, ref BRepOffset_Status theStatus)
        {
            throw new NotImplementedException();
        }

        public Geom_Surface CollapseSingularities(Geom_Surface theSurface, TopoDS_Face theFace, double thePrec_ision)
        {
            throw new NotImplementedException();
        }
    }; // class BRepOffset
}