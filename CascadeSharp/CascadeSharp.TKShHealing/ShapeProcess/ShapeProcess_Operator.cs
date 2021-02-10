//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.Message;

namespace CascadeSharp.TKShHealing.ShapeProcess
{
    //---------------------------------------------------------------------
    //  Class  ShapeProcess_Operator
    //---------------------------------------------------------------------
    public abstract class ShapeProcess_Operator : Standard_Transient
    {
        public ShapeProcess_Operator(ShapeProcess_Operator parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public ShapeProcess_Operator()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public bool Perform(ShapeProcess_Context context, Message_ProgressRange theProgress)
        {
            throw new NotImplementedException();
        }

        public bool Perform(ShapeProcess_Context context)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class ShapeProcess_Operator
}