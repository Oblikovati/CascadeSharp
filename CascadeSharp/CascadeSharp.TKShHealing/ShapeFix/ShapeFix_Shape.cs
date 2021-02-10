//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.Message;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeFix
{
    //---------------------------------------------------------------------
    //  Class  ShapeFix_Shape
    //---------------------------------------------------------------------
    public sealed class ShapeFix_Shape : ShapeFix_Root
    {
        public ShapeFix_Shape()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Shape(TopoDS_Shape shape)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Shape(ShapeFix_Shape parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Shape shape)
        {
            throw new NotImplementedException();
        }

        public bool Perform(Message_ProgressRange theProgress)
        {
            throw new NotImplementedException();
        }

        public bool Perform()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Solid FixSolidTool()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Shell FixShellTool()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Face FixFaceTool()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Wire FixWireTool()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Edge FixEdgeTool()
        {
            throw new NotImplementedException();
        }

        public bool Status(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public void SetMsgRegistrator(ShapeExtend_BasicMsgRegistrator msgreg)
        {
            throw new NotImplementedException();
        }

        public void SetPrecision(double preci)
        {
            throw new NotImplementedException();
        }

        public void SetMinTolerance(double mintol)
        {
            throw new NotImplementedException();
        }

        public void SetMaxTolerance(double maxtol)
        {
            throw new NotImplementedException();
        }

        public int FixSolidMode()
        {
            throw new NotImplementedException();
        }

        public int FixFreeShellMode()
        {
            throw new NotImplementedException();
        }

        public int FixFreeFaceMode()
        {
            throw new NotImplementedException();
        }

        public int FixFreeWireMode()
        {
            throw new NotImplementedException();
        }

        public int FixSameParameterMode()
        {
            throw new NotImplementedException();
        }

        public int FixVertexPositionMode()
        {
            throw new NotImplementedException();
        }

        public int FixVertexTolMode()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void SameParameter(TopoDS_Shape shape, bool enforce, Message_ProgressRange theProgress)
        {
            throw new NotImplementedException();
        }

        public void SameParameter(TopoDS_Shape shape, bool enforce)
        {
            throw new NotImplementedException();
        }
    }; // class ShapeFix_Shape
}