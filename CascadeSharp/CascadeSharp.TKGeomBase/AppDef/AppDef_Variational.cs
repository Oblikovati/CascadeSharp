//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKGeomBase.AppParCurves;
using CascadeSharp.TKGeomBase.FEmTool;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.math;
using CascadeSharp.TKMath.PLib;

namespace CascadeSharp.TKGeomBase.AppDef
{
    //---------------------------------------------------------------------
    //  Class  AppDef_Variational
    //---------------------------------------------------------------------
    public sealed class AppDef_Variational
    {
        public AppDef_Variational(AppDef_MultiLine SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints, int MaxDegree, int MaxSegment,
            GeomAbs_Shape Continuity, bool WithMinMax, bool WithCutting, double Tolerance, int NbIterations)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_Variational(AppDef_MultiLine SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints, int MaxDegree, int MaxSegment,
            GeomAbs_Shape Continuity, bool WithMinMax, bool WithCutting, double Tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_Variational(AppDef_MultiLine SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints, int MaxDegree, int MaxSegment,
            GeomAbs_Shape Continuity, bool WithMinMax, bool WithCutting)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_Variational(AppDef_MultiLine SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints, int MaxDegree, int MaxSegment,
            GeomAbs_Shape Continuity, bool WithMinMax)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_Variational(AppDef_MultiLine SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints, int MaxDegree, int MaxSegment,
            GeomAbs_Shape Continuity)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_Variational(AppDef_MultiLine SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints, int MaxDegree, int MaxSegment)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_Variational(AppDef_MultiLine SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints, int MaxDegree)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_Variational(AppDef_MultiLine SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_Variational(AppDef_Variational parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_Variational()
        {
            throw new NotImplementedException();
        }

        public void Approximate()
        {
            throw new NotImplementedException();
        }

        public bool IsCreated()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public bool IsOverConstrained()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_MultiBSpCurve Value()
        {
            throw new NotImplementedException();
        }

        public double MaxError()
        {
            throw new NotImplementedException();
        }

        public int MaxErrorIndex()
        {
            throw new NotImplementedException();
        }

        public double QuadraticError()
        {
            throw new NotImplementedException();
        }

        public void Distance(math_Matrix mat)
        {
            throw new NotImplementedException();
        }

        public double AverageError()
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray1OfReal Parameters()
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray1OfReal Knots()
        {
            throw new NotImplementedException();
        }

        public void Criterium(ref double VFirstOrder, ref double VSecondOrder, ref double VThirdOrder)
        {
            throw new NotImplementedException();
        }

        public void CriteriumWeight(ref double Percent1, ref double Percent2, ref double Percent3)
        {
            throw new NotImplementedException();
        }

        public int MaxDegree()
        {
            throw new NotImplementedException();
        }

        public int MaxSegment()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity()
        {
            throw new NotImplementedException();
        }

        public bool WithMinMax()
        {
            throw new NotImplementedException();
        }

        public bool WithCutting()
        {
            throw new NotImplementedException();
        }

        public double Tolerance()
        {
            throw new NotImplementedException();
        }

        public int NbIterations()
        {
            throw new NotImplementedException();
        }

        public bool SetConstraints(AppParCurves_HArray1OfConstraintCouple aConstrainst)
        {
            throw new NotImplementedException();
        }

        public void SetParameters(TColStd_HArray1OfReal param)
        {
            throw new NotImplementedException();
        }

        public bool SetKnots(TColStd_HArray1OfReal knots)
        {
            throw new NotImplementedException();
        }

        public bool SetMaxDegree(int Degree)
        {
            throw new NotImplementedException();
        }

        public bool SetMaxSegment(int NbSegment)
        {
            throw new NotImplementedException();
        }

        public bool SetContinuity(GeomAbs_Shape C)
        {
            throw new NotImplementedException();
        }

        public void SetWithMinMax(bool MinMax)
        {
            throw new NotImplementedException();
        }

        public bool SetWithCutting(bool Cutting)
        {
            throw new NotImplementedException();
        }

        public void SetCriteriumWeight(double Percent1, double Percent2, double Percent3)
        {
            throw new NotImplementedException();
        }

        public void SetCriteriumWeight(int Order, double Percent)
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(double Tol)
        {
            throw new NotImplementedException();
        }

        public void SetNbIterations(int Iter)
        {
            throw new NotImplementedException();
        }

        public void TheMotor(AppDef_SmoothCriterion J, double WQuadratic, double WQuality, FEmTool_Curve TheCurve,
            TColStd_Array1OfReal Ecarts)
        {
            throw new NotImplementedException();
        }

        public void Adjusting(AppDef_SmoothCriterion J, ref double WQuadratic, ref double WQuality,
            FEmTool_Curve TheCurve, TColStd_Array1OfReal Ecarts)
        {
            throw new NotImplementedException();
        }

        public void Optimization(AppDef_SmoothCriterion J, FEmTool_Assembly A, bool ToAssemble, double EpsDeg,
            FEmTool_Curve Curve, TColStd_Array1OfReal Parameters)
        {
            throw new NotImplementedException();
        }

        public void Project(FEmTool_Curve C, TColStd_Array1OfReal Ti, TColStd_Array1OfReal ProjTi,
            TColStd_Array1OfReal D_istance, ref int NumPoints, ref double MaxErr, ref double QuaErr, ref double AveErr,
            int NbIterations)
        {
            throw new NotImplementedException();
        }

        public void Project(FEmTool_Curve C, TColStd_Array1OfReal Ti, TColStd_Array1OfReal ProjTi,
            TColStd_Array1OfReal D_istance, ref int NumPoints, ref double MaxErr, ref double QuaErr, ref double AveErr)
        {
            throw new NotImplementedException();
        }

        public void ACR(FEmTool_Curve Curve, TColStd_Array1OfReal Ti, int Decima)
        {
            throw new NotImplementedException();
        }

        public void SplitCurve(FEmTool_Curve InCurve, TColStd_Array1OfReal Ti, double CurveTol, FEmTool_Curve OutCurve,
            ref bool _iscut)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public void InitSmoothCriterion()
        {
            throw new NotImplementedException();
        }

        public void InitParameters(ref double Length)
        {
            throw new NotImplementedException();
        }

        public void InitCriterionEstimations(double Length, ref double J1, ref double J2, ref double J3)
        {
            throw new NotImplementedException();
        }

        public void EstTangent(int ipnt, math_Vector VTang)
        {
            throw new NotImplementedException();
        }

        public void EstSecnd(int ipnt, math_Vector VTang1, math_Vector VTang2, double Length, math_Vector VScnd)
        {
            throw new NotImplementedException();
        }

        public void InitCutting(PLib_Base aBase, double CurvTol, FEmTool_Curve aCurve)
        {
            throw new NotImplementedException();
        }

        public void AssemblingConstraints(FEmTool_Curve Curve, TColStd_Array1OfReal Parameters, double CBLONG,
            FEmTool_Assembly A)
        {
            throw new NotImplementedException();
        }

        public bool InitTthetaF(int ndimen, AppParCurves_Constraint typcon, int begin, int jndex)
        {
            throw new NotImplementedException();
        }
    }; // class AppDef_Variational
}