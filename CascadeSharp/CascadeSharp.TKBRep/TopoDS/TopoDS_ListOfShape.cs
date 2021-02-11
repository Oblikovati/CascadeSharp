//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.NCollection;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_ListOfShape
    //---------------------------------------------------------------------
    public sealed class TopoDS_ListOfShape : NCollection_List<TopoDS_Shape>
    {
        public TopoDS_ListOfShape()
        {

        }

        public TopoDS_ListOfShape(TopoDS_ListOfShape theOther)
            : base(theOther)
        {

        }


        public TopoDS_ListOfShape Assign(TopoDS_ListOfShape theOther)
        {
            return (TopoDS_ListOfShape) base.Assign(theOther);
        }
    }
}