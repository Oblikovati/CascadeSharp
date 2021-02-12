//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------


namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_Compound
    //---------------------------------------------------------------------
    /// <summary>
    /// Describes a compound which
    /// - references an underlying compound with the potential to be given a location and an orientation
    /// - has a location for the underlying compound, giving its placement in the local coordinate system
    /// - has an orientation for the underlying compound, in terms of its geometry (as opposed to orientation in
    /// relation to other shapes).
    /// Casts shape S to the more specialized return type, Compound.
    /// </summary>
    public class TopoDS_Compound : TopoDS_Shape
    {

    }
}