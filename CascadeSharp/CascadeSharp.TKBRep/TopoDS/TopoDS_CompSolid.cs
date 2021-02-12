//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------


namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_CompSolid
    //---------------------------------------------------------------------
    /// <summary>
    /// Describes a composite solid which
    /// - references an underlying composite solid with the potential to be given a location and an orientation
    /// - has a location for the underlying composite solid, giving its placement in the local coordinate system
    /// - has an orientation for the underlying composite solid, in terms of its geometry (as opposed to
    /// orientation in relation to other shapes).
    /// Casts shape S to the more specialized return type, CompSolid.
    /// </summary>
    public sealed class TopoDS_CompSolid : TopoDS_Shape
    {

    }
}