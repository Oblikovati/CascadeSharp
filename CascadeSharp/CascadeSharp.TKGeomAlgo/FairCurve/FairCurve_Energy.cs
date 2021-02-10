//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomAlgo.FairCurve
{
    //---------------------------------------------------------------------
    //  Class  FairCurve_Energy
    //---------------------------------------------------------------------
    public abstract class FairCurve_Energy : math_MultipleVarFunctionWithHessian
    {
        public FairCurve_Energy(TColgp_HArray1OfPnt2d Poles, int ConstrOrder1, int ConstrOrder2, bool WithAuxValue,
            double Angle1, double Angle2, int Degree, double Curvature1, double Curvature2)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FairCurve_Energy(TColgp_HArray1OfPnt2d Poles, int ConstrOrder1, int ConstrOrder2, bool WithAuxValue,
            double Angle1, double Angle2, int Degree, double Curvature1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FairCurve_Energy(TColgp_HArray1OfPnt2d Poles, int ConstrOrder1, int ConstrOrder2, bool WithAuxValue,
            double Angle1, double Angle2, int Degree)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FairCurve_Energy(TColgp_HArray1OfPnt2d Poles, int ConstrOrder1, int ConstrOrder2, bool WithAuxValue,
            double Angle1, double Angle2)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FairCurve_Energy(TColgp_HArray1OfPnt2d Poles, int ConstrOrder1, int ConstrOrder2, bool WithAuxValue,
            double Angle1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FairCurve_Energy(TColgp_HArray1OfPnt2d Poles, int ConstrOrder1, int ConstrOrder2, bool WithAuxValue)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FairCurve_Energy(TColgp_HArray1OfPnt2d Poles, int ConstrOrder1, int ConstrOrder2)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FairCurve_Energy(FairCurve_Energy parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public FairCurve_Energy()
        {
            throw new NotImplementedException();
        }

        public int NbVariables()
        {
            throw new NotImplementedException();
        }

        public bool Value(Vector X, ref double E)
        {
            throw new NotImplementedException();
        }

        public bool Gradient(Vector X, Vector G)
        {
            throw new NotImplementedException();
        }

        public bool Values(Vector X, ref double E, Vector G)
        {
            throw new NotImplementedException();
        }

        public bool Values(Vector X, ref double E, Vector G, math_Matrix H)
        {
            throw new NotImplementedException();
        }

        public bool Variable(Vector X)
        {
            throw new NotImplementedException();
        }

        public TColgp_HArray1OfPnt2d Poles()
        {
            throw new NotImplementedException();
        }

        public void Gradient1(Vector TheVector, Vector G)
        {
            throw new NotImplementedException();
        }

        public void Hessian1(Vector TheVector, math_Matrix H)
        {
            throw new NotImplementedException();
        }

        public void ComputePoles(Vector X)
        {
            throw new NotImplementedException();
        }

        public int Indice(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void ComputePolesG1(int Side, double Lambda, gp_Pnt2d P1, gp_Pnt2d P2)
        {
            throw new NotImplementedException();
        }

        public void ComputePolesG2(int Side, double Lambda, double Rho, gp_Pnt2d P1, gp_Pnt2d P2)
        {
            throw new NotImplementedException();
        }

        public bool Compute(int DerivativeOrder, Vector Result)
        {
            throw new NotImplementedException();
        }
    }; // class FairCurve_Energy
}