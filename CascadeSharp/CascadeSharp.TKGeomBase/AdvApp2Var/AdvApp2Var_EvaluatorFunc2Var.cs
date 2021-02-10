//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKGeomBase.AdvApp2Var
{
    //---------------------------------------------------------------------
    //  Class  AdvApp2Var_EvaluatorFunc2Var
    //---------------------------------------------------------------------
    public abstract class AdvApp2Var_EvaluatorFunc2Var
    {
        public AdvApp2Var_EvaluatorFunc2Var()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public AdvApp2Var_EvaluatorFunc2Var(AdvApp2Var_EvaluatorFunc2Var parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void Evaluate(ref int theDimension, ref double theUStartEnd, ref double theVStartEnd,
            ref int theFavorIso, ref double theConstParam, ref int theNbParams, ref double theParameters,
            ref int theUOrder, ref int theVOrder, ref double theResult, ref int theErrorCode)
        {
            throw new NotImplementedException();
        }
    }; // class AdvApp2Var_EvaluatorFunc2Var
}