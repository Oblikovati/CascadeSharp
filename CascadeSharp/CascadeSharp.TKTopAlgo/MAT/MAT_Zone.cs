//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKTopAlgo.MAT
{
    //---------------------------------------------------------------------
    //  Class  MAT_Zone
    //---------------------------------------------------------------------
    public sealed class MAT_Zone : Standard_Transient
    {
        public MAT_Zone()
            : base()
        {
            throw new NotImplementedException();
        }

        public MAT_Zone(MAT_BasicElt aBasicElt)
            : base()
        {
            throw new NotImplementedException();
        }

        public MAT_Zone(MAT_Zone parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Perform(MAT_BasicElt aBasicElt)
        {
            throw new NotImplementedException();
        }

        public int NumberOfArcs()
        {
            throw new NotImplementedException();
        }

        public MAT_Arc ArcOnFrontier(int Index)
        {
            throw new NotImplementedException();
        }

        public bool NoEmptyZone()
        {
            throw new NotImplementedException();
        }

        public bool Limited()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public MAT_Node NodeForTurn(MAT_Arc anArc, MAT_BasicElt aBasicElt, MAT_Side aSide)
        {
            throw new NotImplementedException();
        }
    }; // class MAT_Zone
}