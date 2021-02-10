//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKTopAlgo.MAT
{
    //---------------------------------------------------------------------
    //  Class  MAT_Graph
    //---------------------------------------------------------------------
    public sealed class MAT_Graph : Standard_Transient
    {
        public MAT_Graph()
            : base()
        {
            throw new NotImplementedException();
        }

        public MAT_Graph(MAT_Graph parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Perform(bool SemiInfinite, MAT_ListOfBisector TheRoots, int NbBasicElts, int NbArcs)
        {
            throw new NotImplementedException();
        }

        public MAT_Arc Arc(int Index)
        {
            throw new NotImplementedException();
        }

        public MAT_BasicElt BasicElt(int Index)
        {
            throw new NotImplementedException();
        }

        public MAT_Node Node(int Index)
        {
            throw new NotImplementedException();
        }

        public int NumberOfArcs()
        {
            throw new NotImplementedException();
        }

        public int NumberOfNodes()
        {
            throw new NotImplementedException();
        }

        public int NumberOfBasicElts()
        {
            throw new NotImplementedException();
        }

        public int NumberOfInfiniteNodes()
        {
            throw new NotImplementedException();
        }

        public void FusionOfBasicElts(int IndexElt1, int IndexElt2, ref bool MergeArc1, ref int GeomIndexArc1,
            ref int GeomIndexArc2, ref bool MergeArc2, ref int GeomIndexArc3, ref int GeomIndexArc4)
        {
            throw new NotImplementedException();
        }

        public void CompactArcs()
        {
            throw new NotImplementedException();
        }

        public void CompactNodes()
        {
            throw new NotImplementedException();
        }

        public void ChangeBasicElts(MAT_DataMapOfIntegerBasicElt NewMap)
        {
            throw new NotImplementedException();
        }

        public MAT_BasicElt ChangeBasicElt(int Index)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void FusionOfArcs(MAT_Arc Arc1, MAT_Arc Arc2)
        {
            throw new NotImplementedException();
        }

        public void UpDateNodes(ref int Index)
        {
            throw new NotImplementedException();
        }
    }; // class MAT_Graph
}