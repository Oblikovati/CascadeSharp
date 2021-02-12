using CascadeSharp.TKernel.NCollection;
using System;

namespace CascadeSharp.TKBRep.TopoDS
{
    public class TopoDS_ListIteratorOfListOfShape : NCollection_List<TopoDS_Shape>.Iterator
    {
        public TopoDS_ListIteratorOfListOfShape()
        {
            
        }

        public TopoDS_ListIteratorOfListOfShape(TopoDS_ListOfShape list)
            : base(list)
        {
                    
        }

        internal void Initialize(TopoDS_ListOfShape myShapes)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Value()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public bool More()
        {
            throw new NotImplementedException();
        }
    }
}