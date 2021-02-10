//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.BRep
{
    //---------------------------------------------------------------------
    //  Class  BRep_TFace
    //---------------------------------------------------------------------
    public sealed class BRep_TFace : TopoDS_TFace
    {
        public BRep_TFace()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRep_TFace(BRep_TFace parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Surface Surface()
        {
            throw new NotImplementedException();
        }

        public TopLoc_Location Location()
        {
            throw new NotImplementedException();
        }

        public double Tolerance()
        {
            throw new NotImplementedException();
        }

        public void Surface(Geom_Surface S)
        {
            throw new NotImplementedException();
        }

        public void Location(TopLoc_Location L)
        {
            throw new NotImplementedException();
        }

        public void Tolerance(double T)
        {
            throw new NotImplementedException();
        }

        public bool NaturalRestriction()
        {
            throw new NotImplementedException();
        }

        public void NaturalRestriction(bool N)
        {
            throw new NotImplementedException();
        }

        public TopoDS_TShape EmptyCopy()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class BRep_TFace
}