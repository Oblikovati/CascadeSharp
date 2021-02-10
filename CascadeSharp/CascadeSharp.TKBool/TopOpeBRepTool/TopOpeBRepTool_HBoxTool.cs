//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.Bnd;

namespace CascadeSharp.TKBool.TopOpeBRepTool
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRepTool_HBoxTool
    //---------------------------------------------------------------------
    public sealed class TopOpeBRepTool_HBoxTool : Standard_Transient
    {
        public TopOpeBRepTool_HBoxTool()
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_HBoxTool(TopOpeBRepTool_HBoxTool parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void AddBoxes(TopoDS_Shape S, TopAbs_ShapeEnum TS, TopAbs_ShapeEnum TA)
        {
            throw new NotImplementedException();
        }

        public void AddBoxes(TopoDS_Shape S, TopAbs_ShapeEnum TS)
        {
            throw new NotImplementedException();
        }

        public void AddBox(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void ComputeBox(TopoDS_Shape S, Bnd_Box B)
        {
            throw new NotImplementedException();
        }

        public void ComputeBoxOnVertices(TopoDS_Shape S, Bnd_Box B)
        {
            throw new NotImplementedException();
        }

        public void DumpB(Bnd_Box B)
        {
            throw new NotImplementedException();
        }

        public Bnd_Box Box(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public Bnd_Box Box(int I)
        {
            throw new NotImplementedException();
        }

        public bool HasBox(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape(int I)
        {
            throw new NotImplementedException();
        }

        public int Index(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public int Extent()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_IndexedDataMapOfShapeBox ChangeIMS()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepTool_IndexedDataMapOfShapeBox IMS()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class TopOpeBRepTool_HBoxTool
}