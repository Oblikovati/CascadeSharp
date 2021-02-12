using CascadeSharp.TKernel.NCollection;

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
    }
}