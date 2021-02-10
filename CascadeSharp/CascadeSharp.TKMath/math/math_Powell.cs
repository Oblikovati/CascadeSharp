//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_Powell
    //---------------------------------------------------------------------
    public sealed class math_Powell
    {
        public math_Powell(math_MultipleVarFunction theFunction, double theTolerance, int theNbIterations,
            double theZEPS)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_Powell(math_MultipleVarFunction theFunction, double theTolerance, int theNbIterations)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_Powell(math_MultipleVarFunction theFunction, double theTolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_Powell(math_Powell parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_Powell()
        {
            throw new NotImplementedException();
        }

        public void Perform(math_MultipleVarFunction theFunction, Vector theStartingPoint,
            math_Matrix theStartingDirections)
        {
            throw new NotImplementedException();
        }

        public bool IsSolutionReached(math_MultipleVarFunction theFunction)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public Vector Location()
        {
            throw new NotImplementedException();
        }

        public void Location(Vector Loc)
        {
            throw new NotImplementedException();
        }

        public double Minimum()
        {
            throw new NotImplementedException();
        }

        public int NbIterations()
        {
            throw new NotImplementedException();
        }
    }; // class math_Powell
}