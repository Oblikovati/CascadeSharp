//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_PSO
    //---------------------------------------------------------------------
    public sealed class math_PSO
    {
        public math_PSO(math_MultipleVarFunction theFunc, math_Vector theLowBorder, math_Vector theUppBorder,
            math_Vector theSteps, int theNbParticles, int theNbIter)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_PSO(math_MultipleVarFunction theFunc, math_Vector theLowBorder, math_Vector theUppBorder,
            math_Vector theSteps, int theNbParticles)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_PSO(math_MultipleVarFunction theFunc, math_Vector theLowBorder, math_Vector theUppBorder,
            math_Vector theSteps)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_PSO(math_PSO parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_PSO()
        {
            throw new NotImplementedException();
        }

        public void Perform(math_Vector theSteps, ref double theValue, math_Vector theOutPnt, int theNbIter)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_Vector theSteps, ref double theValue, math_Vector theOutPnt)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_PSOParticlesPool theParticles, int theNbParticles, ref double theValue,
            math_Vector theOutPnt, int theNbIter)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_PSOParticlesPool theParticles, int theNbParticles, ref double theValue,
            math_Vector theOutPnt)
        {
            throw new NotImplementedException();
        }

        public void performPSOWithGivenParticles(math_PSOParticlesPool theParticles, int theNbParticles,
            ref double theValue, math_Vector theOutPnt, int theNbIter)
        {
            throw new NotImplementedException();
        }

        public void performPSOWithGivenParticles(math_PSOParticlesPool theParticles, int theNbParticles,
            ref double theValue, math_Vector theOutPnt)
        {
            throw new NotImplementedException();
        }
    }; // class math_PSO
}