//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;

namespace CascadeSharp.TKMath.BVH
{
    //---------------------------------------------------------------------
    //  Class  BVH_ObjectTransient
    //---------------------------------------------------------------------
    public sealed class BVH_ObjectTransient : Standard_Transient
    {
        public BVH_ObjectTransient()
            : base()
        {
            throw new NotImplementedException();
        }

        public BVH_ObjectTransient(BVH_ObjectTransient parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public BVH_Properties Properties()
        {
            throw new NotImplementedException();
        }

        public void SetProperties(BVH_Properties theProperties)
        {
            throw new NotImplementedException();
        }

        public bool IsDirty()
        {
            throw new NotImplementedException();
        }

        public void MarkDirty()
        {
            throw new NotImplementedException();
        }
    }; // class BVH_ObjectTransient
}