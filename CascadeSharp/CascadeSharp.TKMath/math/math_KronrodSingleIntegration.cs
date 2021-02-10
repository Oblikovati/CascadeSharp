//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_KronrodSingleIntegration
    //---------------------------------------------------------------------
    public sealed class math_KronrodSingleIntegration
    {
        public math_KronrodSingleIntegration()
            : base()
        {
            throw new NotImplementedException();
        }

        public math_KronrodSingleIntegration(math_Function theFunction, double theLower, double theUpper, int theNbPnts)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_KronrodSingleIntegration(math_Function theFunction, double theLower, double theUpper, int theNbPnts,
            double theTolerance, int theMaxNbIter)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_KronrodSingleIntegration(math_KronrodSingleIntegration parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Perform(math_Function theFunction, double theLower, double theUpper, int theNbPnts)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_Function theFunction, double theLower, double theUpper, int theNbPnts,
            double theTolerance, int theMaxNbIter)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public double Value()
        {
            throw new NotImplementedException();
        }

        public double ErrorReached()
        {
            throw new NotImplementedException();
        }

        public double AbsolutError()
        {
            throw new NotImplementedException();
        }

        public int OrderReached()
        {
            throw new NotImplementedException();
        }

        public int NbIterReached()
        {
            throw new NotImplementedException();
        }

        public bool GKRule(math_Function theFunction, double theLower, double theUpper, Vector theGaussP,
            Vector theGaussW, Vector theKronrodP, Vector theKronrodW, ref double theValue,
            ref double theError)
        {
            throw new NotImplementedException();
        }
    }; // class math_KronrodSingleIntegration
}