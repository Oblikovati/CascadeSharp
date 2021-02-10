//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;

namespace CascadeSharp.TKShHealing.ShapeAnalysis
{
    //---------------------------------------------------------------------
    //  Class  ShapeAnalysis_Shell
    //---------------------------------------------------------------------
    public sealed class ShapeAnalysis_Shell
    {
        public ShapeAnalysis_Shell()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeAnalysis_Shell(ShapeAnalysis_Shell parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void LoadShells(TopoDS_Shape shape)
        {
            throw new NotImplementedException();
        }

        public bool CheckOrientedShells(TopoDS_Shape shape, bool alsofree, bool checkinternaledges)
        {
            throw new NotImplementedException();
        }

        public bool CheckOrientedShells(TopoDS_Shape shape, bool alsofree)
        {
            throw new NotImplementedException();
        }

        public bool CheckOrientedShells(TopoDS_Shape shape)
        {
            throw new NotImplementedException();
        }

        public bool IsLoaded(TopoDS_Shape shape)
        {
            throw new NotImplementedException();
        }

        public int NbLoaded()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Loaded(int num)
        {
            throw new NotImplementedException();
        }

        public bool HasBadEdges()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Compound BadEdges()
        {
            throw new NotImplementedException();
        }

        public bool HasFreeEdges()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Compound FreeEdges()
        {
            throw new NotImplementedException();
        }

        public bool HasConnectedEdges()
        {
            throw new NotImplementedException();
        }
    }; // class ShapeAnalysis_Shell
}