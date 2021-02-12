//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------


namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_HShape
    //---------------------------------------------------------------------
    public sealed class TopoDS_HShape
    {
        public TopoDS_HShape()
        {

        }

        public TopoDS_HShape(TopoDS_Shape aShape)
        {
            myShape = aShape;
        }

        #region Private Objects

        TopoDS_Shape myShape;

        #endregion


        public TopoDS_Shape Shape
        {
            get => myShape;
            set => myShape = value;
        }

    }
}