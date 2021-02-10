//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.BVH
{
    //---------------------------------------------------------------------
    //  Class  BVH_BuildTool
    //---------------------------------------------------------------------
    public abstract class BVH_BuildTool
    {
        public BVH_BuildTool()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public BVH_BuildTool(BVH_BuildTool parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void Perform(int theNode)
        {
            throw new NotImplementedException();
        }
    }; // class BVH_BuildTool
}