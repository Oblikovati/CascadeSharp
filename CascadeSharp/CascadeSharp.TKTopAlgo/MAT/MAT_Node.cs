//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKTopAlgo.MAT
{
    //---------------------------------------------------------------------
    //  Class  MAT_Node
    //---------------------------------------------------------------------
    public sealed class MAT_Node : Standard_Transient
    {
        public MAT_Node(int GeomIndex, MAT_Arc LinkedArc, double D_istance)
            : base()
        {
            throw new NotImplementedException();
        }

        public MAT_Node(MAT_Node parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public MAT_Node()
        {
            throw new NotImplementedException();
        }

        public int GeomIndex()
        {
            throw new NotImplementedException();
        }

        public int Index()
        {
            throw new NotImplementedException();
        }

        public void LinkedArcs(MAT_SequenceOfArc S)
        {
            throw new NotImplementedException();
        }

        public void NearElts(MAT_SequenceOfBasicElt S)
        {
            throw new NotImplementedException();
        }

        public double Distance()
        {
            throw new NotImplementedException();
        }

        public bool PendingNode()
        {
            throw new NotImplementedException();
        }

        public bool OnBasicElt()
        {
            throw new NotImplementedException();
        }

        public bool Infinite()
        {
            throw new NotImplementedException();
        }

        public void SetIndex(int anIndex)
        {
            throw new NotImplementedException();
        }

        public void SetLinkedArc(MAT_Arc anArc)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class MAT_Node
}