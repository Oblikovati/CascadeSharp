//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKBool.BRepAlgo
{
    //---------------------------------------------------------------------
    //  Class  BRepAlgo_AsDes
    //---------------------------------------------------------------------
    public sealed class BRepAlgo_AsDes : Standard_Transient
    {
        public BRepAlgo_AsDes()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepAlgo_AsDes(BRepAlgo_AsDes parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Shape S, TopoDS_Shape SS)
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Shape S, TopTools_ListOfShape SS)
        {
            throw new NotImplementedException();
        }

        public bool HasAscendant(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool HasDescendant(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Ascendant(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape Descendant(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public TopTools_ListOfShape ChangeDescendant(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void Replace(TopoDS_Shape OldS, TopoDS_Shape NewS)
        {
            throw new NotImplementedException();
        }

        public void Remove(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool HasCommonDescendant(TopoDS_Shape S1, TopoDS_Shape S2, TopTools_ListOfShape LC)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void BackReplace(TopoDS_Shape OldS, TopoDS_Shape NewS, TopTools_ListOfShape L, bool InUp)
        {
            throw new NotImplementedException();
        }
    }; // class BRepAlgo_AsDes
}