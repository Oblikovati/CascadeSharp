//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKGeomBase.AdvApp2Var
{
    //---------------------------------------------------------------------
    //  Class  AdvApp2Var_Criterion
    //---------------------------------------------------------------------
    public abstract class AdvApp2Var_Criterion
    {
        public AdvApp2Var_Criterion()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public AdvApp2Var_Criterion(AdvApp2Var_Criterion parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void Value(AdvApp2Var_Patch P, AdvApp2Var_Context C)
        {
            throw new NotImplementedException();
        }

        public bool IsSatisfied(AdvApp2Var_Patch P)
        {
            throw new NotImplementedException();
        }

        public double MaxValue()
        {
            throw new NotImplementedException();
        }

        public AdvApp2Var_CriterionType Type()
        {
            throw new NotImplementedException();
        }

        public AdvApp2Var_CriterionRepartition Repartition()
        {
            throw new NotImplementedException();
        }
    }; // class AdvApp2Var_Criterion
}