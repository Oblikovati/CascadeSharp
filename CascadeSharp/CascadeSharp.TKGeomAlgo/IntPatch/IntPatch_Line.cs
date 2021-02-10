//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKGeomAlgo.IntSurf;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
    //---------------------------------------------------------------------
    //  Class  IntPatch_Line
    //---------------------------------------------------------------------
    public class IntPatch_Line : Standard_Transient
    {
        public IntPatch_Line(bool Tang, IntSurf_TypeTrans Trans1, IntSurf_TypeTrans Trans2)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_Line(bool Tang, IntSurf_Situation Situ1, IntSurf_Situation Situ2)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_Line(bool Tang)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_Line(IntPatch_Line parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_Line()
        {
            throw new NotImplementedException();
        }

        public void SetValue(bool U_iso1, bool V_iso1, bool U_iso2, bool V_iso2)
        {
            throw new NotImplementedException();
        }

        public IntPatch_IType ArcType()
        {
            throw new NotImplementedException();
        }

        public bool IsTangent()
        {
            throw new NotImplementedException();
        }

        public IntSurf_TypeTrans TransitionOnS1()
        {
            throw new NotImplementedException();
        }

        public IntSurf_TypeTrans TransitionOnS2()
        {
            throw new NotImplementedException();
        }

        public IntSurf_Situation SituationS1()
        {
            throw new NotImplementedException();
        }

        public IntSurf_Situation SituationS2()
        {
            throw new NotImplementedException();
        }

        public bool IsUIsoOnS1()
        {
            throw new NotImplementedException();
        }

        public bool IsVIsoOnS1()
        {
            throw new NotImplementedException();
        }

        public bool IsUIsoOnS2()
        {
            throw new NotImplementedException();
        }

        public bool IsVIsoOnS2()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class IntPatch_Line
}