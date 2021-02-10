//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKTopAlgo.BRepCheck
{
    //---------------------------------------------------------------------
    //  Class  BRepCheck_Shell
    //---------------------------------------------------------------------
    public sealed class BRepCheck_Shell : BRepCheck_Result
    {
        public BRepCheck_Shell(TopoDS_Shell S)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Shell(BRepCheck_Shell parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Shell()
        {
            throw new NotImplementedException();
        }

        public void InContext(TopoDS_Shape ContextShape)
        {
            throw new NotImplementedException();
        }

        public void Minimum()
        {
            throw new NotImplementedException();
        }

        public void Blind()
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Status Closed(bool Update)
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Status Closed()
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Status Orientation(bool Update)
        {
            throw new NotImplementedException();
        }

        public BRepCheck_Status Orientation()
        {
            throw new NotImplementedException();
        }

        public void SetUnorientable()
        {
            throw new NotImplementedException();
        }

        public bool IsUnorientable()
        {
            throw new NotImplementedException();
        }

        public int NbConnectedSet(TopTools_ListOfShape theSets)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class BRepCheck_Shell
}