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
    //  Class  ShapeFix_Solid
    //---------------------------------------------------------------------
    public sealed class ShapeFix_Solid : ShapeFix_Root
    {
        public ShapeFix_Solid()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Solid(TopoDS_Solid solid)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Solid(ShapeFix_Solid parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Solid solid)
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

        public TopoDS_Solid SolidFromShell(TopoDS_Shell shell)
        {
            throw new NotImplementedException();
        }

        public bool Status(ShapeExtend_Status status)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Solid()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_Shell FixShellTool()
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

        public int FixShellMode()
        {
            throw new NotImplementedException();
        }

        public int FixShellOrientationMode()
        {
            throw new NotImplementedException();
        }

        public bool CreateOpenSolidMode()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class ShapeFix_Solid
}