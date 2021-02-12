//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using CascadeSharp.TKernel.Standard;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS
    //---------------------------------------------------------------------
    /// <summary>
    /// Provides methods to cast objects of class TopoDS_Shape to be objects of more specialized
    /// sub-classes. Types are verified, thus in the example below,
    /// the first two blocks are correct but the third is rejected by the compiler.
    /// </summary>
    public sealed class TopoDS
    {
        private static bool TopoDS_Mismatch(TopoDS_Shape S, TopAbs_ShapeEnum T)
        {
            return S is { } && S.ShapeType() != T;
        }
        public static TopoDS_Vertex Vertex(TopoDS_Shape S)
        {
            if (TopoDS_Mismatch(S,TopAbs_ShapeEnum.TopAbs_VERTEX))
                throw new Standard_TypeMismatch("TopoDS.Vertex");
            return (TopoDS_Vertex) S;
        }

        public static TopoDS_Edge Edge(TopoDS_Shape S)
        {
            if (TopoDS_Mismatch(S, TopAbs_ShapeEnum.TopAbs_EDGE))
                throw new Standard_TypeMismatch("TopoDS.Edge");
            return (TopoDS_Edge)S;
        }

        public static TopoDS_Wire Wire(TopoDS_Shape S)
        {
            if (TopoDS_Mismatch(S, TopAbs_ShapeEnum.TopAbs_WIRE))
                throw new Standard_TypeMismatch("TopoDS.Wire");
            return (TopoDS_Wire)S;
        }

        public static TopoDS_Face Face(TopoDS_Shape S)
        {
            if (TopoDS_Mismatch(S, TopAbs_ShapeEnum.TopAbs_FACE))
                throw new Standard_TypeMismatch("TopoDS.Face");
            return (TopoDS_Face)S;
        }

        public static TopoDS_Shell Shell(TopoDS_Shape S)
        {
            if (TopoDS_Mismatch(S, TopAbs_ShapeEnum.TopAbs_SHELL))
                throw new Standard_TypeMismatch("TopoDS.Shell");
            return (TopoDS_Shell)S;
        }

        public static TopoDS_Solid Solid(TopoDS_Shape S)
        {
            if (TopoDS_Mismatch(S, TopAbs_ShapeEnum.TopAbs_SOLID))
                throw new Standard_TypeMismatch("TopoDS.Solid");
            return (TopoDS_Solid)S;
        }

        public static TopoDS_CompSolid CompSolid(TopoDS_Shape S)
        {
            if (TopoDS_Mismatch(S, TopAbs_ShapeEnum.TopAbs_COMPSOLID))
                throw new Standard_TypeMismatch("TopoDS.CompSolid");
            return (TopoDS_CompSolid)S;
        }

        public static TopoDS_Compound Compound(TopoDS_Shape S)
        {
            if (TopoDS_Mismatch(S, TopAbs_ShapeEnum.TopAbs_COMPOUND))
                throw new Standard_TypeMismatch("TopoDS.Compound");
            return (TopoDS_Compound)S;
        }
    }
}