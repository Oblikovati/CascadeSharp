//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKG3d.GeomAdaptor;
using CascadeSharp.TKGeomAlgo.IntPatch;

namespace CascadeSharp.TKGeomAlgo.GeomInt
{
    //---------------------------------------------------------------------
    //  Class  GeomInt_LineConstructor
    //---------------------------------------------------------------------
    public sealed class GeomInt_LineConstructor
    {
        public GeomInt_LineConstructor()
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomInt_LineConstructor(GeomInt_LineConstructor parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Load(Adaptor3d_TopolTool D1, Adaptor3d_TopolTool D2, GeomAdaptor_HSurface S1,
            GeomAdaptor_HSurface S2)
        {
            throw new NotImplementedException();
        }

        public void Perform(IntPatch_Line L)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public int NbParts()
        {
            throw new NotImplementedException();
        }

        public void Part(int I, ref double WFirst, ref double WLast)
        {
            throw new NotImplementedException();
        }

        public void TreatCircle(IntPatch_Line aLine, double aTol)
        {
            throw new NotImplementedException();
        }
    }; // class GeomInt_LineConstructor
}