//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_GlobOptMin
    //---------------------------------------------------------------------
    public sealed class math_GlobOptMin
    {
        public math_GlobOptMin(math_MultipleVarFunction theFunc, Vector theLowerBorder, Vector theUpperBorder,
            double theC, double theD_iscretizationTol, double theSameTol)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_GlobOptMin(math_MultipleVarFunction theFunc, Vector theLowerBorder, Vector theUpperBorder,
            double theC, double theD_iscretizationTol)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_GlobOptMin(math_MultipleVarFunction theFunc, Vector theLowerBorder, Vector theUpperBorder,
            double theC)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_GlobOptMin(math_MultipleVarFunction theFunc, Vector theLowerBorder, Vector theUpperBorder)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_GlobOptMin(math_GlobOptMin parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_GlobOptMin()
        {
            throw new NotImplementedException();
        }

        public void SetGlobalParams(math_MultipleVarFunction theFunc, Vector theLowerBorder,
            Vector theUpperBorder, double theC, double theD_iscretizationTol, double theSameTol)
        {
            throw new NotImplementedException();
        }

        public void SetGlobalParams(math_MultipleVarFunction theFunc, Vector theLowerBorder,
            Vector theUpperBorder, double theC, double theD_iscretizationTol)
        {
            throw new NotImplementedException();
        }

        public void SetGlobalParams(math_MultipleVarFunction theFunc, Vector theLowerBorder,
            Vector theUpperBorder, double theC)
        {
            throw new NotImplementedException();
        }

        public void SetGlobalParams(math_MultipleVarFunction theFunc, Vector theLowerBorder,
            Vector theUpperBorder)
        {
            throw new NotImplementedException();
        }

        public void SetLocalParams(Vector theLocalA, Vector theLocalB)
        {
            throw new NotImplementedException();
        }

        public void SetTol(double theD_iscretizationTol, double theSameTol)
        {
            throw new NotImplementedException();
        }

        public void GetTol(ref double theD_iscretizationTol, ref double theSameTol)
        {
            throw new NotImplementedException();
        }

        public void Perform(bool _isFindSingleSolution)
        {
            throw new NotImplementedException();
        }

        public void Perform()
        {
            throw new NotImplementedException();
        }

        public void Points(int theIndex, Vector theSol)
        {
            throw new NotImplementedException();
        }

        public void SetContinuity(int theCont)
        {
            throw new NotImplementedException();
        }

        public int GetContinuity()
        {
            throw new NotImplementedException();
        }

        public void SetFunctionalMinimalValue(double theMinimalValue)
        {
            throw new NotImplementedException();
        }

        public double GetFunctionalMinimalValue()
        {
            throw new NotImplementedException();
        }

        public void SetLipConstState(bool theFlag)
        {
            throw new NotImplementedException();
        }

        public bool GetLipConstState()
        {
            throw new NotImplementedException();
        }

        public bool isDone()
        {
            throw new NotImplementedException();
        }

        public double GetF()
        {
            throw new NotImplementedException();
        }

        public int NbExtrema()
        {
            throw new NotImplementedException();
        }

        public void initCellSize()
        {
            throw new NotImplementedException();
        }

        public void ComputeInitSol()
        {
            throw new NotImplementedException();
        }

        public bool computeLocalExtremum(Vector thePnt, ref double theVal, Vector theOutPnt)
        {
            throw new NotImplementedException();
        }

        public void computeGlobalExtremum(int theIndex)
        {
            throw new NotImplementedException();
        }

        public bool CheckFunctionalStopCriteria()
        {
            throw new NotImplementedException();
        }

        public void computeInitialValues()
        {
            throw new NotImplementedException();
        }

        public bool isInside(Vector thePnt)
        {
            throw new NotImplementedException();
        }

        public bool isStored(Vector thePnt)
        {
            throw new NotImplementedException();
        }

        public void checkAddCandidate(Vector thePnt, double theValue)
        {
            throw new NotImplementedException();
        }
    }; // class math_GlobOptMin
}